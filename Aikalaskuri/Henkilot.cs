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
    public partial class Henkilot : Form
    {
        string EventID;
        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;

        public Henkilot(string inEventID)
        {
            InitializeComponent();
            EventID = inEventID;
            ListPersons();
            this.Text = "Henkilöiden hallinta";

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ListPersons ()
        {
            // Clean Osallistumiset listBox
            lbListPersons.Items.Clear();

            // Call DatabaseConnection Class
            // first create new object
            objConnect = new DatabaseConnection();
            // then give SQL as a parameter
            objConnect.Sql = "SELECT LastName, FirstName From Person WHERE EventID = '" + EventID + "' ORDER By LastName, FirstName";
            ds = objConnect.GetConnection;
            dt = new DataTable();
            dt = ds.Tables["Table"];
            // Update ListBox
            foreach (DataRow dr in dt.Rows)
            {
                string PersonName = dr["LastName"] + ", " + dr["FirstName"];
                lbListPersons.Items.Add(PersonName);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if ( lbListPersons.SelectedIndex == -1 )
                {
                    // Do nothing - nothing selected
                }
                else
                {
                    string toRemove = lbListPersons.SelectedItem.ToString();
                    string LastName = toRemove.Split(',')[0];
                    string FirstName = toRemove.Split(',')[1];
                    FirstName = FirstName.TrimStart();

                    DialogResult dr = MessageBox.Show("Olet poistamassa henkilöä " + toRemove + ". Oletko varma?", "Henkilön poisto", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        // first create new object
                        objConnect = new DatabaseConnection();
                        // then give SQL as a parameter - Device table fist
                        objConnect.Sql = "DELETE FROM Device WHERE PersonID in (SELECT PersonID FROM Person WHERE LastName = '" + LastName + "' AND FirstName = '" + FirstName + "' AND EventID = '" + EventID + "')";
                        // Run
                        ds = objConnect.GetConnection;

                        // Then remove from Person
                        objConnect.Sql = "DELETE FROM Person WHERE LastName = '" + LastName + "' AND FirstName = '" + FirstName + "' AND EventID = '" + EventID + "'";
                        // Run
                        ds = objConnect.GetConnection;

                        // Load Osallistumiset listBox
                        ListPersons();
                    }
                    else if (dr == DialogResult.Cancel)
                    {
                        // Do nothing here
                    }

                    
                }
            }
            catch ( Exception exc )
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveParti_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbListPersons.SelectedIndex == -1)
                {
                    // Do nothing - nothing selected
                }
                else
                {
                    string toRemove = lbListPersons.SelectedItem.ToString();
                    string LastName = toRemove.Split(',')[0];
                    string FirstName = toRemove.Split(',')[1];
                    string PersonID = "";
                    FirstName = FirstName.TrimStart();
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter - Device table fist
                    objConnect.Sql = "SELECT * FROM Person WHERE LastName = '" + LastName + "' AND FirstName = '" + FirstName + "' AND EventID = '" + EventID + "'";
                    ds = objConnect.GetConnection;
                    dt = new DataTable();
                    dt = ds.Tables["Table"];
                    // Update params and call Osallistuminen form
                    foreach (DataRow dr in dt.Rows)
                    {
                        PersonID = dr["PersonID"].ToString();
                    }

                    // Form calling
                    Osallistuminen t = new Osallistuminen(PersonID, LastName, FirstName, EventID);
                    t.ShowDialog();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                UusiHenkilo t = new UusiHenkilo(EventID);
                t.ShowDialog();

                // Load Osallistumiset listBox
                ListPersons();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message);  }
        }
    }
}
