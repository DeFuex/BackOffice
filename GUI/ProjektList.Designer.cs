namespace GUI
{
    partial class ProjektList
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
            this.btProjekteEdit = new System.Windows.Forms.Button();
            this.btProjekteDelete = new System.Windows.Forms.Button();
            this.btProjekteAdd = new System.Windows.Forms.Button();
            this.lvProjekte = new System.Windows.Forms.ListView();
            this.tbProjekte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btProjekteEdit
            // 
            this.btProjekteEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btProjekteEdit.Location = new System.Drawing.Point(430, 335);
            this.btProjekteEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btProjekteEdit.Name = "btProjekteEdit";
            this.btProjekteEdit.Size = new System.Drawing.Size(78, 21);
            this.btProjekteEdit.TabIndex = 12;
            this.btProjekteEdit.Text = "Bearbeiten";
            this.btProjekteEdit.UseVisualStyleBackColor = true;
            this.btProjekteEdit.Click += new System.EventHandler(this.btProjekteEdit_Click_1);
            // 
            // btProjekteDelete
            // 
            this.btProjekteDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btProjekteDelete.Location = new System.Drawing.Point(510, 335);
            this.btProjekteDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btProjekteDelete.Name = "btProjekteDelete";
            this.btProjekteDelete.Size = new System.Drawing.Size(78, 21);
            this.btProjekteDelete.TabIndex = 13;
            this.btProjekteDelete.Text = "Löschen";
            this.btProjekteDelete.UseVisualStyleBackColor = true;
            this.btProjekteDelete.Click += new System.EventHandler(this.btProjekteDelete_Click_1);
            // 
            // btProjekteAdd
            // 
            this.btProjekteAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btProjekteAdd.Location = new System.Drawing.Point(1, 335);
            this.btProjekteAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btProjekteAdd.Name = "btProjekteAdd";
            this.btProjekteAdd.Size = new System.Drawing.Size(78, 21);
            this.btProjekteAdd.TabIndex = 15;
            this.btProjekteAdd.Text = "Hinzufügen";
            this.btProjekteAdd.UseVisualStyleBackColor = true;
            this.btProjekteAdd.Click += new System.EventHandler(this.btProjekteAdd_Click_1);
            // 
            // lvProjekte
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lvProjekte, 4);
            this.lvProjekte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProjekte.FullRowSelect = true;
            this.lvProjekte.Location = new System.Drawing.Point(3, 26);
            this.lvProjekte.MultiSelect = false;
            this.lvProjekte.Name = "lvProjekte";
            this.lvProjekte.Size = new System.Drawing.Size(583, 305);
            this.lvProjekte.TabIndex = 14;
            this.lvProjekte.UseCompatibleStateImageBehavior = false;
            this.lvProjekte.View = System.Windows.Forms.View.Details;
            this.lvProjekte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvProjekte_KeyDown);
            this.lvProjekte.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProjekte_MouseDoubleClick);
            // 
            // tbProjekte
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbProjekte, 3);
            this.tbProjekte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProjekte.Location = new System.Drawing.Point(83, 3);
            this.tbProjekte.Name = "tbProjekte";
            this.tbProjekte.Size = new System.Drawing.Size(503, 20);
            this.tbProjekte.TabIndex = 11;
            this.tbProjekte.TextChanged += new System.EventHandler(this.tbProjekte_TextChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.lvProjekte, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btProjekteEdit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btProjekteDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbProjekte, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btProjekteAdd, 0, 2);
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
            // ProjektList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjektList";
            this.Size = new System.Drawing.Size(589, 357);
            this.Load += new System.EventHandler(this.ProjektList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btProjekteEdit;
        private System.Windows.Forms.Button btProjekteDelete;
        private System.Windows.Forms.Button btProjekteAdd;
        private System.Windows.Forms.ListView lvProjekte;
        private System.Windows.Forms.TextBox tbProjekte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
