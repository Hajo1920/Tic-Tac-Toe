using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool checkBoxClicked(Image image)
        {
            if (image == null) return false;

            // Compare image sources or unique identifiers
            return (image.Tag != null &&
                    (image.Tag.ToString() == "O" || image.Tag.ToString() == "X"));
        }
        bool checkAllBoxesClicked()
        {

            if (pbOne.Image.Tag.ToString() == "Q") return false;
            if (pbTwo.Image.Tag.ToString() == "Q") return false;
            if (pbThree.Image.Tag.ToString() == "Q") return false;
            if (pbFour.Image.Tag.ToString() == "Q") return false;
            if (pbFive.Image.Tag.ToString() == "Q") return false;
            if (pbSix.Image.Tag.ToString() == "Q") return false;
            if (pbSeven.Image.Tag.ToString() == "Q") return false;
            if (pbEight.Image.Tag.ToString() == "Q") return false;
            if (pbNine.Image.Tag.ToString() == "Q") return false;

            return true;

        }
        void PlayerInitialState()
        {
            lbPlayer.Text = "Player 1";
            lbWinner.Text = "InProgress";
            lbWinner.ForeColor = Color.Black;
        }

        void GameBoardInitialState()
        {
            pbOne.Image = Resources.Q;
            pbTwo.Image = Resources.Q;
            pbThree.Image = Resources.Q;
            pbFour.Image = Resources.Q;
            pbFive.Image = Resources.Q;
            pbSix.Image = Resources.Q;
            pbSeven.Image = Resources.Q;
            pbEight.Image = Resources.Q;
            pbNine.Image = Resources.Q;

            pbOne.Image.Tag = "Q";
            pbTwo.Image.Tag = "Q";
            pbThree.Image.Tag = "Q";
            pbFour.Image.Tag = "Q";
            pbFive.Image.Tag = "Q";
            pbSix.Image.Tag = "Q";
            pbSeven.Image.Tag = "Q";
            pbEight.Image.Tag = "Q";
            pbNine.Image.Tag = "Q";
        }
        void BoardBackColorIntialState()
        {
            pbOne.BackColor = Color.White;
            pbTwo.BackColor = Color.White;
            pbThree.BackColor = Color.White;
            pbFour.BackColor = Color.White;
            pbFive.BackColor = Color.White;
            pbSix.BackColor = Color.White;
            pbSeven.BackColor = Color.White;
            pbEight.BackColor = Color.White;
            pbNine.BackColor = Color.White;

        }
        void InitialGameState()
        {
            PlayerInitialState();
            GameBoardInitialState();
            BoardBackColorIntialState();
        }

        void SetPlayerOneWinner()
        {
            lbPlayer.Text = "Player 1";
            lbWinner.Text = "Winner";
            lbWinner.ForeColor = Color.Green;
            if (!checkAllBoxesClicked())
            {
                MessageBox.Show("Player 1 Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }
        void SetPlayerTwoWinner()
        {
            lbPlayer.Text = "Player 2";
            lbWinner.Text = "Winner";
            lbWinner.ForeColor = Color.Green;
            if (!checkAllBoxesClicked())
            {
                MessageBox.Show("Player 2 Won", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        bool checkVerticalLineWin()
        {
            bool win = false;
            if (pbOne.Image.Tag.ToString() == "X" && pbTwo.Image.Tag.ToString() == "X" && pbThree.Image.Tag.ToString() == "X")
            {
                SetPlayerTwoWinner();
                pbOne.BackColor = Color.Green;
                pbTwo.BackColor = Color.Green;
                pbThree.BackColor = Color.Green;

                win = true;

            }
            else if (pbOne.Image.Tag.ToString() == "O" && pbTwo.Image.Tag.ToString() == "O" && pbThree.Image.Tag.ToString() == "O")
            {
                SetPlayerOneWinner();
                pbOne.BackColor = Color.Green;
                pbTwo.BackColor = Color.Green;
                pbThree.BackColor = Color.Green;
                win = true;
            }

            if (pbFour.Image.Tag.ToString() == "X" && pbFive.Image.Tag.ToString() == "X" && pbSix.Image.Tag.ToString() == "X")
            {
                SetPlayerTwoWinner();
                pbFour.BackColor = Color.Green;
                pbFive.BackColor = Color.Green;
                pbSix.BackColor = Color.Green;
                win = true;
            }
            else if (pbFour.Image.Tag.ToString() == "O" && pbFive.Image.Tag.ToString() == "O" && pbSix.Image.Tag.ToString() == "O")
            {
                SetPlayerOneWinner();
                pbFour.BackColor = Color.Green;
                pbFive.BackColor = Color.Green;
                pbSix.BackColor = Color.Green;
                win = true;
            }

            if (pbSeven.Image.Tag.ToString() == "X" && pbEight.Image.Tag.ToString() == "X" && pbNine.Image.Tag.ToString() == "X")
            {
                SetPlayerTwoWinner();
                pbSeven.BackColor = Color.Green;
                pbEight.BackColor = Color.Green;
                pbNine.BackColor = Color.Green;
                win = true;
            }
            else if (pbSeven.Image.Tag.ToString() == "O" && pbEight.Image.Tag.ToString() == "O" && pbNine.Image.Tag.ToString() == "O")
            {
                SetPlayerOneWinner();
                pbSeven.BackColor = Color.Green;
                pbEight.BackColor = Color.Green;
                pbNine.BackColor = Color.Green;
                win = true;
            }

            return win;
        }

        bool checkHorizontalLineWin()
        {
            bool win = false;
            if (pbOne.Image.Tag.ToString() == "X" && pbFour.Image.Tag.ToString() == "X" && pbSeven.Image.Tag.ToString() == "X")
            {
                SetPlayerTwoWinner();
                pbOne.BackColor = Color.Green;
                pbFour.BackColor = Color.Green;
                pbSeven.BackColor = Color.Green;

                win = true;
            }
            else if (pbOne.Image.Tag.ToString() == "O" && pbFour.Image.Tag.ToString() == "O" && pbSeven.Image.Tag.ToString() == "O")
            {
                SetPlayerOneWinner();
                pbOne.BackColor = Color.Green;
                pbFour.BackColor = Color.Green;
                pbSeven.BackColor = Color.Green;
                win = true;
            }

            if (pbTwo.Image.Tag.ToString() == "X" && pbFive.Image.Tag.ToString() == "X" && pbEight.Image.Tag.ToString() == "X")
            {
                SetPlayerTwoWinner();
                pbTwo.BackColor = Color.Green;
                pbFive.BackColor = Color.Green;
                pbEight.BackColor = Color.Green;
                win = true;
            }
            else if (pbTwo.Image.Tag.ToString() == "O" && pbFive.Image.Tag.ToString() == "O" && pbEight.Image.Tag.ToString() == "O")
            {
                SetPlayerOneWinner();
                pbTwo.BackColor = Color.Green;
                pbFive.BackColor = Color.Green;
                pbEight.BackColor = Color.Green;
                win = true;
            }

            if (pbThree.Image.Tag.ToString() == "X" && pbSix.Image.Tag.ToString() == "X" && pbNine.Image.Tag.ToString() == "X")
            {
                SetPlayerTwoWinner();
                pbThree.BackColor = Color.Green;
                pbSix.BackColor = Color.Green;
                pbNine.BackColor = Color.Green;
                win = true;
            }
            else if (pbThree.Image.Tag.ToString() == "O" && pbSix.Image.Tag.ToString() == "O" && pbNine.Image.Tag.ToString() == "O")
            {
                SetPlayerOneWinner();
                pbThree.BackColor = Color.Green;
                pbSix.BackColor = Color.Green;
                pbNine.BackColor = Color.Green;
                win = true;
            }

            return win;
        }

        bool checkDiagonalLineWin()
        {
            bool win = false;
            if (pbOne.Image.Tag.ToString() == "X" && pbFive.Image.Tag.ToString() == "X" && pbNine.Image.Tag.ToString() == "X")
            {
                SetPlayerTwoWinner();
                pbOne.BackColor = Color.Green;
                pbFive.BackColor = Color.Green;
                pbNine.BackColor = Color.Green;
                win = true;
            }
            else if (pbOne.Image.Tag.ToString() == "O" && pbFive.Image.Tag.ToString() == "O" && pbNine.Image.Tag.ToString() == "O")
            {
                SetPlayerOneWinner();
                pbOne.BackColor = Color.Green;
                pbFive.BackColor = Color.Green;
                pbNine.BackColor = Color.Green;
                win = true;
            }

            if (pbThree.Image.Tag.ToString() == "X" && pbFive.Image.Tag.ToString() == "X" && pbSeven.Image.Tag.ToString() == "X")
            {
                SetPlayerTwoWinner();
                pbThree.BackColor = Color.Green;
                pbFive.BackColor = Color.Green;
                pbSeven.BackColor = Color.Green;
                win = true;
            }
            else if (pbThree.Image.Tag.ToString() == "O" && pbFive.Image.Tag.ToString() == "O" && pbSeven.Image.Tag.ToString() == "O")
            {
                SetPlayerOneWinner();
                pbThree.BackColor = Color.Green;
                pbFive.BackColor = Color.Green;
                pbSeven.BackColor = Color.Green;
                win = true;
            }

            return win;

        }

        void checkGameWinner()
        {
            
                checkVerticalLineWin();
                checkHorizontalLineWin();
                checkDiagonalLineWin();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           InitialGameState();   
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.Black;
            Pen pen = new Pen(color);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 550, 100, 550, 400);
            e.Graphics.DrawLine(pen, 450, 100, 450, 400); // |

            e.Graphics.DrawLine(pen, 350, 200, 650, 200); // ___
            e.Graphics.DrawLine(pen, 350, 300, 650, 300);
        }

        private void Box_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (checkBoxClicked(pb.Image))
            {
                MessageBox.Show("Box already used !", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbPlayer.Text == "Player 1")
            {
                pb.Image = Resources.O;
                pb.Image.Tag = "O";
                lbPlayer.Text = "Player 2";
            }
            else
            {
                pb.Image = Resources.X;
                pb.Image.Tag = "X";
                lbPlayer.Text = "Player 1";
            }

            checkGameWinner();
            if (checkAllBoxesClicked())
            {

                if (!checkDiagonalLineWin() && !checkHorizontalLineWin() && !checkVerticalLineWin())
                {
                    lbWinner.Text = "Draw";
                    lbWinner.ForeColor = Color.Blue;
                }
                MessageBox.Show("Game Over", "Boxes Filled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            InitialGameState();
        }
    }
}
