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
namespace EjercicioFinoCliente
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        IPHostEntry servidorHost;
        IPAddress serverIP;
        Socket listener;
        IPEndPoint remoteEP;
        Socket h;
        Boolean finish;
        public string recibirTexto()
        {
            byte[] buffer = new byte[1024];
            int p = h.ReceiveAsync(buffer, SocketFlags.None);
            string msgRecibido = ASCIIEncoding.ASCII.GetString(buffer, 0, p);
            finish = true;
            return msgRecibido;
        }


        private void btnRecibir_Click(object sender, EventArgs e)
        {
            listener.Listen(5);
            tbMensajes.Text = recibirTexto();
        }

        private void btenviarMsg_Click(object sender, EventArgs e)
        {
            
            byte[] mensaje = Encoding.ASCII.GetBytes(tbMensajeEnviar.Text);
            listener.SendAsync(mensaje, SocketFlags.None);
            tbMensajeEnviar.Text = "Mensaje Enviado";
            listener.Close();
            //Application.Exit();
        }

        private void empezarSv_Click(object sender, EventArgs e)
        {
            empezarSv.BackColor = Color.Green;
            servidorHost = Dns.GetHostEntry("localHost");
            serverIP = servidorHost.AddressList[0];
            int puerto = 50288;
            remoteEP = new IPEndPoint(serverIP, puerto);
            listener = new Socket(serverIP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.Connect(remoteEP);
        }
    }
}
