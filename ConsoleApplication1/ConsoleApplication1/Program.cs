using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class EntryPoint {
    static void Main(string[] args) {
      var board = new Board(50);  //look at the collectable's start position

      var player = new Player(board._Size);

      //i have a strong feeling that i went too deep and overcomplicated this severly,
      //or at least in my mind i did and i psyched myself out.
      //or i justwas not finding the right thing about lists... it's possible
      //but i was looking all day trying to figure it out.
      var rnd = new Random();

      List<Collectable> collectablesList = new List<Collectable>() {
        new Collectable(board._Size, rnd),
        new Collectable(20, 20, board._Size, rnd),
        new Collectable(1, 1, board._Size, rnd),
        new Collectable(3, 3, board._Size, rnd),
        new Collectable(6, 42, board._Size, rnd),
        new Collectable(8, 8, board._Size, rnd),
        new Collectable(10, 17, board._Size, rnd),
        new Collectable(25, 37, board._Size, rnd),
        new Collectable(9, 28, board._Size, rnd),
        new Collectable(3, 19, board._Size, rnd)
      };

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

        //Im still looking at how to properly access the list by an calling it...
        //this is where i was thinking that i really overcomplicated it because
        //it should not be this difficult to call a list with variables in it
        //and it shouldn't be this difficult to find something online about it. 
        //i don't know how to call this properly - I want to call the name of the list
        //and have vars in the list follow, but I had such a hard time trying to find
        //accessors.                 
        //my thot process was to associate each variable in the collectablesList list with the same
        //properties... apparently it didn't work. 
        foreach (Collectable c in collectablesList) {
          c.Move();
          c.UpdateWithPlayer(player);
        }
        board.Draw(player, collectablesList);


        input = Console.ReadLine();
        Console.SetCursorPosition(0, Console.CursorTop - 1);
      }  // while loop for game "tick"
    } // main function
  }
}


// have collectable move randomly on a "void Move()" method     (DONE)
// have 10 collectables (Hint: use a list)                 (DONE)
// have collectable be triggered by player proximity via a "void UpdateWithPlayer(Player p) method"  (DONE)
// have collective be triggered and start to "run" in a direction when the player is close  (DONE)
// create a MoveableItem class that can be used by Collectable and Player in their classes (to help with duplicated logic)   (DONE)
// the collectable disappears when you collide with it  (DONE)
// start game with several collectables   (working on it, paired with the second task)       (DONE)
// keep track and display count of collected items on player (DONE)
// 1. replace character display with a <^v> pointing a certain direction of their last move
// 2. have a new action for player (hit SPACE) that shoots a bow in the direction you last faced one space at a time
// 3. have bow shoot also collect a collectable (so you don't have to touch it)
// make it so you dont have to hit enter to tick the game state (make game tick once per second)
// when the player hits the collectable, the player moves differently












