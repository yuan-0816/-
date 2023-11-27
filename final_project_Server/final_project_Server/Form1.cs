using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;           // 匯入網路通訊協定相關函數
using System.Net.Sockets;   // 匯入網路插座功能函數
using System.Threading;     // 匯入多執行緒功能函數
using System.Collections;   // 匯入集合物件


namespace final_project_Server
{
    public partial class Form1 : Form
    {
        TcpListener Server;
        Socket Client;
        Thread Th_Svr;
        Thread Th_Clt;
        Hashtable HT = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Th_Svr = new Thread(ServerSub);
            Th_Svr.IsBackground = true;
            Th_Svr.Start();
            button1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
        private void ServerSub()
        {
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Server = new TcpListener(EP);
            Server.Start(100);
            while (true)
            {
                Client = Server.AcceptSocket();
                Th_Clt = new Thread(Listen);
                Th_Clt.IsBackground = true;
                Th_Clt.Start();

            }
        }

        private void Listen()
        {
            Socket Sck = Client;
            Thread Th = Th_Clt;
            while (true)
            {
                try
                {
                    byte[] B = new byte[1023];
                    int inLen = Sck.Receive(B);
                    string Msg = Encoding.Default.GetString(B, 0, inLen);
                    string Cmd = Msg.Substring(0, 1);
                    string Str = Msg.Substring(1);
                    switch (Cmd)
                    {
                        case "0":   //上線
                            string[] OnLineUserScore = Str.Split(':');
                            HT.Add(OnLineUserScore[0], Sck);
                            listBox1.Items.Add(Str);
                            if (listBox1.Items.Count > 1)
                                SortOnLineList();
                            SendAll(OnLineList());
                            break;

                        case "9":   //下線
                            // Str = UserID
                            HT.Remove(Str);
                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                string tmp = listBox1.Items[i].ToString();
                                if (tmp.Split(':')[0] == Str)
                                    listBox1.Items.Remove(listBox1.Items[i]);
                            }
                            if (listBox1.Items.Count > 1)
                                SortOnLineList();
                            SendAll(OnLineList());
                            Th.Abort();
                            break;

                        case "1":   //update Score
                            // Str = UserID:Score
                            string[] UserScore = Str.Split(':');
                            // UserScore[0] = User
                            // UserScore[1] = Score or "Game Over !"
                            for (int i = 0; i < listBox1.Items.Count; i++)
                            {
                                string tmp = listBox1.Items[i].ToString();
                                if (tmp.Split(':')[0] == UserScore[0])
                                    listBox1.Items[i] = Str;
                            }
                            SortOnLineList();
                            SendAll(OnLineList());
                            break;
                    }

                }
                catch (Exception)
                {

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = MyIP();
        }
        private string MyIP()
        {
            string hn = Dns.GetHostName();
            IPAddress[] IP = Dns.GetHostEntry(hn).AddressList;
            foreach (IPAddress it in IP)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork)
                {
                    return it.ToString();
                }
            }
            return "";
        }

        private string OnLineList()
        {
            string L = "L";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                L += listBox1.Items[i];
                if (i < listBox1.Items.Count - 1)
                {
                    L += ",";
                }
            }
            return L;
        }

        private void SortOnLineList()
        {
            string tmp;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = i + 1; j < listBox1.Items.Count; j++)
                {
                    if (listBox1.Items[i].ToString().Split(':')[1] == "Game Over !" && listBox1.Items[j].ToString().Split(':')[1] != "Game Over !")
                    {
                        tmp = listBox1.Items[i].ToString();
                        listBox1.Items[i] = listBox1.Items[j].ToString();
                        listBox1.Items[j] = tmp;

                    }
                    if (listBox1.Items[i].ToString().Split(':')[1] != "Game Over !" && listBox1.Items[j].ToString().Split(':')[1] != "Game Over !") 
                    { 
                        if (int.Parse(listBox1.Items[i].ToString().Split(':')[1]) < int.Parse(listBox1.Items[j].ToString().Split(':')[1]))
                        {
                            tmp = listBox1.Items[i].ToString();
                            listBox1.Items[i] = listBox1.Items[j].ToString();
                            listBox1.Items[j] = tmp;
                        }
                    }
                }
            }
        }

        private void SendAll(String Str)
        {
            byte[] B = Encoding.Default.GetBytes(Str);
            foreach (Socket s in HT.Values)
            {
                s.Send(B, 0, B.Length, SocketFlags.None);
            }
        }
    }
}
