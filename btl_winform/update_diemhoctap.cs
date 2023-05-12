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
    public partial class update_diemhoctap : Form
    {
        SqlConnection connection = null;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-S72H6GF;Initial Catalog=btl;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string cmd;
        List<string> li = new List<string>();
        public void capnhat_sql(string cd)
        {
            check();
            command = connection.CreateCommand();
            command.CommandText = cd;
            command.ExecuteNonQuery();
        } 
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

        public void xethocluc(string ma_hs,string ma_hk)
        { check();
            MessageBox.Show(ma_hs);
            bool ok = true;
            List<string> mh = new List<string>();
            command = connection.CreateCommand();
            command.CommandText = "select name_subject from monhoc";
            SqlDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                mh.Add(rd[0].ToString());
            }
            rd.Close();
            bool kt_hk1 = false;
            bool kt_hk1_mnx = false; // kiem tra mon nhan xet
            bool kt_hk1_mnx_hienthi = false;
            bool kt_hk1_mcd_hienthi = false;
            double mh_chinh = 0;
            double mh_phu =10;
            double dtb_hk1_cac_mon = 0;
            double somon = 0;
            // học kì 1
            
            foreach (string mh1 in mh)
            {
                MessageBox.Show(mh1);
                command.CommandText = "select hinhthuc,diem_hk_tbm from hocsinh_monhoc inner join monhoc on hocsinh_monhoc.id_subject =monhoc.id_subject  where id_student =N'" + ma_hs + "' and id_hocki =N'"+ma_hk+"' and name_subject =N'" + mh1+"'";
                rd = command.ExecuteReader();
                if (rd.Read())
                {
                    int hinh_thuc_mon_hoc = int.Parse(rd[0].ToString());
                    MessageBox.Show(hinh_thuc_mon_hoc.ToString());
                    if (hinh_thuc_mon_hoc == 1)
                    {
                        if (rd[1].ToString() =="")
                        {
                            kt_hk1 = true;
                            kt_hk1_mnx_hienthi = true;
                        }
                        else
                        {
                            string kq = rd[1].ToString();
                            if (kq == "KĐ")
                                kt_hk1_mnx = true;
                        }
                    }
                    else
                    { 
                        if (rd[1].ToString()=="")
                        {
                            kt_hk1 = true;
                            kt_hk1_mcd_hienthi = true;
                            
                        }
                        else
                        {
                            MessageBox.Show(rd[1].ToString());
                            double kq = double.Parse(rd[1].ToString());
                            dtb_hk1_cac_mon += kq;
                            ++somon;
                            if (mh1 == "Toán")
                            {
                                if (kq > mh_chinh)
                                    mh_chinh = kq;
                                if (mh_phu > kq)
                                    mh_phu = kq;
                            }
                            else if (mh1 == "Tiếng Việt")
                            {
                                if (kq > mh_chinh)
                                    mh_chinh = kq;
                                if (mh_phu > kq)
                                    mh_phu = kq;
                            }
                            else
                            {
                                if (mh_phu > kq)
                                    mh_phu = kq;
                            }
                        }
                    }
                }
                else
                {
                    
                    rd.Close();
                    command.CommandText = "select hinhthuc from monhoc where name_subject=N'" + mh1 + "'";
                    rd = command.ExecuteReader();
                    rd.Read();
                    kt_hk1 = true;
                    if (rd[0].ToString() == "1") { kt_hk1_mnx_hienthi = true; }
                    else
                    {
                        kt_hk1_mcd_hienthi = true;
                    }
                }
                rd.Close();
            }
            
            if (kt_hk1_mcd_hienthi == false && kt_hk1 == false && kt_hk1_mnx_hienthi == false)
            {
               double tinh = dtb_hk1_cac_mon / somon;
                string dbm_hk= Math.Round(tinh, 1).ToString();

                string cmd1 = "select * from tk_hocki where id_student =N'" + ma_hs + "' and id_hocki =N'" + ma_hk + "'";
                bool kt = check_dulieu(cmd1);

                // Học lực giỏi 
                if (mh_chinh >= 8 && mh_phu >= 6.5 && tinh >= 8 && kt_hk1_mnx == false)
                {
                    if (kt == true)
                    {
                        cmd1 = "update  tk_hocki set id_hocluc= N'HL001' ,diem_tbhk =N'" + dbm_hk + "' where id_student =N'" + ma_hs + "' and id_hocki=N'" + ma_hk + "' ";
                        capnhat_sql(cmd1);
                    }
                    else
                    {
                        cmd1 = "insert into tk_hocki(id_student,id_hocluc,id_hocki,diem_tbhk) values (N'" + ma_hs + "',N'HL001',N'" + ma_hk + "',N'" + dbm_hk + "')";
                        capnhat_sql(cmd1);
                    }
                }
                // Học lực khá
                else if (mh_chinh >= 6.5 && mh_phu >= 5 && tinh >= 6.5 && kt_hk1_mnx == false)
                {
                    if (kt == true)
                    {
                        cmd1 = "update  tk_hocki set id_hocluc= N'HL002' ,diem_tbhk =N'" + dbm_hk + "' where id_student =N'" + ma_hs + "' and id_hocki=N'"+ma_hk+"' ";
                        capnhat_sql(cmd1);
                    }
                    else
                    {
                        cmd1 = "insert into tk_hocki(id_student,id_hocluc,id_hocki,diem_tbhk) values (N'" + ma_hs + "',N'HL002',N'" + ma_hk + "',N'" + dbm_hk + "')";
                        capnhat_sql(cmd1);
                    }

                }
                // học lực trung bình 
                else if (mh_chinh >= 5 && tinh >= 5 && mh_phu >= 3.5 && kt_hk1_mnx == false)
                {
                    if (kt == true)
                    {
                        cmd1 = "update  tk_hocki set id_hocluc= N'HL003' ,diem_tbhk =N'" + dbm_hk + "' where id_student =N'" + ma_hs + "' and id_hocki=,N'" + ma_hk + "' ";
                        capnhat_sql(cmd1);
                    }
                    else
                    {
                        cmd1 = "insert into tk_hocki(id_student,id_hocluc,id_hocki,diem_tbhk) values (N'" + ma_hs + "',N'HL003',N'" + ma_hk + "',N'" + dbm_hk + "')";
                        capnhat_sql(cmd1);
                    }
                }
                else if (tinh >= 3.5 && mh_phu >= 2)
                {
                    if (kt == true)
                    {
                        cmd1 = "update  tk_hocki set id_hocluc= N'HL004' ,diem_tbhk =N'" + dbm_hk + "' where id_student =N'" + ma_hs + "' and id_hocki=,N'" + ma_hk + "' ";
                        capnhat_sql(cmd1);
                    }
                    else
                    {
                        cmd1 = "insert into tk_hocki(id_student,id_hocluc,id_hocki,diem_tbhk) values (N'" + ma_hs + "',N'HL004',,N'" + ma_hk + "',N'" + dbm_hk + "')";
                        capnhat_sql(cmd1);
                    }
                }
                else
                {

                    if (kt == true)
                    {
                        cmd1 = "update  tk_hocki set id_hocluc= N'HL005' ,diem_tbhk =N'" + dbm_hk + "' where id_student =N'" + ma_hs + "' and id_hocki=,N'" + ma_hk + "' ";
                        capnhat_sql(cmd1);
                    }
                    else
                    {
                        cmd1 = "insert into tk_hocki(id_student,id_hocluc,id_hocki,diem_tbhk) values (N'" + ma_hs + "',N'HL005',,N'" + ma_hk + "',N'" + dbm_hk + "')";
                        capnhat_sql(cmd1);
                    }

                }

              }
            else
            {
                
                string cmd1 = "select * from tk_hocki where id_student =N'" + ma_hs + "' and id_hocki =N'" + ma_hk + "'";
                bool kt = check_dulieu(cmd1);
                if (kt == true)
                {
                    MessageBox.Show("ngu");
                    cmd1 = "update  tk_hocki set id_hocluc = null ,diem_tbhk = null where id_student =N'" + ma_hs + "' and id_hocki= N'" + ma_hk + "' ";
                    capnhat_sql(cmd1);
                }
               
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
            dgv_update_diemhoctap.DataSource = table;
            connection.Close();


        }
        public update_diemhoctap()
        {
            InitializeComponent();
        }

        private void update_diemhoctap_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cb_hoctap_khoi.Text = "khối 1";
            cb_hoctap_hocki.Text = "học kì 1";
            cb_hoctap_monhoc.Text = "Toán";
            check();
            bt_hoctap_capnhat.Enabled = false;
            tb_hoctap_diemtbm.ReadOnly = true;
            // khối
            command = connection.CreateCommand();
            command.CommandText = "select name_khoi from khoi ";
            SqlDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hoctap_khoi.Items.Add(rd[0].ToString());
            }
            rd.Close();
            // hocki
            command = connection.CreateCommand();
            command.CommandText = "select name_hocki from hocki ";
             rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hoctap_hocki.Items.Add(rd[0].ToString());
            }
            rd.Close();

            // monhoc
            command = connection.CreateCommand();
            command.CommandText = "select name_subject from monhoc ";
            rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hoctap_monhoc.Items.Add(rd[0].ToString());
            }
            rd.Close();

            command = connection.CreateCommand();
            cb_hoctap_lop.Items.Clear();
            string ck = "khối 1";
            command.CommandText = "select name_class from lophoc left join khoi on lophoc.id_khoi = khoi.id_khoi where name_khoi = N'" + ck + "'";
             rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hoctap_lop.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }

        private void cb_hoctap_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_hoctap_capnhat.Enabled = false;
        }

        private void cb_hoctap_khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            check();
            command = connection.CreateCommand();
            cb_hoctap_lop.Items.Clear();
            command.CommandText = "select name_class from lophoc left join khoi on lophoc.id_khoi = khoi.id_khoi where name_khoi = N'" +cb_hoctap_khoi.Text + "'";
            SqlDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                cb_hoctap_lop.Items.Add(rd[0].ToString());
            }
            rd.Close();
            bt_hoctap_capnhat.Enabled = false;

        }

        private void bt_hoctap_timkiem_Click(object sender, EventArgs e)
        {
            if (cb_hoctap_lop.Text == "")
                MessageBox.Show("Bạn chưa xét lớp học");
            else
            {
                check();
                command = connection.CreateCommand();
                command.CommandText="select id_student from student inner join lophoc on student.id_class = lophoc.id_class where name_class=N'"+cb_hoctap_lop.Text+"'";
                SqlDataReader rd = command.ExecuteReader();
                if (li.Count > 0)
                    li.Clear();
                while (rd.Read())
                {
                    li.Add(rd[0].ToString());
                }
                rd.Close();
                SqlCommand command2 = connection.CreateCommand();
                command2.CommandText = "select id_hocki from hocki where name_hocki=N'" + cb_hoctap_hocki.Text + "'";
                SqlDataReader rd2 = command2.ExecuteReader();
                rd2.Read();
                string hk = rd2[0].ToString();
                rd2.Close();
                command2.CommandText = "select id_subject from monhoc where name_subject=N'" + cb_hoctap_monhoc.Text + "'";
                rd2 = command2.ExecuteReader();
                rd2.Read();
                string mh = rd2[0].ToString();
                
                rd2.Close();
                foreach (string c in li)
                {
                    command2.CommandText = "select * from(hocsinh_monhoc inner join hocki on hocsinh_monhoc.id_hocki = hocki.id_hocki) inner join monhoc on hocsinh_monhoc.id_subject = monhoc.id_subject   where id_student = N'" + c + "' and name_subject = N'" + cb_hoctap_monhoc.Text + "' and name_hocki = N'" + cb_hoctap_hocki.Text + "'";
                    rd2 = command2.ExecuteReader();
                    if (!rd2.Read())
                    {
                        rd2.Close();
                       
                        command2.CommandText = "insert into  hocsinh_monhoc (id_student,id_hocki,id_subject) values (N'" + c + "',N'" + hk + "',N'" + mh + "')";
                        command2.ExecuteNonQuery();
                    }
                    rd2.Close();
                }
                 cmd = "select STT,hocsinh_monhoc.id_student,name_student,gender,diem_dgtx,diem_dk,diem_ck,diem_hk_tbm from (( (hocsinh_monhoc inner join student on hocsinh_monhoc.id_student = student.id_student ) inner join lophoc on student.id_class=lophoc.id_class ) inner join hocki on hocsinh_monhoc.id_hocki = hocki.id_hocki ) inner join monhoc on hocsinh_monhoc.id_subject=monhoc.id_subject where name_class=N'"+cb_hoctap_lop.Text+"' and name_hocki=N'"+cb_hoctap_hocki.Text+"' and name_subject =N'"+cb_hoctap_monhoc.Text+"'";
                loaddata(cmd);
            }
            bt_hoctap_capnhat.Enabled = true;
        }

        private void bt_hoctap_capnhat_Click(object sender, EventArgs e)
        {
            check();
            int row = dgv_update_diemhoctap.CurrentRow.Index;
            string hienthi = "STT: " + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "\nMã học sinh: " + dgv_update_diemhoctap.Rows[row].Cells[1].Value.ToString() + "\nTên học sinh: " + dgv_update_diemhoctap.Rows[row].Cells[2].Value.ToString() + "\nGiới tính: " + dgv_update_diemhoctap.Rows[row].Cells[3].Value.ToString();
            string hienthi2 = "Các loại điểm không đúng định dạng:\n";
            bool tb = false;
            // lấy mã học kì
            command = connection.CreateCommand();
            command.CommandText = "select id_hocki from hocki where name_hocki=N'" + cb_hoctap_hocki.Text + "'";
            SqlDataReader rd = command.ExecuteReader();
            rd.Read();
            string ma_hk = rd[0].ToString();
            rd.Close();
            //
            DialogResult r = MessageBox.Show("Thông tin cập nhật: \n" + hienthi, "Xác thực thông tin", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                int cnt = 0;
                bool check_mon = false;
                string ckmh = cb_hoctap_monhoc.Text;
                // note : có thể thêm thược tính hình thức cho môn học
                command = connection.CreateCommand();
                command.CommandText="select hinhthuc from monhoc where name_subject =N'"+ckmh+"'";
                SqlDataReader hinhthuc1 = command.ExecuteReader();
                hinhthuc1.Read();
                if (hinhthuc1[0].ToString() == "1")
                    check_mon = true;
                hinhthuc1.Close();

                // Diem ĐGTX
                if (tb_hoctap_diemdgtx.Text != "")
                {
                    if (check_mon == true)
                    {
                        if (tb_hoctap_diemdgtx.Text == "Đ" || tb_hoctap_diemdgtx.Text == "KĐ")
                        {
                            ++cnt;
                            command = connection.CreateCommand();
                            command.CommandText = " update hocsinh_monhoc set diem_dgtx=N'" + tb_hoctap_diemdgtx.Text + "' where STT = N'" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "' ";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            tb = true;
                            hienthi2 += "Điểm ĐGTX\n";
                        }
                    }
                    else
                    {
                        bool ckdd = true;
                        string len = tb_hoctap_diemdgtx.Text;
                        if (len.Length > 3)
                            ckdd = false;
                        else
                        {
                            try
                            {
                                if (len.Length > 1 && len[1] != '.')
                                    ckdd = false;
                                double ck = double.Parse(len);
                            }
                            catch (Exception ex)
                            {
                                ckdd = false;
                            }
                        }
                        if (ckdd == true)
                        {
                            ++cnt;
                            command = connection.CreateCommand();
                            command.CommandText = " update hocsinh_monhoc set diem_dgtx=N'" + tb_hoctap_diemdgtx.Text + "' where STT = N'" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "' ";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            tb = true;
                            hienthi2 += "Điểm ĐGTX\n";
                        }


                    }

                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = " update hocsinh_monhoc set diem_dgtx= null where STT = N'" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "' ";
                    command.ExecuteNonQuery();
                }

                // Điểm GK
                if (tb_hoctap_diemgk.Text != "")
                {
                    if (check_mon == true)
                    {
                        if (tb_hoctap_diemgk.Text == "Đ" || tb_hoctap_diemgk.Text == "KĐ")
                        {
                            ++cnt;
                            command = connection.CreateCommand();
                            command.CommandText = "update hocsinh_monhoc set diem_dk = N'" + tb_hoctap_diemgk.Text + "' where STT = " + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + " ";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            tb = true;
                            hienthi2 += "Điểm GK\n";
                        }
                    }
                    else
                    {
                        bool ckdd = true;
                        string len = tb_hoctap_diemgk.Text;
                        if (len.Length > 3)
                            ckdd = false;
                        else
                        {
                            try
                            {
                                if (len.Length > 1 && len[1] != '.')
                                    ckdd = false;
                                double ck = double.Parse(len);
                            }
                            catch (Exception ex)
                            {
                                ckdd = false;
                            }
                        }
                        if (ckdd == true)
                        {
                            ++cnt;
                            command = connection.CreateCommand();
                            command.CommandText = " update hocsinh_monhoc set diem_dk=N'" + tb_hoctap_diemdgtx.Text + "' where STT = N'" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "' ";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            tb = true;
                            hienthi2 += "Điểm GK\n";
                        }


                    }
                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = " update hocsinh_monhoc set diem_dk= null where STT = N'" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "' ";
                    command.ExecuteNonQuery();
                }


                // diem cuoi ky
                if (tb_hoctap_diemck.Text != "")
                {
                    if (check_mon == true)
                    {
                        if (tb_hoctap_diemck.Text == "Đ" || tb_hoctap_diemck.Text == "KĐ")
                        {
                            ++cnt;
                            command = connection.CreateCommand();
                            command.CommandText = " update hocsinh_monhoc set diem_ck=N'" + tb_hoctap_diemck.Text + "' where STT = N'" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "' ";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            tb = true;
                            hienthi2 += "Điểm CK\n";
                        }
                    }
                    else
                    {
                        bool ckdd = true;
                        string len = tb_hoctap_diemck.Text;
                        if (len.Length > 3)
                            ckdd = false;
                        else
                        {   
                            try
                            {   if (len.Length > 1 && len[1] != '.')
                                    ckdd = false;
                                double ck = double.Parse(len);
                            }
                            catch (Exception ex)
                            {
                                ckdd = false;
                            }
                        }
                        if (ckdd == true)
                        {
                            ++cnt;
                            command = connection.CreateCommand();
                            command.CommandText = " update hocsinh_monhoc set diem_ck=N'" + tb_hoctap_diemck.Text + "' where STT = N'" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "' ";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            tb = true;
                            hienthi2 += "Điểm CK\n";
                        }


                    }
                }
                else
                {
                    command = connection.CreateCommand();
                    command.CommandText = " update hocsinh_monhoc set diem_ck= null where STT = N'" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "' ";
                    command.ExecuteNonQuery();

                }
                if (tb)
                   MessageBox.Show(hienthi2);
               if (cnt == 3)
                {   if (check_mon != true)
                    {
                        double a = double.Parse(tb_hoctap_diemdgtx.Text);
                        double b = double.Parse(tb_hoctap_diemgk.Text);
                        double c = double.Parse(tb_hoctap_diemck.Text);
                        double tbc = (double)(a + b * 2 + c * 3) / 6;                    
                        tb_hoctap_diemtbm.Text = Math.Round(tbc, 1).ToString();


                        command = connection.CreateCommand();
                        command.CommandText = "update hocsinh_monhoc set diem_hk_tbm =N'" + tb_hoctap_diemtbm.Text + "' where STT =" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "";
                        command.ExecuteNonQuery();
                    }
                    else
                    { bool check_d = false;
                        if (tb_hoctap_diemdgtx.Text == "KĐ")
                            check_d = true;
                        if (tb_hoctap_diemgk.Text == "KĐ")
                            check_d = true;
                        if (tb_hoctap_diemck.Text == "KĐ")
                            check_d = true;
                        if (check_d)
                        {
                            tb_hoctap_diemtbm.Text = "KĐ";
                            command = connection.CreateCommand();
                            command.CommandText = "update hocsinh_monhoc set diem_hk_tbm =N'" + tb_hoctap_diemtbm.Text + "' where STT =" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "";
                            command.ExecuteNonQuery();

                        }
                        else
                        {
                            tb_hoctap_diemtbm.Text = "Đ";
                            command = connection.CreateCommand();
                            command.CommandText = "update hocsinh_monhoc set diem_hk_tbm =N'" + tb_hoctap_diemtbm.Text + "' where STT =" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "";
                            command.ExecuteNonQuery();

                        }


                    }
                }
               else
                {
                    tb_hoctap_diemtbm.Text = "";
                    command = connection.CreateCommand();
                    command.CommandText = "update hocsinh_monhoc set diem_hk_tbm  = null where STT =" + dgv_update_diemhoctap.Rows[row].Cells[0].Value.ToString() + "";
                    command.ExecuteNonQuery();
                }
              
                xethocluc(dgv_update_diemhoctap.Rows[row].Cells[1].Value.ToString(),ma_hk);
                string cmd = "select STT,hocsinh_monhoc.id_student,name_student,gender,diem_dgtx,diem_dk,diem_ck,diem_hk_tbm from (( (hocsinh_monhoc inner join student on hocsinh_monhoc.id_student = student.id_student ) inner join lophoc on student.id_class=lophoc.id_class ) inner join hocki on hocsinh_monhoc.id_hocki = hocki.id_hocki ) inner join monhoc on hocsinh_monhoc.id_subject=monhoc.id_subject where name_class=N'" + cb_hoctap_lop.Text + "' and name_hocki=N'" + cb_hoctap_hocki.Text + "' and name_subject =N'" + cb_hoctap_monhoc.Text + "'";
                loaddata(cmd);
           
             
               


            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_update_diemhoctap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_update_diemhoctap.CurrentCell.Value !=null)
            {
                int row = dgv_update_diemhoctap.CurrentRow.Index;
                tb_hoctap_diemdgtx.Text = dgv_update_diemhoctap.Rows[row].Cells[4].Value.ToString();
                tb_hoctap_diemgk.Text = dgv_update_diemhoctap.Rows[row].Cells[5].Value.ToString();
                tb_hoctap_diemck.Text = dgv_update_diemhoctap.Rows[row].Cells[6].Value.ToString();
                tb_hoctap_diemtbm.Text = dgv_update_diemhoctap.Rows[row].Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa tìm kiếm hoặc lớp học hiện tại chưa có học sinh");
               
            }
        }

        private void cb_hoctap_hocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_hoctap_capnhat.Enabled = false;
        }

        private void cb_hoctap_monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_hoctap_capnhat.Enabled = false;
        }

        private void tb_hoctap_diemdgtx_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_hoctap_diemck_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_hoctap_diemgk_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_hoctap_diemdgtx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
