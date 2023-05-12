
namespace btl_winform
{
    partial class update_hanhkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_hanhkiem));
            this.gb_tìmkiem = new System.Windows.Forms.GroupBox();
            this.bt_hoctap_timkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_hk_hocki = new System.Windows.Forms.ComboBox();
            this.cb_hk_lop = new System.Windows.Forms.ComboBox();
            this.cb_hk_khoi = new System.Windows.Forms.ComboBox();
            this.bt_hk_capnhat = new System.Windows.Forms.Button();
            this.cb_hanhkiem = new System.Windows.Forms.ComboBox();
            this.tb_hk_mahs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_update_hanhkiem = new System.Windows.Forms.DataGridView();
            this.cl_mahs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_tenhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_hanh_kiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_tìmkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_update_hanhkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_tìmkiem
            // 
            this.gb_tìmkiem.Controls.Add(this.bt_hoctap_timkiem);
            this.gb_tìmkiem.Controls.Add(this.label3);
            this.gb_tìmkiem.Controls.Add(this.label2);
            this.gb_tìmkiem.Controls.Add(this.label1);
            this.gb_tìmkiem.Controls.Add(this.cb_hk_hocki);
            this.gb_tìmkiem.Controls.Add(this.cb_hk_lop);
            this.gb_tìmkiem.Controls.Add(this.cb_hk_khoi);
            this.gb_tìmkiem.Location = new System.Drawing.Point(693, 31);
            this.gb_tìmkiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gb_tìmkiem.Name = "gb_tìmkiem";
            this.gb_tìmkiem.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gb_tìmkiem.Size = new System.Drawing.Size(187, 336);
            this.gb_tìmkiem.TabIndex = 2;
            this.gb_tìmkiem.TabStop = false;
            this.gb_tìmkiem.Text = "Tìm kiếm ";
            // 
            // bt_hoctap_timkiem
            // 
            this.bt_hoctap_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_hoctap_timkiem.Image")));
            this.bt_hoctap_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_hoctap_timkiem.Location = new System.Drawing.Point(44, 285);
            this.bt_hoctap_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_hoctap_timkiem.Name = "bt_hoctap_timkiem";
            this.bt_hoctap_timkiem.Size = new System.Drawing.Size(93, 36);
            this.bt_hoctap_timkiem.TabIndex = 8;
            this.bt_hoctap_timkiem.Text = "Tìm kiếm";
            this.bt_hoctap_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_hoctap_timkiem.UseVisualStyleBackColor = true;
            this.bt_hoctap_timkiem.Click += new System.EventHandler(this.bt_hoctap_timkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Học kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Khối";
            // 
            // cb_hk_hocki
            // 
            this.cb_hk_hocki.FormattingEnabled = true;
            this.cb_hk_hocki.Location = new System.Drawing.Point(20, 241);
            this.cb_hk_hocki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_hk_hocki.Name = "cb_hk_hocki";
            this.cb_hk_hocki.Size = new System.Drawing.Size(140, 23);
            this.cb_hk_hocki.TabIndex = 3;
            this.cb_hk_hocki.SelectedIndexChanged += new System.EventHandler(this.cb_hk_hocki_SelectedIndexChanged);
            // 
            // cb_hk_lop
            // 
            this.cb_hk_lop.FormattingEnabled = true;
            this.cb_hk_lop.Location = new System.Drawing.Point(20, 158);
            this.cb_hk_lop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_hk_lop.Name = "cb_hk_lop";
            this.cb_hk_lop.Size = new System.Drawing.Size(140, 23);
            this.cb_hk_lop.TabIndex = 2;
            this.cb_hk_lop.SelectedIndexChanged += new System.EventHandler(this.cb_hk_lop_SelectedIndexChanged);
            // 
            // cb_hk_khoi
            // 
            this.cb_hk_khoi.FormattingEnabled = true;
            this.cb_hk_khoi.Location = new System.Drawing.Point(20, 78);
            this.cb_hk_khoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_hk_khoi.Name = "cb_hk_khoi";
            this.cb_hk_khoi.Size = new System.Drawing.Size(140, 23);
            this.cb_hk_khoi.TabIndex = 0;
            this.cb_hk_khoi.SelectedIndexChanged += new System.EventHandler(this.cb_hk_khoi_SelectedIndexChanged);
            // 
            // bt_hk_capnhat
            // 
            this.bt_hk_capnhat.Location = new System.Drawing.Point(252, 101);
            this.bt_hk_capnhat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bt_hk_capnhat.Name = "bt_hk_capnhat";
            this.bt_hk_capnhat.Size = new System.Drawing.Size(101, 36);
            this.bt_hk_capnhat.TabIndex = 9;
            this.bt_hk_capnhat.Text = "Cập nhật";
            this.bt_hk_capnhat.UseVisualStyleBackColor = true;
            this.bt_hk_capnhat.Click += new System.EventHandler(this.bt_hoctap_capnhat_Click);
            // 
            // cb_hanhkiem
            // 
            this.cb_hanhkiem.FormattingEnabled = true;
            this.cb_hanhkiem.Location = new System.Drawing.Point(434, 46);
            this.cb_hanhkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_hanhkiem.Name = "cb_hanhkiem";
            this.cb_hanhkiem.Size = new System.Drawing.Size(140, 23);
            this.cb_hanhkiem.TabIndex = 10;
            // 
            // tb_hk_mahs
            // 
            this.tb_hk_mahs.Location = new System.Drawing.Point(139, 41);
            this.tb_hk_mahs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_hk_mahs.Name = "tb_hk_mahs";
            this.tb_hk_mahs.Size = new System.Drawing.Size(116, 23);
            this.tb_hk_mahs.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã học sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hạnh kiểm";
            // 
            // dgv_update_hanhkiem
            // 
            this.dgv_update_hanhkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_update_hanhkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_update_hanhkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_mahs,
            this.cl_tenhs,
            this.cl_gender,
            this.cl_datetime,
            this.cl_hanh_kiem});
            this.dgv_update_hanhkiem.Location = new System.Drawing.Point(26, 176);
            this.dgv_update_hanhkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_update_hanhkiem.Name = "dgv_update_hanhkiem";
            this.dgv_update_hanhkiem.RowTemplate.Height = 21;
            this.dgv_update_hanhkiem.Size = new System.Drawing.Size(647, 326);
            this.dgv_update_hanhkiem.TabIndex = 14;
            this.dgv_update_hanhkiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_update_hanhkiem_CellClick);
            // 
            // cl_mahs
            // 
            this.cl_mahs.DataPropertyName = "id_student";
            this.cl_mahs.HeaderText = "Mã học sinh";
            this.cl_mahs.Name = "cl_mahs";
            // 
            // cl_tenhs
            // 
            this.cl_tenhs.DataPropertyName = "name_student";
            this.cl_tenhs.HeaderText = "Tên học sinh";
            this.cl_tenhs.Name = "cl_tenhs";
            // 
            // cl_gender
            // 
            this.cl_gender.DataPropertyName = "gender";
            this.cl_gender.HeaderText = "Giới tính";
            this.cl_gender.Name = "cl_gender";
            // 
            // cl_datetime
            // 
            this.cl_datetime.DataPropertyName = "ngaysinh";
            this.cl_datetime.HeaderText = "Ngày sinh";
            this.cl_datetime.Name = "cl_datetime";
            // 
            // cl_hanh_kiem
            // 
            this.cl_hanh_kiem.DataPropertyName = "loaihanhkiem";
            this.cl_hanh_kiem.HeaderText = "Hạnh kiểm";
            this.cl_hanh_kiem.Name = "cl_hanh_kiem";
            // 
            // update_hanhkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 562);
            this.Controls.Add(this.dgv_update_hanhkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_hk_mahs);
            this.Controls.Add(this.cb_hanhkiem);
            this.Controls.Add(this.bt_hk_capnhat);
            this.Controls.Add(this.gb_tìmkiem);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "update_hanhkiem";
            this.Text = "update_hanhkiem";
            this.Load += new System.EventHandler(this.update_hanhkiem_Load);
            this.gb_tìmkiem.ResumeLayout(false);
            this.gb_tìmkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_update_hanhkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_tìmkiem;
        private System.Windows.Forms.Button bt_hoctap_timkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_hk_hocki;
        private System.Windows.Forms.ComboBox cb_hk_lop;
        private System.Windows.Forms.ComboBox cb_hk_khoi;
        private System.Windows.Forms.Button bt_hk_capnhat;
        private System.Windows.Forms.ComboBox cb_hanhkiem;
        private System.Windows.Forms.TextBox tb_hk_mahs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_update_hanhkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_mahs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_tenhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_hanh_kiem;
    }
}