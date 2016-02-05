using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class EntryPoint {
    static void Main(string[] args) {
      var board = new Board(25);

      var player = new Player(board.size);

      var collectable = new Collectable(board.size);
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
        board.Draw(player, collectable);
        input = Console.ReadLine();
        Console.SetCursorPosition(0, Console.CursorTop - 1);
      }
    }
  }


  // have collectable move randomly on a "void Move()" method     (DONE)
  // have collectable be triggered by player proximity via a "void UpdateWithPlayer(Player p) method"
  //if we already have it moving randomly, if @ starts to approach it, why not just have it run? 
  //basically, why not just skip the second "story" here and work on the third?
  //i think the second and the third are rather similar, in the sense that the third involves the second. 
  // have collective be triggered and start to "run" in a direction when the player is close
  //create a MoveableItem class that can be used by Collectable and Player in their classes (to help with duplicated logic)   (DONE)


} //ns

// if the player gets within 3 spaces of the collectable, have the collectable move in the same 
//direction, so as to run away
//tasks: 
//if function: if the player gets close, do this (would need it for each direction? 
//or would we be able to say to move in the same direction as the player in a function?
//have the collectable move 1 space every time the player approaches 1 space in his direction
//when the player is within 3 spaces of the collectable. 
//  public bool IsCollectablePosition(int collectC, int collectR) {
//         return this.item.IsPosition(collectC, collectR);









