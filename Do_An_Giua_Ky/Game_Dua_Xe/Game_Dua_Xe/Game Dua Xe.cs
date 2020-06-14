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
        private int score = 0;
        private CarContext MyCar = null;
        List<PhuongTien> coinList = null;
        List<PhuongTien> enemyList = null;
        Timer tmBatDau = null;
        private int igiay;

        public frmMain()
        {
            InitializeComponent();
            Init();

        }

        // Timer chạy 3s đầu game
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
                timerCar.Start();
                timerMain.Start();
                igiay = 30;
                tmBatDau.Stop();
                return;
            }
        }

        //Timer chạy khi game bắt đầu
        private void timerMain_Tick(object sender, EventArgs e)
        {
            moveLine(5);
            MovingPhuongtien();
            TinhDiem();
            gameOver();
        }

        //Timer di chuyển Xe
        private void timerCar_Tick(object sender, EventArgs e)
        {
            MyCar.Moving();

            lbState.Text = MyCar.getState();
        }

        // Khởi tạo đầu game và các đối tượng
        private void Init()
        {
            btnRestart.Enabled = false;
            this.isGameOver = false;
            this.score = 0;
            igiay = 30;
            lbgameover.Visible = false;
            lbState.Text = "";
            coinList = new List<PhuongTien>();
            enemyList = new List<PhuongTien>();
            MyCar = new CarContext();
            tmBatDau = new Timer();
            tmBatDau.Tick += TmBatDau_Tick;
            this.tmBatDau.Enabled = false;
            this.tmBatDau.Interval = 100;

            //My car
            MyCar.Image = Game_Dua_Xe.Properties.Resources.police;
            MyCar.Location = new Point(130, 310);
            MyCar.Size = new Size(40, 80);
            MyCar.Speed = 2;
            this.Controls.Add(MyCar);
            MyCar.BringToFront();

            //list Enemy
            PhuongTien xehoi = new PhuongTien();
            xehoi.Image = Game_Dua_Xe.Properties.Resources.naucar;
            xehoi.Location = new Point(200, -300);
            xehoi.Size = new Size(35, 70);
            xehoi.Speed = 2;

            PhuongTien xetai = new PhuongTien();
            xetai.Image = Game_Dua_Xe.Properties.Resources.truck;
            xetai.Location = new Point(125, -500);
            xetai.Size = new Size(40, 80);
            xetai.Speed = 2;

            PhuongTien xetim = new PhuongTien();
            xetim.Image = Game_Dua_Xe.Properties.Resources.timcar;
            xetim.Location = new Point(50, -80);
            xetim.Size = new Size(30, 60);
            xetim.Speed = 2;

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
            coin1.Speed = 2;

            PhuongTien coin2 = new PhuongTien();
            coin2.Image = Game_Dua_Xe.Properties.Resources.coin;
            coin2.Location = new Point(-80, 50);
            coin2.Size = new Size(18, 20);
            coin2.Speed = 2;

            PhuongTien coin3 = new PhuongTien();
            coin3.Image = Game_Dua_Xe.Properties.Resources.coin;
            coin3.Location = new Point(-60, 50);
            coin3.Size = new Size(18, 20);
            coin3.Speed = 2;

            PhuongTien coin4 = new PhuongTien();
            coin4.Image = Game_Dua_Xe.Properties.Resources.coin;
            coin4.Location = new Point(-20, 50);
            coin4.Size = new Size(18, 20);
            coin4.Speed = 2;

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


        }

        //Event khi di ấn các phím di chuyển
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            // Không làm gì nếu game đã kết thúc
            if (isGameOver)
                return;

            // nhấn button Up
            if(e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                MyCar._Up = true;
            }

            //Nhấn Button Down
            else if(e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                MyCar._Down = true;
            }

            // Nhấn button left
            else if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                MyCar._Left = true;
            }

            //Nhấn button right
            else if(e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                MyCar._Right = true;
            }

            // Gọi hàm Move
            MyCar.Moving();

            //thay đổi text box
            lbState.Text = MyCar.getState();

            //gọi timer di chuyển xe
            timerCar.Start();
                
        }
        //Event khi 
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
                timerCar.Stop();
            }
        }

        //Event nhấn button start game
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Bắt đầu với Normal State
            MyCar.TransitionTo(StartState.Instance());

            tmBatDau.Start();
            btnStart.Enabled = false;
            btnRestart.Enabled = false;
        }
        
        //Restart
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private Random random = new Random();
        //Di chuyển vạch phân cách
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
        //Di chuyển các enemy và coin
        private void MovingPhuongtien()
        {
            foreach (PhuongTien enemy in enemyList)
            {
                //Nếu ra khỏi khu vực màn hình game thì sẽ Relocate phương tiện đó lại
                if (enemy.Top >= 500)
                {
                    Relocation(enemy);
                }
                //Di chuyển phương tiện xuống dưới
                else
                {
                    enemy.Move();
                }
            }

            foreach (PhuongTien coin in coinList)
            {
                if (coin.Top >= 500)
                {
                    Relocation(coin);
                }
                else
                {
                    coin.Move();
                }
            }

        }
        //Relocate lại phương tiện
        private void Relocation(PhuongTien phuongTien)
        {
            do
            {
                phuongTien.ReLocation();
            } while (IsIntersect(phuongTien));
        }
        //Tăng điểm khi ăn được tiền
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
        //Kết thúc game nếu va chạm vào enemy
        private void gameOver()
        {
            foreach (PhuongTien item in enemyList)
            {
                //Va chạm với xe khác
                if (MyCar.IsIntersect(item))
                {
                    //
                    item.SendToBack();
                    MyCar.isOver = true;
                    MyCar.Image = Game_Dua_Xe.Properties.Resources.boom;
                    lbState.Text = MyCar.getState();
                    item.Image = Game_Dua_Xe.Properties.Resources.boom;
                    MyCar.Size = new Size(80, 80);
                    
                    //Dừng các timer
                    timerMain.Enabled = false;
                    timerCar.Enabled = false;

                    lbgameover.BringToFront();
                    lbgameover.Text = "Game Over\nYour score: " + score;
                    lbgameover.Visible = true;
                    isGameOver = true;
                   
                    btnRestart.Enabled = true;
                }
            }
        }
        //Kiểm tra xem phương tiện truyền vào có intersect với bất kỳ phương tiện khác hay không
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
