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
    public partial class update_hanhkiem : Form
    {
        SqlConnection connection = null;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string cmd;
        List<string> li = new List<string>();
        public  void xep_hocluc()
        {
            
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
        public void loaddata(string s)
        {
            check();
            command = connection.CreateCommand();
            command.CommandText = s;
            table.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(table);
         dgv_update_hanhkiem.DataSource = table;
            connection.Close();


        }
        public update_hanhkiem()
        {
            InitializeComponent();
        }

        private void bt_hoctap_capnhat_Click(object sender, EventArgs e)
        {
            check();
            if (cb_hanhkiem.Text != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "select id_hanhkiem from score_hanhkiem where loaihanhkiem=N'"+cb_hanhkiem.Text+"' ";
                SqlDataReader rd = command.ExecuteReader();
                rd.Read();
                string id_hk = rd[0].ToString();
                rd.Close();

                command = connection.CreateCommand();
                command.CommandText = "update tk_hocki set id_hanhkiem=N'"+id_hk+"' where id_student =N'"+tb_hk_mahs.Text+"'";
                command.ExecuteNonQuery();
                
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "update tk_hocki set id_hanhkiem=null where id_student =N'" + tb_hk_mahs.Text + "'";
                command.ExecuteNonQuery();
            }
            cmd = "select tk_hocki.id_student,name_student,gender,ngaysinh,loaihanhkiem from (((tk_hocki inner join student on tk_hocki.id_student = student.id_student) left join score_hanhkiem on score_hanhkiem.id_hanhkiem=tk_hocki.id_hanhkiem ) inner join lophoc on lophoc.id_class = student.id_class) inner join hocki on tk_hocki.id_hocki=hocki.id_hocki where name_class=N'" + cb_hk_lop.Text + "' and  name_hocki =N'" + cb_hk_hocki.Text + "'";
            loaddata(cmd);
        }

        private void update_hanhkiem_Load(object sender, EventArgs e)
        {
            check();
            tb_hk_mahs.ReadOnly = true;
            cb_hk_khoi.Text = "khối 1";
            cb_hk_hocki.Text = "học kì 1";
            // khối
            command = connection.CreateCommand();
            command.CommandText = "select name_khoi from khoi ";
            SqlDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hk_khoi.Items.Add(rd[0].ToString());
            }
            rd.Close();
            // hocki
            command = connection.CreateCommand();
            command.CommandText = "select name_hocki from hocki ";
            rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hk_hocki.Items.Add(rd[0].ToString());
            }
            rd.Close();
            // hanhkiem
            cb_hanhkiem.Text = "Tốt";
            command = connection.CreateCommand();
            command.CommandText = "select loaihanhkiem from score_hanhkiem ";
            rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hanhkiem.Items.Add(rd[0].ToString());
            }
            rd.Close();

            // lớp mặc định

            command = connection.CreateCommand();
            cb_hk_lop.Items.Clear();
            string ck = "khối 1";
            command.CommandText = "select name_class from lophoc left join khoi on lophoc.id_khoi = khoi.id_khoi where name_khoi = N'" + ck + "'";
            rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hk_lop.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }

        private void cb_hk_khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            check();
            command = connection.CreateCommand();
            cb_hk_lop.Text = "";
            cb_hk_lop.Items.Clear();
            command.CommandText = "select name_class from lophoc left join khoi on lophoc.id_khoi = khoi.id_khoi where name_khoi = N'" + cb_hk_khoi.Text + "'";
            SqlDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hk_lop.Items.Add(rd[0].ToString());
            }
            rd.Close();
            bt_hk_capnhat.Enabled = false;
        }

        private void cb_hk_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_hk_capnhat.Enabled = false;

        }

        private void cb_hk_hocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_hk_capnhat.Enabled = false;
        }

        private void bt_hoctap_timkiem_Click(object sender, EventArgs e)
        {
            if (cb_hk_lop.Text == "")
                MessageBox.Show("Bạn chưa xét lớp học");
            else
            {
                check();
                command = connection.CreateCommand();
                command.CommandText = "select id_student from student inner join lophoc on student.id_class = lophoc.id_class where name_class=N'" + cb_hk_lop.Text + "'";
                SqlDataReader rd = command.ExecuteReader();
                if (li.Count > 0)
                    li.Clear();
                while (rd.Read())
                {
                    li.Add(rd[0].ToString());
                }
                rd.Close();
                SqlCommand command2 = connection.CreateCommand();
                command2.CommandText = "select id_hocki from hocki where name_hocki=N'" + cb_hk_hocki.Text + "'";
                SqlDataReader rd2 = command2.ExecuteReader();
                rd2.Read();
                string hk = rd2[0].ToString();
                rd2.Close();

                foreach (string c in li)
                {
                    command2.CommandText = "select * from tk_hocki inner join hocki on tk_hocki.id_hocki = hocki.id_hocki   where id_student = N'" + c + "' and name_hocki = N'" + cb_hk_hocki.Text + "'";
                    rd2 = command2.ExecuteReader();
                    if (!rd2.Read())
                    {
                        rd2.Close();

                        command2.CommandText = "insert into  tk_hocki (id_student,id_hocki) values (N'" + c + "',N'" + hk + "')";
                        command2.ExecuteNonQuery();
                    }
                    rd2.Close();
                }
                cmd = "select tk_hocki.id_student,name_student,gender,ngaysinh,loaihanhkiem from (((tk_hocki inner join student on tk_hocki.id_student = student.id_student) left join score_hanhkiem on score_hanhkiem.id_hanhkiem=tk_hocki.id_hanhkiem ) inner join lophoc on lophoc.id_class = student.id_class) inner join hocki on tk_hocki.id_hocki=hocki.id_hocki where name_class=N'" + cb_hk_lop.Text + "' and  name_hocki =N'" + cb_hk_hocki.Text + "'";
                loaddata(cmd);

            }
            tb_hk_mahs.Text = "";

        }

        private void dgv_update_hanhkiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_update_hanhkiem.CurrentRow != null)
            {
                bt_hk_capnhat.Enabled = true;
                int row = dgv_update_hanhkiem.CurrentRow.Index;
                tb_hk_mahs.Text = dgv_update_hanhkiem.Rows[row].Cells[0].Value.ToString();
                cb_hanhkiem.Text = dgv_update_hanhkiem.Rows[row].Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Hiện tại chưa có học sinh trong lớp học này");
            }
        }
    }
}
