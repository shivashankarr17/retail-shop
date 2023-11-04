namespace Retail
{
    partial class UC_Billing
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.db_procardsDataGridView = new System.Windows.Forms.DataGridView();
            this.invoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proqut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_productid = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_customerid = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_remove_ = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dtp_invoicedate = new System.Windows.Forms.DateTimePicker();
            this.pcb_search = new System.Windows.Forms.PictureBox();
            this.txt_invoiceno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_grandtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_addtocard = new System.Windows.Forms.Button();
            this.txt_productquantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsDataGridView)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.db_procardsDataGridView);
            this.panel3.Location = new System.Drawing.Point(403, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 203);
            this.panel3.TabIndex = 138;
            // 
            // db_procardsDataGridView
            // 
            this.db_procardsDataGridView.AllowUserToAddRows = false;
            this.db_procardsDataGridView.AllowUserToDeleteRows = false;
            this.db_procardsDataGridView.AllowUserToResizeColumns = false;
            this.db_procardsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.db_procardsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.db_procardsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.db_procardsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_procardsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.db_procardsDataGridView.ColumnHeadersHeight = 40;
            this.db_procardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoid,
            this.cusid,
            this.proid,
            this.proname,
            this.proqut,
            this.proprice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_procardsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.db_procardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_procardsDataGridView.EnableHeadersVisualStyles = false;
            this.db_procardsDataGridView.GridColor = System.Drawing.Color.White;
            this.db_procardsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_procardsDataGridView.Name = "db_procardsDataGridView";
            this.db_procardsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_procardsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.db_procardsDataGridView.RowHeadersVisible = false;
            this.db_procardsDataGridView.RowHeadersWidth = 51;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.db_procardsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.db_procardsDataGridView.RowTemplate.Height = 35;
            this.db_procardsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db_procardsDataGridView.Size = new System.Drawing.Size(620, 201);
            this.db_procardsDataGridView.TabIndex = 2;
            this.db_procardsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_procardsDataGridView_CellClick);
            // 
            // invoid
            // 
            this.invoid.DataPropertyName = "invoid";
            this.invoid.HeaderText = "invoid";
            this.invoid.MinimumWidth = 6;
            this.invoid.Name = "invoid";
            this.invoid.ReadOnly = true;
            this.invoid.Visible = false;
            this.invoid.Width = 125;
            // 
            // cusid
            // 
            this.cusid.DataPropertyName = "cusid";
            this.cusid.HeaderText = "cusid";
            this.cusid.MinimumWidth = 6;
            this.cusid.Name = "cusid";
            this.cusid.ReadOnly = true;
            this.cusid.Visible = false;
            this.cusid.Width = 125;
            // 
            // proid
            // 
            this.proid.DataPropertyName = "proid";
            this.proid.HeaderText = "proid";
            this.proid.MinimumWidth = 6;
            this.proid.Name = "proid";
            this.proid.ReadOnly = true;
            this.proid.Visible = false;
            this.proid.Width = 125;
            // 
            // proname
            // 
            this.proname.DataPropertyName = "proname";
            this.proname.HeaderText = "Product Name";
            this.proname.MinimumWidth = 6;
            this.proname.Name = "proname";
            this.proname.ReadOnly = true;
            this.proname.Width = 340;
            // 
            // proqut
            // 
            this.proqut.DataPropertyName = "proqut";
            this.proqut.HeaderText = "Quantity";
            this.proqut.MinimumWidth = 6;
            this.proqut.Name = "proqut";
            this.proqut.ReadOnly = true;
            this.proqut.Width = 150;
            // 
            // proprice
            // 
            this.proprice.DataPropertyName = "proprice";
            this.proprice.HeaderText = "Price";
            this.proprice.MinimumWidth = 6;
            this.proprice.Name = "proprice";
            this.proprice.ReadOnly = true;
            this.proprice.Width = 125;
            // 
            // lbl_productid
            // 
            this.lbl_productid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_productid.AutoSize = true;
            this.lbl_productid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productid.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_productid.Location = new System.Drawing.Point(61, 9);
            this.lbl_productid.Name = "lbl_productid";
            this.lbl_productid.Size = new System.Drawing.Size(0, 28);
            this.lbl_productid.TabIndex = 133;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_productid);
            this.panel6.Controls.Add(this.lbl_customerid);
            this.panel6.Location = new System.Drawing.Point(304, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(80, 47);
            this.panel6.TabIndex = 130;
            this.panel6.Visible = false;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // lbl_customerid
            // 
            this.lbl_customerid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerid.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_customerid.Location = new System.Drawing.Point(20, 9);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(0, 28);
            this.lbl_customerid.TabIndex = 132;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_address.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(722, 264);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(303, 45);
            this.txt_address.TabIndex = 131;
            // 
            // txt_contact
            // 
            this.txt_contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contact.BackColor = System.Drawing.Color.White;
            this.txt_contact.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.ForeColor = System.Drawing.Color.Black;
            this.txt_contact.Location = new System.Drawing.Point(380, 264);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(303, 45);
            this.txt_contact.TabIndex = 130;
            // 
            // txt_customername
            // 
            this.txt_customername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_customername.BackColor = System.Drawing.Color.White;
            this.txt_customername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_customername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.ForeColor = System.Drawing.Color.Black;
            this.txt_customername.Location = new System.Drawing.Point(31, 264);
            this.txt_customername.Multiline = true;
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(303, 45);
            this.txt_customername.TabIndex = 127;
            this.txt_customername.TextChanged += new System.EventHandler(this.txt_customername_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(13, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 28);
            this.label8.TabIndex = 126;
            this.label8.Text = "Customer Name :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(704, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 128;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(359, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 28);
            this.label7.TabIndex = 129;
            this.label7.Text = "Contact :";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(76, 582);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 50);
            this.btn_save.TabIndex = 136;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_print.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(746, 582);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(200, 50);
            this.btn_print.TabIndex = 139;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_remove_
            // 
            this.btn_remove_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove_.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_remove_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove_.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_.ForeColor = System.Drawing.Color.White;
            this.btn_remove_.Location = new System.Drawing.Point(521, 582);
            this.btn_remove_.Name = "btn_remove_";
            this.btn_remove_.Size = new System.Drawing.Size(200, 50);
            this.btn_remove_.TabIndex = 138;
            this.btn_remove_.Text = "Remove";
            this.btn_remove_.UseVisualStyleBackColor = false;
            this.btn_remove_.Click += new System.EventHandler(this.btn_remove__Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(299, 582);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(200, 50);
            this.btn_update.TabIndex = 137;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dtp_invoicedate
            // 
            this.dtp_invoicedate.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_invoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_invoicedate.Location = new System.Drawing.Point(31, 58);
            this.dtp_invoicedate.Name = "dtp_invoicedate";
            this.dtp_invoicedate.Size = new System.Drawing.Size(264, 48);
            this.dtp_invoicedate.TabIndex = 129;
            // 
            // pcb_search
            // 
            this.pcb_search.Image = global::Retail.Properties.Resources.icons8_search_48px_1;
            this.pcb_search.Location = new System.Drawing.Point(339, 153);
            this.pcb_search.Name = "pcb_search";
            this.pcb_search.Size = new System.Drawing.Size(45, 45);
            this.pcb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_search.TabIndex = 128;
            this.pcb_search.TabStop = false;
            this.pcb_search.Click += new System.EventHandler(this.pcb_search_Click);
            // 
            // txt_invoiceno
            // 
            this.txt_invoiceno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceno.BackColor = System.Drawing.Color.White;
            this.txt_invoiceno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceno.ForeColor = System.Drawing.Color.Black;
            this.txt_invoiceno.Location = new System.Drawing.Point(31, 155);
            this.txt_invoiceno.Multiline = true;
            this.txt_invoiceno.Name = "txt_invoiceno";
            this.txt_invoiceno.Size = new System.Drawing.Size(302, 45);
            this.txt_invoiceno.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(13, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 28);
            this.label9.TabIndex = 126;
            this.label9.Text = "Invoice No. :";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(13, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 28);
            this.label10.TabIndex = 124;
            this.label10.Text = "Invoice Date :";
            // 
            // txt_productname
            // 
            this.txt_productname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productname.BackColor = System.Drawing.Color.White;
            this.txt_productname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_productname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productname.ForeColor = System.Drawing.Color.Black;
            this.txt_productname.Location = new System.Drawing.Point(31, 375);
            this.txt_productname.Multiline = true;
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(303, 45);
            this.txt_productname.TabIndex = 153;
            this.txt_productname.TextChanged += new System.EventHandler(this.txt_productname_TextChanged);
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_totalprice.BackColor = System.Drawing.Color.White;
            this.txt_totalprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.Black;
            this.txt_totalprice.Location = new System.Drawing.Point(34, 475);
            this.txt_totalprice.Multiline = true;
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(303, 45);
            this.txt_totalprice.TabIndex = 163;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(13, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 162;
            this.label3.Text = "Total Price :";
            // 
            // txt_grandtotal
            // 
            this.txt_grandtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_grandtotal.BackColor = System.Drawing.Color.White;
            this.txt_grandtotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grandtotal.ForeColor = System.Drawing.Color.Black;
            this.txt_grandtotal.Location = new System.Drawing.Point(725, 475);
            this.txt_grandtotal.Multiline = true;
            this.txt_grandtotal.Name = "txt_grandtotal";
            this.txt_grandtotal.Size = new System.Drawing.Size(303, 45);
            this.txt_grandtotal.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(707, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 160;
            this.label4.Text = "Grand Total :";
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remove.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(559, 470);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(142, 50);
            this.btn_remove.TabIndex = 159;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_addtocard
            // 
            this.btn_addtocard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addtocard.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_addtocard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addtocard.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addtocard.ForeColor = System.Drawing.Color.White;
            this.btn_addtocard.Location = new System.Drawing.Point(377, 470);
            this.btn_addtocard.Name = "btn_addtocard";
            this.btn_addtocard.Size = new System.Drawing.Size(175, 50);
            this.btn_addtocard.TabIndex = 158;
            this.btn_addtocard.Text = "Add To Card";
            this.btn_addtocard.UseVisualStyleBackColor = false;
            this.btn_addtocard.Click += new System.EventHandler(this.btn_addtocard_Click);
            // 
            // txt_productquantity
            // 
            this.txt_productquantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productquantity.BackColor = System.Drawing.Color.White;
            this.txt_productquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_productquantity.Location = new System.Drawing.Point(722, 375);
            this.txt_productquantity.Multiline = true;
            this.txt_productquantity.Name = "txt_productquantity";
            this.txt_productquantity.Size = new System.Drawing.Size(303, 45);
            this.txt_productquantity.TabIndex = 157;
            this.txt_productquantity.TextChanged += new System.EventHandler(this.txt_productquantity_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(365, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 154;
            this.label1.Text = "Product Price :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(704, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 28);
            this.label2.TabIndex = 155;
            this.label2.Text = "Product Quantity :";
            // 
            // txt_productprice
            // 
            this.txt_productprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productprice.BackColor = System.Drawing.Color.White;
            this.txt_productprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productprice.ForeColor = System.Drawing.Color.Black;
            this.txt_productprice.Location = new System.Drawing.Point(386, 375);
            this.txt_productprice.Multiline = true;
            this.txt_productprice.Name = "txt_productprice";
            this.txt_productprice.Size = new System.Drawing.Size(303, 45);
            this.txt_productprice.TabIndex = 156;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(13, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 28);
            this.label5.TabIndex = 152;
            this.label5.Text = "Product Name :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // UC_Billing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_grandtotal);
            this.Controls.Add(this.btn_remove_);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.txt_productquantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_addtocard);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_search);
            this.Controls.Add(this.dtp_invoicedate);
            this.Controls.Add(this.txt_productprice);
            this.Controls.Add(this.txt_invoiceno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.label8);
            this.Name = "UC_Billing";
            this.Size = new System.Drawing.Size(1038, 660);
            this.Load += new System.EventHandler(this.UC_Billing_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_procardsDataGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_productid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_customerid;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_remove_;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DateTimePicker dtp_invoicedate;
        private System.Windows.Forms.PictureBox pcb_search;
        private System.Windows.Forms.TextBox txt_invoiceno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_grandtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_addtocard;
        private System.Windows.Forms.TextBox txt_productquantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.DataGridView db_procardsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusid;
        private System.Windows.Forms.DataGridViewTextBoxColumn proid;
        private System.Windows.Forms.DataGridViewTextBoxColumn proname;
        private System.Windows.Forms.DataGridViewTextBoxColumn proqut;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprice;
    }
}
