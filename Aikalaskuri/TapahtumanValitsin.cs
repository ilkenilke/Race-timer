using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Aikalaskuri
{
    // http://www.homeandlearn.co.uk/csharp/csharp_s12p7.html 
    // https://forums.asp.net/t/1466296.aspx?Using+dr+ItemArray+with+Column+Names+
    // https://msdn.microsoft.com/en-us/library/aa288403(v=vs.71).aspx
    // https://msdn.microsoft.com/en-us/library/system.windows.forms.listcontrol.datasource%28v=vs.110%29.aspx
    public partial class TapahtumanValitsin : Form
    {
        public TapahtumanValitsin()
        {
            InitializeComponent();
            this.Text = "Aikatimmi | tapahtumien valitsin. Copyright Ilkka Ruuska";
        }

        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;
        public string NewEvent;
        public string NewDate;
        public string Event;
        public string SelectedEvent;

        private void TapahtumanValitsin_Load(object sender, EventArgs e)
        {
            // this will open always on the form
            // But we need to reload form later so let's create own void and call it
            LoadEvent();
        }

        private void LoadEvent()
        {
            try
            {
                // Call DatabaseConnection Class
                // first create new object
                objConnect = new DatabaseConnection();
                // then give SQL as a parameter
                objConnect.Sql = "SELECT * From Event order by EventName";
                ds = objConnect.GetConnection;
                dt = new DataTable();
                dt = ds.Tables["Table"];
                TaytaLista();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void TaytaLista()
        {
            foreach ( DataRow dr in dt.Rows )
            {
                // MessageBox.Show(dr["EventName"].ToString());
                lstTapahtumat.Items.Add(dr["EventName"].ToString());
            }
        }

        private void btnLopeta_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUusi_Click(object sender, EventArgs e)
        {
            // When there is data button will create new event
            try
            {
                if ( string.IsNullOrWhiteSpace(NewEvent) )
                {
                    MessageBox.Show("Anna tapahtumalle nimi!");
                }
                else
                {
                    // MessageBox.Show(NewEvent); // Debug: NewEvent contains new string
                    // MessageBox.Show(NewDate); // Debug: NewDate contains new value in a string
                    //string Yhdistetty = "Luodaan uusi tapahtuma: " + NewEvent + " " + NewDate; // Debug
                    // MessageBox.Show(Yhdistetty);
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "INSERT INTO Event (EventName, EventDate) VALUES ('" + NewEvent + "', '" + NewDate + "')";
                    // Run
                    ds = objConnect.GetConnection;

                    // Then clear field lstTapahtumat reload the form
                    lstTapahtumat.Items.Clear();
                    LoadEvent();
                }
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void uusiTapahtuma_TextChanged(object sender, EventArgs e)
        {
            //TextBox objTextBox = (TextBox)sender;
            //NewEvent = objTextBox.Text;
            NewEvent = uusiTapahtuma.Text;
            NewDate = tapahtumanPaiva.Value.ToString("yyyy-MM-dd");
            
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            // Delete selected event
            try
            {
                if ( lstTapahtumat.SelectedIndex == -1 )
                {
                    // Ei ole valittu mitään - ei poisteta mitään
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Olet poistamassa tapahtumaa. Oletko varma?", "Tapahtuman poisto", MessageBoxButtons.OKCancel);
                    if ( dr == DialogResult.OK )
                    {
                        string Poistettava = lstTapahtumat.GetItemText(lstTapahtumat.SelectedItem);
                        // first create new object
                        objConnect = new DatabaseConnection();
                        // then give SQL as a parameter
                        //class, person, event
                        //device,
                        objConnect.Sql = "DELETE FROM Class WHERE EventID IN (SELECT EventID FROM Event WHERE EventName = '" + Poistettava + "')";
                        ds = objConnect.GetConnection;
                        objConnect.Sql = "DELETE FROM Device WHERE PersonID IN (SELECT PersonID FROM Person WHERE EventID IN (SELECT EventID FROM Event WHERE EventName = '" + Poistettava + "'))";
                        ds = objConnect.GetConnection;
                        objConnect.Sql = "DELETE FROM Person WHERE EventID IN (SELECT EventID FROM Event WHERE EventName = '" + Poistettava + "')";
                        ds = objConnect.GetConnection;
                        objConnect.Sql = "DELETE FROM Event WHERE EventName = '" + Poistettava + "'";
                        // Run
                        ds = objConnect.GetConnection;

                        // Then clear field lstTapahtumat reload the form
                        lstTapahtumat.Items.Clear();
                        LoadEvent();
                    }
                    else if ( dr == DialogResult.Cancel)
                    {
                        lstTapahtumat.Text = string.Empty;
                    }
                    
                }
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        

        private void lstTapahtumat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnValitse_Click(object sender, EventArgs e)
        {
            if ( lstTapahtumat.SelectedIndex == -1 )
            {
                MessageBox.Show("Valitse tapahtuma ensin!");
            }
            else
            {
                SelectedEvent = lstTapahtumat.GetItemText(lstTapahtumat.SelectedItem);
                this.Hide();
                Tapahtuma t = new Tapahtuma(SelectedEvent);
                t.FormClosed += (s, args) => this.Close();
                t.ShowDialog();
            }
            
        }
    }
}
