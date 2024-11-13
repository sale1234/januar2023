using Biblioteka;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerskiDeo
{
    public class Server
    {
        private Socket serverSoket;
        private List<Radnik> radnici = Kontroler.Instanca.VratiRadnike();
        private List<ClientHandler> clients = new List<ClientHandler>();
        internal void Start()
        {
            if(serverSoket == null)
            {
                serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSoket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000));
                serverSoket.Listen(5);
            }
        }

        internal void HandleClients()
        {
            try
            {
                while(true)
                {
                    Socket klijentSoket = serverSoket.Accept();
                    ClientHandler handler = new ClientHandler(klijentSoket, clients, radnici);
                    clients.Add(handler);
                    Thread thread = new Thread(handler.HandleRequests);
                    thread.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>> " + ex.Message);
            }
        }
    }
}
