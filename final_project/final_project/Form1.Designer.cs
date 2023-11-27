
namespace final_project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labGameOver = new System.Windows.Forms.Label();
            this.OnLinePlayerList = new System.Windows.Forms.ListBox();
            this.labOnLinePlayer = new System.Windows.Forms.Label();
            this.labPlayerName = new System.Windows.Forms.Label();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.txbServerIP = new System.Windows.Forms.TextBox();
            this.labServerIP = new System.Windows.Forms.Label();
            this.txbServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txbSystemInfo = new System.Windows.Forms.TextBox();
            this.labSystemInfo = new System.Windows.Forms.Label();
            this.pictureOnLinePlayer = new System.Windows.Forms.PictureBox();
            this.labScore = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.LowerPipe = new System.Windows.Forms.PictureBox();
            this.UpperPipe = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.BackGroundMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnLinePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundMusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // labGameOver
            // 
            this.labGameOver.AutoSize = true;
            this.labGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.labGameOver.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGameOver.Location = new System.Drawing.Point(233, 662);
            this.labGameOver.Name = "labGameOver";
            this.labGameOver.Size = new System.Drawing.Size(397, 81);
            this.labGameOver.TabIndex = 5;
            this.labGameOver.Text = "GameOver!";
            // 
            // OnLinePlayerList
            // 
            this.OnLinePlayerList.BackColor = System.Drawing.Color.White;
            this.OnLinePlayerList.Enabled = false;
            this.OnLinePlayerList.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OnLinePlayerList.FormattingEnabled = true;
            this.OnLinePlayerList.ItemHeight = 19;
            this.OnLinePlayerList.Location = new System.Drawing.Point(815, 38);
            this.OnLinePlayerList.Name = "OnLinePlayerList";
            this.OnLinePlayerList.Size = new System.Drawing.Size(158, 232);
            this.OnLinePlayerList.TabIndex = 7;
            // 
            // labOnLinePlayer
            // 
            this.labOnLinePlayer.AutoSize = true;
            this.labOnLinePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(222)))));
            this.labOnLinePlayer.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOnLinePlayer.Location = new System.Drawing.Point(846, 9);
            this.labOnLinePlayer.Name = "labOnLinePlayer";
            this.labOnLinePlayer.Size = new System.Drawing.Size(96, 26);
            this.labOnLinePlayer.TabIndex = 8;
            this.labOnLinePlayer.Text = "線上玩家";
            // 
            // labPlayerName
            // 
            this.labPlayerName.AutoSize = true;
            this.labPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(222)))));
            this.labPlayerName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPlayerName.Location = new System.Drawing.Point(846, 294);
            this.labPlayerName.Name = "labPlayerName";
            this.labPlayerName.Size = new System.Drawing.Size(96, 26);
            this.labPlayerName.TabIndex = 9;
            this.labPlayerName.Text = "玩家名子";
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbPlayerName.Location = new System.Drawing.Point(815, 323);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(158, 33);
            this.txbPlayerName.TabIndex = 10;
            this.txbPlayerName.Text = "User";
            // 
            // txbServerIP
            // 
            this.txbServerIP.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbServerIP.Location = new System.Drawing.Point(815, 388);
            this.txbServerIP.Name = "txbServerIP";
            this.txbServerIP.Size = new System.Drawing.Size(158, 33);
            this.txbServerIP.TabIndex = 12;
            this.txbServerIP.Text = "26.92.166.252";
            // 
            // labServerIP
            // 
            this.labServerIP.AutoSize = true;
            this.labServerIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(222)))));
            this.labServerIP.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labServerIP.Location = new System.Drawing.Point(845, 359);
            this.labServerIP.Name = "labServerIP";
            this.labServerIP.Size = new System.Drawing.Size(99, 26);
            this.labServerIP.TabIndex = 11;
            this.labServerIP.Text = "Server IP";
            // 
            // txbServerPort
            // 
            this.txbServerPort.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbServerPort.Location = new System.Drawing.Point(815, 453);
            this.txbServerPort.Name = "txbServerPort";
            this.txbServerPort.Size = new System.Drawing.Size(158, 33);
            this.txbServerPort.TabIndex = 14;
            this.txbServerPort.Text = "2019";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(222)))));
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(833, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Server Port";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Azure;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnect.Location = new System.Drawing.Point(815, 492);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(158, 38);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "連線";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txbSystemInfo
            // 
            this.txbSystemInfo.Enabled = false;
            this.txbSystemInfo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbSystemInfo.Location = new System.Drawing.Point(815, 623);
            this.txbSystemInfo.Name = "txbSystemInfo";
            this.txbSystemInfo.Size = new System.Drawing.Size(158, 25);
            this.txbSystemInfo.TabIndex = 16;
            // 
            // labSystemInfo
            // 
            this.labSystemInfo.AutoSize = true;
            this.labSystemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(145)))), ((int)(((byte)(222)))));
            this.labSystemInfo.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSystemInfo.Location = new System.Drawing.Point(846, 594);
            this.labSystemInfo.Name = "labSystemInfo";
            this.labSystemInfo.Size = new System.Drawing.Size(96, 26);
            this.labSystemInfo.TabIndex = 17;
            this.labSystemInfo.Text = "系統訊息";
            // 
            // pictureOnLinePlayer
            // 
            this.pictureOnLinePlayer.Image = global::final_project.Properties.Resources.記分板1;
            this.pictureOnLinePlayer.Location = new System.Drawing.Point(801, -23);
            this.pictureOnLinePlayer.Name = "pictureOnLinePlayer";
            this.pictureOnLinePlayer.Size = new System.Drawing.Size(218, 805);
            this.pictureOnLinePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOnLinePlayer.TabIndex = 6;
            this.pictureOnLinePlayer.TabStop = false;
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.labScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labScore.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScore.Image = global::final_project.Properties.Resources.ground;
            this.labScore.Location = new System.Drawing.Point(12, 708);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(111, 35);
            this.labScore.TabIndex = 4;
            this.labScore.Text = "Score:0";
            this.labScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Ground.Image = global::final_project.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-21, 615);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(825, 153);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // LowerPipe
            // 
            this.LowerPipe.Image = global::final_project.Properties.Resources.pipe;
            this.LowerPipe.Location = new System.Drawing.Point(550, 400);
            this.LowerPipe.Name = "LowerPipe";
            this.LowerPipe.Size = new System.Drawing.Size(110, 318);
            this.LowerPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LowerPipe.TabIndex = 2;
            this.LowerPipe.TabStop = false;
            // 
            // UpperPipe
            // 
            this.UpperPipe.Image = global::final_project.Properties.Resources.pipedown;
            this.UpperPipe.Location = new System.Drawing.Point(550, -100);
            this.UpperPipe.Name = "UpperPipe";
            this.UpperPipe.Size = new System.Drawing.Size(110, 317);
            this.UpperPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpperPipe.TabIndex = 1;
            this.UpperPipe.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::final_project.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(75, 250);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(80, 60);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            // 
            // BackGroundMusicPlayer
            // 
            this.BackGroundMusicPlayer.Enabled = true;
            this.BackGroundMusicPlayer.Location = new System.Drawing.Point(815, 708);
            this.BackGroundMusicPlayer.Name = "BackGroundMusicPlayer";
            this.BackGroundMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BackGroundMusicPlayer.OcxState")));
            this.BackGroundMusicPlayer.Size = new System.Drawing.Size(158, 49);
            this.BackGroundMusicPlayer.TabIndex = 18;
            this.BackGroundMusicPlayer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(983, 761);
            this.Controls.Add(this.BackGroundMusicPlayer);
            this.Controls.Add(this.labSystemInfo);
            this.Controls.Add(this.txbSystemInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txbServerPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbServerIP);
            this.Controls.Add(this.labServerIP);
            this.Controls.Add(this.txbPlayerName);
            this.Controls.Add(this.labPlayerName);
            this.Controls.Add(this.labOnLinePlayer);
            this.Controls.Add(this.OnLinePlayerList);
            this.Controls.Add(this.pictureOnLinePlayer);
            this.Controls.Add(this.labGameOver);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.LowerPipe);
            this.Controls.Add(this.UpperPipe);
            this.Controls.Add(this.Bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ㄛㄛㄛ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnLinePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGroundMusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox UpperPipe;
        private System.Windows.Forms.PictureBox LowerPipe;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label labGameOver;
        private System.Windows.Forms.PictureBox pictureOnLinePlayer;
        private System.Windows.Forms.ListBox OnLinePlayerList;
        private System.Windows.Forms.Label labOnLinePlayer;
        private System.Windows.Forms.Label labPlayerName;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.TextBox txbServerIP;
        private System.Windows.Forms.Label labServerIP;
        private System.Windows.Forms.TextBox txbServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txbSystemInfo;
        private System.Windows.Forms.Label labSystemInfo;
        private AxWMPLib.AxWindowsMediaPlayer BackGroundMusicPlayer;
    }
}

