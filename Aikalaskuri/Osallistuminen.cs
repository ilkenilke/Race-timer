using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aikalaskuri
{
    public partial class Osallistuminen : Form
    {
        string PersonID;
        string LastName;
        string FirstName;
        string CombName;
        string EventID;

        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;

        public Osallistuminen(string inPersonID, string inLastName, string inFirstName, string inEventID)
        {
            InitializeComponent();
            PersonID = inPersonID;
            LastName = inLastName;
            FirstName = inFirstName;
            CombName = LastName + ", " + FirstName;
            lblHnimi.Text = CombName;
            this.Text = "Muokataan henkilöt " + CombName;
            EventID = inEventID;

            // Form modifications
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Osallistuminen_Load(object sender, EventArgs e)
        {
            // Call DatabaseConnection Class
            // first create new object
            objConnect = new DatabaseConnection();
            // then give SQL as a parameter
            objConnect.Sql = "SELECT * From Class WHERE EventID = '" + EventID + "'";
            ds = objConnect.GetConnection;
            dt = new DataTable();
            dt = ds.Tables["Table"];

            foreach (DataRow dr in dt.Rows)
            {
                cbClass.Items.Add(dr["Name"]);
            }

            // Load Osallistumiset listBox
            LataaOsallistumiset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string Vehicle = tbVehicle.Text;
                string Vehicle_info = tbVehicle_info.Text;
                string Vehicle_info1 = tbVehicle_info1.Text;
                string ClassID = "";

                if ( string.IsNullOrWhiteSpace(Vehicle) || cbClass.SelectedIndex == -1 )
                {
                    MessageBox.Show("Anna vähintään ajoneuvon nimi ja valitse luokka");
                }
                else
                {

                    string SClass = cbClass.SelectedItem.ToString();
                    // Call DatabaseConnection Class
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "SELECT ClassID From Class WHERE EventID = '" + EventID + "' AND Name = '" + SClass + "'";
                    ds = objConnect.GetConnection;
                    dt = new DataTable();
                    dt = ds.Tables["Table"];

                    foreach (DataRow dr in dt.Rows)
                    {
                        ClassID = dr["ClassID"].ToString();
                    }

                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "INSERT INTO Device (PersonID, ClassID, RaceOrder, Vehicle, Vehicle_info, Vehicle_info2)" +
                        " VALUES ('" + PersonID + "', '" + ClassID + "', (SELECT IFNULL(MAX(RaceOrder)+1,'1') FROM Device WHERE ClassID = '" + ClassID + "'), '" + Vehicle + "', '" + Vehicle_info + "', '" + Vehicle_info1 + "')";
                    // Run
                    ds = objConnect.GetConnection;
                    // Clean Osallistumiset listBox
                    lbOsallistumiset.Items.Clear();
                    // Load Osallistumiset listBox
                    LataaOsallistumiset();

                    // Clear fields
                    tbVehicle.Clear();
                    tbVehicle_info.Clear();
                    tbVehicle_info1.Clear();
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void LataaOsallistumiset()
        {
            // Call DatabaseConnection Class
            // first create new object
            objConnect = new DatabaseConnection();
            // then give SQL as a parameter
            objConnect.Sql = "SELECT c.Name as Name, d.Vehicle as Vehicle from Class c join Device d ON c.ClassID = d.ClassID WHERE PersonID = '" + PersonID + "' AND c.EventID = '" + EventID + "'";
            ds = objConnect.GetConnection;
            dt = new DataTable();
            dt = ds.Tables["Table"];
 

            foreach (DataRow dr in dt.Rows)
            {
                string Cla = dr["Name"].ToString();
                string Veh = dr["Vehicle"].ToString();
                string CombOsallistuminen = "Luokkaan: " + Cla + "  >> " + Veh;
                lbOsallistumiset.Items.Add(CombOsallistuminen);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if ( lbOsallistumiset.Items.Count == 0 )
                {
                    DialogResult dr = MessageBox.Show("Henkilöllä ei ole yhtään luokkaa, silti pois?", "Poistuminen", MessageBoxButtons.OKCancel);
                    if ( dr == DialogResult.OK )
                    {
                        // 
                        this.Close();
                    }
                    else
                    {
                        // Don't exit
                    }

                }
                else
                {
                    // Person has classes. Just exit
                    this.Close();
                }


            }
            catch (Exception err) { MessageBox.Show(err.Message); }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if ( lbOsallistumiset.SelectedIndex == -1 )
                {
                    // Do nothing here
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Olet poistamassa osallistumista. Oletko varma?", "Osallistumisen poisto", MessageBoxButtons.OKCancel);
                    if ( dr == DialogResult.OK)
                    {
                        string CombOsallistuminen = lbOsallistumiset.SelectedItem.ToString();
                        string Class = CombOsallistuminen.Split(':', '>')[1];
                        Class = Class.TrimStart();
                        Class = Class.TrimEnd();
                        string Device = CombOsallistuminen.Split('>')[2];
                        Device = Device.TrimStart();
                        
                        // first create new object
                        objConnect = new DatabaseConnection();
                        // then give SQL as a parameter
                        
                        objConnect.Sql = "DELETE FROM Device WHERE PersonID = '" + PersonID + "' AND Vehicle = '" + Device + "' AND ClassID in (SELECT ClassID FROM Class Where Name = '" + Class + "' AND EventID = '" + EventID + "')";
                        // Run
                        ds = objConnect.GetConnection;

                        // Refresh osallistumiset listbox
                        lbOsallistumiset.Items.Clear();

                        // Load Osallistumiset listBox
                        LataaOsallistumiset();
                    }
                    else if (dr == DialogResult.Cancel) {
                        // Nothing to do 
                    }
                    


                    
                }
            }
            catch ( Exception err )
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void lbOsallistumiset_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
