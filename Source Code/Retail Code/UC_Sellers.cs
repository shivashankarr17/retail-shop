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
    public partial class UC_Sellers : UserControl
    {
        dbconnection db = new dbconnection();
        public UC_Sellers()
        {
            InitializeComponent();
        }

      

        private void UC_Sellers_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void showdata()
        {
           MySqlConnection con = new MySqlConnection(db.dbcon);
            
            con.Open();

            String str = "Select * From db_user";

            MySqlCommand cmd = new MySqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            db_userDataGridView.AutoGenerateColumns = false;

            db_userDataGridView.DataSource = dt;

            con.Close();
        }

        private void pcb_serchbyname_Click(object sender, EventArgs e)
        {
           MySqlConnection con = new MySqlConnection(db.dbcon);
            
            con.Open();

            String str = "Select username,ufullname,upassword,umobailno From db_user Where username = '" + txt_Username.Text + "'";

            MySqlCommand cmd = new MySqlCommand(str, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_Username.Text = dr.GetValue(0).ToString();
                txt_fullname.Text = dr.GetValue(1).ToString();
                txt_Password.Text = dr.GetValue(2).ToString();
                txt_mobailno.Text = dr.GetValue(3).ToString();
            }

            con.Close();
        
        }

        private void pcb_serchbyfullname_Click(object sender, EventArgs e)
        {
           MySqlConnection con = new MySqlConnection(db.dbcon);
            
            con.Open();

            String str = "Select username,ufullname,upassword,umobailno From db_user Where ufullname = '" + txt_fullname.Text + "'";

            MySqlCommand cmd = new MySqlCommand(str, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txt_Username.Text = dr.GetValue(0).ToString();
                txt_fullname.Text = dr.GetValue(1).ToString();
                txt_Password.Text = dr.GetValue(2).ToString();
                txt_mobailno.Text = dr.GetValue(3).ToString();
            }

            con.Close();
      
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "" || txt_fullname.Text == "" || txt_mobailno.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                   MySqlConnection con = new MySqlConnection(db.dbcon);
            
                    con.Open();

                    String str = "Insert Into db_user (username,ufullname,upassword,umobailno)Values('" + txt_Username.Text + "','" + txt_fullname.Text + "','" + txt_Password.Text + "','" + txt_mobailno.Text + "')";

                    MySqlCommand cmd = new MySqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(username) From db_user";

                    MySqlCommand cmd2 = new MySqlCommand(str2, con);

                    MySqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();

                        MessageBox.Show("User Created Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

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
            txt_fullname.Clear();
            txt_mobailno.Clear();
            txt_Password.Clear();
            txt_Username.Clear();
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "" || txt_fullname.Text == "" || txt_mobailno.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                   MySqlConnection con = new MySqlConnection(db.dbcon);
            
                    con.Open();

                    String str = "Update db_user Set ufullname = '" + txt_fullname.Text + "',upassword = '" + txt_Password.Text + "',umobailno = '" + txt_mobailno.Text + "' Where username = '" + txt_Username.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str2 = "Select max(username) From db_user";

                    MySqlCommand cmd2 = new MySqlCommand(str2, con);

                    MySqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        showdata();

                        MessageBox.Show("User Updated Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clear();

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
                if (txt_Username.Text == "" || txt_Password.Text == "" || txt_fullname.Text == "" || txt_mobailno.Text == "")
                {
                    MessageBox.Show("Please , Insert all Information ... ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                   MySqlConnection con = new MySqlConnection(db.dbcon);
            
                    con.Open();

                    String str = "Delete From db_user Where username = '" + txt_Username.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    showdata();

                    MessageBox.Show("User Delete Successfull ....", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;

                index = e.RowIndex;

                DataGridViewRow dgvr = db_userDataGridView.Rows[index];

                txt_Username.Text = dgvr.Cells[0].Value.ToString();
                txt_fullname.Text = dgvr.Cells[1].Value.ToString();
                txt_Password.Text = dgvr.Cells[2].Value.ToString();
                txt_mobailno.Text = dgvr.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
