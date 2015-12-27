namespace GUI
{
    partial class RechnungszeileList
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
            this.btRechnungszeilenEdit = new System.Windows.Forms.Button();
            this.btRechnungszeilenDelete = new System.Windows.Forms.Button();
            this.btRechnungszeilenAdd = new System.Windows.Forms.Button();
            this.lvRechnungszeilen = new System.Windows.Forms.ListView();
            this.tbRechnungszeilen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRechnungszeilenEdit
            // 
            this.btRechnungszeilenEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRechnungszeilenEdit.Location = new System.Drawing.Point(430, 335);
            this.btRechnungszeilenEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btRechnungszeilenEdit.Name = "btRechnungszeilenEdit";
            this.btRechnungszeilenEdit.Size = new System.Drawing.Size(78, 21);
            this.btRechnungszeilenEdit.TabIndex = 12;
            this.btRechnungszeilenEdit.Text = "Bearbeiten";
            this.btRechnungszeilenEdit.UseVisualStyleBackColor = true;
            this.btRechnungszeilenEdit.Click += new System.EventHandler(this.btRechnungszeilenEdit_Click_1);
            // 
            // btRechnungszeilenDelete
            // 
            this.btRechnungszeilenDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRechnungszeilenDelete.Location = new System.Drawing.Point(510, 335);
            this.btRechnungszeilenDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btRechnungszeilenDelete.Name = "btRechnungszeilenDelete";
            this.btRechnungszeilenDelete.Size = new System.Drawing.Size(78, 21);
            this.btRechnungszeilenDelete.TabIndex = 13;
            this.btRechnungszeilenDelete.Text = "Löschen";
            this.btRechnungszeilenDelete.UseVisualStyleBackColor = true;
            this.btRechnungszeilenDelete.Click += new System.EventHandler(this.btRechnungszeilenDelete_Click_1);
            // 
            // btRechnungszeilenAdd
            // 
            this.btRechnungszeilenAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btRechnungszeilenAdd.Location = new System.Drawing.Point(1, 335);
            this.btRechnungszeilenAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btRechnungszeilenAdd.Name = "btRechnungszeilenAdd";
            this.btRechnungszeilenAdd.Size = new System.Drawing.Size(78, 21);
            this.btRechnungszeilenAdd.TabIndex = 15;
            this.btRechnungszeilenAdd.Text = "Hinzufügen";
            this.btRechnungszeilenAdd.UseVisualStyleBackColor = true;
            this.btRechnungszeilenAdd.Click += new System.EventHandler(this.btRechnungszeilenAdd_Click_1);
            // 
            // lvRechnungszeilen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lvRechnungszeilen, 4);
            this.lvRechnungszeilen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRechnungszeilen.FullRowSelect = true;
            this.lvRechnungszeilen.Location = new System.Drawing.Point(3, 26);
            this.lvRechnungszeilen.MultiSelect = false;
            this.lvRechnungszeilen.Name = "lvRechnungszeilen";
            this.lvRechnungszeilen.Size = new System.Drawing.Size(583, 305);
            this.lvRechnungszeilen.TabIndex = 14;
            this.lvRechnungszeilen.UseCompatibleStateImageBehavior = false;
            this.lvRechnungszeilen.View = System.Windows.Forms.View.Details;
            this.lvRechnungszeilen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvRechnungszeilen_KeyDown);
            this.lvRechnungszeilen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvRechnungszeilen_MouseDoubleClick);
            // 
            // tbRechnungszeilen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbRechnungszeilen, 3);
            this.tbRechnungszeilen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRechnungszeilen.Location = new System.Drawing.Point(83, 3);
            this.tbRechnungszeilen.Name = "tbRechnungszeilen";
            this.tbRechnungszeilen.Size = new System.Drawing.Size(503, 20);
            this.tbRechnungszeilen.TabIndex = 11;
            this.tbRechnungszeilen.TextChanged += new System.EventHandler(this.tbRechnungszeilen_TextChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.lvRechnungszeilen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btRechnungszeilenEdit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btRechnungszeilenDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbRechnungszeilen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btRechnungszeilenAdd, 0, 2);
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
            // RechnungszeileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RechnungszeileList";
            this.Size = new System.Drawing.Size(589, 357);
            this.Load += new System.EventHandler(this.RechnungszeileList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRechnungszeilenEdit;
        private System.Windows.Forms.Button btRechnungszeilenDelete;
        private System.Windows.Forms.Button btRechnungszeilenAdd;
        private System.Windows.Forms.ListView lvRechnungszeilen;
        private System.Windows.Forms.TextBox tbRechnungszeilen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
