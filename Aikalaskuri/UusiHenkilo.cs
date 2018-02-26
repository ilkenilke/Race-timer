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
    public partial class UusiHenkilo : Form
    {
        string EventID;
        string PersonID;
        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;

        public UusiHenkilo(string inEventID)
        {
            InitializeComponent();
            EventID = inEventID; // Connect to Event

            // Form modications
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            try
            {
                string UusiHSuku = tbSukunimi.Text;
                string UusiHEtu = tbEtunimi.Text;
                if (string.IsNullOrWhiteSpace(UusiHSuku) || string.IsNullOrWhiteSpace(UusiHEtu) || !cbKayttoehdot.Checked )
                {
                    MessageBox.Show("Anna vähintään etu- ja sukunimi sekä hyväksy käyttöehdot\nja valitse osallistuminen");
                }
                else
                {
                    // Add New person to database

                    string Email = tbEmail.Text;
                    string City = tbCity.Text;
                    string Club = tbClub.Text;
                     
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "INSERT INTO Person (EventID, LastName, FirstName, Email, City, Acceptance, Club)" +
                        " VALUES ('" + EventID + "', '" + UusiHSuku + "', '" + UusiHEtu + "', '" + Email + "', '" + City + "', '1', '" + Club + "')";
                    // Run
                    ds = objConnect.GetConnection;

                    // Get PersonID

                    // Call DatabaseConnection Class
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "SELECT MAX(PersonID) AS PersonID From Person";
                    ds = objConnect.GetConnection;
                    dt = new DataTable();
                    dt = ds.Tables["Table"];
                    foreach (DataRow dr in dt.Rows)
                    {
                        PersonID = dr["PersonID"].ToString();
                    }

                    Osallistuminen t = new Osallistuminen(PersonID, UusiHSuku, UusiHEtu, EventID);
                    t.FormClosed += (s, args) => this.Close();
                    t.ShowDialog();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
