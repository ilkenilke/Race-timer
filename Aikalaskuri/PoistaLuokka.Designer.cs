namespace Aikalaskuri
{
    partial class PoistaLuokka
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
            this.lbPoistettavat = new System.Windows.Forms.ListBox();
            this.lblPoisto = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnAddNewClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPoistettavat
            // 
            this.lbPoistettavat.FormattingEnabled = true;
            this.lbPoistettavat.Location = new System.Drawing.Point(58, 56);
            this.lbPoistettavat.Name = "lbPoistettavat";
            this.lbPoistettavat.Size = new System.Drawing.Size(227, 147);
            this.lbPoistettavat.TabIndex = 1;
            // 
            // lblPoisto
            // 
            this.lblPoisto.AutoSize = true;
            this.lblPoisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPoisto.Location = new System.Drawing.Point(54, 21);
            this.lblPoisto.Name = "lblPoisto";
            this.lblPoisto.Size = new System.Drawing.Size(152, 20);
            this.lblPoisto.TabIndex = 1;
            this.lblPoisto.Text = "Luokan poistaminen";
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(291, 85);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(89, 23);
            this.btnPoista.TabIndex = 2;
            this.btnPoista.Text = "Poista luokka";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(291, 180);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(89, 23);
            this.btnPeruuta.TabIndex = 3;
            this.btnPeruuta.Text = "Sulje";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnAddNewClass
            // 
            this.btnAddNewClass.Location = new System.Drawing.Point(291, 56);
            this.btnAddNewClass.Name = "btnAddNewClass";
            this.btnAddNewClass.Size = new System.Drawing.Size(89, 23);
            this.btnAddNewClass.TabIndex = 4;
            this.btnAddNewClass.Text = "Uusi luokka";
            this.btnAddNewClass.UseVisualStyleBackColor = true;
            this.btnAddNewClass.Click += new System.EventHandler(this.btnAddNewClass_Click);
            // 
            // PoistaLuokka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 250);
            this.Controls.Add(this.btnAddNewClass);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.lblPoisto);
            this.Controls.Add(this.lbPoistettavat);
            this.Name = "PoistaLuokka";
            this.Text = "PoistaLuokka";
            this.Load += new System.EventHandler(this.PoistaLuokka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPoistettavat;
        private System.Windows.Forms.Label lblPoisto;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnAddNewClass;
    }
}