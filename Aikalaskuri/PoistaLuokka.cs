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
    public partial class PoistaLuokka : Form
    {
        string EventID;

        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;

        public PoistaLuokka(string inEventID)
        {
            InitializeComponent();
            EventID = inEventID;
            this.Text = "Luokkien poistaminen";
        }

        private void PoistaLuokka_Load(object sender, EventArgs e)
        {
            // Call void
            UpdateList();
        }

        private void UpdateList()
        {
            // Clear listBox
            lbPoistettavat.Items.Clear();

            // Call DatabaseConnection Class
            // first create new object
            objConnect = new DatabaseConnection();
            // then give SQL as a parameter
            objConnect.Sql = "SELECT Name FROM Class Where EventID = '" + EventID + "'";
            ds = objConnect.GetConnection;
            dt = new DataTable();
            dt = ds.Tables["Table"];
            foreach (DataRow dr in dt.Rows)
            {
                // MessageBox.Show(dr["EventName"].ToString());
                lbPoistettavat.Items.Add(dr["Name"].ToString());
            }
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (lbPoistettavat.SelectedIndex == -1)
            {
                // Nothing to do here
            }
            else
            {
                string Poistettava = lbPoistettavat.GetItemText(lbPoistettavat.SelectedItem);
                DialogResult dr = MessageBox.Show("Olet poistamassa luokkaa " + Poistettava + ". Oletko varma?", "Tapahtuman poisto", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    // first create new object
                    objConnect = new DatabaseConnection();

                    // Then remove device participancy to avoid orphan rows
                    objConnect.Sql = "DELETE FROM Device WHERE ClassID in (SELECT ClassID FROM Class WHERE EventID = '" + EventID + "' AND Name = '" + Poistettava + "')";
                    // Run
                    ds = objConnect.GetConnection;
                    // then give SQL as a parameter to remove class

                    objConnect.Sql = "DELETE FROM Class WHERE EventID = '" + EventID + "' AND Name = '" + Poistettava + "'";
                    // Run
                    ds = objConnect.GetConnection;

                }
                else if ( dr == DialogResult.Cancel )
                {
                    // No commands here - do nothing
                }

                // Call void
                UpdateList();

            }
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            try
            {
                UusiLuokka t = new UusiLuokka(EventID);
                t.ShowDialog();

                // Call void
                UpdateList();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
            
        }
    }
}
