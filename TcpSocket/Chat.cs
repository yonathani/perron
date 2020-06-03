using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace TcpSocket
{
    public partial class Chat : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        static private string nick = "unknown";

        private delegate void DAddItem(String s);




        private void AddItem(String s)
        {
            listBox1.Items.Add(s);
        }
        public Chat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnconctar_Click(object sender, EventArgs e)
        {
            {
                lbl1.Visible = false;
                textBox1.Visible = false;
                btnconctar.Visible = false;
            

                nick = textBox1.Text;

                Conectar();

            }
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            streamw.WriteLine(textBox2.Text);
            streamw.Flush();
            textBox2.Clear();
        }
        void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DAddItem(AddItem), streamr.ReadLine());

                }
                catch
                {
                    MessageBox.Show("No se ha podido conectar al servidor");
                    Application.Exit();
                }
            }
        }

        void Conectar()
        {
            try
            {
                client.Connect("127.0.0.1", 8000);
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);

                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);

                    streamw.WriteLine(nick);
                    streamw.Flush();

                    t.Start();
                }
                else
                {
                    MessageBox.Show("Servidor no Disponible");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Servidor no Disponible");
                Application.Exit();
            }
        }
    }
}
