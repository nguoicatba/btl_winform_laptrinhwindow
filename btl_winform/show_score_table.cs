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
    public partial class show_score_table : Form
    {
        string tk;
        SqlConnection connection = null;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string cmd;
        public bool check_dulieu(string cd)
        {
            check();
            command = connection.CreateCommand();
            command.CommandText = cd;
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {
                rd.Close();
                return true;
            }
            else
            {
                rd.Close();
                return false;
            }
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
            dgv_bangdiem.DataSource = table;
            connection.Close();


        }
        public show_score_table()
        {
            InitializeComponent();
        }

        public show_score_table(string tk)
        {
            this.tk = tk;
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void show_score_table_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            check();
            if (tk != "")
            {
                command = connection.CreateCommand();
                command.CommandText = "select name_student,name_class from (student inner join nguoidung on nguoidung.idnguoidung=student.idnguoidung) left join lophoc on student.id_class = lophoc.id_class where nguoidung.idnguoidung=N'" + tk + "'";
                SqlDataReader rd = command.ExecuteReader();
                if (rd.Read())
                {
                    lb_hotenhs.Text += " " + rd[0].ToString();
                    if (rd[1].ToString() != "")
                        lb_hsclass.Text += " " + rd[1].ToString();
                    else
                    {
                        rd.Close();
                        MessageBox.Show("Chưa có lớp học nên bảng điểm tạm thời đóng");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản chưa có người sử dụng nên chức năng này không sử dụng được");

                }
                rd.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
            command = connection.CreateCommand();
            command.CommandText = "select id_hocluc,id_hanhkiem,diem_tbhk from tk_hocki where id_student=N'" + tk + "' and id_hocki =N'HOCKI01'";
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            { 
                lb_dtbm.Text = rd[2].ToString();
            string hk = rd[1].ToString();
            string hl = rd[0].ToString();
            rd.Close();
                if (hk != "")
                {
                    command.CommandText = "select loaihanhkiem from score_hanhkiem where id_hanhkiem=N'" + hk + "'";
                    rd = command.ExecuteReader();
                    rd.Read();
                    lb_hk.Text = rd[0].ToString();
                    rd.Close();
                }
                else
                    lb_hk.Text = "";
                if (hl != "")
                {

                    command.CommandText = "select loai_hocluc from score_hocluc where id_hocluc=N'" + hl + "'";
                    rd = command.ExecuteReader();
                    rd.Read();
                    lb_hl.Text = rd[0].ToString();
                    rd.Close();
                }
                else
                    lb_hl.Text = "";

                if (lb_hl.Text != "" && lb_hk.Text != "")
                {
                    if (lb_hl.Text == "Giỏi" && lb_hk.Text == "Tốt")
                        lb_dh.Text = "Học sinh giỏi";
                    else if ((lb_hl.Text == "Giỏi" || lb_hl.Text == "Khá") && (lb_hk.Text == "Tốt" || lb_hk.Text == "Khá"))
                        lb_dh.Text = "Học sinh tiên tiến";
                    else
                        lb_dh.Text = "Không có danh hiệu";
                }
                else
                    lb_dh.Text = "";
        }
            else
            {
                lb_dtbm.Text = "";
                lb_hk.Text = "";
                lb_hl.Text = "";
                rd.Close();
            }
           
            cmd = "select name_subject as Môn_học,diem_dgtx as Điểm_ĐGTX,diem_dk as Điểm_Giữa_kỳ,diem_ck as Điểm_Cuối_kỳ,diem_hk_tbm Điểm_TBM from (hocsinh_monhoc left join monhoc on hocsinh_monhoc.id_subject=monhoc.id_subject) inner join hocki on hocsinh_monhoc.id_hocki=hocki.id_hocki where id_student='" + tk+"' and name_hocki=N'học kì 1'";
            loaddata(cmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check();
            command = connection.CreateCommand();
            command.CommandText = "select id_hocluc,id_hanhkiem,diem_tbhk from tk_hocki where id_student=N'" + tk + "' and id_hocki =N'HOCKI02'";
            SqlDataReader rd = command.ExecuteReader();
            if (rd.Read())
            {
                lb_dtbm.Text = rd[2].ToString();
                string hk = rd[1].ToString();
                string hl = rd[0].ToString();
                rd.Close();
                if (hk != "")
                {
                    command.CommandText = "select loaihanhkiem from score_hanhkiem where id_hanhkiem=N'" + hk + "'";
                    rd = command.ExecuteReader();
                    rd.Read();
                    lb_hk.Text = rd[0].ToString();
                    rd.Close();
                }
                else
                    lb_hk.Text = "";
                if (hl != "")
                {

                    command.CommandText = "select loai_hocluc from score_hocluc where id_hocluc=N'" + hl + "'";
                    rd = command.ExecuteReader();
                    rd.Read();
                    lb_hl.Text = rd[0].ToString();
                    rd.Close();
                }
                else
                    lb_hl.Text = "";

                if (lb_hl.Text != "" && lb_hk.Text != "")
                {
                    if (lb_hl.Text == "Giỏi" && lb_hk.Text == "Tốt")
                        lb_dh.Text = "Học sinh giỏi";
                    else if ((lb_hl.Text == "Giỏi" || lb_hl.Text == "Khá") && (lb_hk.Text == "Tốt" || lb_hk.Text == "Khá"))
                        lb_dh.Text = "Học sinh tiên tiến";
                    else
                        lb_dh.Text = "Không có danh hiệu";
                }
                else
                    lb_dh.Text = "";
            }
            else
            {
                lb_dtbm.Text = "";
                lb_hk.Text = "";
                lb_hl.Text = "";
                rd.Close();
            }

            cmd = "select name_subject as Môn_học,diem_dgtx as Điểm_ĐGTX,diem_dk as Điểm_Giữa_kỳ,diem_ck as Điểm_Cuối_kỳ,diem_hk_tbm Điểm_TBM from (hocsinh_monhoc left join monhoc on hocsinh_monhoc.id_subject=monhoc.id_subject) inner join hocki on hocsinh_monhoc.id_hocki=hocki.id_hocki where id_student='" + tk + "' and name_hocki=N'học kì 2'";
            loaddata(cmd);
        }
    }
}
