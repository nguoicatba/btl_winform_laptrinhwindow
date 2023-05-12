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
    public partial class xep_lop : Form
    {
        SqlConnection connection = null ;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string cmd;
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
        public void loaddata(string s)
        {
                check();
                command = connection.CreateCommand();
                command.CommandText = s;
                table.Clear();
                adapter.SelectCommand = command;
                adapter.Fill(table);
                dgv_xep_lop.DataSource = table;
                connection.Close();
           
            
        }
        public xep_lop()
        {
            InitializeComponent();
        }

        private void xep_lop_Load(object sender, EventArgs e)
        {
            
            cb_ht_trang_thai.Text = "Nhập học";
            cb_ht_lophoc.Enabled = false;
            cb_td_trang_thai.Text = "khối 1";
           
            // xử lý  cb_td_trang_thai.Text 

           cmd = "select id_student ,name_student,ngaysinh ,gender from student  where id_class is null";
            loaddata(cmd);

        }

        private void cb_ht_trang_thai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ht_trang_thai.Text == "Nhập học")
            {
                cb_ht_lophoc.Enabled = false;
                 cmd = "select id_student ,name_student,ngaysinh ,gender from student  where id_class is null";
                loaddata(cmd);
            }
            else
            {
                cb_ht_lophoc.Enabled = true;
                cmd = "select id_student ,name_student,ngaysinh ,gender from (student left join lophoc on student.id_class = lophoc.id_class) left join khoi on lophoc.id_khoi = khoi.id_khoi  where name_khoi = N'" + cb_ht_trang_thai.Text + "'";
                loaddata(cmd);
                check();
                command = connection.CreateCommand();
                cb_ht_lophoc.Items.Clear();
                command.CommandText = "select name_class from lophoc left join khoi on lophoc.id_khoi = khoi.id_khoi where name_khoi = N'" + cb_ht_trang_thai.Text + "'";
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    cb_ht_lophoc.Items.Add(rd[0].ToString());
                }
                rd.Close();

            }

        }

        private void cb_td_trang_thai_SelectedIndexChanged(object sender, EventArgs e)
        {
            check();
            command = connection.CreateCommand();
            cb_td_lophoc.Items.Clear();
            command.CommandText = "select name_class from lophoc left join khoi on lophoc.id_khoi = khoi.id_khoi where name_khoi = N'" + cb_td_trang_thai.Text + "'";
            SqlDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_td_lophoc.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_xep_lop.CurrentRow != null)
            {
                int row = dgv_xep_lop.CurrentRow.Index;
                string thaydoi = dgv_xep_lop.Rows[row].Cells[0].Value.ToString();
                check();
                command = connection.CreateCommand();
                string kq = "";
                if (cb_td_lophoc.Text != "")
                {
                    command.CommandText = "select id_class from lophoc where name_class=N'" + cb_td_lophoc.Text + "'";
                    SqlDataReader rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        kq = rd[0].ToString();
                    }
                    rd.Close();
                    command = connection.CreateCommand();
                    command.CommandText = "update student set id_class=N'" + kq + "' where id_student=N'" + thaydoi + "'";
                    command.ExecuteNonQuery();
                    loaddata(cmd);
                }
            }
            else
            {
                MessageBox.Show("Không còn học sinh");

            }
            
          
           
            
            

        }

        private void dgv_xep_lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cb_ht_lophoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           cmd= "select id_student ,name_student,ngaysinh ,gender from student left join lophoc on student.id_class = lophoc.id_class where name_class= N'"+cb_ht_lophoc.Text+"'";
            loaddata(cmd);
        }
    }
}
