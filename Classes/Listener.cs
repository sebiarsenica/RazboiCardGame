using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Listener
    {
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;
        

        public Listener()
        {
            listener = new TcpListener(IPAddress.Any, 8888);
            listener.Start();
            client = listener.AcceptTcpClient();
            stream = client.GetStream();
        }

        public async void ListenForMessages()
        {
            while (true)
            {
                byte[] message = new byte[256];
                int bytesRead = stream.Read(message, 0, message.Length);
                string receivedMessage = System.Text.Encoding.ASCII.GetString(message, 0, bytesRead);
            }
        }

        public void Close()
        {
            client.Close();
            listener.Stop();
        }
    }
}
