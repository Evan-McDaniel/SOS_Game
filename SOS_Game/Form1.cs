using System;

namespace SOS_Game
{
    public partial class Form1 : Form
    {
        private DataGridView gameBoard;
        public Form1()
        {
            gameBoard = new DataGridView();
            string[,] twoD = new string[,]
            {
              {"row 0 col 0", "row 0 col 1", "row 0 col 2"},
              {"row 1 col 0", "row 1 col 1", "row 1 col 2"},
              {"row 2 col 0", "row 2 col 1", "row 2 col 2"}
            };

            int height = twoD.GetLength(0);
            int width = 3;

            this.gameBoard.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.gameBoard);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = twoD[r, c];
                }

                this.gameBoard.Rows.Add(row);
            }
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void blueChoiceS_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void blueChoiceO_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}