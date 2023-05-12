
namespace btl_winform
{
    partial class xep_lop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xep_lop));
            this.dgv_xep_lop = new System.Windows.Forms.DataGridView();
            this.id_hocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_ht_trang_thai = new System.Windows.Forms.ComboBox();
            this.cb_ht_lophoc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_td_lophoc = new System.Windows.Forms.ComboBox();
            this.cb_td_trang_thai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xep_lop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_xep_lop
            // 
            this.dgv_xep_lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_xep_lop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_xep_lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xep_lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_hocsinh,
            this.name_student,
            this.ngaysinh,
            this.gender});
            this.dgv_xep_lop.Location = new System.Drawing.Point(12, 162);
            this.dgv_xep_lop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_xep_lop.Name = "dgv_xep_lop";
            this.dgv_xep_lop.ReadOnly = true;
            this.dgv_xep_lop.RowTemplate.Height = 21;
            this.dgv_xep_lop.Size = new System.Drawing.Size(786, 388);
            this.dgv_xep_lop.TabIndex = 0;
            this.dgv_xep_lop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_xep_lop_CellContentClick);
            // 
            // id_hocsinh
            // 
            this.id_hocsinh.DataPropertyName = "id_student";
            this.id_hocsinh.HeaderText = "Mã học sinh";
            this.id_hocsinh.Name = "id_hocsinh";
            this.id_hocsinh.ReadOnly = true;
            // 
            // name_student
            // 
            this.name_student.DataPropertyName = "name_student";
            this.name_student.HeaderText = "Tên học sinh";
            this.name_student.Name = "name_student";
            this.name_student.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_ht_trang_thai
            // 
            this.cb_ht_trang_thai.FormattingEnabled = true;
            this.cb_ht_trang_thai.Items.AddRange(new object[] {
            "Nhập học",
            "Khối 1",
            "Khối 2",
            "Khối 3",
            "Khối 4",
            "Khối 5"});
            this.cb_ht_trang_thai.Location = new System.Drawing.Point(97, 23);
            this.cb_ht_trang_thai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_ht_trang_thai.Name = "cb_ht_trang_thai";
            this.cb_ht_trang_thai.Size = new System.Drawing.Size(141, 23);
            this.cb_ht_trang_thai.TabIndex = 3;
            this.cb_ht_trang_thai.SelectedIndexChanged += new System.EventHandler(this.cb_ht_trang_thai_SelectedIndexChanged);
            // 
            // cb_ht_lophoc
            // 
            this.cb_ht_lophoc.FormattingEnabled = true;
            this.cb_ht_lophoc.Location = new System.Drawing.Point(97, 70);
            this.cb_ht_lophoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_ht_lophoc.Name = "cb_ht_lophoc";
            this.cb_ht_lophoc.Size = new System.Drawing.Size(141, 23);
            this.cb_ht_lophoc.TabIndex = 6;
            this.cb_ht_lophoc.SelectedIndexChanged += new System.EventHandler(this.cb_ht_lophoc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_ht_trang_thai);
            this.groupBox1.Controls.Add(this.cb_ht_lophoc);
            this.groupBox1.Location = new System.Drawing.Point(90, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Trạng thái";
            // 
            // cb_td_lophoc
            // 
            this.cb_td_lophoc.FormattingEnabled = true;
            this.cb_td_lophoc.Location = new System.Drawing.Point(97, 70);
            this.cb_td_lophoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_td_lophoc.Name = "cb_td_lophoc";
            this.cb_td_lophoc.Size = new System.Drawing.Size(141, 23);
            this.cb_td_lophoc.TabIndex = 6;
            // 
            // cb_td_trang_thai
            // 
            this.cb_td_trang_thai.FormattingEnabled = true;
            this.cb_td_trang_thai.Items.AddRange(new object[] {
            "Khối 1",
            "Khối 2",
            "Khối 3",
            "Khối 4",
            "Khối 5"});
            this.cb_td_trang_thai.Location = new System.Drawing.Point(97, 23);
            this.cb_td_trang_thai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_td_trang_thai.Name = "cb_td_trang_thai";
            this.cb_td_trang_thai.Size = new System.Drawing.Size(141, 23);
            this.cb_td_trang_thai.TabIndex = 3;
            this.cb_td_trang_thai.SelectedIndexChanged += new System.EventHandler(this.cb_td_trang_thai_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lớp học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cb_td_trang_thai);
            this.groupBox2.Controls.Add(this.cb_td_lophoc);
            this.groupBox2.Location = new System.Drawing.Point(528, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thay đổi";
            // 
            // xep_lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_xep_lop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xep_lop";
            this.Text = "xep_lop";
            this.Load += new System.EventHandler(this.xep_lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xep_lop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_xep_lop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_ht_trang_thai;
        private System.Windows.Forms.ComboBox cb_ht_lophoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_td_lophoc;
        private System.Windows.Forms.ComboBox cb_td_trang_thai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_hocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
    }
}