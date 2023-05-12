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
    public partial class update_student : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string filename = "";
        public void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select id_student,name_student,ngaysinh,gender,anh,diachi from student";
            table.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dgv_updatestudent.DataSource = table;

        }
        public update_student()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            int i = dgv_updatestudent.CurrentRow.Index;
            tb_mahs.ReadOnly = true;
          
        }

        private void update_student_Load(object sender, EventArgs e)
        {
            bt_del_stu.Enabled = false;
            bt_fix_stu.Enabled = false;
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check_ctrol = false;
            foreach (Control c in gb_student.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "")
                        check_ctrol = true;
                }
                else if (c is DateTimePicker)
                {
                    if (c.Text == "")
                        check_ctrol = true;
                }
                else if (c is ComboBox)
                {
                    if (c.Text == "")
                        check_ctrol = true;
                }

            }
            if (check_ctrol==  true)
            {
                MessageBox.Show("Mong bạn điển đầy đủ thông tin");
                return;
            }

            string id_hocsinh = "HS" + tb_mahs.Text;
            command = connection.CreateCommand();
            command.CommandText = "select * from nguoidung where idnguoidung =N'" + id_hocsinh + "'";
            SqlDataReader rd = command.ExecuteReader();
            if (id_hocsinh.Length > 20)
            {
                MessageBox.Show("Độ dài kí tự vừa nhập ko vượt quá 18");
                rd.Close();
            }
            
           else if (rd.Read())
            {
                MessageBox.Show("Mã học sinh đã tồn tại vui lòng nhập lại");
                rd.Close();
            }

            else
            {
                rd.Close();

                command = connection.CreateCommand();
                command.CommandText = "insert into student(id_student,name_student,ngaysinh,gender,anh,diachi) values(N'" + id_hocsinh+ "',N'" + tb_tenhs.Text + "',N'" + dateTimePicker1.Text + "',N'" + cb_gioitinh.Text + "',N'" + filename + "',N'" + tb_diachi.Text + "' )";
                command.ExecuteNonQuery();
                loaddata();
                command.CommandText = "insert into tk_hocki(id_student,id_hocki) values (N'" + id_hocsinh + "',N'HOCKI01')";
                command.ExecuteNonQuery();
                command.CommandText = "insert into tk_hocki(id_student,id_hocki) values (N'" + id_hocsinh + "',N'HOCKI02')";
                command.ExecuteNonQuery();

                command.CommandText = "insert into nguoidung values (N'"+id_hocsinh+"',N'"+id_hocsinh+"',N'kiencb1234',3)";
                command.ExecuteNonQuery();
                filename = "";
            }
        }

        private void pb_anh_Click(object sender, EventArgs e)
        {
            pb_anh.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog mofile = new OpenFileDialog();
            if (mofile.ShowDialog() == DialogResult.OK)
            {
                filename = mofile.FileName;
            }
            else
            {
                filename = "";
            }
            if (filename != "")
            {
                
                pb_anh.Image = Image.FromFile(filename);
                
            }
        }

        private void dgv_updatestudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_updatestudent.CurrentRow.Index;
            tb_mahs.ReadOnly = true;
            tb_mahs.Text= dgv_updatestudent.Rows[i].Cells[0].Value.ToString();
            tb_tenhs.Text = dgv_updatestudent.Rows[i].Cells[1].Value.ToString();
            dateTimePicker1.Text = dgv_updatestudent.Rows[i].Cells[2].Value.ToString();
            cb_gioitinh.Text= dgv_updatestudent.Rows[i].Cells[3].Value.ToString();
            try
            {
               filename= dgv_updatestudent.Rows[i].Cells[4].Value.ToString();
                Image a = Image.FromFile(filename);
                pb_anh.Image = a;
                pb_anh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {   
                MessageBox.Show("Ảnh lỗi vui lòng cập nhật lại");
            }
            tb_diachi.Text= dgv_updatestudent.Rows[i].Cells[5].Value.ToString();
            bt_del_stu.Enabled = true;
            bt_fix_stu.Enabled = true;
            bt_add_stu.Enabled = false;

        }

        private void dgv_updatestudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tk_hocki where id_student=N'" + tb_mahs.Text + "' ";
            command.ExecuteNonQuery();
            command = connection.CreateCommand();
            command.CommandText = "delete from nguoidung where idnguoidung=N'"+tb_mahs.Text+"' ";
            command.ExecuteNonQuery();
            command = connection.CreateCommand();
            command.CommandText = "delete from student where id_student=N'" + tb_mahs.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_mahs.ReadOnly=false;
            tb_mahs.Text = "";
            tb_tenhs.Text = "";
            tb_diachi.Text = "";
            pb_anh.Image = null;
            bt_del_stu.Enabled = false;
            bt_fix_stu.Enabled = false;
            bt_add_stu.Enabled = true;
        }

        private void tb_mahs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_tenhs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_diachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update student set name_student =N'" + tb_tenhs.Text + "',ngaysinh=N'" + dateTimePicker1.Text + "',gender =N'" + cb_gioitinh.Text + "',diachi=N'" + tb_diachi.Text + "' where id_student=N'" + tb_mahs.Text + "'";
            command.ExecuteNonQuery();
            if (filename != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "update student set anh=N'" + filename + "' where id_student=N'" + tb_mahs.Text + "'";
                command.ExecuteNonQuery();
            }
            loaddata();
        }

        private void tb_mahs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
