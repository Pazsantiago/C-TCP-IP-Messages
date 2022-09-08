using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFinoTCP
{
    public partial class Servidor : Form
    {
        public Servidor()
        {
            InitializeComponent();
        }
        IPHostEntry servidorHost;
        IPAddress serverIP;
        Socket listener;
        IPEndPoint remoteEP;
        Boolean finish;
        private void empezarSv_Click(object sender, EventArgs e)
        {
            empezarSv.BackColor = Color.Green;
            servidorHost = Dns.GetHostEntry("localHost");
            serverIP = this.servidorHost.AddressList[0];
            int puerto = 50288;
            remoteEP = new IPEndPoint(serverIP, puerto);
            listener = new Socket(serverIP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(remoteEP);
            listener.Listen(5);
        }
        public string recibirTexto()
        {
            byte[] buffer = new byte[1024];
            int p = listener.Receive(buffer);
            string msgRecibido = ASCIIEncoding.ASCII.GetString(buffer, 0, p);
            finish = true;
            return msgRecibido;
        }

        private void pararSv_Click(object sender, EventArgs e)
        {
            if (finish)
            {
                listener.Close();
                Application.Exit();
            }
        }


        private void btrecibirMsg_Click(object sender, EventArgs e)
        {
            Socket h = listener.Accept();
            tbMensajes.Text = recibirTexto();
        }

        private void enviarMensajebtn_Click(object sender, EventArgs e)
        { 
            byte[] mensaje = Encoding.ASCII.GetBytes(tbMensajeEnviar.Text);
            listener.SendAsync(mensaje, SocketFlags.None);
            
        }
    }
}
