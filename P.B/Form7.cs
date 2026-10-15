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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cboMaNV.Items.Add("A001");
            cboMaNV.Items.Add("B002");
            cboMaNV.Items.Add("C003");

            cboMaNV.DropDownStyle = ComboBoxStyle.DropDownList;

            txtTenNV.ReadOnly = true;
            txtLuongCoBan.ReadOnly = true;
            txtHeSoPhuCap.ReadOnly = true;

            txtPhuCapCV.ReadOnly = true;
            txtThuongNgay.ReadOnly = true;
            txtLuongThoiGian.ReadOnly = true;
            txtTongCong.ReadOnly = true;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaNV.Text == "A001")
            {
                txtTenNV.Text = "Nguyễn Thanh Tròn";
                txtLuongCoBan.Text = "500000";
                txtHeSoPhuCap.Text = "1.5";
            }
            else if (cboMaNV.Text == "B002")
            {
                txtTenNV.Text = "Nguyễn Văn B";
                txtLuongCoBan.Text = "450000";
                txtHeSoPhuCap.Text = "1.3";
            }
            else if (cboMaNV.Text == "C003")
            {
                txtTenNV.Text = "Nguyễn Văn C";
                txtLuongCoBan.Text = "400000";
                txtHeSoPhuCap.Text = "1.2";
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (cboMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }

            double luongCoBan = double.Parse(txtLuongCoBan.Text);
            double soNgayCong = double.Parse(txtSoNgayCong.Text);

            if (soNgayCong < 0)
            {
                MessageBox.Show("Số ngày công không hợp lệ!");
                return;
            }

            double phuCapCV;

            if (cboMaNV.Text.StartsWith("A"))
                phuCapCV = 500000;
            else if (cboMaNV.Text.StartsWith("B"))
                phuCapCV = 300000;
            else
                phuCapCV = 200000;

            double thuongNgay = soNgayCong * 50000;

            double luongThoiGian;

            if (soNgayCong > 22)
                luongThoiGian = 22 * luongCoBan
                               + (soNgayCong - 22) * luongCoBan * 2;
            else
                luongThoiGian = soNgayCong * luongCoBan;

            double tongCong = luongThoiGian + phuCapCV + thuongNgay;

            txtPhuCapCV.Text = phuCapCV.ToString("N0");
            txtThuongNgay.Text = thuongNgay.ToString("N0");
            txtLuongThoiGian.Text = luongThoiGian.ToString("N0");
            txtTongCong.Text = tongCong.ToString("N0");
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cboMaNV.SelectedIndex = -1;

            txtTenNV.Clear();
            txtLuongCoBan.Clear();
            txtSoNgayCong.Clear();
            txtHeSoPhuCap.Clear();

            txtPhuCapCV.Clear();
            txtThuongNgay.Clear();
            txtLuongThoiGian.Clear();
            txtTongCong.Clear();

            cboMaNV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
