using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A003_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "test" && txtPass.Text == "1234")
                lblResult.Text = "로그인 성공";
            else
                lblResult.Text = "로그인 실패";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
