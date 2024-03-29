﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Client
    {
        private TcpClient client;
        private NetworkStream stream;

        public Client(string ip)
        {
            client = new TcpClient();
            client.Connect(ip, 8888); 
            stream = client.GetStream();
        }

        public void sendMessage()
        {
            byte[] message = System.Text.Encoding.ASCII.GetBytes("Spune te rog ca mierge");
            stream.Write(message, 0, message.Length);
        }

        public void sendCurrentCard(string card)
        {
            byte[] message = System.Text.Encoding.ASCII.GetBytes(card);
            stream.Write(message, 0, message.Length);
        }

        public void closeClient()
        {
            client.Close();
        }
    }
}
