namespace TicTacToe_Game
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        string[] gameboard = new string[9];
        int currentTurn = 0;
        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "0";
            }
            else { return "X"; }
        }

        public void checkForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";
                switch (i)
                {
                    case 0:
                        combination = gameboard[0] + gameboard[4] + gameboard[8];
                        break;
                    case 1:
                        combination = gameboard[0] + gameboard[1] + gameboard[2];
                        break;
                    case 2:
                        combination = gameboard[0] + gameboard[3] + gameboard[6];
                        break;
                    case 3:
                        combination = gameboard[1] + gameboard[4] + gameboard[7];
                        break;
                    case 4:
                        combination = gameboard[2] + gameboard[5] + gameboard[8];
                        break;
                    case 5:
                        combination = gameboard[3] + gameboard[4] + gameboard[5];
                        break;
                    case 6:
                        combination = gameboard[2] + gameboard[4] + gameboard[6];
                        break;
                    case 7:
                        combination = gameboard[6] + gameboard[7] + gameboard[8];
                        break;

                }
                
                if (combination.Equals("000"))
                {
                    
                    MessageBox.Show("0 has won!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (combination.Equals("XXX"))
                {
                    
                    MessageBox.Show("X has won!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else checkDraw();
            }
        }
        public void reset() 
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            gameboard = new string[9];
        }
        public void checkDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameboard.Length; i++)
            {
                if (gameboard[i]!=null) counter++;
                if (counter == 9) 
                {
               
                    MessageBox.Show("Draw!", "There is no winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[0] = returnSymbol(currentTurn); 
            button1.Text =gameboard[0];
            checkForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[1] = returnSymbol(currentTurn);
            button2.Text = gameboard[1];
            checkForWinner();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[2] = returnSymbol(currentTurn);
            button3.Text = gameboard[2];
            checkForWinner();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[3] = returnSymbol(currentTurn);
            button4.Text = gameboard[3];
            checkForWinner();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[4] = returnSymbol(currentTurn);
            button5.Text = gameboard[4];
            checkForWinner();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[5] = returnSymbol(currentTurn);
            button6.Text = gameboard[5];
            checkForWinner();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[6] = returnSymbol(currentTurn);
            button7.Text = gameboard[6];
            checkForWinner();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[7] = returnSymbol(currentTurn);
            button8.Text = gameboard[7];
            checkForWinner();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[8] = returnSymbol(currentTurn);
            button9.Text = gameboard[8];
            checkForWinner();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}