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
    public partial class TimeManagement : Form
    {

        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;

        string LapID = "";
        string EventID = "";
        string VehicleID = "";
        string LapType = "";
        string AddType = "";
        string LapTime = "";

        public TimeManagement(string inPersonName, string inDevice, string inAddType, string inLapID, string inEventID, string inVehicleID, string inLapType, string inLapTime)
        {
            InitializeComponent();


            lblPerson.Text = inPersonName;
            lblDevice.Text = inDevice;
            LapID = inLapID;
            EventID = inEventID;
            VehicleID = inVehicleID;
            LapType = inLapType;
            AddType = inAddType;
            LapTime = inLapTime;

            if ( inAddType == "Add" )
            {
                btnAdd.Text = "Lisää";
                this.Text = "Lisää aika";
            }
            else if ( inAddType == "Modify" )
            {
                btnAdd.Text = "Muokkaa";
                this.Text = "Muokkaa aikaa";

                // This is for updating current value
                // substring Time to separate fields
                string Minutes = LapTime.Split(':')[0];
                string Seconds = LapTime.Split(':', ',')[1];
                string Milliseconds = LapTime.Split(',')[1];
                // And update fields with those values
                if ( Seconds[0].ToString() == "0" ) { Seconds = Seconds[1].ToString(); }
                if ( Milliseconds[0].ToString() == "0") { Milliseconds = Milliseconds[1].ToString(); }

                tbMinutes.Text = Minutes;
                tbSeconds.Text = Seconds;
                tbMilliseconds.Text = Milliseconds;
                
                //numMinutes.Value = decimal.Parse(Minutes);
                //numSeconds.Value = decimal.Parse(Seconds);
                //numMilliseconds.Value = decimal.Parse(Milliseconds);
                cbLapType.Text = LapType;
            }

            LoadEventTypes();
            // Format ComboBox style
            //cbLapType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Autoload first LapType if there is only 1
            if (cbLapType.Items.Count > -1 && cbLapType.Items.Count < 2)
            {
                cbLapType.SelectedIndex = 0;
            }

            cbLapType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void LoadEventTypes()
        {
            // Load Event Types from database
            
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
                cbLapType.Items.Add(dr["LapType"] );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int parsedValue;
                int Minutes = 0;
                int Seconds = 0;
                int MilliSeconds = 0;

                if (!int.TryParse(tbMinutes.Text, out parsedValue) || !int.TryParse(tbSeconds.Text, out parsedValue) || !int.TryParse(tbMilliseconds.Text, out parsedValue))
                {
                    MessageBox.Show("Tarkista aika!");
                }
                else
                {
                    Minutes = Convert.ToInt32(tbMinutes.Text);
                    Seconds = Convert.ToInt32(tbSeconds.Text);
                    MilliSeconds = Convert.ToInt32(tbMilliseconds.Text);


                    // Define time values 
                    Boolean testMinutes = CheckTimes(Minutes, 0, 99999999);
                    Boolean testSeconds = CheckTimes(Seconds, 0, 60);
                    Boolean testMilliSeconds = CheckTimes(MilliSeconds, 0, 100);

                    // Test values to be correct format
                    if (testMinutes == false)
                    {
                        MessageBox.Show("Tarkista Minuutit! Minimiaika on 0");
                    }
                    else if (testSeconds == false)
                    {
                        MessageBox.Show("Tarkista sekunnit! Sekunnit alle 60s");
                    }
                    else if (testMilliSeconds == false)
                    {
                        MessageBox.Show("Tarkista sekunnit! sadasosat alle 100");
                    }
                    else
                    {
                        // Add leading zero if missing
                        string RealSeconds = ModifyNumbers(Seconds);
                        string RealMilliSeconds = ModifyNumbers(MilliSeconds);

                        if (AddType == "Add")
                        {
                            if (cbLapType.SelectedIndex > -1)
                            {
                                // Check if the point entered is numeric or not


                                string SingleLapType = cbLapType.SelectedItem.ToString();


                                //TimeSpan Kierrosaika = new TimeSpan(Minutes, Seconds, Milliseconds);
                                string oLapTime = "00:" + Minutes + ":" + RealSeconds + "," + RealMilliSeconds;
                                // first create new object
                                objConnect = new DatabaseConnection();
                                // then give SQL as a parameter
                                objConnect.Sql = "INSERT INTO LapTime (VehicleID, LapNumber, LapTime, Deleted, LapType)" +
                                    " VALUES ('" + VehicleID + "', (SELECT IFNULL(MAX(LapNumber)+1,'1') FROM LapTime WHERE VehicleID = '" + VehicleID + "'), '" + oLapTime + "', 0, '" + SingleLapType + "')";
                                ds = objConnect.GetConnection;

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Valitse kierrokselle tyyppi");
                            }
                        }
                        else if (AddType == "Modify")
                        {
                            // Modify existing time
                            string SingleLapType = "";
                            if (cbLapType.SelectedIndex == -1)
                            {
                                SingleLapType = LapType;
                            }
                            else
                            {
                                SingleLapType = cbLapType.SelectedItem.ToString();
                            }


                            //TimeSpan Kierrosaika = new TimeSpan(Minutes, Seconds, Milliseconds);
                            string oLapTime = "00:" + Minutes + ":" + RealSeconds + "," + RealMilliSeconds;

                            // first create new object
                            objConnect = new DatabaseConnection();
                            // then give SQL as a parameter
                            objConnect.Sql = "UPDATE LapTime SET LapTime = '" + oLapTime + "', LapType = '" + SingleLapType + "' WHERE LapID = '" + LapID + "'";
                            ds = objConnect.GetConnection;

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tarkista arvot");
                        }
                    }
                }
                
            }
            catch ( Exception exc ) { MessageBox.Show(exc.Message); }
        }

        private string ModifyNumbers (int inNumber)

        {

            if (inNumber.ToString().Length < 2)

            {
                string textInNumber = inNumber.ToString();
                textInNumber = "0" + textInNumber;
                return (textInNumber);
            }
            else
            {
                return inNumber.ToString();
            }

        }

        private Boolean CheckTimes(int inNumber, int MinValue, int MaxValue)

        {

            if ( inNumber >= MinValue && inNumber < MaxValue )

            {
                // Number OK
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close window
            this.Close();
        }

        private void TimeManagement_Load(object sender, EventArgs e)
        {
            // we won't use this
        }

        private void cbLapType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numMilliseconds_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
