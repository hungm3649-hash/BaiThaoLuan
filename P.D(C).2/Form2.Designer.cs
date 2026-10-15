namespace P.D_C_._2
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtDaySo = new System.Windows.Forms.TextBox();
            this.txtMinMax = new System.Windows.Forms.TextBox();
            this.txtSapXep = new System.Windows.Forms.TextBox();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rdMax = new System.Windows.Forms.RadioButton();
            this.rdMin = new System.Windows.Forms.RadioButton();
            this.rdTang = new System.Windows.Forms.RadioButton();
            this.rdGiam = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dãy số vừa nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMin);
            this.groupBox1.Controls.Add(this.rdMax);
            this.groupBox1.Location = new System.Drawing.Point(27, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Min_Max";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdGiam);
            this.groupBox2.Controls.Add(this.rdTang);
            this.groupBox2.Location = new System.Drawing.Point(27, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(237, 35);
            this.txtN.Multiline = true;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(354, 31);
            this.txtN.TabIndex = 2;
            // 
            // txtDaySo
            // 
            this.txtDaySo.Location = new System.Drawing.Point(237, 95);
            this.txtDaySo.Multiline = true;
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.Size = new System.Drawing.Size(354, 49);
            this.txtDaySo.TabIndex = 2;
            // 
            // txtMinMax
            // 
            this.txtMinMax.Location = new System.Drawing.Point(237, 155);
            this.txtMinMax.Multiline = true;
            this.txtMinMax.Name = "txtMinMax";
            this.txtMinMax.Size = new System.Drawing.Size(354, 127);
            this.txtMinMax.TabIndex = 2;
            // 
            // txtSapXep
            // 
            this.txtSapXep.Location = new System.Drawing.Point(237, 307);
            this.txtSapXep.Multiline = true;
            this.txtSapXep.Name = "txtSapXep";
            this.txtSapXep.Size = new System.Drawing.Size(354, 97);
            this.txtSapXep.TabIndex = 2;
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(625, 115);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(163, 40);
            this.btnTaoMang.TabIndex = 3;
            this.btnTaoMang.Text = "Tạo mảng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(625, 180);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(163, 40);
            this.btnMinMax.TabIndex = 3;
            this.btnMinMax.Text = "Tìm Min-Max";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(625, 254);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(163, 40);
            this.btnSapXep.TabIndex = 3;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(625, 329);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 40);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rdMax
            // 
            this.rdMax.AutoSize = true;
            this.rdMax.Location = new System.Drawing.Point(21, 36);
            this.rdMax.Name = "rdMax";
            this.rdMax.Size = new System.Drawing.Size(53, 20);
            this.rdMax.TabIndex = 0;
            this.rdMax.TabStop = true;
            this.rdMax.Text = "Max";
            this.rdMax.UseVisualStyleBackColor = true;
            // 
            // rdMin
            // 
            this.rdMin.AutoSize = true;
            this.rdMin.Location = new System.Drawing.Point(21, 80);
            this.rdMin.Name = "rdMin";
            this.rdMin.Size = new System.Drawing.Size(49, 20);
            this.rdMin.TabIndex = 0;
            this.rdMin.TabStop = true;
            this.rdMin.Text = "Min";
            this.rdMin.UseVisualStyleBackColor = true;
            // 
            // rdTang
            // 
            this.rdTang.AutoSize = true;
            this.rdTang.Location = new System.Drawing.Point(21, 32);
            this.rdTang.Name = "rdTang";
            this.rdTang.Size = new System.Drawing.Size(60, 20);
            this.rdTang.TabIndex = 0;
            this.rdTang.TabStop = true;
            this.rdTang.Text = "Tăng";
            this.rdTang.UseVisualStyleBackColor = true;
            // 
            // rdGiam
            // 
            this.rdGiam.AutoSize = true;
            this.rdGiam.Location = new System.Drawing.Point(21, 58);
            this.rdGiam.Name = "rdGiam";
            this.rdGiam.Size = new System.Drawing.Size(60, 20);
            this.rdGiam.TabIndex = 0;
            this.rdGiam.TabStop = true;
            this.rdGiam.Text = "Giảm";
            this.rdGiam.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.txtSapXep);
            this.Controls.Add(this.txtMinMax);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Dãy số";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtDaySo;
        private System.Windows.Forms.TextBox txtMinMax;
        private System.Windows.Forms.TextBox txtSapXep;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdMin;
        private System.Windows.Forms.RadioButton rdMax;
        private System.Windows.Forms.RadioButton rdGiam;
        private System.Windows.Forms.RadioButton rdTang;
    }
}