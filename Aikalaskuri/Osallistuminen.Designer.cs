namespace Aikalaskuri
{
    partial class Osallistuminen
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
            this.lblHnimi = new System.Windows.Forms.Label();
            this.lblValitseLuokka = new System.Windows.Forms.Label();
            this.tbVehicle = new System.Windows.Forms.TextBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.tbVehicle_info = new System.Windows.Forms.TextBox();
            this.tbVehicle_info1 = new System.Windows.Forms.TextBox();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbOsallistumiset = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHnimi
            // 
            this.lblHnimi.AutoSize = true;
            this.lblHnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHnimi.Location = new System.Drawing.Point(30, 60);
            this.lblHnimi.Name = "lblHnimi";
            this.lblHnimi.Size = new System.Drawing.Size(51, 20);
            this.lblHnimi.TabIndex = 0;
            this.lblHnimi.Text = "HNimi";
            // 
            // lblValitseLuokka
            // 
            this.lblValitseLuokka.AutoSize = true;
            this.lblValitseLuokka.Location = new System.Drawing.Point(41, 103);
            this.lblValitseLuokka.Name = "lblValitseLuokka";
            this.lblValitseLuokka.Size = new System.Drawing.Size(73, 13);
            this.lblValitseLuokka.TabIndex = 2;
            this.lblValitseLuokka.Text = "Valitse luokka";
            // 
            // tbVehicle
            // 
            this.tbVehicle.Location = new System.Drawing.Point(167, 138);
            this.tbVehicle.Name = "tbVehicle";
            this.tbVehicle.Size = new System.Drawing.Size(300, 20);
            this.tbVehicle.TabIndex = 2;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(41, 141);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(106, 13);
            this.lblDevice.TabIndex = 4;
            this.lblDevice.Text = "Anna ajoneuvon nimi";
            // 
            // tbVehicle_info
            // 
            this.tbVehicle_info.Location = new System.Drawing.Point(167, 175);
            this.tbVehicle_info.Name = "tbVehicle_info";
            this.tbVehicle_info.Size = new System.Drawing.Size(300, 20);
            this.tbVehicle_info.TabIndex = 3;
            // 
            // tbVehicle_info1
            // 
            this.tbVehicle_info1.Location = new System.Drawing.Point(167, 211);
            this.tbVehicle_info1.Name = "tbVehicle_info1";
            this.tbVehicle_info1.Size = new System.Drawing.Size(300, 20);
            this.tbVehicle_info1.TabIndex = 4;
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.AutoSize = true;
            this.lblVehicleInfo.Location = new System.Drawing.Point(41, 182);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Size = new System.Drawing.Size(102, 13);
            this.lblVehicleInfo.TabIndex = 7;
            this.lblVehicleInfo.Text = "Ajoneuvon lisätiedot";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(848, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 24);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Lisää luokka >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbOsallistumiset
            // 
            this.lbOsallistumiset.FormattingEnabled = true;
            this.lbOsallistumiset.Location = new System.Drawing.Point(490, 133);
            this.lbOsallistumiset.Name = "lbOsallistumiset";
            this.lbOsallistumiset.Size = new System.Drawing.Size(300, 147);
            this.lbOsallistumiset.TabIndex = 6;
            this.lbOsallistumiset.SelectedIndexChanged += new System.EventHandler(this.lbOsallistumiset_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tässä näet henkilön kaikki osallistumiset";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(167, 100);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(300, 21);
            this.cbClass.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(807, 135);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 25);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Poista osallistuminen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Osallistuminen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 314);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOsallistumiset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVehicleInfo);
            this.Controls.Add(this.tbVehicle_info1);
            this.Controls.Add(this.tbVehicle_info);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.tbVehicle);
            this.Controls.Add(this.lblValitseLuokka);
            this.Controls.Add(this.lblHnimi);
            this.Name = "Osallistuminen";
            this.Text = "Osallistuminen";
            this.Load += new System.EventHandler(this.Osallistuminen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHnimi;
        private System.Windows.Forms.Label lblValitseLuokka;
        private System.Windows.Forms.TextBox tbVehicle;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.TextBox tbVehicle_info;
        private System.Windows.Forms.TextBox tbVehicle_info1;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbOsallistumiset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnRemove;
    }
}