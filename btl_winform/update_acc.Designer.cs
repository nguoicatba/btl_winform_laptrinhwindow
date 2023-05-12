
namespace btl_winform
{
    partial class update_acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_acc));
            this.dgv_acc = new System.Windows.Forms.DataGridView();
            this.id_taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_quyenhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_idtaikhoan = new System.Windows.Forms.TextBox();
            this.tb_matkhau2 = new System.Windows.Forms.TextBox();
            this.tb_tentaikhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_fix_acc = new System.Windows.Forms.Button();
            this.bt_del_acc = new System.Windows.Forms.Button();
            this.cb_quyenhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_set_acc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_acc
            // 
            this.dgv_acc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_taikhoan,
            this.tentaikhoan,
            this.matkhau1,
            this.dgv_quyenhan});
            this.dgv_acc.Location = new System.Drawing.Point(34, 2);
            this.dgv_acc.Name = "dgv_acc";
            this.dgv_acc.RowTemplate.Height = 21;
            this.dgv_acc.Size = new System.Drawing.Size(448, 162);
            this.dgv_acc.TabIndex = 0;
            this.dgv_acc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_acc_CellClick);
            // 
            // id_taikhoan
            // 
            this.id_taikhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_taikhoan.DataPropertyName = "idnguoidung";
            this.id_taikhoan.HeaderText = "ID tài khoản";
            this.id_taikhoan.Name = "id_taikhoan";
            this.id_taikhoan.ReadOnly = true;
            this.id_taikhoan.Width = 104;
            // 
            // tentaikhoan
            // 
            this.tentaikhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tentaikhoan.DataPropertyName = "taikhoan";
            this.tentaikhoan.HeaderText = "Tên tài khoản";
            this.tentaikhoan.Name = "tentaikhoan";
            this.tentaikhoan.ReadOnly = true;
            this.tentaikhoan.Width = 110;
            // 
            // matkhau1
            // 
            this.matkhau1.DataPropertyName = "matkhau";
            this.matkhau1.HeaderText = "Mật khẩu";
            this.matkhau1.Name = "matkhau1";
            this.matkhau1.ReadOnly = true;
            // 
            // dgv_quyenhan
            // 
            this.dgv_quyenhan.DataPropertyName = "quyen";
            this.dgv_quyenhan.HeaderText = "Quyền hạn";
            this.dgv_quyenhan.Name = "dgv_quyenhan";
            this.dgv_quyenhan.ReadOnly = true;
            // 
            // tb_idtaikhoan
            // 
            this.tb_idtaikhoan.Location = new System.Drawing.Point(116, 214);
            this.tb_idtaikhoan.Name = "tb_idtaikhoan";
            this.tb_idtaikhoan.Size = new System.Drawing.Size(100, 20);
            this.tb_idtaikhoan.TabIndex = 1;
            // 
            // tb_matkhau2
            // 
            this.tb_matkhau2.Location = new System.Drawing.Point(116, 278);
            this.tb_matkhau2.Name = "tb_matkhau2";
            this.tb_matkhau2.Size = new System.Drawing.Size(100, 20);
            this.tb_matkhau2.TabIndex = 2;
            // 
            // tb_tentaikhoan
            // 
            this.tb_tentaikhoan.Location = new System.Drawing.Point(320, 215);
            this.tb_tentaikhoan.Name = "tb_tentaikhoan";
            this.tb_tentaikhoan.Size = new System.Drawing.Size(141, 20);
            this.tb_tentaikhoan.TabIndex = 3;
            this.tb_tentaikhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tentaikhoan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID tài khoản";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.AutoSize = true;
            this.tb_matkhau.Location = new System.Drawing.Point(31, 278);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(55, 13);
            this.tb_matkhau.TabIndex = 5;
            this.tb_matkhau.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên tài khoản";
            // 
            // bt_insert
            // 
            this.bt_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_insert.BackgroundImage")));
            this.bt_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_insert.Location = new System.Drawing.Point(521, 115);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(77, 23);
            this.bt_insert.TabIndex = 7;
            this.bt_insert.Text = "Thêm";
            this.bt_insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_fix_acc
            // 
            this.bt_fix_acc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_fix_acc.BackgroundImage")));
            this.bt_fix_acc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_fix_acc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_fix_acc.Location = new System.Drawing.Point(521, 169);
            this.bt_fix_acc.Name = "bt_fix_acc";
            this.bt_fix_acc.Size = new System.Drawing.Size(77, 23);
            this.bt_fix_acc.TabIndex = 8;
            this.bt_fix_acc.Text = "Sửa";
            this.bt_fix_acc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_fix_acc.UseVisualStyleBackColor = true;
            this.bt_fix_acc.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_del_acc
            // 
            this.bt_del_acc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_del_acc.BackgroundImage")));
            this.bt_del_acc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_del_acc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_del_acc.Location = new System.Drawing.Point(521, 218);
            this.bt_del_acc.Name = "bt_del_acc";
            this.bt_del_acc.Size = new System.Drawing.Size(77, 23);
            this.bt_del_acc.TabIndex = 9;
            this.bt_del_acc.Text = "Xóa";
            this.bt_del_acc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_del_acc.UseVisualStyleBackColor = true;
            this.bt_del_acc.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_quyenhan
            // 
            this.cb_quyenhan.FormattingEnabled = true;
            this.cb_quyenhan.Items.AddRange(new object[] {
            "Quản trị viên",
            "Nhân viên văn phòng",
            "Giáo viên",
            "Học sinh"});
            this.cb_quyenhan.Location = new System.Drawing.Point(320, 275);
            this.cb_quyenhan.Name = "cb_quyenhan";
            this.cb_quyenhan.Size = new System.Drawing.Size(121, 21);
            this.cb_quyenhan.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chức vụ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_set_acc
            // 
            this.bt_set_acc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_set_acc.BackgroundImage")));
            this.bt_set_acc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_set_acc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_set_acc.Location = new System.Drawing.Point(521, 273);
            this.bt_set_acc.Name = "bt_set_acc";
            this.bt_set_acc.Size = new System.Drawing.Size(77, 23);
            this.bt_set_acc.TabIndex = 12;
            this.bt_set_acc.Text = "Khởi tạo";
            this.bt_set_acc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_set_acc.UseVisualStyleBackColor = true;
            this.bt_set_acc.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 324);
            this.Controls.Add(this.bt_set_acc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_quyenhan);
            this.Controls.Add(this.bt_del_acc);
            this.Controls.Add(this.bt_fix_acc);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tentaikhoan);
            this.Controls.Add(this.tb_matkhau2);
            this.Controls.Add(this.tb_idtaikhoan);
            this.Controls.Add(this.dgv_acc);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "update_acc";
            this.Text = "update_acc";
            this.Load += new System.EventHandler(this.update_acc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_acc;
        private System.Windows.Forms.TextBox tb_idtaikhoan;
        private System.Windows.Forms.TextBox tb_matkhau2;
        private System.Windows.Forms.TextBox tb_tentaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tb_matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_fix_acc;
        private System.Windows.Forms.Button bt_del_acc;
        private System.Windows.Forms.ComboBox cb_quyenhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_quyenhan;
        private System.Windows.Forms.Button bt_set_acc;
    }
}