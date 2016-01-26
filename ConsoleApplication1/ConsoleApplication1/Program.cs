using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class EntryPoint {
        static void Main(string[] args) {
            //boardHelperVar contains the object, so the it retains the instance of the object,
            // which is the specific existance of one, in a basic sense.
            var boardHelperVar = new BoardHelper();       
            var board = boardHelperVar.InstantiateBoard();

            var playerC = 5;
            var playerR = 5;
            var input = ""; 
            while (input != "q") {
                Console.Out.WriteLine("Type 'q' and enter to quit;");
                if (input == "h") {
                    playerC--;
                }
                if (input == "j") {
                    playerR++;
                }             
                if (input == "k") {
                    playerR--;
                }                    
                if (input == "l") {
                    playerC++;
                }
                  
                boardHelperVar.DrawBoard(board, playerC, playerR);
                input = Console.ReadLine();
            }
        }
    }

    class BoardHelper {
        //this one takes a string array to make the board
        public void DrawBoard(string[,] board, int playerC, int playerR) {
            Console.Out.WriteLine(" ----------");

            for (var r = 0; r < 10; r++) {
                var rowString = "";
                for (var c = 0; c < 10; c++) {
                    if (playerR == r && playerC == c) {
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
