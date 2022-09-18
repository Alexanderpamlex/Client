using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SimpleTCP;

namespace WF1
{
    public partial class X : Form
    {

        private bool WhoTurn = true;

        private Controller _controller;
        public X(Controller controller)
        {
            InitializeComponent();
            
            _controller = controller;

        }

        SimpleTcpClient client;

        private void Connect_Click(object sender, EventArgs e)
        {
            Connect.Enabled = false;
            client.Connect("127.0.0.1", 8910);
            
            MessageBox.Show("Подключение установлено!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.Unicode;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            string[] s = e.MessageString.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            int x = Int32.Parse(s[0]);
            int y = Int32.Parse(s[1]);
            _controller.setO(Field, x, y);

            _controller.Win(Field);

            Turn.Invoke((MethodInvoker)delegate ()
            {

                Turn.Text = "X";

            });

            WhoTurn = true;
        }

        public void __Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text == "" && WhoTurn)
            {
                WhoTurn = false;

                Turn.Text = "O";

                _controller.setX((Label)sender);

                int x = Field.GetColumn((Label)sender);
                int y = Field.GetRow((Label)sender);

                client.Write(string.Format("{0}:{1}", x, y));

                _controller.Win(Field);
                
            }
        }


        

        
    }
}
//string[] s = message.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);