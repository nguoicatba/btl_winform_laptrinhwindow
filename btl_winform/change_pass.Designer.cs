
namespace btl_winform
{
    partial class change_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_pass));
            this.tb_tentk = new System.Windows.Forms.TextBox();
            this.tb_cur_mk = new System.Windows.Forms.TextBox();
            this.tb_new_mk = new System.Windows.Forms.TextBox();
            this.tb_again_mk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_change_mk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_tentk
            // 
            this.tb_tentk.Location = new System.Drawing.Point(15, 23);
            this.tb_tentk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tentk.Name = "tb_tentk";
            this.tb_tentk.Size = new System.Drawing.Size(194, 23);
            this.tb_tentk.TabIndex = 0;
            // 
            // tb_cur_mk
            // 
            this.tb_cur_mk.Location = new System.Drawing.Point(15, 63);
            this.tb_cur_mk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_cur_mk.Name = "tb_cur_mk";
            this.tb_cur_mk.PasswordChar = '*';
            this.tb_cur_mk.Size = new System.Drawing.Size(194, 23);
            this.tb_cur_mk.TabIndex = 1;
            // 
            // tb_new_mk
            // 
            this.tb_new_mk.Location = new System.Drawing.Point(15, 115);
            this.tb_new_mk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_new_mk.Name = "tb_new_mk";
            this.tb_new_mk.PasswordChar = '*';
            this.tb_new_mk.Size = new System.Drawing.Size(194, 23);
            this.tb_new_mk.TabIndex = 2;
            // 
            // tb_again_mk
            // 
            this.tb_again_mk.Location = new System.Drawing.Point(15, 163);
            this.tb_again_mk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_again_mk.Name = "tb_again_mk";
            this.tb_again_mk.PasswordChar = '*';
            this.tb_again_mk.Size = new System.Drawing.Size(194, 23);
            this.tb_again_mk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // bt_change_mk
            // 
            this.bt_change_mk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_change_mk.BackgroundImage")));
            this.bt_change_mk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_change_mk.Location = new System.Drawing.Point(53, 250);
            this.bt_change_mk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_change_mk.Name = "bt_change_mk";
            this.bt_change_mk.Size = new System.Drawing.Size(87, 29);
            this.bt_change_mk.TabIndex = 8;
            this.bt_change_mk.Text = "OK";
            this.bt_change_mk.UseVisualStyleBackColor = true;
            this.bt_change_mk.Click += new System.EventHandler(this.bt_change_mk_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 250);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tentk);
            this.groupBox1.Controls.Add(this.tb_cur_mk);
            this.groupBox1.Controls.Add(this.tb_new_mk);
            this.groupBox1.Controls.Add(this.tb_again_mk);
            this.groupBox1.Location = new System.Drawing.Point(146, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // change_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 337);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_change_mk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "change_pass";
            this.Text = "change_pass";
            this.Load += new System.EventHandler(this.change_pass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tentk;
        private System.Windows.Forms.TextBox tb_cur_mk;
        private System.Windows.Forms.TextBox tb_new_mk;
        private System.Windows.Forms.TextBox tb_again_mk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_change_mk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}