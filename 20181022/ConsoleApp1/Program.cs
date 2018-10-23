using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ConsoleApp1
{
    class TcpClientTest
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient();
                client.Connect("localhost", 5001);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                string dataToSend = Console.ReadLine();

                while(true)
                {
                    writer.WriteLine(dataToSend);

                    if (dataToSend.IndexOf("<EOF") > -1) break;
                }
            }
        }
    }
}
