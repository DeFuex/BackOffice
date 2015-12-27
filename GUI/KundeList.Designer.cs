namespace GUI
{
    partial class KundeList
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
            this.btKundenEdit = new System.Windows.Forms.Button();
            this.btKundenDelete = new System.Windows.Forms.Button();
            this.btKundenAdd = new System.Windows.Forms.Button();
            this.lvKunden = new System.Windows.Forms.ListView();
            this.tbKunden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btKundenEdit
            // 
            this.btKundenEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btKundenEdit.Location = new System.Drawing.Point(430, 335);
            this.btKundenEdit.Margin = new System.Windows.Forms.Padding(1);
            this.btKundenEdit.Name = "btKundenEdit";
            this.btKundenEdit.Size = new System.Drawing.Size(78, 21);
            this.btKundenEdit.TabIndex = 12;
            this.btKundenEdit.Text = "Bearbeiten";
            this.btKundenEdit.UseVisualStyleBackColor = true;
            this.btKundenEdit.Click += new System.EventHandler(this.btKundenEdit_Click);
            // 
            // btKundenDelete
            // 
            this.btKundenDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btKundenDelete.Location = new System.Drawing.Point(510, 335);
            this.btKundenDelete.Margin = new System.Windows.Forms.Padding(1);
            this.btKundenDelete.Name = "btKundenDelete";
            this.btKundenDelete.Size = new System.Drawing.Size(78, 21);
            this.btKundenDelete.TabIndex = 13;
            this.btKundenDelete.Text = "Löschen";
            this.btKundenDelete.UseVisualStyleBackColor = true;
            this.btKundenDelete.Click += new System.EventHandler(this.btKundenDelete_Click);
            // 
            // btKundenAdd
            // 
            this.btKundenAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btKundenAdd.Location = new System.Drawing.Point(1, 335);
            this.btKundenAdd.Margin = new System.Windows.Forms.Padding(1);
            this.btKundenAdd.Name = "btKundenAdd";
            this.btKundenAdd.Size = new System.Drawing.Size(78, 21);
            this.btKundenAdd.TabIndex = 15;
            this.btKundenAdd.Text = "Hinzufügen";
            this.btKundenAdd.UseVisualStyleBackColor = true;
            this.btKundenAdd.Click += new System.EventHandler(this.btKundenAdd_Click);
            // 
            // lvKunden
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lvKunden, 4);
            this.lvKunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKunden.FullRowSelect = true;
            this.lvKunden.Location = new System.Drawing.Point(3, 26);
            this.lvKunden.MultiSelect = false;
            this.lvKunden.Name = "lvKunden";
            this.lvKunden.Size = new System.Drawing.Size(583, 305);
            this.lvKunden.TabIndex = 14;
            this.lvKunden.UseCompatibleStateImageBehavior = false;
            this.lvKunden.View = System.Windows.Forms.View.Details;
            this.lvKunden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvKunden_KeyDown);
            this.lvKunden.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvKunden_MouseDoubleClick);
            // 
            // tbKunden
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbKunden, 3);
            this.tbKunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKunden.Location = new System.Drawing.Point(83, 3);
            this.tbKunden.Name = "tbKunden";
            this.tbKunden.Size = new System.Drawing.Size(503, 20);
            this.tbKunden.TabIndex = 11;
            this.tbKunden.TextChanged += new System.EventHandler(this.tbKunden_TextChanged);
            this.tbKunden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKunden_KeyDown);

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
            this.tableLayoutPanel1.Controls.Add(this.lvKunden, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btKundenEdit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btKundenDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbKunden, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btKundenAdd, 0, 2);
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
            // KundeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KundeList";
            this.Size = new System.Drawing.Size(589, 357);
            this.Load += new System.EventHandler(this.KundeList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btKundenEdit;
        private System.Windows.Forms.Button btKundenDelete;
        private System.Windows.Forms.Button btKundenAdd;
        private System.Windows.Forms.ListView lvKunden;
        private System.Windows.Forms.TextBox tbKunden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
