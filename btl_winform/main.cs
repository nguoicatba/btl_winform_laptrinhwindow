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
    public partial class main : Form
    {
        string tk;
        string mk;
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
        public main()
        {
            InitializeComponent();
        }
        public main (string a,string b)
        {
            InitializeComponent();
            tk = a;
            mk = b;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void taoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_acc kien = new update_acc();
            kien.ShowDialog();
        }

        private void quẩnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void cậpNhậtDanhMụcHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_student kien = new update_student();

            kien.ShowDialog();
           
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = "Chào mừng bạn đăng nhập: " + tk;
            check();
            command = connection.CreateCommand();
            command.CommandText = "select quyen from nguoidung where idnguoidung=N'"+tk+"'";
            SqlDataReader rd = command.ExecuteReader();
            rd.Read();
            string len = rd[0].ToString();
            rd.Close();
            if (len == "1")
            {
                quảnLýHọcSinhToolStripMenuItem.Enabled = false;
                quảnTrịHệThốngToolStripMenuItem.Enabled = false;
            }
            else if (len == "2")
            {
                quảnTrịHệThốngToolStripMenuItem.Enabled = false;
                quảnLýDanhMụcToolStripMenuItem.Enabled = false;
            }
            
                
        }

        private void cậpNhậtDanhMụcGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtNămHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subject kien = new subject();
            kien.ShowDialog();

        }

        private void main_MdiChildActivate(object sender, EventArgs e)
        {
          
        }

        private void cậpNhậtDanhMụcLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_class kien = new update_class();
            kien.ShowDialog();
        }

        private void xếpLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xep_lop kien = new xep_lop();
            kien.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void cậpNhậtĐiểmHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_diemhoctap kien = new update_diemhoctap();
            kien.ShowDialog();
        }

      

        private void tao_tai_khoan_Click(object sender, EventArgs e)
        {
            update_acc kien = new update_acc();
            kien.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            update_student kien = new update_student();

            kien.ShowDialog();
        }

        private void quảnTrịHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_acc kien = new update_acc();
            kien.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_pass kien = new change_pass(tk);
            kien.ShowDialog();
        }

        private void cậpNhậtHạnhKiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_hanhkiem kien = new update_hanhkiem();
            kien.ShowDialog();
        }
    }
}
