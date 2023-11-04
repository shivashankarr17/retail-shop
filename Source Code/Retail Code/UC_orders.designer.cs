namespace Retail
{
    partial class UC_orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcb_search_by_customer_name = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcb_search_by_invoiceno = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.invodate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_refresh);
            this.panel4.Location = new System.Drawing.Point(807, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 100);
            this.panel4.TabIndex = 12;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(14, 25);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(200, 50);
            this.btn_refresh.TabIndex = 139;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(25, 43);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(304, 45);
            this.txt_customername.TabIndex = 48;
            this.txt_customername.TextChanged += new System.EventHandler(this.txt_customername_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Customer Name :";
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(18, 43);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(304, 45);
            this.txt_invoiceno.TabIndex = 47;
            this.txt_invoiceno.TextChanged += new System.EventHandler(this.txt_invoiceno_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pcb_search_by_customer_name);
            this.panel2.Controls.Add(this.txt_customername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(405, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 100);
            this.panel2.TabIndex = 11;
            // 
            // pcb_search_by_customer_name
            // 
            this.pcb_search_by_customer_name.Image = global::Retail.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_customer_name.Location = new System.Drawing.Point(346, 42);
            this.pcb_search_by_customer_name.Name = "pcb_search_by_customer_name";
            this.pcb_search_by_customer_name.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_customer_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_customer_name.TabIndex = 138;
            this.pcb_search_by_customer_name.TabStop = false;
            this.pcb_search_by_customer_name.Click += new System.EventHandler(this.pcb_search_by_customer_name_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "Invoice No. :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcb_search_by_invoiceno);
            this.panel1.Controls.Add(this.txt_invoiceno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 100);
            this.panel1.TabIndex = 10;
            // 
            // pcb_search_by_invoiceno
            // 
            this.pcb_search_by_invoiceno.Image = global::Retail.Properties.Resources.icons8_search_48px_1;
            this.pcb_search_by_invoiceno.Location = new System.Drawing.Point(336, 42);
            this.pcb_search_by_invoiceno.Name = "pcb_search_by_invoiceno";
            this.pcb_search_by_invoiceno.Size = new System.Drawing.Size(45, 45);
            this.pcb_search_by_invoiceno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search_by_invoiceno.TabIndex = 138;
            this.pcb_search_by_invoiceno.TabStop = false;
            this.pcb_search_by_invoiceno.Click += new System.EventHandler(this.pcb_search_by_invoiceno_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.db_ordersDataGridView);
            this.panel3.Location = new System.Drawing.Point(12, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 518);
            this.panel3.TabIndex = 9;
            // 
            // db_ordersDataGridView
            // 
            this.db_ordersDataGridView.AllowUserToAddRows = false;
            this.db_ordersDataGridView.AllowUserToDeleteRows = false;
            this.db_ordersDataGridView.AllowUserToResizeColumns = false;
            this.db_ordersDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.db_ordersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.db_ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.db_ordersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_ordersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.db_ordersDataGridView.ColumnHeadersHeight = 40;
            this.db_ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invodate,
            this.invono,
            this.cusid,
            this.cusname,
            this.contact,
            this.address,
            this.grandtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.db_ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_ordersDataGridView.EnableHeadersVisualStyles = false;
            this.db_ordersDataGridView.GridColor = System.Drawing.Color.White;
            this.db_ordersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_ordersDataGridView.Name = "db_ordersDataGridView";
            this.db_ordersDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_ordersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.db_ordersDataGridView.RowHeadersVisible = false;
            this.db_ordersDataGridView.RowHeadersWidth = 51;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.db_ordersDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.db_ordersDataGridView.RowTemplate.Height = 35;
            this.db_ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db_ordersDataGridView.Size = new System.Drawing.Size(1009, 518);
            this.db_ordersDataGridView.TabIndex = 2;
            // 
            // invodate
            // 
            this.invodate.DataPropertyName = "invodate";
            this.invodate.HeaderText = "Invoice Date";
            this.invodate.MinimumWidth = 6;
            this.invodate.Name = "invodate";
            this.invodate.ReadOnly = true;
            this.invodate.Width = 200;
            // 
            // invono
            // 
            this.invono.DataPropertyName = "invono";
            this.invono.HeaderText = "Invoice No";
            this.invono.MinimumWidth = 6;
            this.invono.Name = "invono";
            this.invono.ReadOnly = true;
            this.invono.Width = 150;
            // 
            // cusid
            // 
            this.cusid.DataPropertyName = "cusid";
            this.cusid.HeaderText = "Customer Id";
            this.cusid.MinimumWidth = 6;
            this.cusid.Name = "cusid";
            this.cusid.ReadOnly = true;
            this.cusid.Width = 150;
            // 
            // cusname
            // 
            this.cusname.DataPropertyName = "cusname";
            this.cusname.HeaderText = "Customer Name";
            this.cusname.MinimumWidth = 6;
            this.cusname.Name = "cusname";
            this.cusname.ReadOnly = true;
            this.cusname.Width = 350;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Contact";
            this.contact.MinimumWidth = 6;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 350;
            // 
            // grandtotal
            // 
            this.grandtotal.DataPropertyName = "grandtotal";
            this.grandtotal.HeaderText = "Grand Total";
            this.grandtotal.MinimumWidth = 6;
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.ReadOnly = true;
            this.grandtotal.Width = 150;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UC_orders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "UC_orders";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.UC_orders_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_customer_name)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search_by_invoiceno)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_search_by_customer_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.PictureBox pcb_search_by_invoiceno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public System.Windows.Forms.DataGridView db_ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn invodate;
        private System.Windows.Forms.DataGridViewTextBoxColumn invono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusname;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandtotal;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
