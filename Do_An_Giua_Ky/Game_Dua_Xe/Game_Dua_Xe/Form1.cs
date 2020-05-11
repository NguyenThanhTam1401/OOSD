using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Dua_Xe
{
    public partial class frmMain : Form
    {

        private bool isGameOver = false;
        private int level = 1;
        private int score = 0;
        private Car MyCar;
        List<PhuongTien> coinList;
        List<PhuongTien> enemyList;
        Timer tmBatDau;
        private int igiay;
        //private Car xechinh;
        public frmMain()
        {
            InitializeComponent();

            lbgameover.Visible = false;
            coinList = new List<PhuongTien>();
            enemyList = new List<PhuongTien>();
            MyCar = new Car();
            tmBatDau = new Timer();
            tmBatDau.Tick += TmBatDau_Tick;
            this.tmBatDau.Enabled = false;
            this.tmBatDau.Interval = 100;
            Init();
            tmBatDau.Start();
        }

        private void TmBatDau_Tick(object sender, EventArgs e)
        {
            igiay--;
            if (igiay < 10)
                ptbxCount.Image = Game_Dua_Xe.Properties.Resources._1;
            else if (igiay < 20)
                ptbxCount.Image = Game_Dua_Xe.Properties.Resources._2;
            else
                ptbxCount.Image = Game_Dua_Xe.Properties.Resources._3;
            if (igiay == 0)
            {
                ptbxCount.Hide();
                tmcar.Start();
                tmmain.Start();
                igiay = 30;
                tmBatDau.Stop();
                return;
            }

            //ptbxCount.Image = Game_Dua_Xe.Properties.Resources._3;
        }

        private void Init()
        {
            igiay = 30;
            //My car
            MyCar.Image = Game_Dua_Xe.Properties.Resources.police;
            MyCar.Location = new Point(130, 310);
            MyCar.Size = new Size(40, 80);
            MyCar.Speed = 4;
            this.Controls.Add(MyCar);
            MyCar.BringToFront();
            //list Enemy
            PhuongTien xehoi = new PhuongTien();
            xehoi.Image = Game_Dua_Xe.Properties.Resources.naucar;
            xehoi.Location = new Point(-100, 50);
            xehoi.Size = new Size(35, 70);
            xehoi.Speed = 3;

            PhuongTien xetai = new PhuongTien();
            xetai.Image = Game_Dua_Xe.Properties.Resources.truck;
            xetai.Location = new Point(-50, 100);
            xetai.Size = new Size(40, 80);
            xetai.Speed = 3;

            PhuongTien xetim = new PhuongTien();
            xetim.Image = Game_Dua_Xe.Properties.Resources.timcar;
            xetim.Location = new Point(-10, 150);
            xetim.Size = new Size(30, 60);
            xetim.Speed = 3;

            enemyList.Add(xetim);
            enemyList.Add(xetai);
            enemyList.Add(xehoi);

            foreach (PhuongTien item in enemyList)
            {
                this.Controls.Add(item);
                item.BringToFront();
            }

            //List Coin
            PhuongTien coin1 = new PhuongTien();
            coin1.Image = Game_Dua_Xe.Properties.Resources.coin;
            coin1.Location = new Point(-100, 50);
            coin1.Size = new Size(18, 20);
            coin1.Speed = 3;

            PhuongTien coin2 = new PhuongTien();
            coin2.Image = Game_Dua_Xe.Properties.Resources.coin;
            coin2.Location = new Point(-80, 50);
            coin2.Size = new Size(18, 20);
            coin2.Speed = 3;

            PhuongTien coin3 = new PhuongTien();
            coin3.Image = Game_Dua_Xe.Properties.Resources.coin;
            coin3.Location = new Point(-60, 50);
            coin3.Size = new Size(18, 20);
            coin3.Speed = 3;

            PhuongTien coin4 = new PhuongTien();
            coin4.Image = Game_Dua_Xe.Properties.Resources.coin;
            coin4.Location = new Point(-20, 50);
            coin4.Size = new Size(18, 20);
            coin4.Speed = 3;

            coinList.Add(coin1);
            coinList.Add(coin2);
            coinList.Add(coin3);
            coinList.Add(coin4);

            foreach (PhuongTien item in coinList)
            {
                this.Controls.Add(item);
                item.BringToFront();
            }
            //
            leftLine.SendToBack();
            RightLine.SendToBack();

            //
            MyCar.TransitionTo(new NormalState());
            MyCar.Moving();
        }
        private void tmmain_Tick(object sender, EventArgs e)
        {
            lbState.Text = MyCar.StateString;
            moveLine(5);
            enemyMove();
            coinMove();
            TinhDiem();
            gameOver();
        }
        private void moveLine(int speed)
        {
            if (line1.Top >= 380)
                line1.Top = -50;
            else
                line1.Top += speed;

            if (line2.Top >= 380)
                line2.Top = -50;
            else
                line2.Top += speed;

            if (line3.Top >= 380)
                line3.Top = -50;
            else
                line3.Top += speed;

            if (line4.Top >= 380)
                line4.Top = -50;
            else
                line4.Top += speed;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameOver)
                return;

            if(e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                MyCar._Up = true; 
            }

            if(e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                MyCar._Down = true;
            }

            if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                MyCar._Left = true;
            }

            if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                MyCar._Right = true;
            }

            if (!isGameOver)
            {
                MyCar.Moving();
                lbState.Text = MyCar.StateString;
            }
            tmcar.Start();
                
        }

        private void tmcar_Tick(object sender, EventArgs e)
        {
            MyCar.Moving();
            lbState.Text = MyCar.StateString;
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (isGameOver)
                return;

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                MyCar._Up = false;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                MyCar._Down = false;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                MyCar._Left = false;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                MyCar._Right = false;
            }

            if (!(MyCar._Up || MyCar._Down || MyCar._Left || MyCar._Right))
            {
                MyCar.Image = Game_Dua_Xe.Properties.Resources.police;
                tmcar.Stop();
            }
        }

        private Random random = new Random();
        private void enemyMove()
        {
            foreach (PhuongTien item in enemyList)
            {
                if (item.Top >= 500)
                {
                    Relocation(item);
                }
                else
                {
                    item.Move();
                }
            }
        }

        private void coinMove()
        {
            foreach (PhuongTien item in coinList)
            {
                if (item.Top >= 500)
                {
                    Relocation(item);
                }
                else
                {
                    item.Move();
                }
            }
        }
        private void Relocation(PhuongTien phuongTien)
        {
            do
            {
                phuongTien.ReLocation();
            } while (IsIntersect(phuongTien));
        }
        private void TinhDiem()
        {
            foreach (PhuongTien item in coinList)
            {
                if (MyCar.IsIntersect(item))
                {
                    Relocation(item);
                    score += 1;
                    lbScore.Text = score.ToString();
                }
            }
        }
        private void gameOver()
        {
            foreach (PhuongTien item in enemyList)
            {
                if (MyCar.IsIntersect(item))
                {
                    item.SendToBack();
                    //MyCar.Image = Game_Dua_Xe.Properties.Resources.boom;
                    MyCar.isOver = true;
                    MyCar.TransitionTo(new CloseState());
                    MyCar.Moving();
                    lbState.Text = MyCar.StateString;
                    item.Image = Game_Dua_Xe.Properties.Resources.boom;
                    MyCar.Size = new Size(80, 80);
                    tmmain.Enabled = false;
                    tmcar.Enabled = false;
                    lbgameover.BringToFront();
                    lbgameover.Text = "Game Over\nYour score: " + score;
                    lbgameover.Visible = true;
                    isGameOver = true;

                }
            }
        }

        private bool IsIntersect(PhuongTien phuongTien)
        {
            foreach (PhuongTien item in coinList)
            {
                if (phuongTien == item)
                    continue;
                if (phuongTien.IsIntersect(item))
                    return true;
            }

            foreach (PhuongTien item in enemyList)
            {
                if (phuongTien == item)
                    continue;
                if (phuongTien.IsIntersect(item))
                    return true;

            }

            if (phuongTien.IsIntersect(leftLine) ||
                                phuongTien.IsIntersect(RightLine))
                return true;

            return false;  
        }

    }
}
