using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void sendCurrentCard(string card, int player)
        {
            if (player == 1) card = "1" + card; 
            else if(player ==2) card = "2" + card;
            byte[] message = System.Text.Encoding.ASCII.GetBytes(card + "\n");
            stream.Write(message, 0, message.Length);
        }

        public void sendPlayerDeck(string card, int player)
        {
            if (player == 2) card = "d" + card;
            byte[] message = System.Text.Encoding.ASCII.GetBytes(card + "\n"); 
            stream.Write(message, 0 ,message.Length);
        }

        public void sendTakenCard(string card, int player)
        {
            if (player == 1) card = "1" + card; 
            else if(player ==2) card = "2" + card;
            card = "t" + card;
            byte[] message = System.Text.Encoding.ASCII.GetBytes(card + "\n");
            stream.Write(message, 0, message.Length);
        }

        public void sendCardCount(string count, int player)
        {
            if (player == 1) count = "1" + count;
            else if (player == 2) count = "2" + count;
            count = "c" + count;
            byte[] message = System.Text.Encoding.ASCII.GetBytes(count + "\n");
            stream.Write(message, 0, message.Length);
        }

        public void sendWinnerWinner(int player)
        { string message = "";
            if (player == 1)
                message = "1" + message;
            else if(player ==2) 
                message = "2" + message;
            message = "w" + message;
            byte[] messagee = System.Text.Encoding.ASCII.GetBytes(message + "\n");
            stream.Write(messagee, 0, messagee.Length);
        }

        public void sendLabelWinnerMessage(string msg)
        {
            msg = "m" + msg;
            byte[] message = System.Text.Encoding.ASCII.GetBytes(msg + "\n");
            stream.Write(message, 0, message.Length);
        }

        public void closeClient()
        {
            client.Close();
        }
    }
}
