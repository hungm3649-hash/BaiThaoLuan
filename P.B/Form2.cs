using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.B
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            double a, b, c, d, dtb;

            a = double.Parse(txtCSharp.Text);
            b = double.Parse(txtTruyenThong.Text);
            c = double.Parse(txtMaNguonMo.Text);
            d = double.Parse(txtQuanTriMang.Text);

            dtb = (a + b + c + d) / 4;

            txtDTB.Text = dtb.ToString("0.00");

            if (dtb >= 8)
                txtXepLoai.Text = "Giỏi";
            else if (dtb >= 7)
                txtXepLoai.Text = "Khá";
            else if (dtb >= 5)
                txtXepLoai.Text = "Trung bình";
            else
                txtXepLoai.Text = "Yếu";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();

            txtCSharp.Clear();
            txtTruyenThong.Clear();
            txtMaNguonMo.Clear();
            txtQuanTriMang.Clear();

            txtDTB.Clear();
            txtXepLoai.Clear();

            rdoNam.Checked = false;
            rdoNu.Checked = false;

            txtMaSV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
