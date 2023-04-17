using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listener l = new Listener();
           

            Client c = new Client();
            c.sendMessage();
            c.closeClient();

        }
    }
}
