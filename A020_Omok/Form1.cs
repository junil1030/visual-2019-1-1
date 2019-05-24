using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A020_Omok
{
    enum STONE {none, black, white};
    public partial class Form1 : Form
    {
        int margin = 30;
        int 눈 = 30;
        int 화점 = 10;
        int 돌 = 28;
        Graphics g;
        Brush wBrush = new SolidBrush(Color.White);
        Brush bBrush = new SolidBrush(Color.Black);
        STONE[,] 바둑판 = new STONE[19, 19]; // 0:빈칸, 1: 검은돌, 2:흰돌
        private bool Flag;
        private bool imageFlag = true;

        int stoneCnt = 1;
        Font font = new Font("맑은 고딕", 10);

        List<Revive> lstRevive = new List<Revive>();
        private string dirName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(2 * margin + 18 * 눈,
                menuStrip1.Height + 2 * margin + 18 * 눈);
            panel1.BackColor = Color.Orange;
            Draw바둑판();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Draw바둑판();
            Draw바둑돌();
        }

        private void Draw바둑돌()
        {
            for (int x= 0;x < 19; x++)
            {
                for(int y = 0; y < 19; y++)
                {
                    if (바둑판[x, y] == STONE.black)
                        if (imageFlag == false)
                        {
                            g.FillEllipse(bBrush,
                                margin + 눈 * x - 눈 / 2, margin + 눈 * y - 눈 / 2,
                                돌, 돌);
                        }
                    else if (바둑판[x,y] == STONE.white)
                        if (imageFlag == false)
                        {
                            g.FillEllipse(wBrush,
                                margin + 눈 * x - 눈 / 2, margin + 눈 * y - 눈 / 2,
                                돌, 돌);
                        }
                }
            }
        }

        private void Draw바둑판()
        {
            g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            for(int i = 0; i < 19; i++)
            {
                //가로줄
                g.DrawLine(pen, margin, margin + i * 눈,
                    margin + 18 * 눈, margin + i * 눈);
                //세로줄
                g.DrawLine(pen, margin + 눈 * i, margin,
                    margin + i * 눈, margin + 눈 * 18);
            }

            for (int x = 3;x<=15;x+=6)
                for (int y = 3; y <= 15; y += 6)
                {
                    g.FillEllipse(bBrush,
                        margin + 눈 * x - 화점 / 2, margin + 눈 * y - 화점 / 2,
                        화점, 화점);
                }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            Draw바둑판();
            Draw바둑돌();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.X + ", " + e.Y);
            //좌표변환
            int x = (e.X - margin + 눈 / 2) / 눈;
            int y = (e.Y - margin + 눈 / 2) / 눈;

            if (바둑판[x, y] != STONE.none)
                return;

            Rectangle r = new Rectangle(margin + 눈 * x - 눈 / 2, margin + 눈 * y - 눈 / 2, 돌, 돌);

            if (Flag == false)
            {
                if (imageFlag == false) { g.FillEllipse(bBrush, r); }
                else
                {
                    Bitmap bmp = new Bitmap("../../Images/Black.png");//bitmap은 비트 지도지
                    g.DrawImage(bmp, r);
                }
                lstRevive.Add(new Revive(x, y, STONE.black, stoneCnt));
                //Revive rev = new Revive(x, y, STONE.black, stoneCnt);
                //lstRevive.Add(rev);

                DrawStoneSequence(stoneCnt++, Brushes.White, r);
                Flag = true;
                바둑판[x, y] = STONE.black;
            }
            else
            {
                if (imageFlag == false) { g.FillEllipse(wBrush, r); }
                else
                {
                    Bitmap bmp = new Bitmap("../../Images/White.png");
                    g.DrawImage(bmp, r);
                }
                lstRevive.Add(new Revive(x, y, STONE.white, stoneCnt));

                DrawStoneSequence(stoneCnt++, Brushes.Black, r);
                Flag = false;
                바둑판[x, y] = STONE.white;
            }

            CheckOmok(x, y);
        }

        private void DrawStoneSequence(int v, Brush color, Rectangle r)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(v.ToString(), font, color, r, stringFormat);
        }

        private void CheckOmok(int x, int y)
        {
            //(1) 좌우 (2) 상하 (3) 대각선 (4)역대각선 방향으로
            //같은 색깔의 돌이 놓여있는 지 체크한다
            int cnt = 1;

            // (1)오른쪽 방향
            for (int i = x + 1; i < 19; i++)
                if (바둑판[x, y] == 바둑판[i, y])
                    cnt++;
                else
                    break;
            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
            //(2)왼쪽 방향
            cnt = 1;
            for (int i = x - 1; i < 19; i--)
                if (바둑판[x, y] == 바둑판[i, y])
                    cnt++;
                else
                    break;
            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
            cnt = 1;
            //(2-1) 위쪽 : y가 줄어드는 쪽
            for (int i = y - 1; i >= 0; i--)
            {
                if (바둑판[x, y] == 바둑판[x, i])
                    cnt++;
                else
                    break;
            }
            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
            cnt = 1;
            for (int i = y + 1; i < 19; i++)
            {
                if (바둑판[x, y] == 바둑판[x, i])
                    cnt++;
                else
                    break;
            }
            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
            //(3-1) 대각선 방향: x는 증가 y는 감소
            cnt = 1;
            for (int i = x + 1, j = y - 1; i < 19 && j > 0; i++, j--)
                if (바둑판[x, y] == 바둑판[i, j])
                    cnt++;
                else
                    break;
            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
            //(3-2)대각선 왼쪽 : x는 감소 y는 증가
            cnt = 1;
            for (int i = x - 1, j = y + 1; i > 0 && j < 19; i--, j++)
                if (바둑판[x, y] == 바둑판[i, j])
                    cnt++;
                else
                    break;
            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
            //(4-1)역대각선 오른쪽: x도 증가, y도 증가
            cnt = 1;
            for (int i = x + 1, j = y + 1; i < 19 && j < 19; i++, j++)
                if (바둑판[x, y] == 바둑판[i, j])
                    cnt++;
                else
                    break;
            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;
            }
            //(4-1)역대각선 왼쪽: x도 감소, y도 감소
            cnt = 1;
            for (int i = x - 1, j = y - 1; i > 0 && j > 0; i--, j--)
                if (바둑판[x, y] == 바둑판[i, j])
                    cnt++;
                else
                    break;

            if (cnt >= 5)
            {
                OmokComplete(x, y);
                return;

            }
        }

            private void OmokComplete(int x, int y)
        {
            MessageBox.Show(바둑판[x, y].ToString().ToUpper() + " Wins!!");
            SaveGame();

            //테스트: lstRevive 값들을 출력
            string s = "";
            foreach (var item in lstRevive)
            {
                s += String.Format("{0} {1} {2} {3}",
                    item.X,
                    item.Y,
                    item.Stone,
                    item.Seq);
                s += "\n";
            }
            MessageBox.Show(s);
        }

        private void SaveGame()
        {
            //문서 폴더의 경로
            string documentPath =
               Path.Combine(Environment.ExpandEnvironmentVariables
               ("%userprofile%"), "Documents").ToString();
            dirName = documentPath + "/Omok/";

            string fileName = dirName + DateTime.Now.ToShortDateString()
               + "-" + DateTime.Now.Hour + DateTime.Now.Minute + ".txt";
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            if (!Directory.Exists(dirName))
                Directory.CreateDirectory(dirName);

            foreach (Revive item in lstRevive)
            {
                sw.WriteLine("{0} {1} {2} {3}",
                   item.X, item.Y, item.Stone, item.Seq);
            }
            sw.Close();
            fs.Close();
        }

        private void 이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFlag = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Invalidate(); // Paint 이벤트를 만들어줍니다. OnPaint()를 실행시킴
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}