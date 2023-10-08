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
        public char blueChoice;
        public char redChoice;
        public char gameMode;
        public char[][] board = new char[3][];

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
    }
}
