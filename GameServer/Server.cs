﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace GameServer
{
    class Server
    {
        static void Main(string[] args)
        {
            IPAddress localhost;

            bool ipIsOk = IPAddress.TryParse("127.0.0.1", out localhost);
            if (!ipIsOk) { Console.WriteLine("ip adres kan niet geparsed worden."); Environment.Exit(1); }

            TcpListener listener = new TcpListener(localhost, 80);
            listener.Start();

            while (true)
            {
                Console.WriteLine(@"
                      ==============================================
                        Server started at {0}
                        Waiting for connection
                      =============================================="
                , DateTime.Now);

                TcpClient client1 = listener.AcceptTcpClient();
                SendMessage(client1, new
                {
                    id = "waiting"
                });
                TcpClient client2 = listener.AcceptTcpClient();
                SendMessage(client2, new
                {
                    id = "waiting"
                });

                Thread thread = new Thread(() => HandleClientThread(client1, client2));
                thread.Start();
            }
        }

        static void HandleClientThread(object obj1, object obj2)
        {
            TcpClient client1 = obj1 as TcpClient;
            TcpClient client2 = obj2 as TcpClient;

            SendMessage(client1, new
            {
                id = "opponentConnected"
            });

            bool win1 = false;
            bool win2 = false;

            SendMessage(client1, new
            {
                id = "yourTurn",
                mark = "X"
            });

            SendMessage(client2, new
            {
                id = "opponentTurn",
                mark = "O"
            });

            while (!win1 && !win2)
            {
                JObject received = ReadMessage(client1);
                switch ((string)received["id"])
                {
                    case ("opponentSet"):
                        SendMessage(client2, received);
                        win1 = Boolean.Parse((string)received["data"]["won"]);
                        break;
                    case ("disconnected"):
                        SendMessage(client2, received);
                        win1 = true;
                        break;
                }

                if (win1)
                    break;

                received = ReadMessage(client2);
                switch ((string)received["id"])
                {
                    case ("opponentSet"):
                        SendMessage(client1, received);
                        win2 = Boolean.Parse((string)received["data"]["won"]);
                        break;
                    case ("disconnected"):
                        SendMessage(client2, received);
                        win2 = true;
                        break;
                }
            }

            if (client1.Connected)
            {
                client1.Close();
            }
            if (client2.Connected)
            {
                client2.Close();
            }
        }

        public static JObject ReadMessage(TcpClient client)
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

                message.AppendFormat("{0}", Encoding.ASCII.GetString(receiveBuffer, 0, numberOfBytesRead));

            }
            while (message.Length < receiveBuffer.Length);

            string response = message.ToString();
            return JObject.Parse(response);
        }

        public static void SendMessage(TcpClient client, dynamic message)
        {
            NetworkStream stream = client.GetStream();
            string json = JsonConvert.SerializeObject(message);

            byte[] prefixArray = BitConverter.GetBytes(json.Length);
            byte[] requestArray = Encoding.Default.GetBytes(json);

            byte[] buffer = new Byte[prefixArray.Length + json.Length];
            prefixArray.CopyTo(buffer, 0);
            requestArray.CopyTo(buffer, prefixArray.Length);
            stream.Write(buffer, 0, buffer.Length);
        }
    }
}
