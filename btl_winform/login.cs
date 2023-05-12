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
    public partial class login : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from nguoidung where taikhoan='" + textBox1.Text + "' and matkhau='" + textBox2.Text + "'";
            SqlDataReader reader1 = command.ExecuteReader();
            if (reader1.Read())
            {
                int phanquyen = int.Parse(reader1[3].ToString());
                if (phanquyen == 3)
                {
                    only_student kien = new only_student(textBox1.Text, textBox2.Text);
                    kien.ShowDialog();
                }
                else
                {
                    main kien = new main(textBox1.Text,textBox2.Text);
                    kien.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn nhập sai");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change_pass kien = new change_pass();
            kien.ShowDialog();
        }
    }
}
