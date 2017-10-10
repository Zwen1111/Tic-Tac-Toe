using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Username : Form
    {
        public Username()
        {
            InitializeComponent();
        }

        private void Confirm_Btn_Click(object sender, EventArgs e)
        {
            if (Username_Txt.TextLength >= 4)
            {
                Form game = new TicTacToe(Username_Txt.Text);
                game.Show();
                this.Hide();
            }
            else
                MessageBox.Show("The username must contain at least 4 characters");
        }
    }
}
