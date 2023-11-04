namespace Retail
{
    partial class UC_categories
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.catid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_categorieid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_categoriename = new System.Windows.Forms.TextBox();
            this.pcb_serch = new System.Windows.Forms.PictureBox();
            this.pcb_search1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_categoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(622, 138);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(154, 50);
            this.btn_remove.TabIndex = 117;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(441, 138);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(154, 50);
            this.btn_edit.TabIndex = 116;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.db_categoriesDataGridView);
            this.panel1.Location = new System.Drawing.Point(25, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 437);
            this.panel1.TabIndex = 118;
            // 
            // db_categoriesDataGridView
            // 
            this.db_categoriesDataGridView.AllowUserToAddRows = false;
            this.db_categoriesDataGridView.AllowUserToDeleteRows = false;
            this.db_categoriesDataGridView.AllowUserToResizeColumns = false;
            this.db_categoriesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.db_categoriesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.db_categoriesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.db_categoriesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_categoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.db_categoriesDataGridView.ColumnHeadersHeight = 40;
            this.db_categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catid,
            this.catname});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_categoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.db_categoriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_categoriesDataGridView.EnableHeadersVisualStyles = false;
            this.db_categoriesDataGridView.GridColor = System.Drawing.Color.White;
            this.db_categoriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_categoriesDataGridView.Name = "db_categoriesDataGridView";
            this.db_categoriesDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_categoriesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.db_categoriesDataGridView.RowHeadersVisible = false;
            this.db_categoriesDataGridView.RowHeadersWidth = 51;
            this.db_categoriesDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_categoriesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.db_categoriesDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_categoriesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_categoriesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.db_categoriesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.db_categoriesDataGridView.RowTemplate.Height = 35;
            this.db_categoriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db_categoriesDataGridView.Size = new System.Drawing.Size(982, 437);
            this.db_categoriesDataGridView.TabIndex = 1;
            this.db_categoriesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_categoriesDataGridView_CellClick);
            // 
            // catid
            // 
            this.catid.DataPropertyName = "catid";
            this.catid.HeaderText = "Categorie Id";
            this.catid.MinimumWidth = 6;
            this.catid.Name = "catid";
            this.catid.ReadOnly = true;
            this.catid.Width = 200;
            // 
            // catname
            // 
            this.catname.DataPropertyName = "catname";
            this.catname.HeaderText = "Categorie Name";
            this.catname.MinimumWidth = 6;
            this.catname.Name = "catname";
            this.catname.ReadOnly = true;
            this.catname.Width = 300;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(263, 138);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(154, 50);
            this.btn_save.TabIndex = 115;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_categorieid
            // 
            this.txt_categorieid.BackColor = System.Drawing.Color.White;
            this.txt_categorieid.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categorieid.ForeColor = System.Drawing.Color.Black;
            this.txt_categorieid.Location = new System.Drawing.Point(116, 58);
            this.txt_categorieid.Multiline = true;
            this.txt_categorieid.Name = "txt_categorieid";
            this.txt_categorieid.Size = new System.Drawing.Size(341, 45);
            this.txt_categorieid.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(524, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 28);
            this.label3.TabIndex = 109;
            this.label3.Text = "Categorie Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(98, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 110;
            this.label2.Text = "Categorie ID  :";
            // 
            // txt_categoriename
            // 
            this.txt_categoriename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_categoriename.BackColor = System.Drawing.Color.White;
            this.txt_categoriename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_categoriename.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoriename.ForeColor = System.Drawing.Color.Black;
            this.txt_categoriename.Location = new System.Drawing.Point(542, 58);
            this.txt_categoriename.Multiline = true;
            this.txt_categoriename.Name = "txt_categoriename";
            this.txt_categoriename.Size = new System.Drawing.Size(341, 45);
            this.txt_categoriename.TabIndex = 111;
            // 
            // pcb_serch
            // 
            this.pcb_serch.Image = global::Retail.Properties.Resources.icons8_search_48px_1;
            this.pcb_serch.Location = new System.Drawing.Point(469, 58);
            this.pcb_serch.Name = "pcb_serch";
            this.pcb_serch.Size = new System.Drawing.Size(45, 45);
            this.pcb_serch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_serch.TabIndex = 114;
            this.pcb_serch.TabStop = false;
            this.pcb_serch.Click += new System.EventHandler(this.pcb_serch_Click);
            // 
            // pcb_search1
            // 
            this.pcb_search1.Image = global::Retail.Properties.Resources.icons8_search_48px_1;
            this.pcb_search1.Location = new System.Drawing.Point(895, 58);
            this.pcb_search1.Name = "pcb_search1";
            this.pcb_search1.Size = new System.Drawing.Size(45, 45);
            this.pcb_search1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search1.TabIndex = 113;
            this.pcb_search1.TabStop = false;
            this.pcb_search1.Click += new System.EventHandler(this.pcb_search1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UC_categories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pcb_serch);
            this.Controls.Add(this.pcb_search1);
            this.Controls.Add(this.txt_categorieid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_categoriename);
            this.Name = "UC_categories";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.UC_categories_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_categoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_serch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pcb_serch;
        private System.Windows.Forms.PictureBox pcb_search1;
        private System.Windows.Forms.TextBox txt_categorieid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_categoriename;
      //  private db_categoriesTableAdapters.db_categoriesTableAdapter db_categoriesTableAdapter;
      //  private db_categoriesTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView db_categoriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn catid;
        private System.Windows.Forms.DataGridViewTextBoxColumn catname;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
