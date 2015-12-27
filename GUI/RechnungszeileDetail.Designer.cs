namespace GUI
{
    partial class RechnungszeileDetail
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbBezeichnung = new System.Windows.Forms.TextBox();
            this.tbBetrag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAngebote = new System.Windows.Forms.ComboBox();
            this.cbAusgangsrechnungen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(331, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(250, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbBezeichnung
            // 
            this.tbBezeichnung.Location = new System.Drawing.Point(112, 12);
            this.tbBezeichnung.Name = "tbBezeichnung";
            this.tbBezeichnung.Size = new System.Drawing.Size(294, 20);
            this.tbBezeichnung.TabIndex = 0;
            // 
            // tbBetrag
            // 
            this.tbBetrag.Location = new System.Drawing.Point(112, 38);
            this.tbBetrag.Name = "tbBetrag";
            this.tbBetrag.Size = new System.Drawing.Size(294, 20);
            this.tbBetrag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bezeichnung:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Betrag:";
            // 
            // cbAngebote
            // 
            this.cbAngebote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAngebote.FormattingEnabled = true;
            this.cbAngebote.Location = new System.Drawing.Point(112, 64);
            this.cbAngebote.Name = "cbAngebote";
            this.cbAngebote.Size = new System.Drawing.Size(294, 21);
            this.cbAngebote.TabIndex = 2;
            // 
            // cbAusgangsrechnungen
            // 
            this.cbAusgangsrechnungen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAusgangsrechnungen.FormattingEnabled = true;
            this.cbAusgangsrechnungen.Location = new System.Drawing.Point(112, 91);
            this.cbAusgangsrechnungen.Name = "cbAusgangsrechnungen";
            this.cbAusgangsrechnungen.Size = new System.Drawing.Size(294, 21);
            this.cbAusgangsrechnungen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ausgangsrechnung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Angebot:";
            // 
            // RechnungszeileDetail
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(418, 180);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAusgangsrechnungen);
            this.Controls.Add(this.cbAngebote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBetrag);
            this.Controls.Add(this.tbBezeichnung);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RechnungszeileDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RechnungszeileDetail";
            this.Load += new System.EventHandler(this.RechnungszeileDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbBezeichnung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBetrag;
        private System.Windows.Forms.ComboBox cbAngebote;
        private System.Windows.Forms.ComboBox cbAusgangsrechnungen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}