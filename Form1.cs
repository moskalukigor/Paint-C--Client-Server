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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static Bitmap btmBack = new Bitmap(260, 237);      //изображение
        static Bitmap btmFront = new Bitmap(260, 237);     //фон
        static Graphics grBack = Graphics.FromImage(btmBack);
        static Graphics grFront = Graphics.FromImage(btmFront);  //лучше объявить заранее глобально.
        static short MouseStatus = 0; // 0 - Stop; 1 - Wait; 2 - Wait two click; 3 - Complete 
        Point pt1 = new Point(0, 0);
        Point pt2 = new Point(0, 0);

        TcpClient client;

        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox1.Image = btmFront;
            PictureBox1.BackgroundImage = btmBack;
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;

             if (MouseStatus == 1)
            {
                pt1.X = mouseEventArgs.X;
                pt1.Y = mouseEventArgs.Y;
            }
            if (MouseStatus == 2)
            {
                pt2.X = mouseEventArgs.X;
                pt2.Y = mouseEventArgs.Y; MouseStatus = 3;
            }

            if (MouseStatus == 3)
            {
                grBack.DrawLine(Pens.Black, pt1, pt2); MouseStatus = 0;
            }
            PictureBox1.Refresh();
        }

        private void btnPt1_Click(object sender, EventArgs e)
        {
            MouseStatus = 1;
        }

        private void btnPt2_Click(object sender, EventArgs e)
        {
            MouseStatus = 2;
        }

        private void btnStartDrawning_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),11000);
                
                client = new TcpClient();
                client.Connect(endPoint);

                NetworkStream nstream = client.GetStream();
                byte[] barray = Encoding.Unicode.GetBytes(pt1.ToString());
            }
        }

    }
}
