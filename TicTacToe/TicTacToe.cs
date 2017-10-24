using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        Client client;
        public string username;
        string mark;

        public TextBox TextConsole { get; set; }

        public TicTacToe(string username)
        {
            InitializeComponent();
            this.username = username;
            DisableButtons();
        }

        public void AddMessageToConsole(string message)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(AddMessageToConsole), new object[] { message });
                return;
            }
            Text_Console.AppendText($"{Text_Console.Text} {message} \r\n");
        }

        internal void ClearField()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(ClearField));
                return;
            }
            foreach (Button button in Playing_Field.Controls)
            {
                button.Text = "";
            }
        }

        internal void SetButton(int x, int y, string mark)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<int, int, string>(SetButton), new object[] { x, y, mark });
                return;
            }
            Button button = (Button)Playing_Field.GetControlFromPosition(x, y);
            if (button.Text.Equals(""))
                button.Text = mark;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button1.Enabled = false;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button2.Enabled = false;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button3.Enabled = false;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button4.Enabled = false;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button5.Enabled = false;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button6.Enabled = false;
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button7.Enabled = false;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button8.Enabled = false;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            int x = Playing_Field.GetPositionFromControl((Button)sender).Column;
            int y = Playing_Field.GetPositionFromControl((Button)sender).Row;


            SetButton(x, y, mark);
            client.SendMessage(new
            {
                id = "opponentSet",
                data = new
                {
                    x = x,
                    y = y,
                    mark = mark,
                    won = Won().ToString()
                }
            });
            AddMessageToConsole("Opponents turn...");
            button9.Enabled = false;
        }

        private bool Won()
        {
            int check = 0;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Button button = (Button)Playing_Field.GetControlFromPosition(x, y);
                    if (button.Text.Equals(mark))
                    {
                        check++;
                        if (check == 3)
                        {
                            client.SetWon();
                            return true;
                        }
                    }
                    else
                        check = 0;
                }
                check = 0;
            }

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Button button = (Button)Playing_Field.GetControlFromPosition(x, y);
                    if (button.Text.Equals(mark))
                    {
                        check++;
                        if (check == 3)
                        {
                            client.SetWon();
                            return true;
                        }
                    }
                    else
                        check = 0;
                }
                check = 0;
            }

            if (((Button)Playing_Field.GetControlFromPosition(0, 0)).Text.Equals(mark) && ((Button)Playing_Field.GetControlFromPosition(1, 1)).Text.Equals(mark) && ((Button)Playing_Field.GetControlFromPosition(2, 2)).Text.Equals(mark))
            {
                client.SetWon();
                return true;
            }
            if (((Button)Playing_Field.GetControlFromPosition(0, 2)).Text.Equals(mark) && ((Button)Playing_Field.GetControlFromPosition(1, 1)).Text.Equals(mark) && ((Button)Playing_Field.GetControlFromPosition(2, 0)).Text.Equals(mark))
            {
                client.SetWon();
                return true;
            }
            return false;
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            client = new Client(this);
            Thread thread = new Thread(() => client.StartGame());
            thread.Start();
        }

        public void SetMark(string mark)
        {
            this.mark = mark;
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(SetMark), new object[] { mark });
                return;
            }
            Player.Text = $"You're {mark}";
        }

        public void DisableButtons()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(DisableButtons));
                return;
            }
            foreach (Button button in Playing_Field.Controls)
            {
                button.Enabled = false;
            }
        }

        public void EnableButtons()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(EnableButtons));
                return;
            }
            foreach (Button button in Playing_Field.Controls)
            {
                if(button.Text == "")
                    button.Enabled = true;
            }
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            client.SendMessage(new
            {
                id = "disconnected",
                data = new { }
            });
            client.Close();
        }
    }
}
