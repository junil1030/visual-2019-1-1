using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A004_SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtNo1.Text == "" || txtNo2.Text == "")
            {
                MessageBox.Show("두개의 숫자를 입력해주세요");
                return;
            }
            double x = double.Parse(txtNo1.Text);
            double y = double.Parse(txtNo2.Text);
            double r = x + y;
            lblResult.Text = "(+) 결과";
            txtResult.Text = r.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtNo1.Text == "" || txtNo2.Text == "")
            {
                MessageBox.Show("두개의 숫자를 입력해주세요");
                return;
            }
            double x = double.Parse(txtNo1.Text);
            double y = double.Parse(txtNo2.Text);
            double r = x - y;
            lblResult.Text = "(-) 결과";
            txtResult.Text = r.ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (txtNo1.Text == "" || txtNo2.Text == "")
            {
                MessageBox.Show("두개의 숫자를 입력해주세요");
                return;
            }
            double x = double.Parse(txtNo1.Text);
            double y = double.Parse(txtNo2.Text);
            double r = x * y;
            lblResult.Text = "(*) 결과";
            txtResult.Text = r.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtNo1.Text == "" || txtNo2.Text == "")
            {
                MessageBox.Show("두개의 숫자를 입력해주세요");
                return;
            }
            double x = double.Parse(txtNo1.Text);
            double y = double.Parse(txtNo2.Text);
            double r = x / y;
            lblResult.Text = "(/) 결과";
            txtResult.Text = r.ToString("0.00"); // 소수점 아래 두자리
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
