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
    public partial class update_class : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select id_class as Mã_lớp,name_class as Tên_Lớp, soluong_class as Sĩ_số,name_khoi as Khối from lophoc left join khoi on lophoc.id_khoi = khoi.id_khoi";
            table.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dgv_update_class.DataSource = table;

        }
        public update_class()
        {
            InitializeComponent();
        }

        private void tb_id_subject_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_class_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            bt_fix_class.Enabled = false;
            bt_delete_class.Enabled = false;

            connection = new SqlConnection(str);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select name_khoi from khoi";
            var dr = command.ExecuteReader();
            cb_khoi.Items.Clear();
            while (dr.Read())
            {
                cb_khoi.Items.Add(dr[0].ToString());
            }
            dr.Close();
         

            loaddata();
            

        }

        private void cb_khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_add_subject_Click(object sender, EventArgs e)
        { bool check_updateclass = false;
           foreach (Control c in gb_update_class.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                        check_updateclass = true;
                }
                else  if  ( c is ComboBox)
                {
                    if (c.Text == "")
                        check_updateclass = true;
                }
            }
            if (check_updateclass == true)
                MessageBox.Show("Nhập đầy đủ thông tin");
            else
            {
                string ID_class = "LH" + tb_id_class.Text;
                command = connection.CreateCommand();
                command.CommandText = "select * from lophoc where id_class = N'" + ID_class + "' ";
                SqlDataReader rd = command.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("Lớp học đã tồn tại");
                    rd.Close();
                }
                else
                {
                    rd.Close();
                    command.CommandText = "select id_khoi from khoi where name_khoi=N'" + cb_khoi.Text + "'";
                    rd = command.ExecuteReader();
                    rd.Read();
                    string makhoi = rd[0].ToString();
                    rd.Close();
                    command.CommandText = "insert into lophoc values(N'" + ID_class + "',N'" + tb_name_class.Text + "',"+tb_siso.Text+ ",N'"+makhoi+"')";
                    command.ExecuteNonQuery();
                    loaddata();
                }
            }

        }

        private void tb_id_class_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgv_update_class_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id_class.ReadOnly = true;
            bt_add_class.Enabled = false;
            bt_fix_class.Enabled = true;
            bt_delete_class.Enabled = true;
            if (dgv_update_class.CurrentRow != null)
            {
                int row = dgv_update_class.CurrentRow.Index;
                tb_id_class.Text = dgv_update_class.Rows[row].Cells[0].Value.ToString();
                tb_name_class.Text = dgv_update_class.Rows[row].Cells[1].Value.ToString();
                tb_siso.Text = dgv_update_class.Rows[row].Cells[2].Value.ToString();
                cb_khoi.Text = dgv_update_class.Rows[row].Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Hiện lớp học chưa có , vui lòng cập nhật");
            }
        }

        private void bt_set_class_Click(object sender, EventArgs e)
        {
            tb_id_class.ReadOnly = false;
            bt_add_class.Enabled = true;
            bt_fix_class.Enabled = false;
            bt_delete_class.Enabled = false;
            foreach (Control c in gb_update_class.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                
            }
            
        }

        private void bt_fix_class_Click(object sender, EventArgs e)
        {   
            command = connection.CreateCommand();
            command.CommandText = "select id_khoi from khoi where name_khoi=N'" + cb_khoi.Text + "'";
            SqlDataReader rd = command.ExecuteReader();
            string makhoi;
            if (rd.Read())
            {
                makhoi = rd[0].ToString();
                rd.Close();
                command.CommandText = "update lophoc set name_class =N'" + tb_name_class.Text + "',soluong_class =" + tb_siso.Text + ",id_khoi=N'" + makhoi + "' where id_class=N'"+tb_id_class.Text+"'";
                command.ExecuteNonQuery();
                loaddata();
            }
            else
            {
                rd.Close();
                MessageBox.Show("Lỗi khối ");

            }
           
        }

        private void bt_delete_class_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from lophoc where id_class=N'" + tb_id_class.Text + "'";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không:\n" + tb_id_class.Text + "\n" + tb_name_class.Text, "Xóa thông tin", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
