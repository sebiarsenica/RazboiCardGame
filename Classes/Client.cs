using System;
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
       

        public Client()
        {
            client = new TcpClient();
            client.Connect("272-738-082", 8888); //272-738-043 schimbi aici
            stream = client.GetStream();
          
        }

        public void sendMessage()
        {
            byte[] message = System.Text.Encoding.ASCII.GetBytes("Spune te rog ca mierge");
            stream.Write(message, 0, message.Length);
            Console.WriteLine("Sent message: Hello World!");
        }

        public void closeClient()
        {
            client.Close();
        }
    }
}
