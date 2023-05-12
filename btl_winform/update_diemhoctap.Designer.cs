
namespace btl_winform
{
    partial class update_diemhoctap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_diemhoctap));
            this.dgv_update_diemhoctap = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbm_hk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_hoctap_timkiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_hoctap_hocki = new System.Windows.Forms.ComboBox();
            this.cb_hoctap_lop = new System.Windows.Forms.ComboBox();
            this.cb_hoctap_monhoc = new System.Windows.Forms.ComboBox();
            this.cb_hoctap_khoi = new System.Windows.Forms.ComboBox();
            this.bt_hoctap_capnhat = new System.Windows.Forms.Button();
            this.tb_hoctap_diemdgtx = new System.Windows.Forms.TextBox();
            this.tb_hoctap_diemck = new System.Windows.Forms.TextBox();
            this.tb_hoctap_diemgk = new System.Windows.Forms.TextBox();
            this.tb_hoctap_diemtbm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_update_diemhoctap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_update_diemhoctap
            // 
            this.dgv_update_diemhoctap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_update_diemhoctap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_update_diemhoctap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mahs,
            this.tenhs,
            this.gender,
            this.Column1,
            this.Column2,
            this.Column3,
            this.tbm_hk});
            this.dgv_update_diemhoctap.Location = new System.Drawing.Point(14, 221);
            this.dgv_update_diemhoctap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_update_diemhoctap.Name = "dgv_update_diemhoctap";
            this.dgv_update_diemhoctap.ReadOnly = true;
            this.dgv_update_diemhoctap.RowTemplate.Height = 21;
            this.dgv_update_diemhoctap.Size = new System.Drawing.Size(886, 326);
            this.dgv_update_diemhoctap.TabIndex = 0;
            this.dgv_update_diemhoctap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_update_diemhoctap_CellClick);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "STT";
            this.stt.FillWeight = 72.22015F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // mahs
            // 
            this.mahs.DataPropertyName = "id_student";
            this.mahs.FillWeight = 82.77454F;
            this.mahs.HeaderText = "Mã HS";
            this.mahs.Name = "mahs";
            this.mahs.ReadOnly = true;
            // 
            // tenhs
            // 
            this.tenhs.DataPropertyName = "name_student";
            this.tenhs.FillWeight = 185.7379F;
            this.tenhs.HeaderText = "Tên học sinh";
            this.tenhs.Name = "tenhs";
            this.tenhs.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.FillWeight = 92.65896F;
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "diem_dgtx";
            this.Column1.FillWeight = 92.65896F;
            this.Column1.HeaderText = "Điểm ĐGTX";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "diem_dk";
            this.Column2.FillWeight = 92.65896F;
            this.Column2.HeaderText = "Điểm GK";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "diem_ck";
            this.Column3.FillWeight = 92.65896F;
            this.Column3.HeaderText = "Điểm CK";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tbm_hk
            // 
            this.tbm_hk.DataPropertyName = "diem_hk_tbm";
            this.tbm_hk.HeaderText = "Điểm TBM";
            this.tbm_hk.Name = "tbm_hk";
            this.tbm_hk.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_hoctap_timkiem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_hoctap_hocki);
            this.groupBox1.Controls.Add(this.cb_hoctap_lop);
            this.groupBox1.Controls.Add(this.cb_hoctap_monhoc);
            this.groupBox1.Controls.Add(this.cb_hoctap_khoi);
            this.groupBox1.Location = new System.Drawing.Point(931, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(180, 407);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm ";
            // 
            // bt_hoctap_timkiem
            // 
            this.bt_hoctap_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_hoctap_timkiem.Image")));
            this.bt_hoctap_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_hoctap_timkiem.Location = new System.Drawing.Point(40, 337);
            this.bt_hoctap_timkiem.Name = "bt_hoctap_timkiem";
            this.bt_hoctap_timkiem.Size = new System.Drawing.Size(80, 29);
            this.bt_hoctap_timkiem.TabIndex = 8;
            this.bt_hoctap_timkiem.Text = "Tìm kiếm";
            this.bt_hoctap_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_hoctap_timkiem.UseVisualStyleBackColor = true;
            this.bt_hoctap_timkiem.Click += new System.EventHandler(this.bt_hoctap_timkiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Học kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khối";
            // 
            // cb_hoctap_hocki
            // 
            this.cb_hoctap_hocki.FormattingEnabled = true;
            this.cb_hoctap_hocki.Location = new System.Drawing.Point(17, 193);
            this.cb_hoctap_hocki.Name = "cb_hoctap_hocki";
            this.cb_hoctap_hocki.Size = new System.Drawing.Size(121, 23);
            this.cb_hoctap_hocki.TabIndex = 3;
            this.cb_hoctap_hocki.SelectedIndexChanged += new System.EventHandler(this.cb_hoctap_hocki_SelectedIndexChanged);
            // 
            // cb_hoctap_lop
            // 
            this.cb_hoctap_lop.FormattingEnabled = true;
            this.cb_hoctap_lop.Location = new System.Drawing.Point(17, 126);
            this.cb_hoctap_lop.Name = "cb_hoctap_lop";
            this.cb_hoctap_lop.Size = new System.Drawing.Size(121, 23);
            this.cb_hoctap_lop.TabIndex = 2;
            this.cb_hoctap_lop.SelectedIndexChanged += new System.EventHandler(this.cb_hoctap_lop_SelectedIndexChanged);
            // 
            // cb_hoctap_monhoc
            // 
            this.cb_hoctap_monhoc.FormattingEnabled = true;
            this.cb_hoctap_monhoc.Location = new System.Drawing.Point(17, 261);
            this.cb_hoctap_monhoc.Name = "cb_hoctap_monhoc";
            this.cb_hoctap_monhoc.Size = new System.Drawing.Size(121, 23);
            this.cb_hoctap_monhoc.TabIndex = 1;
            this.cb_hoctap_monhoc.SelectedIndexChanged += new System.EventHandler(this.cb_hoctap_monhoc_SelectedIndexChanged);
            // 
            // cb_hoctap_khoi
            // 
            this.cb_hoctap_khoi.FormattingEnabled = true;
            this.cb_hoctap_khoi.Location = new System.Drawing.Point(17, 62);
            this.cb_hoctap_khoi.Name = "cb_hoctap_khoi";
            this.cb_hoctap_khoi.Size = new System.Drawing.Size(121, 23);
            this.cb_hoctap_khoi.TabIndex = 0;
            this.cb_hoctap_khoi.SelectedIndexChanged += new System.EventHandler(this.cb_hoctap_khoi_SelectedIndexChanged);
            // 
            // bt_hoctap_capnhat
            // 
            this.bt_hoctap_capnhat.Location = new System.Drawing.Point(270, 162);
            this.bt_hoctap_capnhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_hoctap_capnhat.Name = "bt_hoctap_capnhat";
            this.bt_hoctap_capnhat.Size = new System.Drawing.Size(87, 29);
            this.bt_hoctap_capnhat.TabIndex = 2;
            this.bt_hoctap_capnhat.Text = "Cập nhật";
            this.bt_hoctap_capnhat.UseVisualStyleBackColor = true;
            this.bt_hoctap_capnhat.Click += new System.EventHandler(this.bt_hoctap_capnhat_Click);
            // 
            // tb_hoctap_diemdgtx
            // 
            this.tb_hoctap_diemdgtx.Location = new System.Drawing.Point(149, 38);
            this.tb_hoctap_diemdgtx.Name = "tb_hoctap_diemdgtx";
            this.tb_hoctap_diemdgtx.Size = new System.Drawing.Size(100, 23);
            this.tb_hoctap_diemdgtx.TabIndex = 5;
            this.tb_hoctap_diemdgtx.TextChanged += new System.EventHandler(this.tb_hoctap_diemdgtx_TextChanged);
            // 
            // tb_hoctap_diemck
            // 
            this.tb_hoctap_diemck.Location = new System.Drawing.Point(408, 33);
            this.tb_hoctap_diemck.Name = "tb_hoctap_diemck";
            this.tb_hoctap_diemck.Size = new System.Drawing.Size(100, 23);
            this.tb_hoctap_diemck.TabIndex = 6;
            // 
            // tb_hoctap_diemgk
            // 
            this.tb_hoctap_diemgk.Location = new System.Drawing.Point(149, 103);
            this.tb_hoctap_diemgk.Name = "tb_hoctap_diemgk";
            this.tb_hoctap_diemgk.Size = new System.Drawing.Size(100, 23);
            this.tb_hoctap_diemgk.TabIndex = 7;
            // 
            // tb_hoctap_diemtbm
            // 
            this.tb_hoctap_diemtbm.Location = new System.Drawing.Point(408, 98);
            this.tb_hoctap_diemtbm.Name = "tb_hoctap_diemtbm";
            this.tb_hoctap_diemtbm.Size = new System.Drawing.Size(100, 23);
            this.tb_hoctap_diemtbm.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Điểm ĐGTX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điểm GK\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Điểm CK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Điểm TBM";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(551, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 201);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // update_diemhoctap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 562);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_hoctap_diemtbm);
            this.Controls.Add(this.tb_hoctap_diemgk);
            this.Controls.Add(this.tb_hoctap_diemck);
            this.Controls.Add(this.tb_hoctap_diemdgtx);
            this.Controls.Add(this.bt_hoctap_capnhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_update_diemhoctap);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "update_diemhoctap";
            this.Text = "update_diemhoctap";
            this.Load += new System.EventHandler(this.update_diemhoctap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_update_diemhoctap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_update_diemhoctap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_hoctap_timkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_hoctap_hocki;
        private System.Windows.Forms.ComboBox cb_hoctap_lop;
        private System.Windows.Forms.ComboBox cb_hoctap_monhoc;
        private System.Windows.Forms.ComboBox cb_hoctap_khoi;
        private System.Windows.Forms.Button bt_hoctap_capnhat;
        private System.Windows.Forms.TextBox tb_hoctap_diemdgtx;
        private System.Windows.Forms.TextBox tb_hoctap_diemck;
        private System.Windows.Forms.TextBox tb_hoctap_diemgk;
        private System.Windows.Forms.TextBox tb_hoctap_diemtbm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahs;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbm_hk;
    }
}