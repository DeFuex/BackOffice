namespace GUI
{
    partial class BuchungszeileList
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
            this.btBuchungszeilenEdit = new System.Windows.Forms.Button();
            this.btBuchungszeilenDelete = new System.Windows.Forms.Button();
            this.btBuchungszeilenAdd = new System.Windows.Forms.Button();
            this.lvBuchungszeilen = new System.Windows.Forms.ListView();
            this.tbBuchungszeilen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBuchungszeilenEdit
            // 
            this.btBuchungszeilenEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBuchungszeilenEdit.Location = new System.Drawing.Point(430, 335);
            this.btBuchungszeilenEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btBuchungszeilenEdit.Name = "btBuchungszeilenEdit";
            this.btBuchungszeilenEdit.Size = new System.Drawing.Size(78, 21);
            this.btBuchungszeilenEdit.TabIndex = 12;
            this.btBuchungszeilenEdit.Text = "Bearbeiten";
            this.btBuchungszeilenEdit.UseVisualStyleBackColor = true;
            this.btBuchungszeilenEdit.Click += new System.EventHandler(this.btBuchungszeilenEdit_Click);
            // 
            // btBuchungszeilenDelete
            // 
            this.btBuchungszeilenDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBuchungszeilenDelete.Location = new System.Drawing.Point(510, 335);
            this.btBuchungszeilenDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btBuchungszeilenDelete.Name = "btBuchungszeilenDelete";
            this.btBuchungszeilenDelete.Size = new System.Drawing.Size(78, 21);
            this.btBuchungszeilenDelete.TabIndex = 13;
            this.btBuchungszeilenDelete.Text = "Löschen";
            this.btBuchungszeilenDelete.UseVisualStyleBackColor = true;
            this.btBuchungszeilenDelete.Click += new System.EventHandler(this.btBuchungszeilenDelete_Click);
            // 
            // btBuchungszeilenAdd
            // 
            this.btBuchungszeilenAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btBuchungszeilenAdd.Location = new System.Drawing.Point(1, 335);
            this.btBuchungszeilenAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btBuchungszeilenAdd.Name = "btBuchungszeilenAdd";
            this.btBuchungszeilenAdd.Size = new System.Drawing.Size(78, 21);
            this.btBuchungszeilenAdd.TabIndex = 15;
            this.btBuchungszeilenAdd.Text = "Hinzufügen";
            this.btBuchungszeilenAdd.UseVisualStyleBackColor = true;
            this.btBuchungszeilenAdd.Click += new System.EventHandler(this.btBuchungszeilenAdd_Click);
            // 
            // lvBuchungszeilen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lvBuchungszeilen, 4);
            this.lvBuchungszeilen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBuchungszeilen.FullRowSelect = true;
            this.lvBuchungszeilen.Location = new System.Drawing.Point(3, 26);
            this.lvBuchungszeilen.MultiSelect = false;
            this.lvBuchungszeilen.Name = "lvBuchungszeilen";
            this.lvBuchungszeilen.Size = new System.Drawing.Size(583, 305);
            this.lvBuchungszeilen.TabIndex = 14;
            this.lvBuchungszeilen.UseCompatibleStateImageBehavior = false;
            this.lvBuchungszeilen.View = System.Windows.Forms.View.Details;
            this.lvBuchungszeilen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvBuchungszeilen_KeyDown);
            this.lvBuchungszeilen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvBuchungszeilen_MouseDoubleClick);
            // 
            // tbBuchungszeilen
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbBuchungszeilen, 3);
            this.tbBuchungszeilen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBuchungszeilen.Location = new System.Drawing.Point(83, 3);
            this.tbBuchungszeilen.Name = "tbBuchungszeilen";
            this.tbBuchungszeilen.Size = new System.Drawing.Size(503, 20);
            this.tbBuchungszeilen.TabIndex = 11;
            this.tbBuchungszeilen.TextChanged += new System.EventHandler(this.tbBuchungszeilen_TextChanged);
            this.tbBuchungszeilen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBuchungszeilen_KeyDown);
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
            this.tableLayoutPanel1.Controls.Add(this.lvBuchungszeilen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btBuchungszeilenEdit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btBuchungszeilenDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbBuchungszeilen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btBuchungszeilenAdd, 0, 2);
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
            // BuchungszeileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BuchungszeileList";
            this.Size = new System.Drawing.Size(589, 357);
            this.Load += new System.EventHandler(this.BuchungszeileList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBuchungszeilenEdit;
        private System.Windows.Forms.Button btBuchungszeilenDelete;
        private System.Windows.Forms.Button btBuchungszeilenAdd;
        private System.Windows.Forms.ListView lvBuchungszeilen;
        private System.Windows.Forms.TextBox tbBuchungszeilen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
