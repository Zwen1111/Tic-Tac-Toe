using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TicTacToe
{
    class Client
    {
        static TcpClient client;

        public Client()
        {
            client = new TcpClient("127.0.0.1", 80);
            Console.WriteLine("Waiting for opponent...");

            Console.WriteLine(ReadMessage(client));

            bool done = false;
            while (!done)
            {
                string response = ReadMessage(client);
                Console.WriteLine("\nResponse: " + response);
                done = response.Equals("BYE");

                int hoi;
                bool parsable = int.TryParse(response.Substring(0,1), out hoi);
                if(parsable)
                    Console.Write("Your answer: ");

                Thread thread = new Thread(() => WriteServer());
                thread.Start();
                while (!client.GetStream().DataAvailable) { }
                thread.Abort();
            }
        }

        public void WriteServer()
        {
            SendMessage(client, Console.ReadLine());
        }

        public string ReadMessage(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StringBuilder message = new StringBuilder();
            int numberOfBytesRead = 0;
            byte[] messageBytes = new byte[4];
            stream.Read(messageBytes, 0, messageBytes.Length);
            byte[] receiveBuffer = new byte[BitConverter.ToInt32(messageBytes, 0)];

            do
            {
                numberOfBytesRead = stream.Read(receiveBuffer, 0, receiveBuffer.Length);

                message.AppendFormat("{0}", Encoding.UTF8.GetString(receiveBuffer, 0, numberOfBytesRead));

            }
            while (message.Length < receiveBuffer.Length);

            string response = message.ToString();
            return response;
        }

        public void SendMessage(TcpClient client, string message)
        {
            NetworkStream stream = client.GetStream();

            byte[] prefixArray = BitConverter.GetBytes(message.Length);
            byte[] requestArray = Encoding.UTF8.GetBytes(message);

            byte[] buffer = new Byte[prefixArray.Length + message.Length];
            prefixArray.CopyTo(buffer, 0);
            requestArray.CopyTo(buffer, prefixArray.Length);
            stream.Write(buffer, 0, buffer.Length);
        }
    }
}
