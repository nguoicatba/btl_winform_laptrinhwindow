using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_winform
{
    public partial class only_student : Form
    {
        string tk, mk;
        public only_student()
        {
            InitializeComponent();
        }
        public only_student(string tk, string mk) {
            this.tk = tk;
            this.mk = mk;
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tt_ca_nhan kien = new tt_ca_nhan(tk, mk);
            kien.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            show_score_table kien = new show_score_table(tk);
            kien.ShowDialog();
        }

        private void only_student_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label1.Text = "Chào mừng bạn đã đang nhập: " + tk;
        }
    }
}
