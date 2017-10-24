using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TicTacToe
{
    class Client
    {
        TcpClient client;
        TicTacToe form;
        NetworkStream stream;
        Boolean done;

        public Client(TicTacToe ticTacToe)
        {
            this.form = ticTacToe;
            client = new TcpClient("127.0.0.1", 80);
            stream = client.GetStream();
        }

        public void StartGame()
        {
            form.ClearField();

            done = false;
            while(!done)
            {
                JObject response = ReadMessage();

                switch ((string)response["id"])
                {
                    case "usernameRequest":
                        new Thread(() => 
                        SendMessage(new
                        {
                            username = form.username
                        })
                        ).Start();
                        break;
                    case ("yourTurn"):
                        new Thread(() => MyTurn(response)).Start();
                        break;
                    case ("opponentTurn"):
                        new Thread(() => OpponentTurn(response)).Start();
                        break;
                    case ("opponentSet"):
                        new Thread(() => OpponentSet(response)).Start();
                        break;
                    case ("waiting"):
                        new Thread(() => form.AddMessageToConsole("Waiting for an opponent")).Start();
                        break;
                    case ("opponentConnected"):
                        new Thread(() => form.AddMessageToConsole((string)response["data"])).Start();
                        break;
                    case ("won"):
                        new Thread(() => Won()).Start();
                        break;
                    case ("disconnected"):
                        new Thread(() => Disconnected()).Start();
                        break;
                }
            }

            form.DisableButtons();

            client.Close();
        }

        private void Disconnected()
        {
            form.AddMessageToConsole("The opponent lost connection");
            done = true;
        }

        private void Won()
        {
            form.AddMessageToConsole("You won!");
            done = true;
        }

        private void OpponentSet(JObject response)
        {
            form.SetButton((int)response["data"]["x"], (int)response["data"]["y"], (string)response["data"]["mark"]);
            done = Boolean.Parse((string)response["data"]["won"]);
            if (!done)
            {
                form.EnableButtons();
                form.AddMessageToConsole("Your turn...");
            }
            else
            {
                form.AddMessageToConsole("You lost!");
            }
        }

        private void OpponentTurn(JObject response)
        {
            form.SetMark((string)response["mark"]);
            form.AddMessageToConsole("Opponents turn...");
            form.DisableButtons();
        }

        private void MyTurn(JObject response)
        {
            form.SetMark((string)response["mark"]);
            form.AddMessageToConsole("Your turn...");
            form.EnableButtons();
        }

        public JObject ReadMessage()
        {
            StringBuilder message = new StringBuilder();
            try
            {
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
            }catch(Exception e) { }

            string response = message.ToString();
            if (response.Equals(""))
            {
                dynamic winningMessage = new
                {
                    id = "won"
                };
                return JObject.Parse(JsonConvert.SerializeObject(winningMessage));
            }
            return JObject.Parse(response);
        }

        public void SendMessage(dynamic message)
        {
            string json = JsonConvert.SerializeObject(message);

            byte[] prefixArray = BitConverter.GetBytes(json.Length);
            byte[] requestArray = Encoding.Default.GetBytes(json);

            byte[] buffer = new Byte[prefixArray.Length + json.Length];
            prefixArray.CopyTo(buffer, 0);
            requestArray.CopyTo(buffer, prefixArray.Length);
            stream.Write(buffer, 0, buffer.Length);

            form.DisableButtons();
        }

        internal void SetWon()
        {
            done = true;
        }

        internal void Close()
        {
            done = true;
            stream.Close();
        }
    }
}
