
namespace btl_winform
{
    partial class update_class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_class));
            this.bt_set_class = new System.Windows.Forms.Button();
            this.bt_delete_class = new System.Windows.Forms.Button();
            this.bt_fix_class = new System.Windows.Forms.Button();
            this.bt_add_class = new System.Windows.Forms.Button();
            this.tb_name_class = new System.Windows.Forms.TextBox();
            this.tb_id_class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_khoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_siso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_update_class = new System.Windows.Forms.DataGridView();
            this.gb_update_class = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_update_class)).BeginInit();
            this.gb_update_class.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_set_class
            // 
            this.bt_set_class.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_set_class.BackgroundImage")));
            this.bt_set_class.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_set_class.Location = new System.Drawing.Point(482, 238);
            this.bt_set_class.Name = "bt_set_class";
            this.bt_set_class.Size = new System.Drawing.Size(88, 33);
            this.bt_set_class.TabIndex = 16;
            this.bt_set_class.Text = "Khởi tạo";
            this.bt_set_class.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_set_class.UseVisualStyleBackColor = true;
            this.bt_set_class.Click += new System.EventHandler(this.bt_set_class_Click);
            // 
            // bt_delete_class
            // 
            this.bt_delete_class.Image = ((System.Drawing.Image)(resources.GetObject("bt_delete_class.Image")));
            this.bt_delete_class.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_delete_class.Location = new System.Drawing.Point(334, 238);
            this.bt_delete_class.Name = "bt_delete_class";
            this.bt_delete_class.Size = new System.Drawing.Size(61, 33);
            this.bt_delete_class.TabIndex = 15;
            this.bt_delete_class.Text = "Xóa ";
            this.bt_delete_class.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_delete_class.UseVisualStyleBackColor = true;
            this.bt_delete_class.Click += new System.EventHandler(this.bt_delete_class_Click);
            // 
            // bt_fix_class
            // 
            this.bt_fix_class.Image = ((System.Drawing.Image)(resources.GetObject("bt_fix_class.Image")));
            this.bt_fix_class.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_fix_class.Location = new System.Drawing.Point(195, 238);
            this.bt_fix_class.Name = "bt_fix_class";
            this.bt_fix_class.Size = new System.Drawing.Size(68, 33);
            this.bt_fix_class.TabIndex = 14;
            this.bt_fix_class.Text = "Sửa";
            this.bt_fix_class.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_fix_class.UseVisualStyleBackColor = true;
            this.bt_fix_class.Click += new System.EventHandler(this.bt_fix_class_Click);
            // 
            // bt_add_class
            // 
            this.bt_add_class.Image = ((System.Drawing.Image)(resources.GetObject("bt_add_class.Image")));
            this.bt_add_class.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_add_class.Location = new System.Drawing.Point(73, 238);
            this.bt_add_class.Name = "bt_add_class";
            this.bt_add_class.Size = new System.Drawing.Size(65, 33);
            this.bt_add_class.TabIndex = 13;
            this.bt_add_class.Text = "Thêm";
            this.bt_add_class.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_add_class.UseVisualStyleBackColor = true;
            this.bt_add_class.Click += new System.EventHandler(this.bt_add_subject_Click);
            // 
            // tb_name_class
            // 
            this.tb_name_class.Location = new System.Drawing.Point(127, 102);
            this.tb_name_class.Name = "tb_name_class";
            this.tb_name_class.Size = new System.Drawing.Size(91, 23);
            this.tb_name_class.TabIndex = 12;
            // 
            // tb_id_class
            // 
            this.tb_id_class.Location = new System.Drawing.Point(127, 42);
            this.tb_id_class.Name = "tb_id_class";
            this.tb_id_class.Size = new System.Drawing.Size(91, 23);
            this.tb_id_class.TabIndex = 11;
            this.tb_id_class.TextChanged += new System.EventHandler(this.tb_id_subject_TextChanged);
            this.tb_id_class.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_class_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã lớp";
            // 
            // cb_khoi
            // 
            this.cb_khoi.FormattingEnabled = true;
            this.cb_khoi.Location = new System.Drawing.Point(365, 102);
            this.cb_khoi.Name = "cb_khoi";
            this.cb_khoi.Size = new System.Drawing.Size(61, 23);
            this.cb_khoi.TabIndex = 17;
            this.cb_khoi.SelectedIndexChanged += new System.EventHandler(this.cb_khoi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Khối";
            // 
            // tb_siso
            // 
            this.tb_siso.Location = new System.Drawing.Point(365, 42);
            this.tb_siso.Name = "tb_siso";
            this.tb_siso.Size = new System.Drawing.Size(91, 23);
            this.tb_siso.TabIndex = 20;
            this.tb_siso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tb_siso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sĩ số";
            // 
            // dgv_update_class
            // 
            this.dgv_update_class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_update_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_update_class.Location = new System.Drawing.Point(37, 317);
            this.dgv_update_class.Name = "dgv_update_class";
            this.dgv_update_class.RowTemplate.Height = 21;
            this.dgv_update_class.Size = new System.Drawing.Size(504, 187);
            this.dgv_update_class.TabIndex = 21;
            this.dgv_update_class.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_update_class_CellClick);
            // 
            // gb_update_class
            // 
            this.gb_update_class.Controls.Add(this.label1);
            this.gb_update_class.Controls.Add(this.label2);
            this.gb_update_class.Controls.Add(this.tb_siso);
            this.gb_update_class.Controls.Add(this.tb_id_class);
            this.gb_update_class.Controls.Add(this.label4);
            this.gb_update_class.Controls.Add(this.tb_name_class);
            this.gb_update_class.Controls.Add(this.label3);
            this.gb_update_class.Controls.Add(this.cb_khoi);
            this.gb_update_class.Location = new System.Drawing.Point(37, 54);
            this.gb_update_class.Name = "gb_update_class";
            this.gb_update_class.Size = new System.Drawing.Size(567, 155);
            this.gb_update_class.TabIndex = 22;
            this.gb_update_class.TabStop = false;
            this.gb_update_class.Text = "Cập nhật lớp";
            // 
            // update_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 562);
            this.Controls.Add(this.gb_update_class);
            this.Controls.Add(this.dgv_update_class);
            this.Controls.Add(this.bt_set_class);
            this.Controls.Add(this.bt_delete_class);
            this.Controls.Add(this.bt_fix_class);
            this.Controls.Add(this.bt_add_class);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "update_class";
            this.Text = "update_class";
            this.Load += new System.EventHandler(this.update_class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_update_class)).EndInit();
            this.gb_update_class.ResumeLayout(false);
            this.gb_update_class.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_set_class;
        private System.Windows.Forms.Button bt_delete_class;
        private System.Windows.Forms.Button bt_fix_class;
        private System.Windows.Forms.Button bt_add_class;
        private System.Windows.Forms.TextBox tb_name_class;
        private System.Windows.Forms.TextBox tb_id_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_khoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_siso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_update_class;
        private System.Windows.Forms.GroupBox gb_update_class;
    }
}