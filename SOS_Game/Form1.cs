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

            for (int i = 0; i < gridSize; i++)
            {
                gameBoard.Columns.Insert(i, new DataGridViewButtonColumn());
            }

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.gameBoard);
                row.Height = gameBoard.Height / width;

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = " ";
                }

                this.gameBoard.Rows.Add(row);
            }
            gameBoard.AllowUserToAddRows = false;
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
                this.gameLogic.playerClicked();
                this.currentPlayer.Text = gameLogic.playerTurn;
                Console.WriteLine(gameLogic.playerTurn);
            }
        }

        private void keyPressedBoardSize(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                MessageBox.Show(boardSize.Text);
            }
        }
    }
}