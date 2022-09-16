using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Saper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreatePole();
            this.NewGame();
            this.ClientSize = new Size(20*MC + 1, 20*MR + 23);
        }
        public void CreatePole()
        {
            for (int row = 0; row <= MR + 1; row++)
            {
                pole[row, 0] = -3;
                pole[row, MC + 1] = -3;
            }
            for (int col = 0; col <= MC + 1; col++)
            {
                pole[0, col] = -3;
                pole[MR + 1, col] += -3;
            }
        }
        public static int
             MR = 10,
             MC = 10,
             MinNum = 10;
        private int [,] pole = new int[MR+2,MC+2];
        private int mins, flags; bool alreadySown = false;
        private int status;
      
        private void NewGame()
        {
            int row, col;
            int n = 0;
            int k;
            for (row = 1; row <= MR; row++)
                for (col = 1; col <= MC; col++)
                    pole[row, col] = 0;
            Random rnd = new Random();
            while (n != MinNum)
            {
                row = rnd.Next(1, MR + 1);
                col = rnd.Next(1, MC + 1);
                if (pole[row, col] != 9)
                {
                    pole[row, col] = 9;
                    n++;
                }
            }
            for (row = 1; row <= MR; row++)
                for (col = 1 ;col <= MC; col++)
                    if (pole[row, col] != 9)
                    {
                        k = 0;
                        if (pole[row-1, col-1] == 9) k++;
                        if (pole[row-1, col] == 9) k++;
                        if (pole[row-1, col+1] == 9) k++;
                        if (pole[row, col-1] == 9) k++;
                        if (pole[row, col+1] == 9) k++;
                        if (pole[row+1, col-1] == 9) k++;
                        if (pole[row+1, col] == 9) k++;
                        if (pole[row+1, col+1] == 9) k++;
                        pole[row, col] = k;
                    }
            status = 0;
            mins = 0;
            flags = 0;
        }
        private void showPole(Graphics g,int status)
        {
            for (int row = 1; row <= MR; row++)
                for (int col = 1; col <= MC; col++)
                    this.kletka(g, row, col, status);
        }
        private int GetTopX(int col)
        {
            return (col - 1) * 20 + 1;
        }
        private int GetTopY(int row)
        {
            return (row - 1) * 20 + 1;
        }
        private void kletka(Graphics g, int row, int col, int status)
        {
            int x = GetTopX(col),
                y = GetTopY(row);
            if (pole[row, col] < 100)
            {
                g.FillRectangle(Brushes.GhostWhite, x, y, x+20, y+20);
            }
            if (pole[row, col] >= 100)
            {
                if (pole[row, col] != 109)
                {
                    g.FillRectangle(Brushes.Pink, x, y, x + 20, y + 20);
                }
                else
                {
                    g.FillRectangle(Brushes.Red, x, y, x + 20, y + 20);
                    Bitmap img3 = new Bitmap("bomb.bmp");
                    g.DrawImage(img3, x - 20, y - 42);
                }
                if ((pole[row, col] >= 101) && (pole[row, col] <= 108))
                {
                    g.DrawString((pole[row,col]-100).ToString(),new Font("Arial",10,System.Drawing.FontStyle.Bold),Brushes.Red,x+3,y+2);
                }
            }
            if (pole[row, col] >= 200)
            {
                this.flag(g,x,y);
               
            }
            g.DrawRectangle(Pens.Black, x - 1, y - 1, x + 20, y + 20);
            if ((status == 2) && ((pole[row, col] % 10) == 9))
            {
                this.mina(g,x,y);
            }
        }
        private void open(int row, int col)
        {
            int x = GetTopX(col),
                y = GetTopY(row);
            if (pole[row, col] == 0)
            {
                pole[row, col] = 100;
                this.Invalidate(new Rectangle(x,y,20,20));
                this.open(row,col-1);
                this.open(row-1,col);
                this.open(row,col+1);
                this.open(row+1,col);
                this.open(row-1,col-1);
                this.open(row-1,col+1);
                this.open(row+1,col-1);
                this.open(row+1,col+1);
            }
            else
                if ((pole[row, col] < 100) && (pole[row, col] != -3))
                {
                    pole[row, col] += 100;
                    this.Invalidate(new Rectangle(x, y, 20, 20));
                }
        }
        private void mina(Graphics g, int x, int y)
        {
            g.DrawImage(new Bitmap("bomb.bmp"), x, y);
            //g.DrawImage(new Bitmap("bomb2.bmp"), x + 8, y + 13, 4, 2);
            //g.DrawImage(new Bitmap("bomb1.bmp"), x + 4, y + 15, 12, 2);
            g.FillRectangle(Brushes.Red, x + 8, y + 13, 4, 2);
            g.FillRectangle(Brushes.Yellow, x + 4, y + 15, 12, 2);
            g.DrawPie(Pens.Black, x + 8, y + 14, 14, 8, 0, -90);
            g.FillPie(Brushes.Green, x + 3, y + 14, 14, 8, 0, -90);
            g.DrawLine(Pens.Black, x + 6, y + 16, x + 14, y + 16);
            g.DrawLine(Pens.Black, x + 10, y + 11, x + 10, y + 13);
            g.DrawLine(Pens.Black, x + 4, y + 15, x + 3, y + 14);
            g.DrawLine(Pens.Black, x + 16, y + 15, x + 17, y + 14);
        }
        private void flag(Graphics g, int x, int y)
        {
            Point[] p = new Point[3];
            Point[] m = new Point[5];
            p[0].X = x + 2; p[0].Y = y + 2;
            p[1].X = x + 15; p[1].Y = y + 6;
            p[2].X = x + 2; p[2].Y = y + 10;
            g.FillPolygon(Brushes.Red,p);
            g.DrawLine(Pens.Black,x+2,y+2,x+2,y+18);
            m[0].X = x + 8; m[0].Y = y + 14;
            m[1].X = x + 8; m[1].Y = y + 8;
            m[2].X = x + 10; m[2].Y = y + 10;
            m[3].X = x + 12; m[3].Y = y + 8;
            m[4].X = x + 12; m[4].Y = y + 14;
            g.DrawLines(Pens.Black, m);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (status == 2)
            {
                return;
            }
            if (status == 0)
            {
                status = 1;
            }
            int row = (int)(e.Y / 20) + 1,
                col = (int)(e.X/20)+1;
            int x = GetTopX(col),
                y = GetTopY(row);
            if (e.Button == MouseButtons.Left)
            {
                if (pole[row, col] == 9)
                {
                    pole[row, col] += 100;
                    status = 2;
                    BOOM(x, y);
                    this.Invalidate();
                }
                else if (pole[row, col] == 0)
                    open(row, col);
                else if (pole[row, col] < 9)
                {
                    pole[row, col] += 100;
                    this.Invalidate(new Rectangle(x, y, 20, 20));
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (pole[row, col] <= 9)
                {
                    flags += 1;
                    if (pole[row, col] == 9)
                    {
                        mins += 1;
                    }
                        pole[row, col] += 200;
                    
                    if ((mins == MinNum) && (flags == MinNum))
                    {
                        status = 2;
                        YouWon();
                        this.Invalidate();
                    }
                    else
                    {
                        this.Invalidate(new Rectangle(x, y, 20, 20));
                    }
                }
                else
                {
                    if (pole[row, col] >= 200)
                    {
                        flags -= 1;
                        pole[row, col] -= 200;
                        this.Invalidate(new Rectangle(x, y, 20, 20));
                    }
                }
            } 
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.showPole(e.Graphics,status);
        }
        private void YouWon()
        {
            alreadySown = true;
            MessageBox.Show("Победа");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((mins == MinNum) && (flags == MinNum) && !alreadySown)
            {
                status = 2;
                YouWon();
            }
        }
        private void BOOM(int x, int y)
        {
            Graphics g = this.CreateGraphics();
            Bitmap img1 = new Bitmap("bomb.bmp");
            Bitmap img2 = new Bitmap("bomb.bmp");
            Bitmap img3 = new Bitmap("bomb.bmp");
            g.DrawImage(img1, x-20, y+2);
            DateTime dt = DateTime.Now;
            MessageBox.Show("Увы, вы проиграли");
            g.DrawImage(img2, x - 20, y - 25);
            g.DrawImage(img3, x -20, y - 42);
        }

        private void newPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alreadySown = false;
            this.NewGame();
            this.Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ''.ToString())
            {
                alreadySown = false;
                this.NewGame();
                this.Invalidate();
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MR = 10; MC = 10; MinNum = 10;
            pole = new int[MR+2,MC+2];
            CreatePole();
            this.NewGame();
            this.ClientSize = new Size(20 * MC + 1, 20 * MR + 23);
            newPlayerToolStripMenuItem.Checked = true;
            loverPlayerToolStripMenuItem.Checked = false;
            profiPlayerToolStripMenuItem.Checked = false;
            this.Invalidate();
        }

        private void loverPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MR = 16; MC = 16; MinNum = 40;
            pole = new int[MR+2,MC+2];
            CreatePole();
            this.NewGame();
            this.ClientSize = new Size(20 * MC + 1, 20 * MR + 23);
            loverPlayerToolStripMenuItem.Checked = true;
            newPlayerToolStripMenuItem.Checked = false;
            profiPlayerToolStripMenuItem.Checked = false;
            this.Invalidate();
        }

        private void profiPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MR = 16; MC = 30; MinNum = 99;
            pole = new int[MR + 2, MC + 2];
            CreatePole();
            this.NewGame();
            this.ClientSize = new Size(20 * MC + 1, 20 * MR + 23);
            profiPlayerToolStripMenuItem.Checked = true;
            newPlayerToolStripMenuItem.Checked = false;
            loverPlayerToolStripMenuItem.Checked = false;
            this.Invalidate();
        }


        private void c_Click(object sender, EventArgs e)
        {

        }


        public static void GetFromOsoblyvi(int mr, int mc, int minnum)
        {
            MR = mr; MC = mc; MinNum = minnum;
        }

       
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new Size(20 * MC + 1, 20 * MR + 23);
        }
    }
}
