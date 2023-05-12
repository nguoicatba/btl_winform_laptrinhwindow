using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace btl_winform
{
    public partial class change_pass : Form
    {
        string tk;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        public change_pass()
        {
            InitializeComponent();
        }

        public change_pass(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        public void check()
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(str);
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi connection");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_pass_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            check();
            if (tk != null)
            {   
                tb_tentk.Text = tk;
                tb_tentk.ReadOnly = true;
            }
            else
            {
                tb_tentk.ReadOnly = false;
            }
        }

        private void bt_change_mk_Click(object sender, EventArgs e)
        {
            check();
           foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                    {
                        TextBox ck = (TextBox) c;
                        ck.Focus();
                        MessageBox.Show("Nhập đủ thông tin !");
                        return;
                    }
                }
            }
            command = connection.CreateCommand();
            command.CommandText = "select taikhoan,matkhau from nguoidung where taikhoan =N'"+tb_tentk.Text+"'";
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {
                string ck_mk = rd[1].ToString();
                rd.Close();
                if (tb_cur_mk.Text != ck_mk)
                {
                    MessageBox.Show("Mật khẩu không tồn tại");
                }
                else
                {
                    if (tb_new_mk.Text != tb_again_mk.Text)
                    {
                        MessageBox.Show("Mật khẩu mới và Nhập lại mật khẩu mới không ăn khớp với nhau");
                    }
                    else
                    {
                        command.CommandText ="update nguoidung set matkhau=N'"+tb_new_mk.Text+"' where taikhoan=N'"+tb_tentk.Text+"'" ;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.Close();
                    }
                }


            }
            else
            {
                rd.Close();
                MessageBox.Show("Tài khoản không tồn tại");
            }
           
        }
    }
}
