namespace Aikalaskuri
{
    partial class UusiLuokka
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
            this.lblLuokanLisays = new System.Windows.Forms.Label();
            this.tbUusiLuokka = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.lblLuokanNimi = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.tbLuokanKuvaus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLuokanLisays
            // 
            this.lblLuokanLisays.AutoSize = true;
            this.lblLuokanLisays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLuokanLisays.Location = new System.Drawing.Point(163, 48);
            this.lblLuokanLisays.Name = "lblLuokanLisays";
            this.lblLuokanLisays.Size = new System.Drawing.Size(150, 20);
            this.lblLuokanLisays.TabIndex = 0;
            this.lblLuokanLisays.Text = "Uuden luokan lisäys";
            // 
            // tbUusiLuokka
            // 
            this.tbUusiLuokka.Location = new System.Drawing.Point(167, 94);
            this.tbUusiLuokka.Name = "tbUusiLuokka";
            this.tbUusiLuokka.Size = new System.Drawing.Size(297, 20);
            this.tbUusiLuokka.TabIndex = 1;
            this.tbUusiLuokka.TextChanged += new System.EventHandler(this.tbUusiLuokka_TextChanged);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(308, 179);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(75, 23);
            this.btnLisaa.TabIndex = 3;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(389, 179);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(75, 23);
            this.btnPeruuta.TabIndex = 4;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // lblLuokanNimi
            // 
            this.lblLuokanNimi.AutoSize = true;
            this.lblLuokanNimi.Location = new System.Drawing.Point(98, 97);
            this.lblLuokanNimi.Name = "lblLuokanNimi";
            this.lblLuokanNimi.Size = new System.Drawing.Size(63, 13);
            this.lblLuokanNimi.TabIndex = 4;
            this.lblLuokanNimi.Text = "Uusi luokka";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(118, 129);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lblKuvaus.TabIndex = 5;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // tbLuokanKuvaus
            // 
            this.tbLuokanKuvaus.Location = new System.Drawing.Point(168, 129);
            this.tbLuokanKuvaus.Name = "tbLuokanKuvaus";
            this.tbLuokanKuvaus.Size = new System.Drawing.Size(296, 20);
            this.tbLuokanKuvaus.TabIndex = 2;
            // 
            // UusiLuokka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 214);
            this.Controls.Add(this.tbLuokanKuvaus);
            this.Controls.Add(this.lblKuvaus);
            this.Controls.Add(this.lblLuokanNimi);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbUusiLuokka);
            this.Controls.Add(this.lblLuokanLisays);
            this.Name = "UusiLuokka";
            this.Text = "UusiLuokka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLuokanLisays;
        private System.Windows.Forms.TextBox tbUusiLuokka;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Label lblLuokanNimi;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.TextBox tbLuokanKuvaus;
    }
}