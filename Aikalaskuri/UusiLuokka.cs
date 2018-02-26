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
    public partial class UusiLuokka : Form
    {

        DatabaseConnection objConnect;
        DataSet ds;
        string EventID;

        public UusiLuokka(string inEventID)
        {
            InitializeComponent();
            EventID = inEventID;
        }

        private void tbUusiLuokka_TextChanged(object sender, EventArgs e)
        {
            // Nothing to do here
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            try
            {
                string UusiLuokka = tbUusiLuokka.Text;
                if (string.IsNullOrWhiteSpace(UusiLuokka))
                {
                    MessageBox.Show("Anna luokalle vähintään nimi!");
                }
                else
                {
                    // Add values to database

                    string LuokanKuvaus = tbLuokanKuvaus.Text;
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "INSERT INTO Class (EventID, Name, Class_info) VALUES ('" + EventID +"', '" + UusiLuokka + "', '" + LuokanKuvaus + "')";
                    // Run
                    ds = objConnect.GetConnection;
                    this.Close();
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
