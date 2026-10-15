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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private int USCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        private int BSCNN(int a, int b)
        {
           if (a == 0 || b == 0)
                return 0;
            return Math.Abs(a * b) / USCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a, b;

            if (!int.TryParse(txtA.Text, out a) ||
                !int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên hợp lệ!");
                return;
            }

            if (!rdoUSCLN.Checked && !rdoBSCNN.Checked)
            {
                MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!");
                return;
            }

            if (rdoUSCLN.Checked)
                txtKetQua.Text = USCLN(a, b).ToString();
            else
            {
                if (a == int.MinValue || b == int.MinValue)
                {
                    MessageBox.Show("Số nhập quá lớn, vui lòng nhập số khác!");
                    return;
                }

                txtKetQua.Text = BSCNN(a, b).ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
