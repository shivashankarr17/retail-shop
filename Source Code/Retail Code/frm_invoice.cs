using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using MySql.Data.MySqlClient;

namespace Retail
{
    public partial class frm_invoice : Form
    {
        public static string invoice_id;

        dbconnection db = new dbconnection();
        
        public frm_invoice()
        {
            InitializeComponent();
        }

        private void frm_invoice_Load(object sender, EventArgs e)
        {
            invoice_id = UC_Billing.invoiceid;

            txt_invoiceid.Text = invoice_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_invoiceid_TextChanged(object sender, EventArgs e)
        {
            invoiceproduct();
        }

        private void invoiceproduct()
        {
            MySqlConnection con = new MySqlConnection(db.dbcon);

            con.Open();

            String str = "SELECT * FROM invoice_view WHERE invono = '" + txt_invoiceid.Text + "'";

            MySqlCommand cmd = new MySqlCommand(str, con);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

            invoiceproduct dstp = new invoiceproduct();

            sda.Fill(dstp, "invoice_view");

            CrystalReport1 CRSI = new CrystalReport1();

            CRSI.SetDataSource(dstp);

            crystalReportViewer1.ReportSource = CRSI;

            con.Close();

        }
    }
}
