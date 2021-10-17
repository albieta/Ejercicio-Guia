using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClienteGuia
{
    public partial class Convertidor : Form
    {
        Socket server;
        public Convertidor()
        {
            InitializeComponent();
        }

        private void convertir_Click(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress direc = IPAddress.Parse("192.168.1.92");
            IPEndPoint ipep = new IPEndPoint(direc, 9070);

            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;

                if(aC.Checked)
                {
                    string mensaje = "1/" + valor.Text;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("El valor introducido en Celsius es: " + mensaje + " Grados Celsius");
                }
                else
                {
                    string mensaje = "2/" + valor.Text;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("El valor introducido en Fahrenheit es: " + mensaje + " Grados Fahrenheit");
                }
                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();
            }
            catch (SocketException)
            {
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }


        }
    }
}
