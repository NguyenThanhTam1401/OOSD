namespace Game_Dua_Xe
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmmain = new System.Windows.Forms.Timer(this.components);
            this.tmcar = new System.Windows.Forms.Timer(this.components);
            this.lbgameover = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            this.leftLine = new System.Windows.Forms.Panel();
            this.RightLine = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.ptbxCount = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tmmain
            // 
            this.tmmain.Interval = 10;
            this.tmmain.Tick += new System.EventHandler(this.tmmain_Tick);
            // 
            // tmcar
            // 
            this.tmcar.Interval = 10;
            this.tmcar.Tick += new System.EventHandler(this.tmcar_Tick);
            // 
            // lbgameover
            // 
            this.lbgameover.AutoSize = true;
            this.lbgameover.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbgameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbgameover.ForeColor = System.Drawing.Color.Crimson;
            this.lbgameover.Location = new System.Drawing.Point(78, 106);
            this.lbgameover.Name = "lbgameover";
            this.lbgameover.Size = new System.Drawing.Size(165, 50);
            this.lbgameover.TabIndex = 2;
            this.lbgameover.Text = "Game Over\r\nYour score: 100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Level: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÊN GAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dễ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Độ khó:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "1";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(495, 74);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(24, 25);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(375, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 5);
            this.panel1.TabIndex = 5;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(178, 370);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 82);
            this.line4.TabIndex = 0;
            this.line4.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(178, 243);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 82);
            this.line3.TabIndex = 0;
            this.line3.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(178, 106);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 82);
            this.line2.TabIndex = 0;
            this.line2.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(178, -26);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 82);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            // 
            // leftLine
            // 
            this.leftLine.BackColor = System.Drawing.Color.BurlyWood;
            this.leftLine.Location = new System.Drawing.Point(2, -1);
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(10, 514);
            this.leftLine.TabIndex = 6;
            // 
            // RightLine
            // 
            this.RightLine.BackColor = System.Drawing.Color.BurlyWood;
            this.RightLine.Location = new System.Drawing.Point(363, -1);
            this.RightLine.Name = "RightLine";
            this.RightLine.Size = new System.Drawing.Size(10, 514);
            this.RightLine.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "My Car\'s State:";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(400, 290);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(63, 25);
            this.lbState.TabIndex = 3;
            this.lbState.Text = "State";
            // 
            // ptbxCount
            // 
            this.ptbxCount.Image = global::Game_Dua_Xe.Properties.Resources._3;
            this.ptbxCount.Location = new System.Drawing.Point(154, 194);
            this.ptbxCount.Name = "ptbxCount";
            this.ptbxCount.Size = new System.Drawing.Size(56, 74);
            this.ptbxCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxCount.TabIndex = 8;
            this.ptbxCount.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(601, 514);
            this.Controls.Add(this.ptbxCount);
            this.Controls.Add(this.RightLine);
            this.Controls.Add(this.leftLine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbgameover);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line4);
            this.Name = "frmMain";
            this.Text = "Dễ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.Timer tmmain;
        private System.Windows.Forms.Timer tmcar;
        private System.Windows.Forms.Label lbgameover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftLine;
        private System.Windows.Forms.Panel RightLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.PictureBox ptbxCount;
    }
}

