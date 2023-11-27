using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Media;


namespace final_project
{
    public partial class Form1 : Form
    {
        Socket T;
        Thread Th;
        string User;
        int PipeSpeed = 5;
        int Gravity = 5;
        int Score = 0;
        int Rand_gap;
        bool IsEnd = false;
        bool IsConnect = false;
        Random Rd = new Random();
        SoundPlayer sp = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (IsConnect)
            {
                Bird.Top += Gravity;
                LowerPipe.Left -= PipeSpeed;
                UpperPipe.Left -= PipeSpeed;
                labScore.Text = "Score:" + Score;

                if (LowerPipe.Right < -5)
                {
                    Rand_gap = Rd.Next(0, 3);
                    switch (Rand_gap)
                    {
                        case 0:
                            UpperPipe.Location = new Point(800, -100);
                            LowerPipe.Location = new Point(800, 400);
                            break;
                        case 1:
                            UpperPipe.Location = new Point(800, 0);
                            LowerPipe.Location = new Point(800, 500);
                            break;
                        case 2:
                            UpperPipe.Location = new Point(800, -200);
                            LowerPipe.Location = new Point(800, 300);
                            break;
                    }
                    Score++;
                    Send("1" + User + ":" + Score.ToString());
                    sp = new SoundPlayer(@"Score.wav");
                    sp.Play();
                }

                if (Bird.Bounds.IntersectsWith(UpperPipe.Bounds) ||
                    Bird.Bounds.IntersectsWith(LowerPipe.Bounds) ||
                    Bird.Bounds.IntersectsWith(Ground.Bounds))
                {
                    EndGame();
                }

                if (Bird.Top <= 0)
                {
                    Bird.Top = 0;
                }

                if (Score > 5)
                {
                    PipeSpeed = 10;
                }
                if (Score > 15)
                {
                    PipeSpeed = 15;
                }
                if (Score > 30)
                {
                    PipeSpeed = 20;
                }

                if (IsEnd)
                {
                    GameTimer.Stop();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Gravity = -10;

                if (IsEnd)
                {
                    IsEnd = false;
                    Reset();
                    GameTimer.Start();
                }
            }
        }

        private void Reset()
        {
            Bird.Location = new Point(75, 250);
            UpperPipe.Location = new Point(550, -100);
            LowerPipe.Location = new Point(550, 400);
            Score = 0;
            PipeSpeed = 5;
            labGameOver.Text = "";
            labScore.Text = "Score:" + Score;
            Send("1" + User + ":" + Score.ToString());
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Gravity = 5;
            }
        }

        private void EndGame()
        {
            sp = new SoundPlayer(@"GameOver.wav");
            sp.Play();
            labGameOver.Text = "Game Over !";
            Send("1" + User + ":" + "Game Over !");
            IsEnd = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labGameOver.Text = "";
            BackGroundMusicPlayer.URL = string.Format(@"BackGroundMusic.mp3");
            BackGroundMusicPlayer.settings.setMode("loop", true);
            BackGroundMusicPlayer.settings.volume = 10;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            User = txbPlayerName.Text;
            string IP = txbServerIP.Text;
            int Port = int.Parse(txbServerPort.Text);
            try
            {
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse(IP), Port);
                T = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                T.Connect(EP);
                Th = new Thread(Listen);
                Th.IsBackground = true;
                Th.Start();
                txbSystemInfo.Text = "Connected!" + "\r\n";
                Send("0" + User + ":" + Score.ToString());
                btnConnect.Enabled = false;
                IsConnect = true;
                txbPlayerName.Enabled = false;
                txbServerIP.Enabled = false;
                txbServerPort.Enabled = false;
            }
            catch
            {
                txbSystemInfo.Text = "Can Not Connect!" + "\r\n";
            }
        }

        private void Listen()
        {
            EndPoint ServerIP = (EndPoint)T.RemoteEndPoint;
            byte[] B = new byte[1023];
            int inLen = 0;
            string Msg;
            string St;
            string Str;
            while (true)
            {
                try
                {
                    inLen = T.ReceiveFrom(B, ref ServerIP);
                }
                catch (Exception)
                {
                    T.Close();
                    OnLinePlayerList.Items.Clear();
                    IsConnect = false;
                    MessageBox.Show("Disconnected!");
                    btnConnect.Enabled = true;
                    txbSystemInfo.Text = "Can Not Connect!" + "\r\n";
                    Th.Abort();

                }
                Msg = Encoding.Default.GetString(B, 0, inLen);
                St = Msg.Substring(0, 1);
                Str = Msg.Substring(1);
                switch (St)
                {
                    case "L":
                        OnLinePlayerList.Items.Clear();
                        string[] M = Str.Split(',');
                        for (int i = 0; i < M.Length; i++)
                        {
                            OnLinePlayerList.Items.Add(M[i]);
                        }
                        break;
                }
            }
        }

        private void Send(string Str)
        {
            try
            {
                byte[] B = Encoding.Default.GetBytes(Str);
                T.Send(B, 0, B.Length, SocketFlags.None);
            }
            catch {
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsConnect)
            {
                Gravity = -10;

                if (IsEnd)
                {
                    IsEnd = false;
                    Reset();
                    GameTimer.Start();
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsConnect)
            {
                Gravity = 5;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnConnect.Enabled == false)
            {
                Send("9" + User);
                T.Close();
            }
            sp.Dispose();
        } 
    }
}
