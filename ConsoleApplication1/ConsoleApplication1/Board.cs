﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
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
  }  // class
}
