namespace Aikalaskuri
{
    partial class TapahtumanValitsin
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
            this.lstTapahtumat = new System.Windows.Forms.ListBox();
            this.btnLopeta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUusi = new System.Windows.Forms.Button();
            this.btnValitse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uusiTapahtuma = new System.Windows.Forms.TextBox();
            this.tapahtumanPaiva = new System.Windows.Forms.DateTimePicker();
            this.btnPoista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTapahtumat
            // 
            this.lstTapahtumat.FormattingEnabled = true;
            this.lstTapahtumat.Location = new System.Drawing.Point(81, 214);
            this.lstTapahtumat.Name = "lstTapahtumat";
            this.lstTapahtumat.Size = new System.Drawing.Size(404, 199);
            this.lstTapahtumat.TabIndex = 4;
            this.lstTapahtumat.SelectedIndexChanged += new System.EventHandler(this.lstTapahtumat_SelectedIndexChanged);
            // 
            // btnLopeta
            // 
            this.btnLopeta.Location = new System.Drawing.Point(494, 390);
            this.btnLopeta.Name = "btnLopeta";
            this.btnLopeta.Size = new System.Drawing.Size(93, 23);
            this.btnLopeta.TabIndex = 7;
            this.btnLopeta.Text = "Lopeta";
            this.btnLopeta.UseVisualStyleBackColor = true;
            this.btnLopeta.Click += new System.EventHandler(this.btnLopeta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aikatimmi";
            // 
            // btnUusi
            // 
            this.btnUusi.Location = new System.Drawing.Point(494, 96);
            this.btnUusi.Name = "btnUusi";
            this.btnUusi.Size = new System.Drawing.Size(93, 23);
            this.btnUusi.TabIndex = 3;
            this.btnUusi.Text = "Lisää uusi";
            this.btnUusi.UseVisualStyleBackColor = true;
            this.btnUusi.Click += new System.EventHandler(this.btnUusi_Click);
            // 
            // btnValitse
            // 
            this.btnValitse.Location = new System.Drawing.Point(494, 214);
            this.btnValitse.Name = "btnValitse";
            this.btnValitse.Size = new System.Drawing.Size(93, 23);
            this.btnValitse.TabIndex = 5;
            this.btnValitse.Text = "Valitse";
            this.btnValitse.UseVisualStyleBackColor = true;
            this.btnValitse.Click += new System.EventHandler(this.btnValitse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lisää uusi tapahtuma";
            // 
            // uusiTapahtuma
            // 
            this.uusiTapahtuma.Location = new System.Drawing.Point(80, 96);
            this.uusiTapahtuma.Name = "uusiTapahtuma";
            this.uusiTapahtuma.Size = new System.Drawing.Size(403, 20);
            this.uusiTapahtuma.TabIndex = 1;
            this.uusiTapahtuma.TextChanged += new System.EventHandler(this.uusiTapahtuma_TextChanged);
            // 
            // tapahtumanPaiva
            // 
            this.tapahtumanPaiva.Location = new System.Drawing.Point(80, 123);
            this.tapahtumanPaiva.Name = "tapahtumanPaiva";
            this.tapahtumanPaiva.Size = new System.Drawing.Size(190, 20);
            this.tapahtumanPaiva.TabIndex = 2;
            this.tapahtumanPaiva.Value = new System.DateTime(2017, 3, 15, 0, 0, 0, 0);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(494, 361);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(93, 23);
            this.btnPoista.TabIndex = 6;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yläosassa voit luoda uuden tapahtuman\r\n\r\nAlaosassa taas voit hallinnoida valmiita" +
    " tapahtumia";
            // 
            // TapahtumanValitsin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 468);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.tapahtumanPaiva);
            this.Controls.Add(this.uusiTapahtuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValitse);
            this.Controls.Add(this.btnUusi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLopeta);
            this.Controls.Add(this.lstTapahtumat);
            this.Name = "TapahtumanValitsin";
            this.Text = "Tapahtumat";
            this.Load += new System.EventHandler(this.TapahtumanValitsin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTapahtumat;
        private System.Windows.Forms.Button btnLopeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUusi;
        private System.Windows.Forms.Button btnValitse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uusiTapahtuma;
        private System.Windows.Forms.DateTimePicker tapahtumanPaiva;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Label label3;
    }
}

