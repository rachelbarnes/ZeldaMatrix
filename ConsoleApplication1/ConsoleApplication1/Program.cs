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

      var collectable2 = new Collectable(20, 20, board._Size); 

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

        collectable.Move();
        collectable2.Move();

        //if (player.item.CollidesWith(collectable.item))
        //   Console.WriteLine("Item get!");

        collectable.UpdateWithPlayer(player);
        collectable2.UpdateWithPlayer(player);
        
        board.Draw(player, collectable, collectable2);
        input = Console.ReadLine();
        Console.SetCursorPosition(0, Console.CursorTop - 1);
      }
    }
  }


  // have collectable move randomly on a "void Move()" method     (DONE)
  // have collectable be triggered by player proximity via a "void UpdateWithPlayer(Player p) method"  (DONE)
  // have collective be triggered and start to "run" in a direction when the player is close  (DONE)
  // create a MoveableItem class that can be used by Collectable and Player in their classes (to help with duplicated logic)   (DONE)
  // when the player hits the collectable, the player moves differently (TBD)
  // the collectable disappears when you collide with it  (DONE)
  // start game with several collectables
  // keep track and display count of collected items on player
  // 1. replace character display with a <^v> pointing a certain direction of their last move
  // 2. have a new action for player (hit SPACE) that shoots a bow in the direction you last faced one space at a time
  // 3. have bow shoot also collect a collectable (so you don't have to touch it)
  // make it so you dont have to hit enter to tick the game state (make game tick once per second)
} //ns










