namespace GUI
{
    partial class EingangsrechnungList
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
            this.btEingangsrechnungenEdit = new System.Windows.Forms.Button();
            this.btEingangsrechnungenDelete = new System.Windows.Forms.Button();
            this.btEingangsrechnungenAdd = new System.Windows.Forms.Button();
            this.lvEingangsrechnungen = new System.Windows.Forms.ListView();
            this.tbEingangsrechnungen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEingangsrechnungenEdit
            // 
            this.btEingangsrechnungenEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEingangsrechnungenEdit.Location = new System.Drawing.Point(430, 335);
            this.btEingangsrechnungenEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btEingangsrechnungenEdit.Name = "btEingangsrechnungenEdit";
            this.btEingangsrechnungenEdit.Size = new System.Drawing.Size(78, 21);
            this.btEingangsrechnungenEdit.TabIndex = 12;
            this.btEingangsrechnungenEdit.Text = "Bearbeiten";
            this.btEingangsrechnungenEdit.UseVisualStyleBackColor = true;
            this.btEingangsrechnungenEdit.Click += new System.EventHandler(this.btEingangsrechnungenEdit_Click);
            // 
            // btEingangsrechnungenDelete
            // 
            this.btEingangsrechnungenDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEingangsrechnungenDelete.Location = new System.Drawing.Point(510, 335);
            this.btEingangsrechnungenDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btEingangsrechnungenDelete.Name = "btEingangsrechnungenDelete";
            this.btEingangsrechnungenDelete.Size = new System.Drawing.Size(78, 21);
            this.btEingangsrechnungenDelete.TabIndex = 13;
            this.btEingangsrechnungenDelete.Text = "Löschen";
            this.btEingangsrechnungenDelete.UseVisualStyleBackColor = true;
            this.btEingangsrechnungenDelete.Click += new System.EventHandler(this.btEingangsrechnungenDelete_Click);
            // 
            // btEingangsrechnungenAdd
            // 
            this.btEingangsrechnungenAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEingangsrechnungenAdd.Location = new System.Drawing.Point(1, 335);
            this.btEingangsrechnungenAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btEingangsrechnungenAdd.Name = "btEingangsrechnungenAdd";
            this.btEingangsrechnungenAdd.Size = new System.Drawing.Size(78, 21);
            this.btEingangsrechnungenAdd.TabIndex = 15;
            this.btEingangsrechnungenAdd.Text = "Hinzufügen";
            this.btEingangsrechnungenAdd.UseVisualStyleBackColor = true;
            this.btEingangsrechnungenAdd.Click += new System.EventHandler(this.btEingangsrechnungenAdd_Click);
            // 
            // lvEingangsrechnungen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lvEingangsrechnungen, 4);
            this.lvEingangsrechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEingangsrechnungen.FullRowSelect = true;
            this.lvEingangsrechnungen.Location = new System.Drawing.Point(3, 26);
            this.lvEingangsrechnungen.MultiSelect = false;
            this.lvEingangsrechnungen.Name = "lvEingangsrechnungen";
            this.lvEingangsrechnungen.Size = new System.Drawing.Size(583, 305);
            this.lvEingangsrechnungen.TabIndex = 14;
            this.lvEingangsrechnungen.UseCompatibleStateImageBehavior = false;
            this.lvEingangsrechnungen.View = System.Windows.Forms.View.Details;
            this.lvEingangsrechnungen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvEingangsrechnungen_KeyDown);
            this.lvEingangsrechnungen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvEingangsrechnungen_MouseDoubleClick);
            // 
            // tbEingangsrechnungen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbEingangsrechnungen, 3);
            this.tbEingangsrechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEingangsrechnungen.Location = new System.Drawing.Point(83, 3);
            this.tbEingangsrechnungen.Name = "tbEingangsrechnungen";
            this.tbEingangsrechnungen.Size = new System.Drawing.Size(503, 20);
            this.tbEingangsrechnungen.TabIndex = 11;
            this.tbEingangsrechnungen.TextChanged += new System.EventHandler(this.tbEingangsrechnungen_TextChanged);
            this.tbEingangsrechnungen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEingangsrechnungen_KeyDown);
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
            this.tableLayoutPanel1.Controls.Add(this.lvEingangsrechnungen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btEingangsrechnungenEdit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btEingangsrechnungenDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbEingangsrechnungen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btEingangsrechnungenAdd, 0, 2);
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
            // EingangsrechnungList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EingangsrechnungList";
            this.Size = new System.Drawing.Size(589, 357);
            this.Load += new System.EventHandler(this.EingangsrechnungList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEingangsrechnungenEdit;
        private System.Windows.Forms.Button btEingangsrechnungenDelete;
        private System.Windows.Forms.Button btEingangsrechnungenAdd;
        private System.Windows.Forms.ListView lvEingangsrechnungen;
        private System.Windows.Forms.TextBox tbEingangsrechnungen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
