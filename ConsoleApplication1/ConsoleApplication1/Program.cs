using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class EntryPoint {
        static void Main(string[] args) {
            //boardHelperVar contains the object, so the it retains the instance of the object,
            // which is the specific existance of one, in a basic sense.
            var boardHelperVar = new BoardHelper();       
            var board = boardHelperVar.InstantiateBoard();

            var player = new Player();
            var input = ""; 
            while (input != "q") {
                Console.Out.WriteLine("Type 'q' and enter to quit;");
                if (input == "h") {
                    player.MoveLeft();
                }
                if (input == "j") {
                    player.MoveDown();
                }             
                if (input == "k") {
                    player.MoveUp();
                }                    
                if (input == "l") {
                    player.MoveRight();
                }
                  
                boardHelperVar.DrawBoard(board, player);
                input = Console.ReadLine();
            }
        }
    }
    public class Player {
        private int playerC = 5;
        private int playerR = 5;
        public bool IsPlayerPosition(int c, int r) {
            return playerR == r && playerC == c;
        }

        public void MoveUp() {
            if (playerR > 0) {
                playerR--;
            }
        }
        public void MoveDown() {
            if (playerR < 9) {
                playerR++;
            }
        }
        public void MoveLeft() {
            if (playerC > 0) {
                playerC--;
            }         
        }
        public void MoveRight() {
            if (playerC < 9) {
                playerC++;
            }
        }
       }
    public class BoardHelper {
        //this one takes a string array to make the board
        public void DrawBoard(string[,] board, Player player) {
            Console.Out.WriteLine(" ----------");

            for (var r = 0; r < 10; r++) {
                var rowString = "";
                for (var c = 0; c < 10; c++) {
                    if (player.IsPlayerPosition(c, r)) {
                        rowString += "@";
                    } else {
                        rowString += board[r, c];
                    }
                }
                Console.Out.WriteLine(String.Format("|{0}|", rowString));
            }
            Console.Out.WriteLine(" ----------");
        }
        // this oen makes the string array to make the board, hence the "creation"
        // of the rows and columns 
        public string[,] InstantiateBoard() {
            string[,] board = new string[10, 10];
            for (var r = 0; r < 10; r++) {
                for (var c = 0; c < 10; c++) {
                    board[r, c] = " ";
                }
            }
            return board;
        }
    }

}
