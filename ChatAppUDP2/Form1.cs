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

namespace ChatAppUDP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void btnTaEmot_Click(object sender, EventArgs e)
        {
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient client = new UdpClient(12345);
            byte[] inström = client.Receive(ref klientEndPoint);
            tbxMeddelande.Text = Encoding.Unicode.GetString(inström);
        }
    }
}
