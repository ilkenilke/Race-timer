namespace Aikalaskuri
{
    partial class Henkilot
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
            this.lbListPersons = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemoveParti = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListPersons
            // 
            this.lbListPersons.FormattingEnabled = true;
            this.lbListPersons.Location = new System.Drawing.Point(41, 37);
            this.lbListPersons.Name = "lbListPersons";
            this.lbListPersons.Size = new System.Drawing.Size(248, 407);
            this.lbListPersons.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(295, 95);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Poista henkilö";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(295, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemoveParti
            // 
            this.btnRemoveParti.Location = new System.Drawing.Point(295, 66);
            this.btnRemoveParti.Name = "btnRemoveParti";
            this.btnRemoveParti.Size = new System.Drawing.Size(112, 23);
            this.btnRemoveParti.TabIndex = 2;
            this.btnRemoveParti.Text = "Osallistumiset";
            this.btnRemoveParti.UseVisualStyleBackColor = true;
            this.btnRemoveParti.Click += new System.EventHandler(this.btnRemoveParti_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(295, 37);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(112, 23);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.Text = "Lisää henkilö";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // Henkilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 458);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnRemoveParti);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbListPersons);
            this.Name = "Henkilot";
            this.Text = "ListaaHenkilot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListPersons;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemoveParti;
        private System.Windows.Forms.Button btnAddPerson;
    }
}