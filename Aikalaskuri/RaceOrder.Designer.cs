namespace Aikalaskuri
{
    partial class RaceOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRaceOrders = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.dgvClassOrder = new System.Windows.Forms.DataGridView();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbClassIDs = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaceOrders
            // 
            this.lblRaceOrders.AutoSize = true;
            this.lblRaceOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceOrders.Location = new System.Drawing.Point(56, 46);
            this.lblRaceOrders.Name = "lblRaceOrders";
            this.lblRaceOrders.Size = new System.Drawing.Size(215, 18);
            this.lblRaceOrders.TabIndex = 0;
            this.lblRaceOrders.Text = "Lähtöjärjestyksien muuttaminen";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(149, 95);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(147, 21);
            this.cbClass.TabIndex = 1;
            this.cbClass.Text = "Valitse luokka";
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(58, 98);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(43, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Luokka";
            // 
            // dgvClassOrder
            // 
            this.dgvClassOrder.AllowUserToAddRows = false;
            this.dgvClassOrder.AllowUserToDeleteRows = false;
            this.dgvClassOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClassOrder.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvClassOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClassOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceID,
            this.LapOrder,
            this.Person,
            this.Vehicle});
            this.dgvClassOrder.Location = new System.Drawing.Point(149, 131);
            this.dgvClassOrder.Name = "dgvClassOrder";
            this.dgvClassOrder.Size = new System.Drawing.Size(346, 227);
            this.dgvClassOrder.TabIndex = 3;
            this.dgvClassOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassOrder_CellContentClick);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(58, 216);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(71, 13);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "Lähtöjärjestys";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(488, 364);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(407, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Tallenna";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbClassIDs
            // 
            this.cbClassIDs.FormattingEnabled = true;
            this.cbClassIDs.Location = new System.Drawing.Point(317, 95);
            this.cbClassIDs.Name = "cbClassIDs";
            this.cbClassIDs.Size = new System.Drawing.Size(147, 21);
            this.cbClassIDs.TabIndex = 7;
            this.cbClassIDs.Text = "ID";
            this.cbClassIDs.Visible = false;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(514, 211);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(49, 23);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "Ylös";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(514, 240);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(49, 23);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "Alas";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // DeviceID
            // 
            this.DeviceID.HeaderText = "VehicleID";
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.ReadOnly = true;
            this.DeviceID.Visible = false;
            // 
            // LapOrder
            // 
            this.LapOrder.HeaderText = "Lähtönumero";
            this.LapOrder.Name = "LapOrder";
            this.LapOrder.ReadOnly = true;
            // 
            // Person
            // 
            this.Person.HeaderText = "Henkilö";
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Ajoneuvo";
            this.Vehicle.Name = "Vehicle";
            // 
            // RaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 399);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.cbClassIDs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.dgvClassOrder);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lblRaceOrders);
            this.Name = "RaceOrder";
            this.Text = "RaceOrder";
            this.Load += new System.EventHandler(this.RaceOrder_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaceOrders;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.DataGridView dgvClassOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbClassIDs;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
    }
}