using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatClient.ServiceChat;
namespace ChatClient
{
    public partial class Form1 : Form, IServiceChatCallback
    {
        bool isConnected = false;
        ServiceChatClient client;
        int ID;
        public Form1()
        {
            InitializeComponent();
        }


        void ConnectUser()
        {
            if (!isConnected)
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(textBox2.Text);
                
                textBox2.Enabled = false;
                button1.Text = "Exiter";
                var messages = client.ShowMsg(textBox2.Text);
                if (messages != null)
                {
                    foreach (var m in messages)
                    {
                        if (m != "")
                        {
                            listBox1.Items.Add(m);
                        }
                    }
                }
                isConnected = true;
            }
        }

        void DisconnectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                textBox2.Enabled = true;
                button1.Text = "Se connecter";
                listBox1.Items.Clear();
                isConnected = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                DisconnectUser();
            }
            else
            {
                ConnectUser();
            }
        }

        public void MsgCallback(string msg)
        {
            listBox1.Items.Add(msg);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DisconnectUser();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (client != null)
                {
                    client.SendMsg(textBox1.Text, ID);
                    textBox1.Text = string.Empty;
                }
            }
        }
    }
}
