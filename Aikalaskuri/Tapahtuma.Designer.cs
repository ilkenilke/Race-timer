namespace Aikalaskuri
{
    partial class Tapahtuma
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
            this.btnPoistaLuokka = new System.Windows.Forms.Button();
            this.btnPoistaOsallistuja = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeRaceOrder = new System.Windows.Forms.Button();
            this.btnLapTypes = new System.Windows.Forms.Button();
            this.lblManagement = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTapahtuma = new System.Windows.Forms.Label();
            this.btnLopeta = new System.Windows.Forms.Button();
            this.dgLuokat = new System.Windows.Forms.DataGridView();
            this.Luokka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvParticipancy = new System.Windows.Forms.DataGridView();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOsallistujat = new System.Windows.Forms.Label();
            this.dgvLapTimes = new System.Windows.Forms.DataGridView();
            this.LapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.btnModifyLap = new System.Windows.Forms.Button();
            this.btnRemoveLap = new System.Windows.Forms.Button();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.btnLoadParticipants = new System.Windows.Forms.Button();
            this.btnLoadLaps = new System.Windows.Forms.Button();
            this.tbTotalResult = new System.Windows.Forms.TextBox();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.btnClassReports = new System.Windows.Forms.Button();
            this.btnPrintRaceOrder = new System.Windows.Forms.Button();
            this.lblReports = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLuokat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapTimes)).BeginInit();
            this.pnlReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPoistaLuokka
            // 
            this.btnPoistaLuokka.Location = new System.Drawing.Point(20, 60);
            this.btnPoistaLuokka.Name = "btnPoistaLuokka";
            this.btnPoistaLuokka.Size = new System.Drawing.Size(116, 26);
            this.btnPoistaLuokka.TabIndex = 1;
            this.btnPoistaLuokka.Text = "Luokat";
            this.btnPoistaLuokka.UseVisualStyleBackColor = true;
            this.btnPoistaLuokka.Click += new System.EventHandler(this.btnPoistaLuokka_Click);
            // 
            // btnPoistaOsallistuja
            // 
            this.btnPoistaOsallistuja.Location = new System.Drawing.Point(20, 28);
            this.btnPoistaOsallistuja.Name = "btnPoistaOsallistuja";
            this.btnPoistaOsallistuja.Size = new System.Drawing.Size(116, 26);
            this.btnPoistaOsallistuja.TabIndex = 3;
            this.btnPoistaOsallistuja.Text = "Osallistujat";
            this.btnPoistaOsallistuja.UseVisualStyleBackColor = true;
            this.btnPoistaOsallistuja.Click += new System.EventHandler(this.btnPoistaOsallistuja_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChangeRaceOrder);
            this.panel1.Controls.Add(this.btnLapTypes);
            this.panel1.Controls.Add(this.lblManagement);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnPoistaLuokka);
            this.panel1.Controls.Add(this.btnPoistaOsallistuja);
            this.panel1.Location = new System.Drawing.Point(40, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 178);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnChangeRaceOrder
            // 
            this.btnChangeRaceOrder.Location = new System.Drawing.Point(20, 121);
            this.btnChangeRaceOrder.Name = "btnChangeRaceOrder";
            this.btnChangeRaceOrder.Size = new System.Drawing.Size(116, 23);
            this.btnChangeRaceOrder.TabIndex = 35;
            this.btnChangeRaceOrder.Text = "Lähtöjärjestys";
            this.btnChangeRaceOrder.UseVisualStyleBackColor = true;
            this.btnChangeRaceOrder.Click += new System.EventHandler(this.btnChangeRaceOrder_Click);
            // 
            // btnLapTypes
            // 
            this.btnLapTypes.Location = new System.Drawing.Point(20, 92);
            this.btnLapTypes.Name = "btnLapTypes";
            this.btnLapTypes.Size = new System.Drawing.Size(116, 23);
            this.btnLapTypes.TabIndex = 16;
            this.btnLapTypes.Text = "Kierrostyypit";
            this.btnLapTypes.UseVisualStyleBackColor = true;
            this.btnLapTypes.Click += new System.EventHandler(this.btnLapTypes_Click);
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagement.Location = new System.Drawing.Point(45, 0);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(57, 15);
            this.lblManagement.TabIndex = 34;
            this.lblManagement.Text = "Hallinta";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(20, 150);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Päivitä osallistujat";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTapahtuma
            // 
            this.lblTapahtuma.AutoSize = true;
            this.lblTapahtuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblTapahtuma.Location = new System.Drawing.Point(102, 20);
            this.lblTapahtuma.Name = "lblTapahtuma";
            this.lblTapahtuma.Size = new System.Drawing.Size(105, 24);
            this.lblTapahtuma.TabIndex = 9;
            this.lblTapahtuma.Text = "Tapahtuma";
            // 
            // btnLopeta
            // 
            this.btnLopeta.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLopeta.Location = new System.Drawing.Point(40, 494);
            this.btnLopeta.Name = "btnLopeta";
            this.btnLopeta.Size = new System.Drawing.Size(156, 35);
            this.btnLopeta.TabIndex = 11;
            this.btnLopeta.Text = "Sulje AikaTimmi";
            this.btnLopeta.UseVisualStyleBackColor = true;
            this.btnLopeta.Click += new System.EventHandler(this.btnLopeta_Click);
            // 
            // dgLuokat
            // 
            this.dgLuokat.AllowUserToAddRows = false;
            this.dgLuokat.AllowUserToDeleteRows = false;
            this.dgLuokat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLuokat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Luokka,
            this.ID});
            this.dgLuokat.Location = new System.Drawing.Point(254, 166);
            this.dgLuokat.Name = "dgLuokat";
            this.dgLuokat.ReadOnly = true;
            this.dgLuokat.Size = new System.Drawing.Size(212, 216);
            this.dgLuokat.TabIndex = 12;
            this.dgLuokat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLuokat_CellContentClick);
            // 
            // Luokka
            // 
            this.Luokka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Luokka.HeaderText = "Luokka";
            this.Luokka.Name = "Luokka";
            this.Luokka.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dgvParticipancy
            // 
            this.dgvParticipancy.AllowUserToAddRows = false;
            this.dgvParticipancy.AllowUserToDeleteRows = false;
            this.dgvParticipancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipancy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonName,
            this.Vehicle,
            this.PersonID,
            this.ClassID,
            this.DeviceID});
            this.dgvParticipancy.Location = new System.Drawing.Point(572, 164);
            this.dgvParticipancy.Name = "dgvParticipancy";
            this.dgvParticipancy.ReadOnly = true;
            this.dgvParticipancy.Size = new System.Drawing.Size(243, 352);
            this.dgvParticipancy.TabIndex = 13;
            this.dgvParticipancy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipancy_CellContentClick);
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Henkilö";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Väline";
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.ReadOnly = true;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "PersonID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Visible = false;
            // 
            // ClassID
            // 
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            this.ClassID.ReadOnly = true;
            this.ClassID.Visible = false;
            // 
            // DeviceID
            // 
            this.DeviceID.HeaderText = "DeviceID";
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.ReadOnly = true;
            this.DeviceID.Visible = false;
            // 
            // lblOsallistujat
            // 
            this.lblOsallistujat.AutoSize = true;
            this.lblOsallistujat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsallistujat.Location = new System.Drawing.Point(569, 88);
            this.lblOsallistujat.Name = "lblOsallistujat";
            this.lblOsallistujat.Size = new System.Drawing.Size(0, 15);
            this.lblOsallistujat.TabIndex = 14;
            // 
            // dgvLapTimes
            // 
            this.dgvLapTimes.AllowUserToAddRows = false;
            this.dgvLapTimes.AllowUserToDeleteRows = false;
            this.dgvLapTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLapTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LapID,
            this.LapNo,
            this.LapTime,
            this.LapType});
            this.dgvLapTimes.Location = new System.Drawing.Point(907, 210);
            this.dgvLapTimes.Name = "dgvLapTimes";
            this.dgvLapTimes.ReadOnly = true;
            this.dgvLapTimes.Size = new System.Drawing.Size(344, 226);
            this.dgvLapTimes.TabIndex = 17;
            this.dgvLapTimes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLapTimes_CellContentClick);
            // 
            // LapID
            // 
            this.LapID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LapID.HeaderText = "LapID";
            this.LapID.Name = "LapID";
            this.LapID.ReadOnly = true;
            this.LapID.Visible = false;
            this.LapID.Width = 5;
            // 
            // LapNo
            // 
            this.LapNo.HeaderText = "Kierros";
            this.LapNo.Name = "LapNo";
            this.LapNo.ReadOnly = true;
            // 
            // LapTime
            // 
            this.LapTime.HeaderText = "Aika";
            this.LapTime.Name = "LapTime";
            this.LapTime.ReadOnly = true;
            // 
            // LapType
            // 
            this.LapType.HeaderText = "Tyyppi";
            this.LapType.Name = "LapType";
            this.LapType.ReadOnly = true;
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(907, 166);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(98, 23);
            this.btnAddTime.TabIndex = 21;
            this.btnAddTime.Text = "Lisää kierrosaika";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // btnModifyLap
            // 
            this.btnModifyLap.Location = new System.Drawing.Point(1012, 166);
            this.btnModifyLap.Name = "btnModifyLap";
            this.btnModifyLap.Size = new System.Drawing.Size(130, 23);
            this.btnModifyLap.TabIndex = 22;
            this.btnModifyLap.Text = "Muokkaa kierrosaikaa";
            this.btnModifyLap.UseVisualStyleBackColor = true;
            this.btnModifyLap.Click += new System.EventHandler(this.btnModifyLap_Click);
            // 
            // btnRemoveLap
            // 
            this.btnRemoveLap.Location = new System.Drawing.Point(1151, 166);
            this.btnRemoveLap.Name = "btnRemoveLap";
            this.btnRemoveLap.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveLap.TabIndex = 23;
            this.btnRemoveLap.Text = "Poista kierrosaika";
            this.btnRemoveLap.UseVisualStyleBackColor = true;
            this.btnRemoveLap.Click += new System.EventHandler(this.btnRemoveLap_Click);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(904, 88);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(0, 15);
            this.lblPerson.TabIndex = 16;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(918, 107);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(0, 13);
            this.lblDeviceName.TabIndex = 27;
            // 
            // btnLoadParticipants
            // 
            this.btnLoadParticipants.Location = new System.Drawing.Point(482, 243);
            this.btnLoadParticipants.Name = "btnLoadParticipants";
            this.btnLoadParticipants.Size = new System.Drawing.Size(84, 23);
            this.btnLoadParticipants.TabIndex = 28;
            this.btnLoadParticipants.Text = "Osallistujiin >>";
            this.btnLoadParticipants.UseVisualStyleBackColor = true;
            this.btnLoadParticipants.Click += new System.EventHandler(this.btnLoadParticipants_Click);
            // 
            // btnLoadLaps
            // 
            this.btnLoadLaps.Location = new System.Drawing.Point(821, 243);
            this.btnLoadLaps.Name = "btnLoadLaps";
            this.btnLoadLaps.Size = new System.Drawing.Size(73, 23);
            this.btnLoadLaps.TabIndex = 31;
            this.btnLoadLaps.Text = "Aikoihin >>";
            this.btnLoadLaps.UseVisualStyleBackColor = true;
            this.btnLoadLaps.Click += new System.EventHandler(this.btnLoadLaps_Click);
            // 
            // tbTotalResult
            // 
            this.tbTotalResult.Location = new System.Drawing.Point(1069, 455);
            this.tbTotalResult.Name = "tbTotalResult";
            this.tbTotalResult.Size = new System.Drawing.Size(100, 20);
            this.tbTotalResult.TabIndex = 32;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Location = new System.Drawing.Point(1066, 439);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(58, 13);
            this.lblTotalResult.TabIndex = 33;
            this.lblTotalResult.Text = "Yhteistulos";
            // 
            // pnlReports
            // 
            this.pnlReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReports.Controls.Add(this.lblReports);
            this.pnlReports.Controls.Add(this.btnPrintRaceOrder);
            this.pnlReports.Controls.Add(this.btnClassReports);
            this.pnlReports.Location = new System.Drawing.Point(40, 337);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(156, 99);
            this.pnlReports.TabIndex = 34;
            // 
            // btnClassReports
            // 
            this.btnClassReports.Location = new System.Drawing.Point(20, 58);
            this.btnClassReports.Name = "btnClassReports";
            this.btnClassReports.Size = new System.Drawing.Size(116, 23);
            this.btnClassReports.TabIndex = 0;
            this.btnClassReports.Text = "Tulokset";
            this.btnClassReports.UseVisualStyleBackColor = true;
            this.btnClassReports.Click += new System.EventHandler(this.btnClassReports_Click);
            // 
            // btnPrintRaceOrder
            // 
            this.btnPrintRaceOrder.Location = new System.Drawing.Point(20, 29);
            this.btnPrintRaceOrder.Name = "btnPrintRaceOrder";
            this.btnPrintRaceOrder.Size = new System.Drawing.Size(116, 23);
            this.btnPrintRaceOrder.TabIndex = 1;
            this.btnPrintRaceOrder.Text = "Lähtölistat";
            this.btnPrintRaceOrder.UseVisualStyleBackColor = true;
            this.btnPrintRaceOrder.Click += new System.EventHandler(this.btnPrintRaceOrder_Click);
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(45, 11);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(66, 15);
            this.lblReports.TabIndex = 35;
            this.lblReports.Text = "Tulosteet";
            // 
            // Tapahtuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 561);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.tbTotalResult);
            this.Controls.Add(this.btnLoadLaps);
            this.Controls.Add(this.btnLoadParticipants);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.btnRemoveLap);
            this.Controls.Add(this.btnModifyLap);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.dgvLapTimes);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblOsallistujat);
            this.Controls.Add(this.dgvParticipancy);
            this.Controls.Add(this.dgLuokat);
            this.Controls.Add(this.btnLopeta);
            this.Controls.Add(this.lblTapahtuma);
            this.Controls.Add(this.panel1);
            this.Name = "Tapahtuma";
            this.Text = "Tapahtuma";
            this.Load += new System.EventHandler(this.Tapahtuma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLuokat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapTimes)).EndInit();
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPoistaLuokka;
        private System.Windows.Forms.Button btnPoistaOsallistuja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTapahtuma;
        private System.Windows.Forms.Button btnLopeta;
        private System.Windows.Forms.DataGridView dgLuokat;
        private System.Windows.Forms.DataGridView dgvParticipancy;
        private System.Windows.Forms.Label lblOsallistujat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvLapTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luokka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceID;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.Button btnModifyLap;
        private System.Windows.Forms.Button btnRemoveLap;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Button btnLoadParticipants;
        private System.Windows.Forms.Button btnLoadLaps;
        private System.Windows.Forms.TextBox tbTotalResult;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Button btnLapTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapType;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Button btnClassReports;
        private System.Windows.Forms.Button btnChangeRaceOrder;
        private System.Windows.Forms.Button btnPrintRaceOrder;
        private System.Windows.Forms.Label lblReports;
    }
}