using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KlijentskiDeo
{
    public class Komunikacija
    {
        private static Komunikacija instanca;

        private Komunikacija()
        {

        }

        public static Komunikacija Instanca
        {
            get
            {
                if (instanca == null) instanca = new Komunikacija();
                return instanca;
            }
        }

        public Radnik UlogovaniRadnik { get; internal set; }

        private Socket socket;
        private CommunicationHelper helper;
        internal void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9000);
            helper = new CommunicationHelper(socket);
        }

        internal void Salji(Poruka poruka)
        {
            helper.SendRequest(poruka);
        }

        internal Poruka Citaj()
        {
            return helper.ReadMessage<Poruka>();
        }
    }
}
