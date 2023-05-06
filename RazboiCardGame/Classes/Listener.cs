using RazboiCardGame;
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
        private Game gameForm;

        public Listener(Game form)
        {
            gameForm = form;
            
        }

        public async void StartListener()
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
                if (stream is not null)
                {
                    int bytesRead = stream.Read(message, 0, message.Length);
                    string receivedMessage = System.Text.Encoding.ASCII.GetString(message, 0, bytesRead);
                    string[] messages = receivedMessage.Split('\n');
                    foreach (string msg in messages)
                    {
                        if (!string.IsNullOrWhiteSpace(msg))
                        {
                            gameForm.computeMessage(msg);
                        }
                    }

                }
            }
        }

        public void Close()
        {
            client.Close();
            listener.Stop();
        }
    }
}
