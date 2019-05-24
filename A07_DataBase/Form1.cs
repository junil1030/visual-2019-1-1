using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A07_DataBase
{
    public partial class Form1 : Form
    {
        string connStr = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\konynag\Desktop\18615016 서준일\A07_DataBase\Students.accdb; Persist Security Info=True";

        public Form1()
        {
            InitializeComponent();
        }
    }
}
