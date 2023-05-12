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
    public partial class subject : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
       
        public void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from monhoc";
            table.Clear();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dgv_subject.DataSource = table;

        }
        public subject()
        {
            InitializeComponent();
        }

        private void subject_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            bt_delete_subject.Enabled = false;
            bt_fix_subject.Enabled = false;

        }

        private void bt_add_subject_Click(object sender, EventArgs e)
        {   if (cb_hinhthuc.Text == "")
                MessageBox.Show("Lựa chọn hình thức đánh giá");
            else
            {
                int len;
                if (cb_hinhthuc.Text == "Nhận xét")
                    len = 1;
                else
                    len = 0;
                command = connection.CreateCommand();
                command.CommandText = "insert  into monhoc values(N'" + tb_id_subject.Text + "',N'" + tb_name_subject.Text + "',"+len+")";
                command.ExecuteNonQuery();
                loaddata();
            }
        }

        private void bt_delete_subject_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from monhoc where id_subject=N'" + tb_id_subject.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void dgv_subject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          tb_id_subject.ReadOnly = true;
            int row = dgv_subject.CurrentRow.Index;
           tb_id_subject.Text = dgv_subject.Rows[row].Cells[0].Value.ToString();
           tb_name_subject.Text = dgv_subject.Rows[row].Cells[1].Value.ToString();
            string hinhthuc= dgv_subject.Rows[row].Cells[2].Value.ToString();
            if (hinhthuc == "1")
                cb_hinhthuc.Text = "Nhận xét";
            else
                cb_hinhthuc.Text = "Chấm điểm";
            bt_add_subject.Enabled = false;
            bt_delete_subject.Enabled = true;
            bt_fix_subject.Enabled = true;
        }

        private void bt_set_subject_Click(object sender, EventArgs e)
        {
            tb_id_subject.ReadOnly = false;
            tb_id_subject.Text = "";
            tb_name_subject.Text = "";
            bt_add_subject.Enabled = true;
            bt_delete_subject.Enabled = false;
            bt_fix_subject.Enabled = false;
            cb_hinhthuc.Text = "";
        }

        private void bt_fix_subject_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from monhoc where id_subject = N'"+tb_id_subject.Text+"'";
            SqlDataReader reader1 = command.ExecuteReader();
            if (reader1.Read())
            {
                int len;
                if (cb_hinhthuc.Text == "Nhận xét")
                    len = 1;
                else
                    len = 0;
                reader1.Close();
                command.CommandText = "update monhoc set name_subject = N'" + tb_name_subject.Text + "',hinhthuc ="+len+" where id_subject =N'" + tb_id_subject.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
            }
            else
            {
                reader1.Close();
                MessageBox.Show("Môn học này không tồn tại ");
            }
           
        }

        private void subject_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void dgv_subject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_name_subject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
