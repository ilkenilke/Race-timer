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
    public partial class Tapahtuma : Form
    {

        // Variables
        // ********************************
        public string TapahtumanNimi { get { return lblTapahtuma.Text; } }
        public string EventID;
        public string EventName;
        public string TimeVehicleID = "";

        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;
        DataTable attendees;
        // ********************************


        // End of variables

        public Tapahtuma(string input)
        {
            InitializeComponent();
            EventName = input; // Just get EventName variable just for sure
            lblTapahtuma.Text = input; // Update Event label on top
            this.Text = "Tapahtuman " + input + " käsittely";

            // Modify form
            tbTotalResult.Enabled = false; // Set textBox AllowEdit = 0
            // Hide next datagridviews
            dgvLapTimes.Visible = false;
            dgvParticipancy.Visible = false;
            // Hide buttons and time
            btnAddTime.Visible = false;
            btnModifyLap.Visible = false;
            btnRemoveLap.Visible = false;
            tbTotalResult.Visible = false;
            lblTotalResult.Visible = false;
            btnLoadLaps.Visible = false;

        }

        private void Tapahtuma_Load(object sender, EventArgs e)
        {
            // This will always come up first
            //
            // Get EventID here as a common variable
            // Call DatabaseConnection Class
            // first create new object
            objConnect = new DatabaseConnection();
            // then give SQL as a parameter
            objConnect.Sql = "SELECT EventID, strftime('%d.%m.%Y', EventDate) AS EventDate From Event WHERE EventName = '" + EventName + "'";
            ds = objConnect.GetConnection;
            dt = new DataTable();
            dt = ds.Tables["Table"];
            string EventDate = "";
            foreach ( DataRow dr in dt.Rows)
            {
                EventID = dr["EventID"].ToString(); // EventID variable we can count on later. Not visible anywhere
                EventDate = dr["EventDate"].ToString();
            }

            // Fill Classes box
            HaeLuokat();

            // Update Event date label
            lblTapahtuma.Text = lblTapahtuma.Text + " | " + EventDate;

            // Change column width to be small one
            dgvLapTimes.Columns["LapID"].Width = 1;

        }

        private void HaeLuokat()
        {
            try
            {
                // Call DatabaseConnection Class
                // first create new object
                objConnect = new DatabaseConnection();
                // then give SQL as a parameter
                objConnect.Sql = "SELECT ClassID, Name From Class WHERE EventID = '" + EventID + "' order by Name";
                ds = objConnect.GetConnection;
                dt = new DataTable();
                dt = ds.Tables["Table"];

                string TestString = "";
                foreach ( DataRow dr in dt.Rows )
                {
                    TestString = dr["ClassID"].ToString();
                }
                if (TestString.Length == 0 )
                {
                    // Call Create New Class form to create new classes to competition
                    MessageBox.Show("Tapahtumalla ei ole vielä yhtään luokkaa. Siirry luomaan niitä");
                    // How?
                }
                else
                {
                    TaytaLuokatDg();
                }

                // Fill Lap types if there is none
                objConnect.Sql = "SELECT LapTypeID From LapTypes WHERE EventID = '" + EventID + "'";
                ds = objConnect.GetConnection;
                dt = new DataTable();
                dt = ds.Tables["Table"];

                TestString = "";
                foreach (DataRow dr in dt.Rows)
                {
                    TestString = dr["LapTypeID"].ToString();
                }
                if (TestString.Length == 0)
                {
                    // Call Create New Class form to create new classes to competition
                    MessageBox.Show("Tapahtumalla ei ole yhtään kierrostyyppiä. Siirry luomaan niitä");
                    FillLapTypes();
                }

                // Get all attendees of all classes to variable
                FetchAttendeesAllClasses();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // Class to get attendees of all classes
        private void FetchAttendeesAllClasses()
        {
            
            try
            {
                // First Clear box values 
                dgvParticipancy.Rows.Clear();
                // Then fill it 
                // Call DatabaseConnection Class
                // first create new object
                objConnect = new DatabaseConnection();
                // then give SQL as a parameter
                objConnect.Sql = "SELECT p.PersonID, p.Lastname, p.Firstname, d.Vehicle, d.ClassID, d.VehicleID FROM Device d JOIN Person p ON p.PersonID = d.PersonID WHERE p.EventID = '" + EventID + "' ORDER BY d.RaceOrder";
                ds = objConnect.GetConnection;
                attendees = new DataTable();
                attendees = ds.Tables["Table"];

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // Class to get attendees of single class
        private void FetchAttendeesSingleClass(string inClassID)
        {
            string ClassID = inClassID;
            try
            {

                string PersonName = "";
                foreach ( DataRow dr in attendees.Rows )
                {
                    if ( dr["ClassID"].ToString() == ClassID)
                    {
                        PersonName = dr["LastName"] + ", " + dr["FirstName"];
                        dgvParticipancy.Rows.Add(new object[] { PersonName, dr["Vehicle"], dr["PersonID"], dr["ClassID"], dr["VehicleID"] });
                    }
                    
                    
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnPoistaOsallistuja_Click(object sender, EventArgs e)
        {
            try
            {
                Henkilot t = new Henkilot(EventID);
                t.ShowDialog();

                // Manual refresh to lists
                ReFreshFields();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnLopeta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kiitos kun käytit AikaTimmiä!\n\nAll rights reserved: \n\tIlkka Ruuska, Ruusolu\n\nPalautteet\\kehitysideat: ilkka87@gmail.com", "Kiitos käynnistä!");
            // Exit application
            Application.Exit();
        }

        private void dgLuokat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear Participancy datagridview
            dgvParticipancy.Rows.Clear();
            // Clear LapTimes datagridview
            dgvLapTimes.Rows.Clear();
            // Clear PersonName label
            lblPerson.Text = "";
            // Clear DeviceName Label
            lblDeviceName.Text = "";
            // Clear TimeVehicleID to null
            TimeVehicleID = "";

            // Hide next datagridview
            dgvLapTimes.Visible = false;
            dgvParticipancy.Visible = false;
            // Hide buttons and time
            btnAddTime.Visible = false;
            btnModifyLap.Visible = false;
            btnRemoveLap.Visible = false;
            tbTotalResult.Visible = false;
            lblTotalResult.Visible = false;
            btnLoadLaps.Visible = false;

        }

        private void btnLoadParticipants_Click(object sender, EventArgs e)
        {
            // Button to refresh class participants list manually
            // Clear Participancy datagridview
            dgvParticipancy.Rows.Clear();
            // Clear LapTimes datagridview
            dgvLapTimes.Rows.Clear();
            // Clear PersonName label
            lblPerson.Text = "";
            // Clear DeviceName Label
            lblDeviceName.Text = "";
            // Clear TimeVehicleID to null
            TimeVehicleID = "";

            //int rowIndex = dgLuokat.CurrentRow.Index;
            string ClassID = dgLuokat.Rows[dgLuokat.CurrentRow.Index].Cells["ID"].Value.ToString();
            string ClassName = dgLuokat.Rows[dgLuokat.CurrentRow.Index].Cells["Luokka"].Value.ToString();
            lblOsallistujat.Text = ClassName;
            FetchAttendeesSingleClass(ClassID);

            // Show datagridview and buttons
            dgvParticipancy.Visible = true;
            btnLoadLaps.Visible = true;
        }

        private void TaytaLuokatDg()
        {
            foreach (DataRow dr in dt.Rows)
            {
                dgLuokat.Rows.Add(new object[] { dr["Name"], dr["ClassID"] });
            }
            
            // Check if there is any LapTypes



        }


        private void btnPoistaLuokka_Click(object sender, EventArgs e)
        {
            try
            {
                PoistaLuokka t = new PoistaLuokka(EventID);
                t.ShowDialog();
                dgLuokat.Rows.Clear();
                ReFreshFields();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Manual refresh
            ReFreshFields();

        }

        private void ReFreshFields ()
        {
            
            // Clear attendees listbox
            dgvParticipancy.Rows.Clear();
            // clear attendees dgv
            dgLuokat.Rows.Clear();
            // Clear lap times dgv
            dgvLapTimes.Rows.Clear();
            // Clear PersonName label
            lblPerson.Text = "";
            // Clear DeviceName Label
            lblDeviceName.Text = "";
            // Clear TimeVehicleID to null
            TimeVehicleID = "";
            // Total result time
            tbTotalResult.Text = "";
            // Participants label
            lblOsallistujat.Text = "";

            // Get data again
            // Fetch Classes
            HaeLuokat();
            // Fetch attendees list
            FetchAttendeesAllClasses();

            // Hide next datagridviews
            dgvLapTimes.Visible = false;
            dgvParticipancy.Visible = false;
            // Hide buttons and time
            btnAddTime.Visible = false;
            btnModifyLap.Visible = false;
            btnRemoveLap.Visible = false;
            tbTotalResult.Visible = false;
            lblTotalResult.Visible = false;
            btnLoadLaps.Visible = false;
        }

        private void dgvParticipancy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // First clear things
            // Clear PersonName label
            lblPerson.Text = "";
            // Clear DeviceName Label
            lblDeviceName.Text = "";
            // Clear LapTimes datagridview
            dgvLapTimes.Rows.Clear();
            // Clear TimeVehicleID to null
            TimeVehicleID = "";
            // Clear Total time
            tbTotalResult.Text = "";

            // Hide next datagridview
            dgvLapTimes.Visible = false;
            // Hide buttons and time
            btnAddTime.Visible = false;
            btnModifyLap.Visible = false;
            btnRemoveLap.Visible = false;
            tbTotalResult.Visible = false;
            lblTotalResult.Visible = false;
        }


        private void btnLoadLaps_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvParticipancy.Rows.Count > 0)
                {
                    // show next datagridview
                    dgvLapTimes.Visible = true;
                    // show buttons and time
                    btnAddTime.Visible = true;
                    btnModifyLap.Visible = true;
                    btnRemoveLap.Visible = true;
                    tbTotalResult.Visible = true;
                    lblTotalResult.Visible = true;


                    string PersonName = dgvParticipancy.Rows[dgvParticipancy.CurrentRow.Index].Cells["PersonName"].Value.ToString();
                    TimeVehicleID = dgvParticipancy.Rows[dgvParticipancy.CurrentRow.Index].Cells["DeviceID"].Value.ToString();
                    string Device = dgvParticipancy.Rows[dgvParticipancy.CurrentRow.Index].Cells["Vehicle"].Value.ToString();
                    // Update label
                    lblPerson.Text = PersonName;
                    lblDeviceName.Text = Device;

                    dgvLapTimes.Rows.Clear();
                    FillLaps();
                }
            }
            catch ( Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void btnAddTime_Click(object sender, EventArgs e)
        {
            try
            {
                if ( dgvParticipancy.Rows.Count > 0 || !string.IsNullOrWhiteSpace(TimeVehicleID) )
                {
                    TimeManagement t = new TimeManagement(lblPerson.Text, lblDeviceName.Text, "Add", "", EventID, TimeVehicleID, "", "");
                    t.ShowDialog();
                    dgvLapTimes.Rows.Clear();
                    FillLaps();
                }
                else
                {
                    MessageBox.Show("Valitse osallistuja!");
                }

                
            }
            catch ( Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void FillLaps()
        {
            // Call DatabaseConnection Class
            // first create new object
            objConnect = new DatabaseConnection();
            // then give SQL as a parameter
            objConnect.Sql = "SELECT LapID, LapNumber, LapTime, VehicleID, LapType From LapTime WHERE VehicleID = '" + TimeVehicleID + "' AND Deleted = 0 ORDER BY LapNumber";
            ds = objConnect.GetConnection;
            dt = new DataTable();
            dt = ds.Tables["Table"];
            DataTable dtLapTimes = dt;  // Copy to another DataTable also
            int tempLapTime = 0;
            foreach (DataRow dr in dt.Rows)
            {
                tempLapTime++;
                string LapID = dr["LapID"].ToString();
                objConnect.Sql = "UPDATE LapTime SET LapNumber = '" + tempLapTime + "' WHERE VehicleID = '" + TimeVehicleID + "' AND Deleted = 0 AND LapID = '" + LapID + "'";
                ds = objConnect.GetConnection;
                string LapTime = dr["LapTime"].ToString();
                // Format output
                if ( LapTime.Substring(0, 3) == "00:" )
                {
                    LapTime = LapTime.Substring(3);
                }
                // And fill table
                dgvLapTimes.Rows.Add(new object[] { dr["LapID"], tempLapTime, LapTime, dr["LapType"] });
            }
            // Delete obsolete values also
            objConnect.Sql = "DELETE From LapTime WHERE VehicleID = '" + TimeVehicleID + "' AND Deleted = 1";
            ds = objConnect.GetConnection;


            if (dgvLapTimes.RowCount > 0)
            {
                // Also fill details 
                TimeSpan TotalTime = new TimeSpan();
                foreach (DataRow dr in dtLapTimes.Rows)
                {
                    string tempTime = dr["LapTime"].ToString();
                    TotalTime = TotalTime + TimeSpan.Parse(tempTime);
                }
                // Update TextBox
                tbTotalResult.Text = TotalTime.ToString(@"mm\:ss\.ff");
            }

        }

        private void btnRemoveLap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(TimeVehicleID))
                {
                    string LapID = dgvLapTimes.Rows[dgvLapTimes.CurrentCell.RowIndex].Cells["LapID"].Value.ToString();
                    string LapNo = dgvLapTimes.Rows[dgvLapTimes.CurrentCell.RowIndex].Cells["LapNo"].Value.ToString();
                    string LapTime = dgvLapTimes.Rows[dgvLapTimes.CurrentCell.RowIndex].Cells["LapTime"].Value.ToString();

                    DialogResult dr = MessageBox.Show("Poistetaanko kierros " + LapNo + ": " + LapTime + "", "Kierroksen poistaminen", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        // first create new object
                        objConnect = new DatabaseConnection();
                        // then give SQL as a parameter
                        objConnect.Sql = "UPDATE LapTime SET Deleted = 1 WHERE LapID = '" + LapID + "'";
                        // Run
                        ds = objConnect.GetConnection;

                        // Refresh
                        dgvLapTimes.Rows.Clear();
                        FillLaps();
                    }
                    else if (dr == DialogResult.No)
                    {
                        // Nothing to do
                    }
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void btnModifyLap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(TimeVehicleID))
                {
                    
                    if ( dgvLapTimes.Rows.Count > 0 )
                    {
                        string LapID = dgvLapTimes.Rows[dgvLapTimes.CurrentCell.RowIndex].Cells["LapID"].Value.ToString();
                        string LapType = dgvLapTimes.Rows[dgvLapTimes.CurrentCell.RowIndex].Cells["LapType"].Value.ToString();
                        string LapTime = dgvLapTimes.Rows[dgvLapTimes.CurrentCell.RowIndex].Cells["LapTime"].Value.ToString();
                        TimeManagement t = new TimeManagement(lblPerson.Text, lblDeviceName.Text, "Modify", LapID, EventID, TimeVehicleID, LapType, LapTime);
                        t.ShowDialog();

                        // Refresh
                        dgvLapTimes.Rows.Clear();
                        FillLaps();
                    }
                    else
                    {
                        // Nothing to do here
                    }
                }
                else
                {
                    // Just do nothing
                }
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }


        private void btnLapTypes_Click(object sender, EventArgs e)
        {
            FillLapTypes();
        }

        private void FillLapTypes()
        {
            // own class that we can call it from different places
            LapTypeManagement ltm = new LapTypeManagement(EventID);
            ltm.ShowDialog();
        }

        private void btnClassReports_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports(EventID);
            rep.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLuokanHallinta_Click(object sender, EventArgs e)
        {

        }

        private void dgvLapTimes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChangeRaceOrder_Click(object sender, EventArgs e)
        {
            RaceOrder rac = new RaceOrder(EventID);
            rac.ShowDialog();

            // Manual refresh
            ReFreshFields();
        }

        private void btnPrintRaceOrder_Click(object sender, EventArgs e)
        {
            // Print starting lists 
            try
            {
                // Call DatabaseConnection Class
                // first create new object
                objConnect = new DatabaseConnection();
                // then give SQL as a parameter
                // Classes
                objConnect.Sql = "select * from class WHERE EventID = '" + EventID + "' ORDER BY Name";
                ds = objConnect.GetConnection;
                DataTable RaceClasses = new DataTable();
                RaceClasses = ds.Tables["Table"];

                // Attendees with more details
                objConnect.Sql = "SELECT d.ClassID, d.RaceOrder Lähtönumero, p.Lastname, p.Firstname, d.Vehicle Ajoneuvo, d.Vehicle_info Ajoneuvon_Tiedot, p.City Kunta, p.Club Seura FROM Device d JOIN Person p ON p.PersonID = d.PersonID WHERE p.EventID = '" + EventID + "' ORDER BY d.RaceOrder";
                ds = objConnect.GetConnection;
                dt = new DataTable();
                dt = ds.Tables["Table"];

                // Warn about actions
                MessageBox.Show("Tulostetaan lähtölistat. Sinulle avautuu jokainen luokka erikseen tulostettavaksi, kun suljet ikkunan aukeaa seuraava luokka.", "Luokkien tulostaminen");

                foreach ( DataRow dr in RaceClasses.Rows)
                {
                    var FilteredAttendees = dt.Select("ClassID = '" + dr["ClassID"].ToString() + "'").CopyToDataTable();
                    if (FilteredAttendees.Rows.Count > 0)
                    {
                        DataGridView dgvAttendees = new DataGridView();
                        dgvAttendees.Rows.Clear();
                        dgvAttendees.Columns.Add("StartingNumber", "Lähtönumero");
                        dgvAttendees.Columns.Add("Person", "Henkilö");
                        dgvAttendees.Columns.Add("Vehicle", "Ajoneuvo");
                        dgvAttendees.Columns.Add("VehicleInfo", "Ajoneuvon lisätiedot");
                        dgvAttendees.Columns.Add("City", "Kunta");
                        dgvAttendees.Columns.Add("Club", "Seura");

                        string Class = "";
                        foreach (DataRow d in FilteredAttendees.Rows)
                        {
                            Class = dr["Name"].ToString();
                            string Henkilö = d["Lastname"].ToString() + ", " + d["Firstname"].ToString();
                            dgvAttendees.Rows.Add(d["Lähtönumero"].ToString(), Henkilö, d["Ajoneuvo"].ToString(), d["Ajoneuvon_Tiedot"].ToString(), d["Kunta"].ToString(), d["Seura"].ToString());
                        }
                        // Then print it
                        ClsPrint _ClsPrint = new ClsPrint(dgvAttendees, Class);
                        _ClsPrint.PrintForm();
                    }
                    else
                    {
                        // Nothing to print here
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
