namespace Aikalaskuri
{
    partial class Reports
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Location = new System.Drawing.Point(28, 43);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1232, 597);
            this.tabControl.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.lblDescription);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1224, 571);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Yhteenveto";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1185, 667);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(80, 33);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(271, 16);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Valitse luokka yläpuolelta välilehdistä";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 702);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblDescription;
    }
}