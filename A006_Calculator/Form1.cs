using System;
using System.Windows.Forms;

namespace A006_Calculator
{
    public partial class 간단한계산기 : Form
    {
        private bool opFlag;

        public 간단한계산기()
        {
            InitializeComponent();
        }
        double result = 0;
        double First = 0;
        double Second = 0;
        private char op;

        //숫자버튼 0~9까지를 클릭했을 때 실행되는 이벤트 처리 메서드
        private void Number_Click(object sender, EventArgs e)
        {
            Button bun = (Button)sender;
            Button btn = sender as Button;
            string no = btn.Text;

            if (txtResult.Text == "0" || opFlag == true)
            {
                txtResult.Text = no;
                opFlag = false;
            }
            else
                txtResult.Text += no;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains(".") == false)
                txtResult.Text += ".";
        }

        private void Op_Click(object sender, EventArgs e)
        {
            opFlag = true;
            First = double.Parse(txtResult.Text);

            Button btn = sender as Button;
            if (btn.Text == "+")
                op = '+';
            else if (btn.Text == "-")
                op = '-';
            else if (btn.Text == "×")
                op = '*';
            else if (btn.Text == "÷")
                op = '/';
        
            txtResult.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double Second = double.Parse(txtResult.Text);
            double r = 0;

            switch (op)
            {
                case '+':
                    r = Second + First;
                    break;
                case '-':
                    r = Second - First;
                    break;
                case '*':
                    r = Second * First;
                    break;
                case '/':
                    r = Second / First;
                    break;
            }
            txtResult.Text = r.ToString();
        }
    }
}