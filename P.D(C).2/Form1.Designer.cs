namespace P.D_C_._2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMangGoc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.rdoMax = new System.Windows.Forms.RadioButton();
            this.rdoMin = new System.Windows.Forms.RadioButton();
            this.rdoTang = new System.Windows.Forms.RadioButton();
            this.rdoGiam = new System.Windows.Forms.RadioButton();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnDemLe = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pDC2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMangGoc);
            this.groupBox1.Location = new System.Drawing.Point(29, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng gốc:";
            // 
            // txtMangGoc
            // 
            this.txtMangGoc.Location = new System.Drawing.Point(190, 21);
            this.txtMangGoc.Multiline = true;
            this.txtMangGoc.Name = "txtMangGoc";
            this.txtMangGoc.Size = new System.Drawing.Size(380, 31);
            this.txtMangGoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Location = new System.Drawing.Point(29, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(190, 21);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(380, 31);
            this.txtKetQua.TabIndex = 0;
            // 
            // rdoMax
            // 
            this.rdoMax.AutoSize = true;
            this.rdoMax.Location = new System.Drawing.Point(82, 253);
            this.rdoMax.Name = "rdoMax";
            this.rdoMax.Size = new System.Drawing.Size(53, 20);
            this.rdoMax.TabIndex = 1;
            this.rdoMax.TabStop = true;
            this.rdoMax.Text = "Max";
            this.rdoMax.UseVisualStyleBackColor = true;
            // 
            // rdoMin
            // 
            this.rdoMin.AutoSize = true;
            this.rdoMin.Location = new System.Drawing.Point(230, 253);
            this.rdoMin.Name = "rdoMin";
            this.rdoMin.Size = new System.Drawing.Size(49, 20);
            this.rdoMin.TabIndex = 1;
            this.rdoMin.TabStop = true;
            this.rdoMin.Text = "Min";
            this.rdoMin.UseVisualStyleBackColor = true;
            // 
            // rdoTang
            // 
            this.rdoTang.AutoSize = true;
            this.rdoTang.Location = new System.Drawing.Point(397, 253);
            this.rdoTang.Name = "rdoTang";
            this.rdoTang.Size = new System.Drawing.Size(60, 20);
            this.rdoTang.TabIndex = 1;
            this.rdoTang.TabStop = true;
            this.rdoTang.Text = "Tăng";
            this.rdoTang.UseVisualStyleBackColor = true;
            // 
            // rdoGiam
            // 
            this.rdoGiam.AutoSize = true;
            this.rdoGiam.Location = new System.Drawing.Point(572, 253);
            this.rdoGiam.Name = "rdoGiam";
            this.rdoGiam.Size = new System.Drawing.Size(60, 20);
            this.rdoGiam.TabIndex = 1;
            this.rdoGiam.TabStop = true;
            this.rdoGiam.Text = "Giảm";
            this.rdoGiam.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(219, 312);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(152, 50);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất ngẫu nhiên";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnDemLe
            // 
            this.btnDemLe.Location = new System.Drawing.Point(219, 368);
            this.btnDemLe.Name = "btnDemLe";
            this.btnDemLe.Size = new System.Drawing.Size(152, 50);
            this.btnDemLe.TabIndex = 2;
            this.btnDemLe.Text = "Đếm các số lẻ";
            this.btnDemLe.UseVisualStyleBackColor = true;
            this.btnDemLe.Click += new System.EventHandler(this.btnDemLe_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(219, 424);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(152, 50);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "Tìm phần tử nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnTongLe
            // 
            this.btnTongLe.Location = new System.Drawing.Point(447, 312);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(152, 50);
            this.btnTongLe.TabIndex = 2;
            this.btnTongLe.Text = "Tổng các số lẻ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            this.btnTongLe.Click += new System.EventHandler(this.btnTongLe_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(447, 368);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(152, 50);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp xếp tăng";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(447, 424);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 50);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDC2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pDC2ToolStripMenuItem
            // 
            this.pDC2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem,
            this.bài2ToolStripMenuItem});
            this.pDC2ToolStripMenuItem.Name = "pDC2ToolStripMenuItem";
            this.pDC2ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.pDC2ToolStripMenuItem.Text = "P.D(C).2";
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài1ToolStripMenuItem.Text = "bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài2ToolStripMenuItem.Text = "bài 2";
            this.bài2ToolStripMenuItem.Click += new System.EventHandler(this.bài2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnDemLe);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.rdoGiam);
            this.Controls.Add(this.rdoTang);
            this.Controls.Add(this.rdoMin);
            this.Controls.Add(this.rdoMax);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMangGoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.RadioButton rdoMax;
        private System.Windows.Forms.RadioButton rdoMin;
        private System.Windows.Forms.RadioButton rdoTang;
        private System.Windows.Forms.RadioButton rdoGiam;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnDemLe;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pDC2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
    }
}

