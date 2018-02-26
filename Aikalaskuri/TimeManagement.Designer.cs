namespace Aikalaskuri
{
    partial class TimeManagement
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
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMilliseconds = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbLapType = new System.Windows.Forms.ComboBox();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.tbSeconds = new System.Windows.Forms.TextBox();
            this.tbMilliseconds = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(154, 88);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "Minuutit";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(230, 88);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "Sekunnit";
            // 
            // lblMilliseconds
            // 
            this.lblMilliseconds.AutoSize = true;
            this.lblMilliseconds.Location = new System.Drawing.Point(306, 88);
            this.lblMilliseconds.Name = "lblMilliseconds";
            this.lblMilliseconds.Size = new System.Drawing.Size(57, 13);
            this.lblMilliseconds.TabIndex = 5;
            this.lblMilliseconds.Text = "Sadasosat";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(26, 18);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(0, 20);
            this.lblPerson.TabIndex = 6;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(27, 50);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(0, 13);
            this.lblDevice.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Lisää";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Peruuta";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbLapType
            // 
            this.cbLapType.FormattingEnabled = true;
            this.cbLapType.Location = new System.Drawing.Point(154, 145);
            this.cbLapType.Name = "cbLapType";
            this.cbLapType.Size = new System.Drawing.Size(139, 21);
            this.cbLapType.TabIndex = 4;
            this.cbLapType.SelectedIndexChanged += new System.EventHandler(this.cbLapType_SelectedIndexChanged);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(151, 129);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(87, 13);
            this.lblEventType.TabIndex = 11;
            this.lblEventType.Text = "Kierroksen tyyppi";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 91);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Valitse kierroksen tyyppi\r\nja anna kierrosajat\r\n\r\nesim. minuutit = 1\r\nsekunnit = " +
    "8\r\nmillisekunnit = 9\r\nYhteensä: 1.08.90";
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(154, 65);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(70, 20);
            this.tbMinutes.TabIndex = 1;
            // 
            // tbSeconds
            // 
            this.tbSeconds.Location = new System.Drawing.Point(230, 65);
            this.tbSeconds.Name = "tbSeconds";
            this.tbSeconds.Size = new System.Drawing.Size(70, 20);
            this.tbSeconds.TabIndex = 2;
            // 
            // tbMilliseconds
            // 
            this.tbMilliseconds.Location = new System.Drawing.Point(309, 65);
            this.tbMilliseconds.Name = "tbMilliseconds";
            this.tbMilliseconds.Size = new System.Drawing.Size(67, 20);
            this.tbMilliseconds.TabIndex = 3;
            // 
            // TimeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 227);
            this.Controls.Add(this.tbMilliseconds);
            this.Controls.Add(this.tbSeconds);
            this.Controls.Add(this.tbMinutes);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.cbLapType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblMilliseconds);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Name = "TimeManagement";
            this.Text = "Ajan syöttö";
            this.Load += new System.EventHandler(this.TimeManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMilliseconds;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbLapType;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.TextBox tbMilliseconds;
    }
}