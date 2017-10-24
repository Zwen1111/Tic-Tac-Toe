namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text_Console = new System.Windows.Forms.TextBox();
            this.Player = new System.Windows.Forms.Label();
            this.Playing_Field = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.Playing_Field.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_Console
            // 
            this.Text_Console.Location = new System.Drawing.Point(12, 12);
            this.Text_Console.Multiline = true;
            this.Text_Console.Name = "Text_Console";
            this.Text_Console.ReadOnly = true;
            this.Text_Console.Size = new System.Drawing.Size(459, 78);
            this.Text_Console.TabIndex = 0;
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.AutoSize = true;
            this.Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.Location = new System.Drawing.Point(185, 110);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(99, 16);
            this.Player.TabIndex = 1;
            this.Player.Text = "You\'re X or O";
            this.Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Playing_Field
            // 
            this.Playing_Field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playing_Field.ColumnCount = 3;
            this.Playing_Field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Playing_Field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Playing_Field.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Playing_Field.Controls.Add(this.button1, 0, 0);
            this.Playing_Field.Controls.Add(this.button2, 1, 0);
            this.Playing_Field.Controls.Add(this.button3, 2, 0);
            this.Playing_Field.Controls.Add(this.button4, 0, 1);
            this.Playing_Field.Controls.Add(this.button5, 1, 1);
            this.Playing_Field.Controls.Add(this.button6, 2, 1);
            this.Playing_Field.Controls.Add(this.button7, 0, 2);
            this.Playing_Field.Controls.Add(this.button8, 1, 2);
            this.Playing_Field.Controls.Add(this.button9, 2, 2);
            this.Playing_Field.Location = new System.Drawing.Point(12, 144);
            this.Playing_Field.Name = "Playing_Field";
            this.Playing_Field.RowCount = 3;
            this.Playing_Field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Playing_Field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Playing_Field.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Playing_Field.Size = new System.Drawing.Size(450, 327);
            this.Playing_Field.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 103);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(153, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 103);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(303, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 103);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(3, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 103);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(153, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 103);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn_5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(303, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 103);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Btn_6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(3, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 103);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Btn_7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(153, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 103);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Btn_8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(303, 221);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 103);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Btn_9_Click);
            // 
            // Start_Btn
            // 
            this.Start_Btn.Location = new System.Drawing.Point(15, 103);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(75, 23);
            this.Start_Btn.TabIndex = 3;
            this.Start_Btn.Text = "Start";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Btn_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(483, 483);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.Playing_Field);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Text_Console);
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.Playing_Field.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Console;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.TableLayoutPanel Playing_Field;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Start_Btn;
    }
}

