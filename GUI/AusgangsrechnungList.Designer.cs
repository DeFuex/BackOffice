namespace GUI
{
    partial class AusgangsrechnungList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAusgangsrechnungenEdit = new System.Windows.Forms.Button();
            this.btAusgangsrechnungenDelete = new System.Windows.Forms.Button();
            this.btAusgangsrechnungenAdd = new System.Windows.Forms.Button();
            this.lvAusgangsrechnungen = new System.Windows.Forms.ListView();
            this.tbAusgangsrechnungen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAusgangsrechnungenEdit
            // 
            this.btAusgangsrechnungenEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAusgangsrechnungenEdit.Location = new System.Drawing.Point(430, 335);
            this.btAusgangsrechnungenEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btAusgangsrechnungenEdit.Name = "btAusgangsrechnungenEdit";
            this.btAusgangsrechnungenEdit.Size = new System.Drawing.Size(78, 21);
            this.btAusgangsrechnungenEdit.TabIndex = 12;
            this.btAusgangsrechnungenEdit.Text = "Bearbeiten";
            this.btAusgangsrechnungenEdit.UseVisualStyleBackColor = true;
            this.btAusgangsrechnungenEdit.Click += new System.EventHandler(this.btAusgangsrechnungenEdit_Click);
            // 
            // btAusgangsrechnungenDelete
            // 
            this.btAusgangsrechnungenDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAusgangsrechnungenDelete.Location = new System.Drawing.Point(510, 335);
            this.btAusgangsrechnungenDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btAusgangsrechnungenDelete.Name = "btAusgangsrechnungenDelete";
            this.btAusgangsrechnungenDelete.Size = new System.Drawing.Size(78, 21);
            this.btAusgangsrechnungenDelete.TabIndex = 13;
            this.btAusgangsrechnungenDelete.Text = "Löschen";
            this.btAusgangsrechnungenDelete.UseVisualStyleBackColor = true;
            this.btAusgangsrechnungenDelete.Click += new System.EventHandler(this.btAusgangsrechnungenDelete_Click);
            // 
            // btAusgangsrechnungenAdd
            // 
            this.btAusgangsrechnungenAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAusgangsrechnungenAdd.Location = new System.Drawing.Point(1, 335);
            this.btAusgangsrechnungenAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btAusgangsrechnungenAdd.Name = "btAusgangsrechnungenAdd";
            this.btAusgangsrechnungenAdd.Size = new System.Drawing.Size(78, 21);
            this.btAusgangsrechnungenAdd.TabIndex = 15;
            this.btAusgangsrechnungenAdd.Text = "Hinzufügen";
            this.btAusgangsrechnungenAdd.UseVisualStyleBackColor = true;
            this.btAusgangsrechnungenAdd.Click += new System.EventHandler(this.btAusgangsrechnungenAdd_Click);
            // 
            // lvAusgangsrechnungen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lvAusgangsrechnungen, 4);
            this.lvAusgangsrechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAusgangsrechnungen.FullRowSelect = true;
            this.lvAusgangsrechnungen.Location = new System.Drawing.Point(3, 26);
            this.lvAusgangsrechnungen.MultiSelect = false;
            this.lvAusgangsrechnungen.Name = "lvAusgangsrechnungen";
            this.lvAusgangsrechnungen.Size = new System.Drawing.Size(583, 305);
            this.lvAusgangsrechnungen.TabIndex = 14;
            this.lvAusgangsrechnungen.UseCompatibleStateImageBehavior = false;
            this.lvAusgangsrechnungen.View = System.Windows.Forms.View.Details;
            this.lvAusgangsrechnungen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvAusgangsrechnungen_KeyDown);
            this.lvAusgangsrechnungen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAusgangsrechnungen_MouseDoubleClick);
            // 
            // tbAusgangsrechnungen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbAusgangsrechnungen, 3);
            this.tbAusgangsrechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAusgangsrechnungen.Location = new System.Drawing.Point(83, 3);
            this.tbAusgangsrechnungen.Name = "tbAusgangsrechnungen";
            this.tbAusgangsrechnungen.Size = new System.Drawing.Size(503, 20);
            this.tbAusgangsrechnungen.TabIndex = 11;
            this.tbAusgangsrechnungen.TextChanged += new System.EventHandler(this.tbAusgangsrechnungen_TextChanged);
            this.tbAusgangsrechnungen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAusgangsrechnungen_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Suchen:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.lvAusgangsrechnungen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btAusgangsrechnungenEdit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAusgangsrechnungenDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAusgangsrechnungen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAusgangsrechnungenAdd, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 357);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // AusgangsrechnungList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AusgangsrechnungList";
            this.Size = new System.Drawing.Size(589, 357);
            this.Load += new System.EventHandler(this.AusgangsrechnungList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAusgangsrechnungenEdit;
        private System.Windows.Forms.Button btAusgangsrechnungenDelete;
        private System.Windows.Forms.Button btAusgangsrechnungenAdd;
        private System.Windows.Forms.ListView lvAusgangsrechnungen;
        private System.Windows.Forms.TextBox tbAusgangsrechnungen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
