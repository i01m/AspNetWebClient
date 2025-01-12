using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string host = "127.0.0.1";
                TcpClient client = new TcpClient();
                client.Connect(host,7777);

                NetworkStream stream = client.GetStream();

                StreamReader reader = new StreamReader(stream, Encoding.UTF8);

                Console.WriteLine("Reading from the server:");
                Console.WriteLine(reader.ReadToEnd());

                reader.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
