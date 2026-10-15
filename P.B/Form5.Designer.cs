namespace P.B
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpNhapSoNguyen = new System.Windows.Forms.GroupBox();
            this.txtNhapSoNguyen = new System.Windows.Forms.TextBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.lstbDaySo = new System.Windows.Forms.ListBox();
            this.btnNhapSo = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChanDau = new System.Windows.Forms.Button();
            this.btnLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.grpNhapSoNguyen.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng dụng xử lý dãy số";
            // 
            // grpNhapSoNguyen
            // 
            this.grpNhapSoNguyen.Controls.Add(this.btnNhapSo);
            this.grpNhapSoNguyen.Controls.Add(this.txtNhapSoNguyen);
            this.grpNhapSoNguyen.Location = new System.Drawing.Point(2, 62);
            this.grpNhapSoNguyen.Name = "grpNhapSoNguyen";
            this.grpNhapSoNguyen.Size = new System.Drawing.Size(752, 87);
            this.grpNhapSoNguyen.TabIndex = 1;
            this.grpNhapSoNguyen.TabStop = false;
            this.grpNhapSoNguyen.Text = "Nhập số nguyên";
            // 
            // txtNhapSoNguyen
            // 
            this.txtNhapSoNguyen.Location = new System.Drawing.Point(231, 21);
            this.txtNhapSoNguyen.Multiline = true;
            this.txtNhapSoNguyen.Name = "txtNhapSoNguyen";
            this.txtNhapSoNguyen.Size = new System.Drawing.Size(246, 39);
            this.txtNhapSoNguyen.TabIndex = 0;
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnXoaCuoi);
            this.grpChucNang.Controls.Add(this.btnXoaDau);
            this.grpChucNang.Controls.Add(this.btnXoaChon);
            this.grpChucNang.Controls.Add(this.btnLeCuoi);
            this.grpChucNang.Controls.Add(this.btnChanDau);
            this.grpChucNang.Controls.Add(this.btnTang2);
            this.grpChucNang.Location = new System.Drawing.Point(362, 163);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(400, 328);
            this.grpChucNang.TabIndex = 2;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng:";
            // 
            // lstbDaySo
            // 
            this.lstbDaySo.FormattingEnabled = true;
            this.lstbDaySo.ItemHeight = 16;
            this.lstbDaySo.Location = new System.Drawing.Point(2, 163);
            this.lstbDaySo.Name = "lstbDaySo";
            this.lstbDaySo.Size = new System.Drawing.Size(354, 324);
            this.lstbDaySo.TabIndex = 3;
            // 
            // btnNhapSo
            // 
            this.btnNhapSo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNhapSo.Location = new System.Drawing.Point(538, 22);
            this.btnNhapSo.Name = "btnNhapSo";
            this.btnNhapSo.Size = new System.Drawing.Size(138, 37);
            this.btnNhapSo.TabIndex = 1;
            this.btnNhapSo.Text = "Nhập số";
            this.btnNhapSo.UseVisualStyleBackColor = false;
            this.btnNhapSo.Click += new System.EventHandler(this.btnNhapSo_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTang2.Location = new System.Drawing.Point(40, 21);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(276, 32);
            this.btnTang2.TabIndex = 1;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = false;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnChanDau
            // 
            this.btnChanDau.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnChanDau.Location = new System.Drawing.Point(40, 69);
            this.btnChanDau.Name = "btnChanDau";
            this.btnChanDau.Size = new System.Drawing.Size(276, 32);
            this.btnChanDau.TabIndex = 1;
            this.btnChanDau.Text = "Chọn số chẵn đầu";
            this.btnChanDau.UseVisualStyleBackColor = false;
            this.btnChanDau.Click += new System.EventHandler(this.btnChanDau_Click);
            // 
            // btnLeCuoi
            // 
            this.btnLeCuoi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLeCuoi.Location = new System.Drawing.Point(40, 121);
            this.btnLeCuoi.Name = "btnLeCuoi";
            this.btnLeCuoi.Size = new System.Drawing.Size(276, 32);
            this.btnLeCuoi.TabIndex = 1;
            this.btnLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnLeCuoi.UseVisualStyleBackColor = false;
            this.btnLeCuoi.Click += new System.EventHandler(this.btnLeCuoi_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaChon.Location = new System.Drawing.Point(40, 173);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(276, 32);
            this.btnXoaChon.TabIndex = 1;
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = false;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaDau.Location = new System.Drawing.Point(40, 229);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(276, 32);
            this.btnXoaDau.TabIndex = 1;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = false;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoaCuoi.Location = new System.Drawing.Point(40, 276);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(276, 32);
            this.btnXoaCuoi.TabIndex = 1;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = false;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.Red;
            this.btnKetThuc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKetThuc.Location = new System.Drawing.Point(72, 508);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(223, 34);
            this.btnKetThuc.TabIndex = 4;
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnXoaDaySo
            // 
            this.btnXoaDaySo.Location = new System.Drawing.Point(450, 508);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(228, 34);
            this.btnXoaDaySo.TabIndex = 4;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = true;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 554);
            this.Controls.Add(this.btnXoaDaySo);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.lstbDaySo);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpNhapSoNguyen);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.grpNhapSoNguyen.ResumeLayout(false);
            this.grpNhapSoNguyen.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpNhapSoNguyen;
        private System.Windows.Forms.TextBox txtNhapSoNguyen;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.ListBox lstbDaySo;
        private System.Windows.Forms.Button btnNhapSo;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnLeCuoi;
        private System.Windows.Forms.Button btnChanDau;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnXoaDaySo;
    }
}