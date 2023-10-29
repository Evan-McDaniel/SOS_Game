using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS_Game
{
    internal class GameLogic
    {
        public string playerTurn = "Blue";
        public string winner;
        public char blueChoice;
        public char redChoice;
        public int bluePoints = 0;
        public int redPoints = 0;
        public char gameMode = 's';
        public char[][] board = new char[3][];

        public char getToken()
        {
            if (playerTurn == "Blue")
            {
                return blueChoice;
            }
            else
            {
                return redChoice;
            }
        }

        private void pointScored()
        {
            if(playerTurn == "Blue")
            {
                bluePoints++;
            }else if(playerTurn == "Red")
            {
                redPoints++;
            }
        }

        public void playerClicked ()
        {
            if(playerTurn == "Blue")
            {
                playerTurn = "Red";
            }
            else
            {
                playerTurn = "Blue";
            }
        }

        public void checkSOS(ref DataGridView board, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            Color color = playerTurn == "Blue" ? Color.Blue: Color.Red;

            int[] match = checkNeighbors(board, row, col);
            if (match[0] != -1)
            {
                board.Rows[row].Cells[col].Style.BackColor = color;
                board.Rows[match[0]].Cells[match[1]].Style.BackColor = color;
                board.Rows[match[2]].Cells[match[3]].Style.BackColor = color;
                pointScored();
            }

        }

        public bool checkWinner()
        {
            if(gameMode == 's')
            {
                if(bluePoints > redPoints)
                {
                    winner = "Blue";
                    return true;
                }
                else if (redPoints > bluePoints)
                {
                    winner = "Red";
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private int[] checkNeighbors(DataGridView board, int row, int col)
        {
            string alt = (board.Rows[row].Cells[col].Value.ToString() == "O")? "S": "O";
            string currValue = board.Rows[row].Cells[col].Value.ToString();
            try
            {
                if ((board.Rows[row + 1].Cells[col]).Value.ToString() == alt && (board.Rows[row + 2].Cells[col]).Value.ToString() == currValue)
                {
                    int[] arr = { row + 1, col, row+2,col };
                    return arr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
               
            }
            try
            {
                if (board.Rows[row + 1].Cells[col + 1].Value.ToString() == alt && board.Rows[row + 2].Cells[col + 2].Value.ToString() == currValue)
                {
                    int[] arr = { row + 1, col + 1,row+2, col+2 };
                    return arr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
            try
            {
                if (board.Rows[row].Cells[col + 1].Value.ToString() == alt && board.Rows[row].Cells[col + 2].Value.ToString() == currValue)
                {
                    int[] arr = { row, col + 1,row, col+2 };
                    return arr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
            try
            {
                if (board.Rows[row - 1].Cells[col + 1].Value.ToString() == alt && board.Rows[row - 2].Cells[col + 2].Value.ToString() == currValue)
                {
                    int[] arr = { row - 1, col + 1, row-2, col + 2 };
                    return arr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
            try {     
                if (board.Rows[row - 1].Cells[col].Value.ToString() == alt && board.Rows[row - 2].Cells[col].Value.ToString() == currValue)
                {
                    int[] arr = { row - 1, col, row-2, col };
                    return arr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
            try {    
                if (board.Rows[row - 1].Cells[col - 1].Value.ToString() == alt && board.Rows[row - 2].Cells[col - 2].Value.ToString() == currValue)
                {
                    int[] arr = { row - 1, col - 1, row-2,col-2 };
                    return arr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
            try{
                if (board.Rows[row].Cells[col - 1].Value.ToString() == alt && board.Rows[row].Cells[col - 2].Value.ToString() == currValue)
                {
                    int[] arr = { row, col - 1,row,col-2 };
                    return arr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
            try { 
                if (board.Rows[row + 1].Cells[col - 1].Value.ToString() == alt && board.Rows[row + 2].Cells[col - 2].Value.ToString() == currValue)
                {
                    int[] arr = { row + 1, col - 1, row+2,col-2 };
                    return arr;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }

            int[] arr2 = { -1, -1 };
            return arr2;
        }
    }
}
