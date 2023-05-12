
namespace btl_winform
{
    partial class subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subject));
            this.dgv_subject = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id_subject = new System.Windows.Forms.TextBox();
            this.tb_name_subject = new System.Windows.Forms.TextBox();
            this.bt_add_subject = new System.Windows.Forms.Button();
            this.bt_fix_subject = new System.Windows.Forms.Button();
            this.bt_delete_subject = new System.Windows.Forms.Button();
            this.bt_set_subject = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_hinhthuc = new System.Windows.Forms.ComboBox();
            this.dgv_idmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_hinhthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subject)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_subject
            // 
            this.dgv_subject.AllowUserToOrderColumns = true;
            this.dgv_subject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_subject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_idmon,
            this.dgv_tenmon,
            this.cl_hinhthuc});
            this.dgv_subject.Location = new System.Drawing.Point(99, 312);
            this.dgv_subject.Name = "dgv_subject";
            this.dgv_subject.RowTemplate.Height = 21;
            this.dgv_subject.Size = new System.Drawing.Size(318, 187);
            this.dgv_subject.TabIndex = 0;
            this.dgv_subject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_subject_CellClick);
            this.dgv_subject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_subject_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn";
            // 
            // tb_id_subject
            // 
            this.tb_id_subject.Location = new System.Drawing.Point(138, 96);
            this.tb_id_subject.Name = "tb_id_subject";
            this.tb_id_subject.Size = new System.Drawing.Size(157, 23);
            this.tb_id_subject.TabIndex = 3;
            // 
            // tb_name_subject
            // 
            this.tb_name_subject.Location = new System.Drawing.Point(138, 142);
            this.tb_name_subject.Name = "tb_name_subject";
            this.tb_name_subject.Size = new System.Drawing.Size(157, 23);
            this.tb_name_subject.TabIndex = 4;
            this.tb_name_subject.TextChanged += new System.EventHandler(this.tb_name_subject_TextChanged);
            // 
            // bt_add_subject
            // 
            this.bt_add_subject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_add_subject.BackgroundImage")));
            this.bt_add_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_add_subject.Location = new System.Drawing.Point(43, 249);
            this.bt_add_subject.Name = "bt_add_subject";
            this.bt_add_subject.Size = new System.Drawing.Size(65, 29);
            this.bt_add_subject.TabIndex = 5;
            this.bt_add_subject.Text = "Thêm";
            this.bt_add_subject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_add_subject.UseVisualStyleBackColor = true;
            this.bt_add_subject.Click += new System.EventHandler(this.bt_add_subject_Click);
            // 
            // bt_fix_subject
            // 
            this.bt_fix_subject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_fix_subject.BackgroundImage")));
            this.bt_fix_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_fix_subject.Location = new System.Drawing.Point(177, 249);
            this.bt_fix_subject.Name = "bt_fix_subject";
            this.bt_fix_subject.Size = new System.Drawing.Size(61, 29);
            this.bt_fix_subject.TabIndex = 6;
            this.bt_fix_subject.Text = "Sửa";
            this.bt_fix_subject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_fix_subject.UseVisualStyleBackColor = true;
            this.bt_fix_subject.Click += new System.EventHandler(this.bt_fix_subject_Click);
            // 
            // bt_delete_subject
            // 
            this.bt_delete_subject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_delete_subject.BackgroundImage")));
            this.bt_delete_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_delete_subject.Location = new System.Drawing.Point(301, 249);
            this.bt_delete_subject.Name = "bt_delete_subject";
            this.bt_delete_subject.Size = new System.Drawing.Size(65, 29);
            this.bt_delete_subject.TabIndex = 7;
            this.bt_delete_subject.Text = "Xóa ";
            this.bt_delete_subject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_delete_subject.UseVisualStyleBackColor = true;
            this.bt_delete_subject.Click += new System.EventHandler(this.bt_delete_subject_Click);
            // 
            // bt_set_subject
            // 
            this.bt_set_subject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_set_subject.BackgroundImage")));
            this.bt_set_subject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_set_subject.Location = new System.Drawing.Point(423, 249);
            this.bt_set_subject.Name = "bt_set_subject";
            this.bt_set_subject.Size = new System.Drawing.Size(81, 29);
            this.bt_set_subject.TabIndex = 8;
            this.bt_set_subject.Text = "Khởi tạo";
            this.bt_set_subject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_set_subject.UseVisualStyleBackColor = true;
            this.bt_set_subject.Click += new System.EventHandler(this.bt_set_subject_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 23);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hình thức đánh giá";
            // 
            // cb_hinhthuc
            // 
            this.cb_hinhthuc.FormattingEnabled = true;
            this.cb_hinhthuc.Items.AddRange(new object[] {
            "Nhận xét",
            "Chấm điểm"});
            this.cb_hinhthuc.Location = new System.Drawing.Point(138, 188);
            this.cb_hinhthuc.Name = "cb_hinhthuc";
            this.cb_hinhthuc.Size = new System.Drawing.Size(157, 23);
            this.cb_hinhthuc.TabIndex = 12;
            // 
            // dgv_idmon
            // 
            this.dgv_idmon.DataPropertyName = "id_subject";
            this.dgv_idmon.HeaderText = "Mã môn";
            this.dgv_idmon.Name = "dgv_idmon";
            this.dgv_idmon.ReadOnly = true;
            // 
            // dgv_tenmon
            // 
            this.dgv_tenmon.DataPropertyName = "name_subject";
            this.dgv_tenmon.HeaderText = "Tên môn học";
            this.dgv_tenmon.Name = "dgv_tenmon";
            this.dgv_tenmon.ReadOnly = true;
            // 
            // cl_hinhthuc
            // 
            this.cl_hinhthuc.DataPropertyName = "hinhthuc";
            this.cl_hinhthuc.HeaderText = "Hình thức đánh giá";
            this.cl_hinhthuc.Name = "cl_hinhthuc";
            // 
            // subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 511);
            this.Controls.Add(this.cb_hinhthuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_set_subject);
            this.Controls.Add(this.bt_delete_subject);
            this.Controls.Add(this.bt_fix_subject);
            this.Controls.Add(this.bt_add_subject);
            this.Controls.Add(this.tb_name_subject);
            this.Controls.Add(this.tb_id_subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_subject);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "subject";
            this.Text = "subject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.subject_FormClosed);
            this.Load += new System.EventHandler(this.subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id_subject;
        private System.Windows.Forms.TextBox tb_name_subject;
        private System.Windows.Forms.Button bt_add_subject;
        private System.Windows.Forms.Button bt_fix_subject;
        private System.Windows.Forms.Button bt_delete_subject;
        private System.Windows.Forms.Button bt_set_subject;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_hinhthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_idmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_hinhthuc;
    }
}