using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sockets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SendMessageFromSocket(int port = 11000)
        {
// Буфер для входящих данных
            byte[] bytes = new byte[1024];
// Соединяемся с удаленным устройством
// Устанавливаем удаленную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);
            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
// Соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);
            string message = DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "#" +
                             DateTime.Now.Hour + ":" + DateTime.Now.Minute + textBox1.Text + "#" + textBox2.Text;
            Console.WriteLine("Сокет соединяется с {0} ", sender.RemoteEndPoint.ToString());
            byte[] msg = Encoding.UTF8.GetBytes(message);
// Отправляем данные через сокет
            int bytesSent = sender.Send(msg);
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SendMessageFromSocket();
        }
    }
}