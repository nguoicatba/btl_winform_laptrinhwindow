
namespace btl_winform
{
    partial class update_student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_student));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_updatestudent = new System.Windows.Forms.DataGridView();
            this.dgv_mahs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mahs = new System.Windows.Forms.TextBox();
            this.tb_tenhs = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.bt_add_stu = new System.Windows.Forms.Button();
            this.bt_fix_stu = new System.Windows.Forms.Button();
            this.bt_del_stu = new System.Windows.Forms.Button();
            this.fix_student = new System.Windows.Forms.Button();
            this.pb_anh = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_student = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_updatestudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).BeginInit();
            this.gb_student.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học sinh";
            // 
            // dgv_updatestudent
            // 
            this.dgv_updatestudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_updatestudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_mahs,
            this.dgv_tenhocsinh,
            this.dgv_date,
            this.dgv_gioitinh,
            this.dgv_anh,
            this.dgv_diachi});
            this.dgv_updatestudent.Location = new System.Drawing.Point(30, 258);
            this.dgv_updatestudent.Name = "dgv_updatestudent";
            this.dgv_updatestudent.RowTemplate.Height = 21;
            this.dgv_updatestudent.Size = new System.Drawing.Size(740, 215);
            this.dgv_updatestudent.TabIndex = 2;
            this.dgv_updatestudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_updatestudent_CellClick);
            this.dgv_updatestudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_updatestudent_CellContentClick);
            // 
            // dgv_mahs
            // 
            this.dgv_mahs.DataPropertyName = "id_student";
            this.dgv_mahs.HeaderText = "Mã học sinh";
            this.dgv_mahs.Name = "dgv_mahs";
            // 
            // dgv_tenhocsinh
            // 
            this.dgv_tenhocsinh.DataPropertyName = "name_student";
            this.dgv_tenhocsinh.HeaderText = "Tên học sinh";
            this.dgv_tenhocsinh.Name = "dgv_tenhocsinh";
            this.dgv_tenhocsinh.Width = 120;
            // 
            // dgv_date
            // 
            this.dgv_date.DataPropertyName = "ngaysinh";
            this.dgv_date.HeaderText = "Ngày sinh";
            this.dgv_date.Name = "dgv_date";
            // 
            // dgv_gioitinh
            // 
            this.dgv_gioitinh.DataPropertyName = "gender";
            this.dgv_gioitinh.HeaderText = "Giới tính";
            this.dgv_gioitinh.Name = "dgv_gioitinh";
            // 
            // dgv_anh
            // 
            this.dgv_anh.DataPropertyName = "anh";
            this.dgv_anh.HeaderText = "Ảnh";
            this.dgv_anh.Name = "dgv_anh";
            this.dgv_anh.Width = 130;
            // 
            // dgv_diachi
            // 
            this.dgv_diachi.DataPropertyName = "diachi";
            this.dgv_diachi.HeaderText = "Địa chỉ";
            this.dgv_diachi.Name = "dgv_diachi";
            this.dgv_diachi.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // tb_mahs
            // 
            this.tb_mahs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mahs.Location = new System.Drawing.Point(121, 12);
            this.tb_mahs.Name = "tb_mahs";
            this.tb_mahs.Size = new System.Drawing.Size(163, 22);
            this.tb_mahs.TabIndex = 7;
            this.tb_mahs.TextChanged += new System.EventHandler(this.tb_mahs_TextChanged);
            this.tb_mahs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_mahs_KeyPress);
            // 
            // tb_tenhs
            // 
            this.tb_tenhs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenhs.Location = new System.Drawing.Point(121, 54);
            this.tb_tenhs.Name = "tb_tenhs";
            this.tb_tenhs.Size = new System.Drawing.Size(163, 22);
            this.tb_tenhs.TabIndex = 8;
            this.tb_tenhs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tenhs_KeyPress);
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diachi.Location = new System.Drawing.Point(379, 58);
            this.tb_diachi.Multiline = true;
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(173, 90);
            this.tb_diachi.TabIndex = 9;
            this.tb_diachi.TextChanged += new System.EventHandler(this.tb_diachi_TextChanged);
            this.tb_diachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_diachi_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 93);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(379, 21);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(121, 22);
            this.cb_gioitinh.TabIndex = 11;
            // 
            // bt_add_stu
            // 
            this.bt_add_stu.Image = ((System.Drawing.Image)(resources.GetObject("bt_add_stu.Image")));
            this.bt_add_stu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add_stu.Location = new System.Drawing.Point(111, 207);
            this.bt_add_stu.Name = "bt_add_stu";
            this.bt_add_stu.Size = new System.Drawing.Size(63, 23);
            this.bt_add_stu.TabIndex = 12;
            this.bt_add_stu.Text = "Thêm";
            this.bt_add_stu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_add_stu.UseVisualStyleBackColor = true;
            this.bt_add_stu.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_fix_stu
            // 
            this.bt_fix_stu.Image = ((System.Drawing.Image)(resources.GetObject("bt_fix_stu.Image")));
            this.bt_fix_stu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_fix_stu.Location = new System.Drawing.Point(217, 207);
            this.bt_fix_stu.Name = "bt_fix_stu";
            this.bt_fix_stu.Size = new System.Drawing.Size(59, 23);
            this.bt_fix_stu.TabIndex = 13;
            this.bt_fix_stu.Text = "Sửa ";
            this.bt_fix_stu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_fix_stu.UseVisualStyleBackColor = true;
            this.bt_fix_stu.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_del_stu
            // 
            this.bt_del_stu.Image = ((System.Drawing.Image)(resources.GetObject("bt_del_stu.Image")));
            this.bt_del_stu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_del_stu.Location = new System.Drawing.Point(329, 207);
            this.bt_del_stu.Name = "bt_del_stu";
            this.bt_del_stu.Size = new System.Drawing.Size(61, 23);
            this.bt_del_stu.TabIndex = 14;
            this.bt_del_stu.Text = "Xóa";
            this.bt_del_stu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_del_stu.UseVisualStyleBackColor = true;
            this.bt_del_stu.Click += new System.EventHandler(this.button3_Click);
            // 
            // fix_student
            // 
            this.fix_student.Image = ((System.Drawing.Image)(resources.GetObject("fix_student.Image")));
            this.fix_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fix_student.Location = new System.Drawing.Point(437, 207);
            this.fix_student.Name = "fix_student";
            this.fix_student.Size = new System.Drawing.Size(75, 23);
            this.fix_student.TabIndex = 15;
            this.fix_student.Text = "Khởi tạo";
            this.fix_student.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fix_student.UseVisualStyleBackColor = true;
            this.fix_student.Click += new System.EventHandler(this.button4_Click);
            // 
            // pb_anh
            // 
            this.pb_anh.BackColor = System.Drawing.SystemColors.Menu;
            this.pb_anh.Location = new System.Drawing.Point(30, 28);
            this.pb_anh.Name = "pb_anh";
            this.pb_anh.Size = new System.Drawing.Size(100, 120);
            this.pb_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_anh.TabIndex = 0;
            this.pb_anh.TabStop = false;
            this.pb_anh.Click += new System.EventHandler(this.pb_anh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ảnh";
            // 
            // gb_student
            // 
            this.gb_student.Controls.Add(this.label1);
            this.gb_student.Controls.Add(this.label2);
            this.gb_student.Controls.Add(this.label3);
            this.gb_student.Controls.Add(this.label4);
            this.gb_student.Controls.Add(this.label5);
            this.gb_student.Controls.Add(this.tb_mahs);
            this.gb_student.Controls.Add(this.tb_tenhs);
            this.gb_student.Controls.Add(this.cb_gioitinh);
            this.gb_student.Controls.Add(this.tb_diachi);
            this.gb_student.Controls.Add(this.dateTimePicker1);
            this.gb_student.Location = new System.Drawing.Point(169, 12);
            this.gb_student.Name = "gb_student";
            this.gb_student.Size = new System.Drawing.Size(574, 169);
            this.gb_student.TabIndex = 17;
            this.gb_student.TabStop = false;
            this.gb_student.Text = "Cập nhật";
            // 
            // update_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 507);
            this.Controls.Add(this.gb_student);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pb_anh);
            this.Controls.Add(this.fix_student);
            this.Controls.Add(this.bt_del_stu);
            this.Controls.Add(this.bt_fix_stu);
            this.Controls.Add(this.bt_add_stu);
            this.Controls.Add(this.dgv_updatestudent);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "update_student";
            this.Text = "update_student";
            this.Load += new System.EventHandler(this.update_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_updatestudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anh)).EndInit();
            this.gb_student.ResumeLayout(false);
            this.gb_student.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_updatestudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mahs;
        private System.Windows.Forms.TextBox tb_tenhs;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_mahs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_diachi;
        private System.Windows.Forms.Button bt_add_stu;
        private System.Windows.Forms.Button bt_fix_stu;
        private System.Windows.Forms.Button bt_del_stu;
        private System.Windows.Forms.Button fix_student;
        private System.Windows.Forms.PictureBox pb_anh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_student;
    }
}