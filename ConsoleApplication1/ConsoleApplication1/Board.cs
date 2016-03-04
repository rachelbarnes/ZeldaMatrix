using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class Board {
    private string[,] _Board;
    public int _Size;

    public Board(int size) {
      this._Size = size;
      _Board = new string[size, size];
      for (var r = 0; r < size; r++) {
        for (var c = 0; c < size; c++) {
          this._Board[r, c] = " ";
        }
      }
    }

    public void Draw(Player player, List<Collectable> collectables) {
      Console.Out.WriteLine(" ");
      var boundingBar = " ";
      for (var x = 0; x < _Size; x++) {
        boundingBar += "-";
      }
      Console.Out.WriteLine(boundingBar);

      for (var r = 0; r < _Size; r++) {
        var rowString = "";
        for (var c = 0; c < _Size; c++) {

          var shouldDrawCollectable = false;

          foreach (Collectable collectableItem in collectables) {
            if (collectableItem.IsCollectablePosition(c, r)) {
              shouldDrawCollectable = true;
            }
          }
        
          //var shouldDrawCollectable = collectables.Any(co => co.IsCollectablePosition(c, r));
              //these lines of code, 44 and 38-42, are telling the program to do the same thing - they're just set up differently.
              //the => is a lambda... read about this more. 


          if (player.IsPlayerPosition(c, r)) {
             rowString += "@";
          } else if (shouldDrawCollectable) { 
            rowString += "C";
          } else {
            rowString += this._Board[r, c];
          }
        }
        Console.Out.WriteLine(String.Format("|{0}|", rowString));

      }

      Console.Out.WriteLine(boundingBar);
      Console.Out.WriteLine("Type 'q' and enter to quit;" + "player count:" + player.currentNumberOfCollectedItems);
      Console.SetCursorPosition(0, Console.CursorTop - (_Size + 4));
    }
  }  // class
}
