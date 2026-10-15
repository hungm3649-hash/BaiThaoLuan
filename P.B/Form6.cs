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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cboMaHocVien.Items.Add("HV001");
            cboMaHocVien.Items.Add("HV002");
            cboMaHocVien.Items.Add("HV003");

            cboMaHocVien.DropDownStyle =
                ComboBoxStyle.DropDownList;

            txtTongTien.ReadOnly = true;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            if (chkTinHocA.Checked)
                tongTien += 300000;

            if (chkTinHocB.Checked)
                tongTien += 500000;

            if (chkTiengAnhA.Checked)
                tongTien += 400000;

            if (chkTiengAnhB.Checked)
                tongTien += 600000;

            txtTongTien.Text = tongTien.ToString("N0") + " đồng";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            chkTinHocA.Checked = false;
            chkTinHocB.Checked = false;
            chkTiengAnhA.Checked = false;
            chkTiengAnhB.Checked = false;

            txtTongTien.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
