namespace GUI
{
    partial class AngebotDetail
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblChance = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbChance = new System.Windows.Forms.TextBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDuration, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblChance, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSum, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbDuration, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbChance, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbSum, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbProject, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCustomer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 233);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(18, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Datum:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProject.Location = new System.Drawing.Point(18, 38);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(93, 23);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Projekt:";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Location = new System.Drawing.Point(18, 61);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(93, 23);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Kunde:";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuration.Location = new System.Drawing.Point(18, 84);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(93, 23);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Dauer:";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChance
            // 
            this.lblChance.AutoSize = true;
            this.lblChance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChance.Location = new System.Drawing.Point(18, 107);
            this.lblChance.Name = "lblChance";
            this.lblChance.Size = new System.Drawing.Size(93, 23);
            this.lblChance.TabIndex = 4;
            this.lblChance.Text = "Chance:";
            this.lblChance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSum.Location = new System.Drawing.Point(18, 130);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(93, 23);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "Summe:";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yyyy";
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(117, 18);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(293, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // tbDuration
            // 
            this.tbDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDuration.Location = new System.Drawing.Point(117, 87);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(293, 20);
            this.tbDuration.TabIndex = 3;
            // 
            // tbChance
            // 
            this.tbChance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChance.Location = new System.Drawing.Point(117, 110);
            this.tbChance.Name = "tbChance";
            this.tbChance.Size = new System.Drawing.Size(293, 20);
            this.tbChance.TabIndex = 4;
            // 
            // tbSum
            // 
            this.tbSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSum.Location = new System.Drawing.Point(117, 133);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(293, 20);
            this.tbSum.TabIndex = 5;
            // 
            // cbProject
            // 
            this.cbProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(117, 41);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(293, 21);
            this.cbProject.TabIndex = 1;
            // 
            // cbCustomer
            // 
            this.cbCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(117, 64);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(293, 21);
            this.cbCustomer.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 195);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 23);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(319, 1);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 21);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(160, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 21);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // AngebotDetail
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(428, 233);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AngebotDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neues Angebot anlegen";
            this.Load += new System.EventHandler(this.AngebotDetail_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblChance;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbChance;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnSave;
    }
}