namespace GUI
{
    partial class AusgangsrechnungDetail
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
            this.tbSumme = new System.Windows.Forms.TextBox();
            this.tbBeschreibung = new System.Windows.Forms.TextBox();
            this.chkbGedruckt = new System.Windows.Forms.CheckBox();
            this.chkbOffen = new System.Windows.Forms.CheckBox();
            this.cbProjekte = new System.Windows.Forms.ComboBox();
            this.cbKunden = new System.Windows.Forms.ComboBox();
            this.lvBuchungszeilen = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbBuchungszeilen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbSumme
            // 
            this.tbSumme.Location = new System.Drawing.Point(127, 14);
            this.tbSumme.Name = "tbSumme";
            this.tbSumme.Size = new System.Drawing.Size(283, 20);
            this.tbSumme.TabIndex = 0;
            // 
            // tbBeschreibung
            // 
            this.tbBeschreibung.Location = new System.Drawing.Point(127, 67);
            this.tbBeschreibung.Name = "tbBeschreibung";
            this.tbBeschreibung.Size = new System.Drawing.Size(283, 20);
            this.tbBeschreibung.TabIndex = 2;
            // 
            // chkbGedruckt
            // 
            this.chkbGedruckt.AutoSize = true;
            this.chkbGedruckt.Location = new System.Drawing.Point(165, 95);
            this.chkbGedruckt.Name = "chkbGedruckt";
            this.chkbGedruckt.Size = new System.Drawing.Size(70, 17);
            this.chkbGedruckt.TabIndex = 3;
            this.chkbGedruckt.Text = "Gedruckt";
            this.chkbGedruckt.UseVisualStyleBackColor = true;
            // 
            // chkbOffen
            // 
            this.chkbOffen.AutoSize = true;
            this.chkbOffen.Location = new System.Drawing.Point(286, 95);
            this.chkbOffen.Name = "chkbOffen";
            this.chkbOffen.Size = new System.Drawing.Size(52, 17);
            this.chkbOffen.TabIndex = 4;
            this.chkbOffen.Text = "Offen";
            this.chkbOffen.UseVisualStyleBackColor = true;
            // 
            // cbProjekte
            // 
            this.cbProjekte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjekte.FormattingEnabled = true;
            this.cbProjekte.Location = new System.Drawing.Point(127, 118);
            this.cbProjekte.Name = "cbProjekte";
            this.cbProjekte.Size = new System.Drawing.Size(283, 21);
            this.cbProjekte.TabIndex = 5;
            // 
            // cbKunden
            // 
            this.cbKunden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKunden.FormattingEnabled = true;
            this.cbKunden.Location = new System.Drawing.Point(127, 145);
            this.cbKunden.Name = "cbKunden";
            this.cbKunden.Size = new System.Drawing.Size(283, 21);
            this.cbKunden.TabIndex = 6;
            // 
            // lvBuchungszeilen
            // 
            this.lvBuchungszeilen.Location = new System.Drawing.Point(12, 212);
            this.lvBuchungszeilen.Name = "lvBuchungszeilen";
            this.lvBuchungszeilen.Size = new System.Drawing.Size(398, 186);
            this.lvBuchungszeilen.TabIndex = 7;
            this.lvBuchungszeilen.UseCompatibleStateImageBehavior = false;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(254, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(335, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(127, 41);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(283, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Summe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Beschreibung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kunde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Projekt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Buchungszeilen:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(254, 404);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "Hinzufügen";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(335, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbBuchungszeilen
            // 
            this.cbBuchungszeilen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuchungszeilen.FormattingEnabled = true;
            this.cbBuchungszeilen.Location = new System.Drawing.Point(15, 404);
            this.cbBuchungszeilen.Name = "cbBuchungszeilen";
            this.cbBuchungszeilen.Size = new System.Drawing.Size(233, 21);
            this.cbBuchungszeilen.TabIndex = 16;
            // 
            // AusgangsrechnungDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 502);
            this.Controls.Add(this.cbBuchungszeilen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvBuchungszeilen);
            this.Controls.Add(this.cbKunden);
            this.Controls.Add(this.cbProjekte);
            this.Controls.Add(this.chkbOffen);
            this.Controls.Add(this.chkbGedruckt);
            this.Controls.Add(this.tbBeschreibung);
            this.Controls.Add(this.tbSumme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AusgangsrechnungDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AusgangsrechnungDetail";
            this.Load += new System.EventHandler(this.AusgangsrechnungDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSumme;
        private System.Windows.Forms.TextBox tbBeschreibung;
        private System.Windows.Forms.CheckBox chkbGedruckt;
        private System.Windows.Forms.CheckBox chkbOffen;
        private System.Windows.Forms.ComboBox cbProjekte;
        private System.Windows.Forms.ComboBox cbKunden;
        private System.Windows.Forms.ListView lvBuchungszeilen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbBuchungszeilen;
    }
}