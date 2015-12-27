namespace GUI
{
    partial class AngebotList
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
            this.btAngeboteEdit = new System.Windows.Forms.Button();
            this.btAngeboteDelete = new System.Windows.Forms.Button();
            this.btAngeboteAdd = new System.Windows.Forms.Button();
            this.lvAngebote = new System.Windows.Forms.ListView();
            this.tbAngebote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAngeboteEdit
            // 
            this.btAngeboteEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAngeboteEdit.Location = new System.Drawing.Point(430, 335);
            this.btAngeboteEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btAngeboteEdit.Name = "btAngeboteEdit";
            this.btAngeboteEdit.Size = new System.Drawing.Size(78, 21);
            this.btAngeboteEdit.TabIndex = 12;
            this.btAngeboteEdit.Text = "Bearbeiten";
            this.btAngeboteEdit.UseVisualStyleBackColor = true;
            this.btAngeboteEdit.Click += new System.EventHandler(this.btAngeboteEdit_Click);
            // 
            // btAngeboteDelete
            // 
            this.btAngeboteDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAngeboteDelete.Location = new System.Drawing.Point(510, 335);
            this.btAngeboteDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btAngeboteDelete.Name = "btAngeboteDelete";
            this.btAngeboteDelete.Size = new System.Drawing.Size(78, 21);
            this.btAngeboteDelete.TabIndex = 13;
            this.btAngeboteDelete.Text = "Löschen";
            this.btAngeboteDelete.UseVisualStyleBackColor = true;
            this.btAngeboteDelete.Click += new System.EventHandler(this.btAngeboteDelete_Click);
            // 
            // btAngeboteAdd
            // 
            this.btAngeboteAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAngeboteAdd.Location = new System.Drawing.Point(1, 335);
            this.btAngeboteAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btAngeboteAdd.Name = "btAngeboteAdd";
            this.btAngeboteAdd.Size = new System.Drawing.Size(78, 21);
            this.btAngeboteAdd.TabIndex = 15;
            this.btAngeboteAdd.Text = "Hinzufügen";
            this.btAngeboteAdd.UseVisualStyleBackColor = true;
            this.btAngeboteAdd.Click += new System.EventHandler(this.btAngeboteAdd_Click);
            // 
            // lvAngebote
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lvAngebote, 4);
            this.lvAngebote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAngebote.FullRowSelect = true;
            this.lvAngebote.Location = new System.Drawing.Point(3, 26);
            this.lvAngebote.MultiSelect = false;
            this.lvAngebote.Name = "lvAngebote";
            this.lvAngebote.Size = new System.Drawing.Size(583, 305);
            this.lvAngebote.TabIndex = 14;
            this.lvAngebote.UseCompatibleStateImageBehavior = false;
            this.lvAngebote.View = System.Windows.Forms.View.Details;
            this.lvAngebote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvAngebote_KeyDown);
            this.lvAngebote.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAngebote_MouseDoubleClick);
            // 
            // tbAngebote
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbAngebote, 3);
            this.tbAngebote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAngebote.Location = new System.Drawing.Point(83, 3);
            this.tbAngebote.Name = "tbAngebote";
            this.tbAngebote.Size = new System.Drawing.Size(503, 20);
            this.tbAngebote.TabIndex = 11;
            this.tbAngebote.TextChanged += new System.EventHandler(this.tbAngebote_TextChanged);
            this.tbAngebote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAngebote_KeyDown);
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
            this.tableLayoutPanel1.Controls.Add(this.lvAngebote, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btAngeboteEdit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAngeboteDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAngebote, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAngeboteAdd, 0, 2);
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
            // AngebotList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AngebotList";
            this.Size = new System.Drawing.Size(589, 357);
            this.Load += new System.EventHandler(this.AngebotList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAngeboteEdit;
        private System.Windows.Forms.Button btAngeboteDelete;
        private System.Windows.Forms.Button btAngeboteAdd;
        private System.Windows.Forms.ListView lvAngebote;
        private System.Windows.Forms.TextBox tbAngebote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
