namespace GUI
{
    partial class BuchungszeileDetail
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
            this.tbBankkonto = new System.Windows.Forms.TextBox();
            this.tbUSt = new System.Windows.Forms.TextBox();
            this.lvKategorien = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbKategorien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRechnungssumme = new System.Windows.Forms.TextBox();
            this.btnNewKat = new System.Windows.Forms.Button();
            this.btnDelKat = new System.Windows.Forms.Button();
            this.tbKategorie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbBankkonto
            // 
            this.tbBankkonto.Location = new System.Drawing.Point(127, 14);
            this.tbBankkonto.Name = "tbBankkonto";
            this.tbBankkonto.Size = new System.Drawing.Size(283, 20);
            this.tbBankkonto.TabIndex = 0;
            // 
            // tbUSt
            // 
            this.tbUSt.Location = new System.Drawing.Point(127, 67);
            this.tbUSt.Name = "tbUSt";
            this.tbUSt.Size = new System.Drawing.Size(283, 20);
            this.tbUSt.TabIndex = 2;
            // 
            // lvKategorien
            // 
            this.lvKategorien.Location = new System.Drawing.Point(12, 126);
            this.lvKategorien.Name = "lvKategorien";
            this.lvKategorien.Size = new System.Drawing.Size(398, 128);
            this.lvKategorien.TabIndex = 7;
            this.lvKategorien.UseCompatibleStateImageBehavior = false;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(254, 373);
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
            this.btnCancel.Location = new System.Drawing.Point(335, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bankkonto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "USt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kategorien:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(254, 260);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "Hinzufügen";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(335, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Entfernen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbKategorien
            // 
            this.cbKategorien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorien.FormattingEnabled = true;
            this.cbKategorien.Location = new System.Drawing.Point(15, 260);
            this.cbKategorien.Name = "cbKategorien";
            this.cbKategorien.Size = new System.Drawing.Size(233, 21);
            this.cbKategorien.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Rechnungssumme:";
            // 
            // tbRechnungssumme
            // 
            this.tbRechnungssumme.Location = new System.Drawing.Point(127, 40);
            this.tbRechnungssumme.Name = "tbRechnungssumme";
            this.tbRechnungssumme.Size = new System.Drawing.Size(283, 20);
            this.tbRechnungssumme.TabIndex = 1;
            // 
            // btnNewKat
            // 
            this.btnNewKat.Location = new System.Drawing.Point(173, 284);
            this.btnNewKat.Name = "btnNewKat";
            this.btnNewKat.Size = new System.Drawing.Size(75, 23);
            this.btnNewKat.TabIndex = 23;
            this.btnNewKat.Text = "Neu";
            this.btnNewKat.UseVisualStyleBackColor = true;
            this.btnNewKat.Click += new System.EventHandler(this.btnNewKat_Click);
            // 
            // btnDelKat
            // 
            this.btnDelKat.Location = new System.Drawing.Point(173, 313);
            this.btnDelKat.Name = "btnDelKat";
            this.btnDelKat.Size = new System.Drawing.Size(75, 23);
            this.btnDelKat.TabIndex = 24;
            this.btnDelKat.Text = "Löschen";
            this.btnDelKat.UseVisualStyleBackColor = true;
            this.btnDelKat.Click += new System.EventHandler(this.btnDelKat_Click);
            // 
            // tbKategorie
            // 
            this.tbKategorie.Location = new System.Drawing.Point(12, 287);
            this.tbKategorie.Name = "tbKategorie";
            this.tbKategorie.Size = new System.Drawing.Size(155, 20);
            this.tbKategorie.TabIndex = 25;
            // 
            // BuchungszeileDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 408);
            this.Controls.Add(this.tbKategorie);
            this.Controls.Add(this.btnDelKat);
            this.Controls.Add(this.btnNewKat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRechnungssumme);
            this.Controls.Add(this.cbKategorien);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvKategorien);
            this.Controls.Add(this.tbUSt);
            this.Controls.Add(this.tbBankkonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BuchungszeileDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuchungszeileDetail";
            this.Load += new System.EventHandler(this.BuchungszeileDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBankkonto;
        private System.Windows.Forms.TextBox tbUSt;
        private System.Windows.Forms.ListView lvKategorien;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbKategorien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRechnungssumme;
        private System.Windows.Forms.Button btnNewKat;
        private System.Windows.Forms.Button btnDelKat;
        private System.Windows.Forms.TextBox tbKategorie;
    }
}