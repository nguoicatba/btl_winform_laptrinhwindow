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
    
    public partial class update_acc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataTable table = new DataTable();
       
        public void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from nguoidung";
            table.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dgv_acc.DataSource = table;
           
        }

        public update_acc()
        {
            InitializeComponent();
        }

        private void dgv_acc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_acc_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            tb_idtaikhoan.ReadOnly = true;
            bt_del_acc.Enabled = false;
            bt_fix_acc.Enabled = false;

            
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string id_tk="";
            if (tb_tentaikhoan.Text == "") ok = false;
            if (tb_matkhau.Text == "") ok = false;
            int i = -1;
            if (cb_quyenhan.Text == "Quản trị viên")
            {
                i = 0;
                id_tk = "QTV";
            }
            else if (cb_quyenhan.Text == "Nhân viên văn phòng")
            {
                i = 1;
                id_tk = "NV";
            }
            else if (cb_quyenhan.Text == "Giáo viên")
            {
                i = 2;
                id_tk = "GV";
            }
            else if (cb_quyenhan.Text == "Học sinh")
            {
                i = 3;
                id_tk = "HS";
            }
            else
                i = -1;
            if (i == -1)
                ok = false;
            if (id_tk != "")
                id_tk = id_tk + tb_tentaikhoan.Text;
            command = connection.CreateCommand();
           
            if (ok)
            {
                if (tb_tentaikhoan.Text.Length > 20 || tb_matkhau2.Text.Length > 20)
                    MessageBox.Show("Độ dài tối đa 20 kí tự");
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = "select * from nguoidung where taikhoan=N'" + tb_tentaikhoan.Text + "'";
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        MessageBox.Show("Tên tài khoản tồn tại");
                        rd.Close();
                    }
                    else
                    {
                        rd.Close();
                        command = connection.CreateCommand();
                        command.CommandText = "insert into nguoidung(idnguoidung,taikhoan,matkhau,quyen) values (N'" + id_tk + "',N'" + tb_tentaikhoan.Text + "',N'" + tb_matkhau2.Text + "'," + i + ")";
                        command.ExecuteNonQuery();
                        loaddata();
                    }
                }
            }
            else
            {  
                
                    MessageBox.Show("Nhập đủ thông tin");
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from nguoidung where idnguoidung=N'" + tb_idtaikhoan.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            bool ok = true;
            string id_tk = "";
            if (tb_tentaikhoan.Text == "") ok = false;
            if (tb_matkhau.Text == "") ok = false;
            int i = -1;
            if (cb_quyenhan.Text == "Quản trị viên")
            {
                i = 0;
                id_tk = "QTV";
            }
            else if (cb_quyenhan.Text == "Nhân viên văn phòng")
            {
                i = 1;
                id_tk = "NV";
            }
            else if (cb_quyenhan.Text == "Giáo viên")
            {
                i = 2;
                id_tk = "GV";
            }
            else if (cb_quyenhan.Text == "Học sinh")
            {
                i = 3;
                id_tk = "HS";
            }
            else
                i = -1;
            if (i == -1)
                ok = false;
            if (id_tk != "")
                id_tk = id_tk + tb_tentaikhoan.Text;
            command = connection.CreateCommand();
            command.CommandText = "select * from nguoidung where taikhoan ='" + id_tk + "'";
            
            SqlDataReader rd = command.ExecuteReader();
            if (!rd.Read())
            {
                rd.Close();
                command = connection.CreateCommand();
                command.CommandText = "update nguoidung set idnguoidung = N'" + id_tk + "', taikhoan = N'" + id_tk+ "',matkhau = N'" + tb_matkhau2.Text + "',quyen =" + i + " where idnguoidung =N'" + tb_idtaikhoan.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
            }
            else
            {
                rd.Close();
                MessageBox.Show("Tài khoản đã tồn tại");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_acc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idtaikhoan.ReadOnly = true;
            int row = dgv_acc.CurrentRow.Index;
            tb_idtaikhoan.Text = dgv_acc.Rows[row].Cells[0].Value.ToString();
  
           
          
            string ck_tk = dgv_acc.Rows[row].Cells[1].Value.ToString();
            string kq = "";
            for (int i = 0; i < ck_tk.Length; ++i)
                if (ck_tk[i] >= '0' && ck_tk[i] <= '9')
                    kq += ck_tk[i];
            tb_tentaikhoan.Text = kq;
            tb_matkhau2.Text = dgv_acc.Rows[row].Cells[2].Value.ToString();
            if (dgv_acc.Rows[row].Cells[3].Value.ToString() == "0")
            {
                cb_quyenhan.Text = "Quản trị viên";
            }
            else if (dgv_acc.Rows[row].Cells[3].Value.ToString() == "1")
                cb_quyenhan.Text = "Nhân viên văn phòng";
            else if (dgv_acc.Rows[row].Cells[3].Value.ToString() == "2")
                cb_quyenhan.Text = "Giáo viên";
            else
                cb_quyenhan.Text = "Học sinh";

            bt_insert.Enabled = false;
            bt_del_acc.Enabled = true;
            bt_fix_acc.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_idtaikhoan.Text = "";
            tb_idtaikhoan.ReadOnly = true;
            tb_tentaikhoan.Text = "";
            tb_matkhau2.Text = "";
            bt_insert.Enabled = true;
            bt_del_acc.Enabled = false;
            bt_fix_acc.Enabled = false;

        }

        private void tb_tentaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
