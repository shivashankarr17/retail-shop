using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Retail
{
    public partial class UC_dashboard : UserControl
    {
        dbconnection db = new dbconnection();
        public UC_dashboard()
        {
            InitializeComponent();
        }

        private void UC_dashboard_Load(object sender, EventArgs e)
        {
            loaddata();
            sum();
            usercount();
            orderscount();
            productcount();
            customercount();
     
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            loaddata();
            sum();
            usercount();
            orderscount();
            productcount();
            customercount();
     
        }

        private void sum()
        {
            int A = 0, B = 0;
            for (A = 0; A < db_ordersDataGridView.Rows.Count; ++A)
            {
                B += Convert.ToInt32(db_ordersDataGridView.Rows[A].Cells[6].Value);
            }

            lbl_total_amount.Text = B.ToString();
        }

        private void loaddata()
        {

           MySqlConnection con = new MySqlConnection(db.dbcon);
           
            con.Open();

            String str = "Select * From db_orders ";

            MySqlCommand cmd = new MySqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            db_ordersDataGridView.DataSource = dt;

            con.Close();

        }

        private void usercount()
        {
            try
            {
               MySqlConnection con = new MySqlConnection(db.dbcon);
           
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(uid)From db_user";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                lbl_user_count.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void customercount()
        {
            try
            {
               MySqlConnection con = new MySqlConnection(db.dbcon);
           
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(cusid)From db_customers";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                lbl_customer_count.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void productcount()
        {
            try
            {
               MySqlConnection con = new MySqlConnection(db.dbcon);
           
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(proid)From db_product";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                lbl_product_count.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void orderscount()
        {
            try
            {
               MySqlConnection con = new MySqlConnection(db.dbcon);
                
                con.Open();

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Select Count(invono)From db_orders";

                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                lbl_orders_count.Text = rows_count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

    }
}
