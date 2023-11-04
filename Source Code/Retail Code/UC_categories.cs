using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Retail
{
    public partial class UC_categories : UserControl
    {
        dbconnection db = new dbconnection();
        public UC_categories()
        {
            InitializeComponent();
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            txt_categorieid.Text = "" + GetUniqueKey(5);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_categorieid.Text == "" || txt_categoriename.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                   MySqlConnection con = new MySqlConnection(db.dbcon);

                    con.Open();

                    String str = "Insert Into db_categories (catid,catname)Values('" + txt_categorieid.Text + "','" + txt_categoriename.Text + "')";

                    MySqlCommand cmd = new MySqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(catid) From db_categories";

                    MySqlCommand cmd2 = new MySqlCommand(str2, con);

                    MySqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();

                        MessageBox.Show("Categories Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        auto();

                        con.Close();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txt_categorieid.Clear();
            txt_categoriename.Clear();
        }

        private void showdata()
        {
          


            MySqlConnection con = new MySqlConnection(db.dbcon);

            con.Open();

            String str = "Select * From db_categories";

            MySqlCommand cmd = new MySqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            db_categoriesDataGridView.AutoGenerateColumns = false;

            db_categoriesDataGridView.DataSource = dt;

            con.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_categorieid.Text == "" || txt_categoriename.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                   MySqlConnection con = new MySqlConnection(db.dbcon);

                    con.Open();

                    String str = "Update db_categories Set catname = '" + txt_categoriename.Text + "' Where catid = '" + txt_categorieid.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(catid) From db_categories";

                    MySqlCommand cmd2 = new MySqlCommand(str2, con);

                    MySqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();

                        MessageBox.Show("Categories Updated Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

                        auto();

                        con.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_categorieid.Text == "" || txt_categoriename.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                   MySqlConnection con = new MySqlConnection(db.dbcon);

                    con.Open();

                    String str = "Delete From db_categories Where catid = '" + txt_categorieid.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    showdata();

                    MessageBox.Show("User Delete Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();

                    auto();

                    con.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void pcb_serch_Click(object sender, EventArgs e)
        {
           MySqlConnection con = new MySqlConnection(db.dbcon);

            con.Open();

            String str = "Select catid,catname From db_categories Where catid = '" + txt_categorieid.Text + "'";

            MySqlCommand cmd = new MySqlCommand(str, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_categorieid.Text = dr.GetValue(0).ToString();
                txt_categoriename.Text = dr.GetValue(1).ToString();
            }

            con.Close();
        }

        private void pcb_search1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(db.dbcon);
            
            con.Open();

            String str = "Select catid,catname From db_categories Where catname = '" + txt_categoriename.Text + "'";

            MySqlCommand cmd = new MySqlCommand(str, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_categorieid.Text = dr.GetValue(0).ToString();
                txt_categoriename.Text = dr.GetValue(1).ToString();
            }

            con.Close();

        }

      

        private void UC_categories_Load(object sender, EventArgs e)
        {
            auto();
            showdata();
        }

        private void db_categoriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;

                index = e.RowIndex;

                DataGridViewRow dgvr = db_categoriesDataGridView.Rows[index];

                txt_categorieid.Text = dgvr.Cells[0].Value.ToString();
                txt_categoriename.Text = dgvr.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
