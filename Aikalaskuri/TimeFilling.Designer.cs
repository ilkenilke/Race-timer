namespace Aikalaskuri
{
    partial class TimeFilling
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
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.tbTotalResult = new System.Windows.Forms.TextBox();
            this.btnRemoveLap = new System.Windows.Forms.Button();
            this.btnModifyLap = new System.Windows.Forms.Button();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.dgvLapTimes = new System.Windows.Forms.DataGridView();
            this.LapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LapType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Location = new System.Drawing.Point(247, 345);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(58, 13);
            this.lblTotalResult.TabIndex = 39;
            this.lblTotalResult.Text = "Yhteistulos";
            // 
            // tbTotalResult
            // 
            this.tbTotalResult.Location = new System.Drawing.Point(250, 361);
            this.tbTotalResult.Name = "tbTotalResult";
            this.tbTotalResult.Size = new System.Drawing.Size(100, 20);
            this.tbTotalResult.TabIndex = 38;
            // 
            // btnRemoveLap
            // 
            this.btnRemoveLap.Location = new System.Drawing.Point(394, 387);
            this.btnRemoveLap.Name = "btnRemoveLap";
            this.btnRemoveLap.Size = new System.Drawing.Size(125, 23);
            this.btnRemoveLap.TabIndex = 37;
            this.btnRemoveLap.Text = "Poista kierrosaika";
            this.btnRemoveLap.UseVisualStyleBackColor = true;
            // 
            // btnModifyLap
            // 
            this.btnModifyLap.Location = new System.Drawing.Point(493, 358);
            this.btnModifyLap.Name = "btnModifyLap";
            this.btnModifyLap.Size = new System.Drawing.Size(130, 23);
            this.btnModifyLap.TabIndex = 36;
            this.btnModifyLap.Text = "Muokkaa kierrosaikaa";
            this.btnModifyLap.UseVisualStyleBackColor = true;
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(394, 358);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(98, 23);
            this.btnAddTime.TabIndex = 35;
            this.btnAddTime.Text = "Lisää kierrosaika";
            this.btnAddTime.UseVisualStyleBackColor = true;
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
            this.dgvLapTimes.Location = new System.Drawing.Point(88, 116);
            this.dgvLapTimes.Name = "dgvLapTimes";
            this.dgvLapTimes.ReadOnly = true;
            this.dgvLapTimes.Size = new System.Drawing.Size(535, 211);
            this.dgvLapTimes.TabIndex = 34;
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(525, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 23);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(99, 65);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(0, 13);
            this.lblDeviceName.TabIndex = 42;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(85, 46);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(0, 15);
            this.lblPerson.TabIndex = 41;
            // 
            // TimeFilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 456);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.tbTotalResult);
            this.Controls.Add(this.btnRemoveLap);
            this.Controls.Add(this.btnModifyLap);
            this.Controls.Add(this.btnAddTime);
            this.Controls.Add(this.dgvLapTimes);
            this.Name = "TimeFilling";
            this.Text = "TimeFilling";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.TextBox tbTotalResult;
        private System.Windows.Forms.Button btnRemoveLap;
        private System.Windows.Forms.Button btnModifyLap;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.DataGridView dgvLapTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LapType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblPerson;
    }
}