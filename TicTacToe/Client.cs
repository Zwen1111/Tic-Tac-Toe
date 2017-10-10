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
                //form.TextConsole.Text = form.TextConsole.Text + response + "\n";

                switch ((string)response["id"])
                {
                    case "usernameRequest":
                        SendMessage(new
                        {
                            username = form.username
                        });
                        break;
                    case ("yourTurn"):
                        form.SetMark((string)response["mark"]);
                        form.AddMessageToConsole("Your turn...");
                        form.EnableButtons();
                        break;
                    case ("opponentTurn"):
                        form.SetMark((string)response["mark"]);
                        form.AddMessageToConsole("Opponents turn...");
                        form.DisableButtons();
                        break;
                    case ("opponentSet"):
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
                        break;
                    case ("waiting"):
                        form.AddMessageToConsole("Waiting for an opponent");
                        break;
                    case ("opponentConnected"):
                        form.AddMessageToConsole((string)response["data"]);
                        break;
                    case ("won"):
                        form.AddMessageToConsole("You won!");
                        done = true;
                        break;
                }
            }

            form.DisableButtons();

            client.Close();
        }

        public JObject ReadMessage()
        {
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
    }
}
