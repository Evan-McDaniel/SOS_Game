using System;
using System.Windows.Forms;

namespace SOS_Game
{
    public partial class Form1 : Form
    {
        private DataGridView gameBoard;
        private int gridSize;
        private GameLogic gameLogic = new GameLogic();

        public Form1()
        {
            InitializeComponent();

            gameLogic.blueChoice = blueChoiceS.Checked ? 'S' : 'O';
            gameLogic.redChoice = redChoiceS.Checked ? 'S' : 'O';

            gridSize = Int32.Parse(boardSize.Text);
            int height = gridSize;
            int width = gridSize;

            //gameBoard.ColumnCount = width;

            this.resizeBoard(gridSize);
            gameBoard.AllowUserToAddRows = false;
        }

        public bool getComputerMode()
        {
            return this.gameLogic.computer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void blueChoiceS_CheckedChanged(object sender, EventArgs e)
        {
            gameLogic.blueChoice = 'S';
        }

        private void blueChoiceO_CheckedChanged(object sender, EventArgs e)
        {
            gameLogic.blueChoice = 'O';
        }
        private void redChoiceS_CheckedChanged(object sender, EventArgs e)
        {
            gameLogic.redChoice = 'S';
        }
        private void redChoiceO_CheckedChanged(object sender, EventArgs e)
        {
            gameLogic.redChoice = 'O';
        }

        private void gameBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = (string)this.gameBoard.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (cellValue == "S" || cellValue == "O")
            {
                MessageBox.Show("Cell is already occupied. Try again.");
                return;
            }
            else
            {
                this.gameBoard.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = gameLogic.getToken().ToString();
                this.gameLogic.playerMoved(e.RowIndex, e.ColumnIndex);
                this.gameLogic.checkSOS(ref this.gameBoard, e.RowIndex, e.ColumnIndex);
                this.gameLogic.playerClicked();
                checkGameWinner();
                this.currentPlayer.Text = gameLogic.playerTurn;
                //Console.WriteLine(gameLogic.playerTurn);
                if ((this.redComputerButton.Checked || this.blueComputerButton.Checked) && !this.gameLogic.checkWinner())
                {
                    this.gameLogic.computerTurn(ref this.gameBoard);
                    this.gameLogic.playerClicked();
                    checkGameWinner();
                    this.currentPlayer.Text = gameLogic.playerTurn;
                }
                //gamelogic.textfile.write(player.turn, gameboardx, gameboardy)
            }
        }

        private void checkGameWinner()
        {
            if (this.gameLogic.checkWinner())
            {
                String result = String.Format("The winner is: {0}\nBlue Points: {1}\nRed Points: {2}", this.gameLogic.winner, this.gameLogic.bluePoints, this.gameLogic.redPoints);
                MessageBox.Show(result);
                gameLogic.logPlayerWon();
            }
        }

        private void keyPressedBoardSize(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                this.gridSize = Int32.Parse(boardSize.Text);
                //MessageBox.Show(boardSize.Text);
                resizeBoard(gridSize);
            }
        }

        public void resizeBoard(int size)
        {
            if (size < 3)
            {
                throw new ArgumentException("Board size cannot be less than 3");
            }
            if (size == null) { return; }
            gameBoard.Rows.Clear();
            gameBoard.Columns.Clear();

            for (int i = 0; i < size; i++)
            {
                gameBoard.Columns.Insert(i, new DataGridViewButtonColumn());
            }

            for (int r = 0; r < size; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.gameBoard);
                row.Height = gameBoard.Height / size;

                for (int c = 0; c < size; c++)
                {
                    row.Cells[c].Value = " ";
                }

                this.gameBoard.Rows.Add(row);
            }
            this.gameLogic.boardSize = size;
        }

        public string getGameMode()
        {
            if (Simple.Checked)
            {
                return "Simple";
            }
            else
            {
                return "General";
            }
        }

        public char getGameLogicMode()
        {
            return this.gameLogic.gameMode;
        }

        public void clickSimple()
        {
            this.Simple.PerformClick();
        }
        public void clickGeneral()
        {
            this.General.PerformClick();
        }

        public void clickBlueComputer()
        {
            this.blueComputerButton.PerformClick();
        }

        private void Simple_CheckedChanged(object sender, EventArgs e)
        {
            this.gameLogic.gameMode = 's';
        }

        private void General_CheckedChanged(object sender, EventArgs e)
        {
            this.gameLogic.gameMode = 'g';
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Form1()));
            t.Start();
            this.Close();
        }

        private void blueComputerButton_CheckedChanged(object sender, EventArgs e)
        {
            this.gameLogic.computer = true;
            do
            {
                this.gameLogic.computerTurn(ref this.gameBoard);
                this.gameLogic.playerClicked();
                checkGameWinner();
                this.currentPlayer.Text = gameLogic.playerTurn;
            } while (this.redComputerButton.Checked && this.blueComputerButton.Checked && !this.gameLogic.checkWinner());
        }

        private void redComputerButton_CheckedChanged(object sender, EventArgs e)
        {
            this.gameLogic.computer = true;
            do
            {
                this.gameLogic.computerTurn(ref this.gameBoard);
                this.gameLogic.playerClicked();
                checkGameWinner();
                this.currentPlayer.Text = gameLogic.playerTurn;
            } while (this.redComputerButton.Checked && this.blueComputerButton.Checked && !this.gameLogic.checkWinner());
        }
    }
}