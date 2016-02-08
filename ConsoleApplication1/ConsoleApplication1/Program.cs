using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class EntryPoint {
    static void Main(string[] args) {
      var board = new Board(25);

      var player = new Player(board._Size);

      var collectable = new Collectable(board._Size);
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

       // collectable.UpdateWithPlayer(player);
        collectable.Move();

        //if (player.item.CollidesWith(collectable.item))
        //   Console.WriteLine("Item get!");

        collectable.UpdateWithPlayer(player);
        board.Draw(player, collectable);
        input = Console.ReadLine();
        Console.SetCursorPosition(0, Console.CursorTop - 1);
      }
    }
  }


  // have collectable move randomly on a "void Move()" method     (DONE)
  // have collectable be triggered by player proximity via a "void UpdateWithPlayer(Player p) method"  (DONE)
  // have collective be triggered and start to "run" in a direction when the player is close  (DONE)
  //create a MoveableItem class that can be used by Collectable and Player in their classes (to help with duplicated logic)   (DONE)


} //ns

// if the player gets within 3 spaces of the collectable, have the collectable move in the same 









