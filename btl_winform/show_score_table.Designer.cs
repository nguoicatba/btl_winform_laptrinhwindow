
namespace btl_winform
{
    partial class show_score_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_score_table));
            this.dgv_bangdiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_dtbm = new System.Windows.Forms.Label();
            this.lb_hk = new System.Windows.Forms.Label();
            this.lb_hl = new System.Windows.Forms.Label();
            this.lb_hotenhs = new System.Windows.Forms.Label();
            this.lb_hsclass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_dh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bangdiem
            // 
            this.dgv_bangdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bangdiem.Location = new System.Drawing.Point(21, 95);
            this.dgv_bangdiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_bangdiem.Name = "dgv_bangdiem";
            this.dgv_bangdiem.RowTemplate.Height = 21;
            this.dgv_bangdiem.Size = new System.Drawing.Size(795, 337);
            this.dgv_bangdiem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm TBM: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hạnh kiểm: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Học lực: ";
            // 
            // lb_dtbm
            // 
            this.lb_dtbm.AutoSize = true;
            this.lb_dtbm.Location = new System.Drawing.Point(170, 462);
            this.lb_dtbm.Name = "lb_dtbm";
            this.lb_dtbm.Size = new System.Drawing.Size(38, 15);
            this.lb_dtbm.TabIndex = 4;
            this.lb_dtbm.Text = "label4";
            // 
            // lb_hk
            // 
            this.lb_hk.AutoSize = true;
            this.lb_hk.Location = new System.Drawing.Point(170, 499);
            this.lb_hk.Name = "lb_hk";
            this.lb_hk.Size = new System.Drawing.Size(38, 15);
            this.lb_hk.TabIndex = 5;
            this.lb_hk.Text = "label5";
            // 
            // lb_hl
            // 
            this.lb_hl.AutoSize = true;
            this.lb_hl.Location = new System.Drawing.Point(411, 462);
            this.lb_hl.Name = "lb_hl";
            this.lb_hl.Size = new System.Drawing.Size(38, 15);
            this.lb_hl.TabIndex = 6;
            this.lb_hl.Text = "label6";
            // 
            // lb_hotenhs
            // 
            this.lb_hotenhs.AutoSize = true;
            this.lb_hotenhs.Location = new System.Drawing.Point(35, 9);
            this.lb_hotenhs.Name = "lb_hotenhs";
            this.lb_hotenhs.Size = new System.Drawing.Size(61, 15);
            this.lb_hotenhs.TabIndex = 7;
            this.lb_hotenhs.Text = "Họ và tên:";
            // 
            // lb_hsclass
            // 
            this.lb_hsclass.AutoSize = true;
            this.lb_hsclass.Location = new System.Drawing.Point(35, 35);
            this.lb_hsclass.Name = "lb_hsclass";
            this.lb_hsclass.Size = new System.Drawing.Size(53, 15);
            this.lb_hsclass.TabIndex = 8;
            this.lb_hsclass.Text = "Lớp học:";
            this.lb_hsclass.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Học kì 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Học kì 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(496, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cả năm học";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Danh hiệu:";
            // 
            // lb_dh
            // 
            this.lb_dh.AutoSize = true;
            this.lb_dh.Location = new System.Drawing.Point(414, 501);
            this.lb_dh.Name = "lb_dh";
            this.lb_dh.Size = new System.Drawing.Size(38, 15);
            this.lb_dh.TabIndex = 13;
            this.lb_dh.Text = "label5";
            // 
            // show_score_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 562);
            this.Controls.Add(this.lb_dh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_hsclass);
            this.Controls.Add(this.lb_hotenhs);
            this.Controls.Add(this.lb_hl);
            this.Controls.Add(this.lb_hk);
            this.Controls.Add(this.lb_dtbm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_bangdiem);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "show_score_table";
            this.Text = "Bảng điểm học tập";
            this.Load += new System.EventHandler(this.show_score_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bangdiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_dtbm;
        private System.Windows.Forms.Label lb_hk;
        private System.Windows.Forms.Label lb_hl;
        private System.Windows.Forms.Label lb_hotenhs;
        private System.Windows.Forms.Label lb_hsclass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_dh;
    }
}