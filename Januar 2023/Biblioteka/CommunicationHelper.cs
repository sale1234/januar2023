﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class CommunicationHelper
    {
        private Socket klijentSoket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public CommunicationHelper(Socket klijentSoket)
        {
            this.klijentSoket = klijentSoket;
            stream = new NetworkStream(klijentSoket);
            formatter = new BinaryFormatter();
        }

        public void SendRequest<T>(T poruka) where T : class
        {
            formatter.Serialize(stream, poruka);
        }

        public T ReadMessage<T>() where T : class
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}
