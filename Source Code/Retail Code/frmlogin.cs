﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Retail
{
    public partial class frmlogin : Form
    {
        dbconnection db = new dbconnection();

        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
            lbl_admin.Visible = false;
            lbl_userlogin.Visible = false;
            btn_login_2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(db.dbcon);

            MySqlCommand cmd = new MySqlCommand();

            DataTable dt = new DataTable();

            try
            {
                if (txt_Username.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    con.Open();

                    cmd = con.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "Select * From db_user Where username = '" + txt_Username.Text + "' and upassword = '" + txt_Password.Text + "'";

                    cmd.ExecuteNonQuery();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        this.Hide();
                        frmHome fh = new frmHome();
                        fh.btn_sellers.Visible = false;
                        fh.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
     
        }

        private void label6_Click(object sender, EventArgs e)
        {
            lbl_admin.Visible = true;
            lbl_userlogin.Visible = true;
            btn_login_2.Visible = true;
            lbl_adminlogin.Visible = false;
        }

        private void lbl_userlogin_Click(object sender, EventArgs e)
        {

            lbl_admin.Visible = false;
            lbl_userlogin.Visible = false;
            btn_login_2.Visible = false;
            lbl_adminlogin.Visible = true;
        }

        private void btn_login_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "admin" && txt_Password.Text == "admin")
                {
                    this.Hide();
                    frmHome fh = new frmHome();
                    fh.ShowDialog();
                 
                }
                else
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
