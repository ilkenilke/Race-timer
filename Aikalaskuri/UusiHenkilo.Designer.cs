namespace Aikalaskuri
{
    partial class UusiHenkilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UusiHenkilo));
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.lblEtunimi = new System.Windows.Forms.Label();
            this.lblSukunimi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSeura = new System.Windows.Forms.Label();
            this.cbKayttoehdot = new System.Windows.Forms.CheckBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbClub = new System.Windows.Forms.TextBox();
            this.lblKayttoehdot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(186, 392);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 7;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(267, 392);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(75, 23);
            this.btnPeruuta.TabIndex = 8;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(187, 68);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(155, 20);
            this.tbEtunimi.TabIndex = 1;
            // 
            // lblEtunimi
            // 
            this.lblEtunimi.AutoSize = true;
            this.lblEtunimi.Location = new System.Drawing.Point(88, 68);
            this.lblEtunimi.Name = "lblEtunimi";
            this.lblEtunimi.Size = new System.Drawing.Size(41, 13);
            this.lblEtunimi.TabIndex = 3;
            this.lblEtunimi.Text = "Etunimi";
            // 
            // lblSukunimi
            // 
            this.lblSukunimi.AutoSize = true;
            this.lblSukunimi.Location = new System.Drawing.Point(88, 102);
            this.lblSukunimi.Name = "lblSukunimi";
            this.lblSukunimi.Size = new System.Drawing.Size(50, 13);
            this.lblSukunimi.TabIndex = 4;
            this.lblSukunimi.Text = "Sukunimi";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(88, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Sähköposti";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(88, 162);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(67, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Paikkakunta";
            // 
            // lblSeura
            // 
            this.lblSeura.AutoSize = true;
            this.lblSeura.Location = new System.Drawing.Point(88, 195);
            this.lblSeura.Name = "lblSeura";
            this.lblSeura.Size = new System.Drawing.Size(35, 13);
            this.lblSeura.TabIndex = 7;
            this.lblSeura.Text = "Seura";
            // 
            // cbKayttoehdot
            // 
            this.cbKayttoehdot.AutoSize = true;
            this.cbKayttoehdot.Location = new System.Drawing.Point(94, 229);
            this.cbKayttoehdot.Name = "cbKayttoehdot";
            this.cbKayttoehdot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbKayttoehdot.Size = new System.Drawing.Size(132, 17);
            this.cbKayttoehdot.TabIndex = 6;
            this.cbKayttoehdot.Text = "Hyväksyn käyttöehdot";
            this.cbKayttoehdot.UseVisualStyleBackColor = true;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(187, 99);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(155, 20);
            this.tbSukunimi.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(187, 129);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(155, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(187, 162);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(155, 20);
            this.tbCity.TabIndex = 4;
            // 
            // tbClub
            // 
            this.tbClub.Location = new System.Drawing.Point(187, 192);
            this.tbClub.Name = "tbClub";
            this.tbClub.Size = new System.Drawing.Size(155, 20);
            this.tbClub.TabIndex = 5;
            // 
            // lblKayttoehdot
            // 
            this.lblKayttoehdot.AutoSize = true;
            this.lblKayttoehdot.Location = new System.Drawing.Point(29, 271);
            this.lblKayttoehdot.Name = "lblKayttoehdot";
            this.lblKayttoehdot.Size = new System.Drawing.Size(357, 91);
            this.lblKayttoehdot.TabIndex = 14;
            this.lblKayttoehdot.Text = resources.GetString("lblKayttoehdot.Text");
            // 
            // UusiHenkilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 447);
            this.Controls.Add(this.lblKayttoehdot);
            this.Controls.Add(this.tbClub);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.cbKayttoehdot);
            this.Controls.Add(this.lblSeura);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSukunimi);
            this.Controls.Add(this.lblEtunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnLisaa);
            this.Name = "UusiHenkilo";
            this.Text = "Uuden henkilön lisäys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label lblEtunimi;
        private System.Windows.Forms.Label lblSukunimi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSeura;
        private System.Windows.Forms.CheckBox cbKayttoehdot;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbClub;
        private System.Windows.Forms.Label lblKayttoehdot;
    }
}