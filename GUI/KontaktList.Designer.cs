namespace GUI
{
    partial class KontaktList
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
            this.btKontakteEdit = new System.Windows.Forms.Button();
            this.btKontakteDelete = new System.Windows.Forms.Button();
            this.btKontakteAdd = new System.Windows.Forms.Button();
            this.lvKontakte = new System.Windows.Forms.ListView();
            this.tbKontakte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btKontakteEdit
            // 
            this.btKontakteEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btKontakteEdit.Location = new System.Drawing.Point(430, 335);
            this.btKontakteEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btKontakteEdit.Name = "btKontakteEdit";
            this.btKontakteEdit.Size = new System.Drawing.Size(78, 21);
            this.btKontakteEdit.TabIndex = 12;
            this.btKontakteEdit.Text = "Bearbeiten";
            this.btKontakteEdit.UseVisualStyleBackColor = true;
            this.btKontakteEdit.Click += new System.EventHandler(this.btKontakteEdit_Click_1);
            // 
            // btKontakteDelete
            // 
            this.btKontakteDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btKontakteDelete.Location = new System.Drawing.Point(510, 335);
            this.btKontakteDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btKontakteDelete.Name = "btKontakteDelete";
            this.btKontakteDelete.Size = new System.Drawing.Size(78, 21);
            this.btKontakteDelete.TabIndex = 13;
            this.btKontakteDelete.Text = "Löschen";
            this.btKontakteDelete.UseVisualStyleBackColor = true;
            this.btKontakteDelete.Click += new System.EventHandler(this.btKontakteDelete_Click_1);
            // 
            // btKontakteAdd
            // 
            this.btKontakteAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btKontakteAdd.Location = new System.Drawing.Point(1, 335);
            this.btKontakteAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btKontakteAdd.Name = "btKontakteAdd";
            this.btKontakteAdd.Size = new System.Drawing.Size(78, 21);
            this.btKontakteAdd.TabIndex = 15;
            this.btKontakteAdd.Text = "Hinzufügen";
            this.btKontakteAdd.UseVisualStyleBackColor = true;
            this.btKontakteAdd.Click += new System.EventHandler(this.btKontakteAdd_Click_1);
            // 
            // lvKontakte
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lvKontakte, 4);
            this.lvKontakte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKontakte.FullRowSelect = true;
            this.lvKontakte.Location = new System.Drawing.Point(3, 26);
            this.lvKontakte.MultiSelect = false;
            this.lvKontakte.Name = "lvKontakte";
            this.lvKontakte.Size = new System.Drawing.Size(583, 305);
            this.lvKontakte.TabIndex = 14;
            this.lvKontakte.UseCompatibleStateImageBehavior = false;
            this.lvKontakte.View = System.Windows.Forms.View.Details;
            this.lvKontakte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKontakte_KeyDown);
            this.lvKontakte.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvKontakte_MouseDoubleClick);
            // 
            // tbKontakte
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbKontakte, 3);
            this.tbKontakte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKontakte.Location = new System.Drawing.Point(83, 3);
            this.tbKontakte.Name = "tbKontakte";
            this.tbKontakte.Size = new System.Drawing.Size(503, 20);
            this.tbKontakte.TabIndex = 11;
            this.tbKontakte.TextChanged += new System.EventHandler(this.tbKontakte_TextChanged);
            this.tbKontakte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKontakte_KeyDown);
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
            this.tableLayoutPanel1.Controls.Add(this.lvKontakte, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btKontakteEdit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btKontakteDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbKontakte, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btKontakteAdd, 0, 2);
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
            // KontaktList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KontaktList";
            this.Size = new System.Drawing.Size(589, 357);
            this.Load += new System.EventHandler(this.KontaktList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btKontakteEdit;
        private System.Windows.Forms.Button btKontakteDelete;
        private System.Windows.Forms.Button btKontakteAdd;
        private System.Windows.Forms.ListView lvKontakte;
        private System.Windows.Forms.TextBox tbKontakte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
