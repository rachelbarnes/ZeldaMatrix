using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    public class EntryPoint {
        static void Main(string[] args) {
            var board = new Board(56);

            var player = new Player(board.size);

            var collectable = new Collectable(4, 2);


            var input = "";
            while (input != "q") {
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

                board.Draw(player, collectable);
                input = Console.ReadLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
        }
    }
    public class Board {
        private string[,] board;
        public int size;

        public Board(int size) {
            this.size = size;
            board = new string[size, size];
            for (var r = 0; r < size; r++) {
                for (var c = 0; c < size; c++) {
                    this.board[r, c] = " ";
                }
            }
        }

        public void Draw(Player player, Collectable collectable) {
            Console.Out.WriteLine(" ");
            //Console.Out.WriteLine( " ----------");
            var boundingBar = " ";
            for (var x = 0; x < size; x++) {
                boundingBar += "-";
            }
            Console.Out.WriteLine(boundingBar);

            for (var r = 0; r < size; r++) {
                var rowString = "";
                for (var c = 0; c < size; c++) {
                    if (player.IsPlayerPosition(c, r)) {
                        rowString += "@";
                    }
                    else if (collectable.IsCollectablePosition(c, r)) {
                        rowString += "C";
                    }
                    else {
                        rowString += this.board[r, c];
                    }
                }
                Console.Out.WriteLine(String.Format("|{0}|", rowString));

            }

            Console.Out.WriteLine(boundingBar);
            Console.Out.WriteLine("Type 'q' and enter to quit;");
            Console.SetCursorPosition(0, Console.CursorTop - (size + 4));
        }
    }

    public class Player {
        private int playerC;
        private int playerR;
        private int size;

        public Player(int size) {
            playerC = (size / 2);
            playerR = (size / 2);
            this.size = size;
        }

        public bool IsPlayerPosition(int c, int r) {
            return playerR == r && playerC == c;
        }
        public void MoveUp() {
            if (playerR > 0) {
                playerR--;
            }
        }
        public void MoveDown() {
            if (playerR < (size - 1)) {
                playerR++;
            }

        }
        public void MoveLeft() {
            if (playerC > 0) {
                playerC--;
            }
        }
        public void MoveRight() {
            if (playerC < (size - 1)) {
                playerC++;
            }
        }
    }

    public class Collectable {
        private int collectableCItem;
        private int collectableRItem;

        public Collectable(int stPosCollC, int stPosCollR) {
            collectableCItem = stPosCollC;
            collectableRItem = stPosCollR;
        }
        //need to place a spot for it to start on the board
        public bool IsCollectablePosition(int collectC, int collectR) {
            return collectableCItem == collectC && collectableRItem == collectR;
        }


    }
}




