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
    public partial class RaceOrder : Form
    {
        string EventID = "";

        // Database parts
        DatabaseConnection objConnect;
        DataSet ds;
        DataTable dt;


        public RaceOrder(string inEventID)
        {
            InitializeComponent();

            // Common variable to point out correct event
            EventID = inEventID;

            // Get classes to comboBox
            GetClasses();
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Text = "Lähtöjästyksen hallinta";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close Form
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Save form
                int i = 1;
                foreach (DataGridViewRow row in dgvClassOrder.Rows)
                {
                    string DeviceID = row.Cells["DeviceID"].Value.ToString();
                    // first create new object
                    objConnect = new DatabaseConnection();
                    // then give SQL as a parameter
                    objConnect.Sql = "UPDATE Device SET RaceOrder = '" + i.ToString() + "' WHERE VehicleID = '" + DeviceID + "' AND ClassID = '" + cbClassIDs.SelectedItem.ToString() + "' AND ClassID in (SELECT ClassID FROM Class WHERE EventID = '" + EventID + "' AND ClassID = '" + cbClassIDs.SelectedItem.ToString() + "' LIMIT 1)";
                    ds = objConnect.GetConnection;
                    // Update database
                    i++;
                }

                // Clear datagridview
                dgvClassOrder.Rows.Clear();
                GetAttendeesByClass(cbClassIDs.SelectedItem.ToString());

                MessageBox.Show("Muutokset tallennettu!", "Tallennus");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int cbIndex = cbClass.SelectedIndex;
                cbClassIDs.SelectedIndex = cbIndex;
                string cbID = cbClassIDs.SelectedItem.ToString();

                // Then fill datagridview by chosen value
                GetAttendeesByClass(cbID);
            }
            catch { }

        }

        private void GetClasses()
        {
            try
            {
                // Get list of classes here

                // Call DatabaseConnection Class
                // first create new object
                objConnect = new DatabaseConnection();
                // then give SQL as a parameter
                objConnect.Sql = "SELECT ClassID, Name FROM Class WHERE EventID = '" + EventID + "' ORDER BY Name";
                ds = objConnect.GetConnection;
                dt = new DataTable();
                dt = ds.Tables["Table"];

                foreach (DataRow dr in dt.Rows)
                {
                    cbClass.Items.Add(dr[1].ToString());
                    cbClassIDs.Items.Add(dr[0].ToString());
                }

                // Select first value 
                if (cbClass.Items.Count > 0)
                {
                    cbClass.SelectedIndex = 0;
                }
            }
            catch { }

        }

        private void GetAttendeesByClass(string ClassID)
        {
            try
            {

                // Get list of classes here

                // Call DatabaseConnection Class
                // first create new object
                objConnect = new DatabaseConnection();
                // then give SQL as a parameter
                objConnect.Sql = "SELECT d.VehicleID, d.RaceOrder, p.Lastname, p.Firstname, d.ClassID, d.Vehicle FROM Device d JOIN Person p ON d.PersonID = p.PersonID WHERE p.EventID = '" + EventID + "' AND d.ClassID = '" + ClassID + "' ORDER BY RaceOrder, LastName";
                ds = objConnect.GetConnection;
                dt = new DataTable();
                dt = ds.Tables["Table"];

                // First Clear list - could contain data
                dgvClassOrder.Rows.Clear();

                // Now fill list
                foreach (DataRow dr in dt.Rows)
                {
                    string PersonName = dr["LastName"].ToString() + ", " + dr["FirstName"].ToString();
                    dgvClassOrder.Rows.Add(dr["VehicleID"].ToString(), dr["RaceOrder"].ToString(), PersonName, dr["Vehicle"].ToString());
                }

                // Enable editing only RaceOrder column
                dgvClassOrder.Columns[0].ReadOnly = true;
                dgvClassOrder.Columns[1].ReadOnly = false;
                dgvClassOrder.Columns[2].ReadOnly = true;
            }
            catch { }

        }
        
        private void btnUp_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvClassOrder;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex - 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvClassOrder;
            try
            {
                int totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                // get index of the column for the selected cell
                int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex + 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void dgvClassOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void RaceOrder_Load_1(object sender, EventArgs e)
        {
        }
    }

    
}
