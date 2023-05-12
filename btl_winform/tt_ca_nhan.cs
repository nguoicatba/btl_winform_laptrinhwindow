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
    public partial class tt_ca_nhan : Form
    {    string tk, mk;
        SqlConnection connection = null;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
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
     
        public tt_ca_nhan()
        {
            InitializeComponent();
        }

        public tt_ca_nhan (string tk1, string  mk1)
        {
            InitializeComponent();
            tk = tk1;
            mk = mk1;

        }
        private void tt_ca_nhan_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            check();
            command = connection.CreateCommand();
            command.CommandText = "select idnguoidung from nguoidung where taikhoan =N'" + tk + "' and matkhau=N'" + mk + "' ";
            SqlDataReader rd = command.ExecuteReader();
            rd.Read();
            string id_tk = rd[0].ToString();
          
            rd.Close();
            command.CommandText = "select name_student,ngaysinh,diachi,gender,anh,name_class,id_student from student left join lophoc on student.id_class = lophoc.id_class where id_student=N'"+id_tk+"'";
          
            rd = command.ExecuteReader();
            while (rd.Read())
            {
                tb_hovaten.Text = rd[0].ToString();
                dateTimePicker1.Text = rd[1].ToString();
                tb_diachi.Text = rd[2].ToString();
                tb_gioitinh.Text = rd[3].ToString();
                string anh = rd[4].ToString();
                tb_class.Text = rd[5].ToString();
                tb_mahs.Text = rd[6].ToString();
                if (anh != "")
                {
                    pic_anh.Image = Image.FromFile(anh);
                }
            }

        }
    }
}
