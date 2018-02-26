using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aikalaskuri
{
    public partial class Reports : Form
    {
        string EventID = "";

        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;
        DataTable dtResults;
        DataTable dtAttendees;
        DataSet dsResults;
        DataTable dtMaxLaps;

        // ********************************

        public Reports(string inEventID)
        {
            InitializeComponent();

            EventID = inEventID;

            CreateTabs();
            // Event Handler
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            this.Text = "Kisan tulokset";
        }

        public void GetAttendees(string ClassName)
        {
            try
            {

                // Lap times to Datatable dtResults
                // Call DatabaseConnection Class
                // first create new object
                // then give SQL as a parameter
                objConnect = new DatabaseConnection();
                objConnect.Sql = "select DISTINCT p.PersonID, d.VehicleID, p.LastName Sukunimi, p.FirstName Etunimi, d.Vehicle Laite from Device D JOIN Class c ON d.ClassID = c.ClassID JOIN LapTime l ON d.VehicleID = l.VehicleID JOIN Person p ON p.PersonID = d.PersonID WHERE c.Name = '" + ClassName + "' AND c.EventID = '" + EventID + "' ORDER BY l.LapNumber";
                dsResults = objConnect.GetConnection;
                dtAttendees = new DataTable();
                dtAttendees = dsResults.Tables["Table"];
            }
            catch { }
        }

        public void GetLaps(string VehicleID)
        {
            try
            {
                // Lap times to Datatable dtResults
                // Call DatabaseConnection Class
                // first create new object
                // then give SQL as a parameter
                objConnect = new DatabaseConnection();
                objConnect.Sql = "select d.VehicleID, l.LapTime from Device D JOIN Class c ON d.ClassID = c.ClassID JOIN LapTime l ON d.VehicleID = l.VehicleID JOIN Person p ON p.PersonID = d.PersonID WHERE d.VehicleID = '" + VehicleID + "' AND c.EventID = '" + EventID + "' ORDER BY l.LapNumber";
                dsResults = objConnect.GetConnection;
                dtResults = new DataTable();
                dtResults = dsResults.Tables["Table"];
            }
            catch { }
        }

        public void GetMaxLapNumberPerClass(string ClassName)
        {
            try
            {

                // Laps amount to Datatable dtMaxLaps
                // Call DatabaseConnection Class
                // first create new object
                // then give SQL as a parameter
                objConnect = new DatabaseConnection();
                objConnect.Sql = "SELECT c.Name as Luokka, MAX(lt.LapNumber) as Kierroksia FROM LapTime lt JOIN Device d ON d.VehicleID = lt.VehicleID JOIN Class c ON c.ClassID = d.ClassID WHERE c.Name = '" + ClassName + "' AND c.EventID = '" + EventID + "' GROUP BY c.Name";
                ds = objConnect.GetConnection;
                dtMaxLaps = new DataTable();
                dtMaxLaps = ds.Tables["Table"];
            }
            catch { }
        }

        /*
        private void ReportDataGridView()
        {

        }
        */
        
        private void CreateTabs()
        {
            try
            {
                // class to create tabs to tabController

                objConnect = new DatabaseConnection();
                objConnect.Sql = "SELECT DISTINCT Name FROM Class WHERE EventID = '" + EventID + "'";
                ds = objConnect.GetConnection;
                dt = new DataTable();
                dt = ds.Tables["Table"];

                foreach (DataRow dr in dt.Rows)
                {
                    // Create tabs from classes
                    string ClassName = dr["Name"].ToString();
                    tabControl.TabPages.Add(ClassName);
                }
            }
            catch { }

        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTab();
        }

        private void FillTab()
        {

            try
            {

                // So far, remove first (Summary) tab
                tabControl.TabPages.RemoveByKey("tab1");
                // But only after some page has been clicked

                string TabName = tabControl.TabPages[this.tabControl.SelectedIndex].Text;

                // Create DataGridView
                DataGridView dgvTime = new DataGridView();
                dgvTime.Name = "dgv" + TabName;
                dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                // dgvTime.Parent = this;
                dgvTime.Location = new System.Drawing.Point(20, 40);
                dgvTime.Size = new System.Drawing.Size(1200, 970);
                dgvTime.ReadOnly = true;
                dgvTime.Enabled = true;
                dgvTime.AllowUserToAddRows = false;
                dgvTime.AllowUserToDeleteRows = true;
                dgvTime.AllowUserToOrderColumns = true;
                dgvTime.AllowUserToResizeRows = true;
                dgvTime.AllowUserToResizeRows = true;
                dgvTime.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                //dgvTime.Allow = true;

                // Add DataGridView to Tab
                TabPage ntb = tabControl.TabPages[this.tabControl.SelectedIndex];
                // Add to Tab
                ntb.Controls.Add(dgvTime);

                // Get distinct users of class results
                GetAttendees(TabName);
                GetMaxLapNumberPerClass(TabName);

                string LapsMax = "0";
                foreach (DataRow dr in dtMaxLaps.Rows)
                {
                    LapsMax = dr["Kierroksia"].ToString();
                }

                DataTable Results = new DataTable();
                Results.Columns.Add("SukuNimi");
                Results.Columns.Add("Etunimi");
                Results.Columns.Add("Laite");

                int r = 0;
                foreach (DataRow dr in dtAttendees.Rows)
                {
                    string VehicleID = dr["VehicleID"].ToString();
                    GetLaps(VehicleID);

                    // Now we got results in dtResults data table
                    if (r == 0)
                    {
                        dgvTime.Columns.Add("LastName", "Sukunimi");
                        dgvTime.Columns.Add("FirstName", "Etunimi");
                        dgvTime.Columns.Add("Device", "Laite");

                        for (int ii = 1; ii <= Int32.Parse(LapsMax); ii++)
                        {
                            dgvTime.Columns.Add("Lap" + ii, "Kierros" + ii);
                        }

                        dgvTime.Columns.Add("TotalTime", "Yhteistulos");
                    }

                    dgvTime.Rows.Add();


                    string LastName = dr["Sukunimi"].ToString();
                    string FirstName = dr["Etunimi"].ToString();
                    string Device = dr["Laite"].ToString();
                    dgvTime.Rows[r].Cells[0].Value = LastName;
                    dgvTime.Rows[r].Cells[1].Value = FirstName;
                    dgvTime.Rows[r].Cells[2].Value = Device;

                    TimeSpan TotalTime = new TimeSpan();

                    int f = 3;
                    for (int j = 0; j < dtResults.Rows.Count; j++)
                    {
                        string LapTimeString = dtResults.Rows[j][1].ToString();
                        // Single LapTime to string 
                        TimeSpan LapTime = TimeSpan.Parse(LapTimeString);
                        // Put it to datagridview with formatting
                        dgvTime.Rows[r].Cells[f].Value = LapTime.ToString(@"mm\:ss\.ff");
                        // Also put same LapTime to TotalTimeString
                        TotalTime = TotalTime + TimeSpan.Parse(LapTimeString);
                        f++;
                    }
                    // Add Total time of laps as a last one to datagridview
                    dgvTime.Rows[r].Cells[dgvTime.Columns.Count - 1].Value = TotalTime.ToString(@"mm\:ss\.ff");

                    // 

                    r++;

                }

                // Sort results

                if (dgvTime.Rows.Count > 0)
                {
                    dgvTime.Sort(dgvTime.Columns["TotalTime"], ListSortDirection.Ascending);
                }

                dgvTime.Columns.Add("Difference", "Ero 1:een");
                
                for ( int i = 1; i<dgvTime.Rows.Count; i++)
                {
                    String var1 = dgvTime.Rows[0].Cells["TotalTime"].Value.ToString();
                    TimeSpan var1TS = TimeSpan.ParseExact(var1, @"mm\:ss\.ff", System.Globalization.CultureInfo.InvariantCulture);
                    String var2 = dgvTime.Rows[i].Cells["TotalTime"].Value.ToString();
                    TimeSpan var2TS = TimeSpan.ParseExact(var2, @"mm\:ss\.ff", System.Globalization.CultureInfo.InvariantCulture);
                    TimeSpan Difference = var2TS - var1TS;
                    dgvTime.Rows[i].Cells["Difference"].Value = Difference.ToString(@"mm\:ss\.ff");
                }
                

                // Create Print button
                Button Print = new Button();
                Print.Text = "Tulosta";
                Print.Name = "btnPrint";
                Print.Location = new System.Drawing.Point(1098, 667);

                this.Controls.Add(Print);

                Print.Click += delegate
                {
                    ClsPrint _ClsPrint = new ClsPrint(dgvTime, TabName);
                    _ClsPrint.PrintForm();
                };


            }
            catch ( Exception exc) { MessageBox.Show(exc.Message); }

        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close window
            this.Close();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // this.reportLapTimes.RefreshReport();
        }


        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }



    }
}
