namespace Aikalaskuri
{
    partial class LapTypeManagement
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
            this.lbLapTypes = new System.Windows.Forms.ListBox();
            this.btnAddLapType = new System.Windows.Forms.Button();
            this.tbNewType = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lbltbDescription = new System.Windows.Forms.Label();
            this.lblRaceTypesDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLapTypes
            // 
            this.lbLapTypes.FormattingEnabled = true;
            this.lbLapTypes.Location = new System.Drawing.Point(324, 96);
            this.lbLapTypes.Name = "lbLapTypes";
            this.lbLapTypes.Size = new System.Drawing.Size(170, 199);
            this.lbLapTypes.TabIndex = 0;
            // 
            // btnAddLapType
            // 
            this.btnAddLapType.Location = new System.Drawing.Point(228, 96);
            this.btnAddLapType.Name = "btnAddLapType";
            this.btnAddLapType.Size = new System.Drawing.Size(75, 20);
            this.btnAddLapType.TabIndex = 1;
            this.btnAddLapType.Text = "Lisää >>";
            this.btnAddLapType.UseVisualStyleBackColor = true;
            this.btnAddLapType.Click += new System.EventHandler(this.btnAddLapType_Click);
            // 
            // tbNewType
            // 
            this.tbNewType.Location = new System.Drawing.Point(52, 96);
            this.tbNewType.Name = "tbNewType";
            this.tbNewType.Size = new System.Drawing.Size(170, 20);
            this.tbNewType.TabIndex = 2;
            this.tbNewType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(500, 96);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Poista";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(500, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Sulje";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(49, 30);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(185, 39);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Tapahtuman kierrostyypit\r\n\r\nArvoja esim. kierros ja kiihdytys";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lbltbDescription
            // 
            this.lbltbDescription.AutoSize = true;
            this.lbltbDescription.Location = new System.Drawing.Point(49, 119);
            this.lbltbDescription.Name = "lbltbDescription";
            this.lbltbDescription.Size = new System.Drawing.Size(86, 39);
            this.lbltbDescription.TabIndex = 6;
            this.lbltbDescription.Text = "Syötä uusi tyyppi\r\ntai \r\npoista vanha";
            // 
            // lblRaceTypesDesc
            // 
            this.lblRaceTypesDesc.AutoSize = true;
            this.lblRaceTypesDesc.Location = new System.Drawing.Point(324, 77);
            this.lblRaceTypesDesc.Name = "lblRaceTypesDesc";
            this.lblRaceTypesDesc.Size = new System.Drawing.Size(82, 13);
            this.lblRaceTypesDesc.TabIndex = 7;
            this.lblRaceTypesDesc.Text = "Kaikki kisatyypit";
            // 
            // LapTypeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 304);
            this.Controls.Add(this.lblRaceTypesDesc);
            this.Controls.Add(this.lbltbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbNewType);
            this.Controls.Add(this.btnAddLapType);
            this.Controls.Add(this.lbLapTypes);
            this.Name = "LapTypeManagement";
            this.Text = "LapTypeManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLapTypes;
        private System.Windows.Forms.Button btnAddLapType;
        private System.Windows.Forms.TextBox tbNewType;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lbltbDescription;
        private System.Windows.Forms.Label lblRaceTypesDesc;
    }
}