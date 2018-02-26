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
    public partial class LapTypeManagement : Form
    {

        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;

        string EventID = "";
        public LapTypeManagement(string inEventID)
        {
            InitializeComponent();

            this.Text = "Kierrostyyppien hallinta";
            EventID = inEventID;
            LoadLapTypes(); // Load LapTypes
        }

        private void btnAddLapType_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNewType.TextLength > 0)
                {
                    // Call DatabaseConnection Class
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "INSERT INTO LapTypes (EventID, LapType) VALUES ('" + EventID + "', '" + tbNewType.Text + "')";
                    ds = objConnect.GetConnection;

                    lbLapTypes.Items.Clear(); // Clear
                    LoadLapTypes(); // Load LapTypes
                    tbNewType.Text = "";
                }
            }
            catch ( Exception exc ) { MessageBox.Show(exc.Message); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbLapTypes.SelectedIndex > -1)
            {
                DialogResult dr = MessageBox.Show("Poistetaanko kierrostyyppi?", "Kierrostyypin poistaminen", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    // Call DatabaseConnection Class
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "DELETE FROM LapTypes WHERE EventID = '" + EventID + "' AND LapType = '" + tbNewType.Text + "'";
                    ds = objConnect.GetConnection;

                    lbLapTypes.Items.Clear(); // Clear
                    LoadLapTypes(); // Load LapTypes
                    tbNewType.Text = "";
                }
                else if (dr == DialogResult.No)
                {
                    // Do Nothing
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLapTypes()
        {
            // Load Lap Types from database
                // Call DatabaseConnection Class
                // first create new object
            objConnect = new DatabaseConnection();
            // then give SQL as a parameter
            objConnect.Sql = "SELECT LapType From LapTypes WHERE EventID = '" + EventID + "' ORDER By LapType";
            ds = objConnect.GetConnection;
            dt = new DataTable();
            dt = ds.Tables["Table"];
            // Update ListBox
            foreach (DataRow dr in dt.Rows)
            {
                lbLapTypes.Items.Add(dr["LapType"]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Not in use
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
