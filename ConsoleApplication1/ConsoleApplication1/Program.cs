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

        collectable.Move();
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

  public class MoveableItem {
    private int C;
    private int R;
    public int size;

    public MoveableItem(int size) {
      this.size = size;
    }
    //what i changed to make this work future Rachel:
    //i decared the field (directly above) and then defined
    //the third parameter of size (direclty below)
    public MoveableItem(int C, int R, int size) {
      this.C = C;
      this.R = R;
      this.size = size;
    }

    public bool IsPosition(int c, int r) {
      return R == r && C == c;
    }
    public void MoveUp() {
      if (R > 0) {
        R--;
      }
    }
    public void MoveDown() {
      if (R < (size - 1)) {
        R++;
      }
    }
    public void MoveLeft() {
      if (C > 0) {
        C--;
      }
    }
    public void MoveRight() {
      if (C < (size - 1)) {
        C++;
      }
    }
  }

  public class Player {
    private MoveableItem item;
    public int currentPlayerCPosition;
    public int currentPlayerRPosition;
    internal static int IsPosition;

    public Player(int size) {
      this.item = new MoveableItem((size / 2), (size / 2), size);
    }

    public bool IsPlayerPosition(int c, int r) {
      return this.item.IsPosition(c, r);
    }
    public void MoveUp() {
      this.item.MoveUp();
    }
    public void MoveDown() {
      this.item.MoveDown();
    }
    public void MoveLeft() {
      this.item.MoveLeft();
    }
    public void MoveRight() {
      this.item.MoveRight();
    }
  }


  // have collectable move randomly on a "void Move()" method     (DONE)
  // have collectable be triggered by player proximity via a "void UpdateWithPlayer(Player p) method"
  //if we already have it moving randomly, if @ starts to approach it, why not just have it run? 
  //basically, why not just skip the second "story" here and work on the third?
  //i think the second and the third are rather similar, in the sense that the third involves the second. 
  // have collective be triggered and start to "run" in a direction when the player is close
  //create a MoveableItem class that can be used by Collectable and Player in their classes (to help with duplicated logic)   (DONE)


  public class Collectable {
    public MoveableItem item;
    private static int IsPosition;

    public bool IsPlayerPosition(int c, int r) {
      return this.item.IsPosition(c, r);
   }
    //public int currentCollectableCPosition;//collectable's current place on the board

      //public int currentCollectableRPosition; //collectable's current place on the board


    public Collectable(int size) {
      this.item = new MoveableItem((size / 4) + 1, (size / 4) + 1, size);
      this.item = new MoveableItem((size / 4) + 1, (size / 4) + 1, size);
    }

    //public bool IsCollectablePosition(int c, int r) {
    //return this.item.IsPosition(c, r); 
    //    var currentPosition = Collectable.IsPosition; //collectable's current place on the board

    //so, does this work in the sense that you give the bool statement, and then you give the ifs? 
    //I have to have a way to determine the player's position in with the collectable's position...
    //so, if the player's position<4 from the collectable's position, 
    //then have the collectable move in the same direction.




    //public void RunWhenPlayerGetsClose() {
    // if (int Player.currentPlayerCPosition) < 4 < int Collectable.currentCollectableCPosition)


    //i assume that we need to do this for the c and the r... i dont see a way to split them
    public bool IsCollectablePositio(int c, int r) {
      return this.item.IsPosition(c, r);
    }

     // if(IsPlayerPosition(c, r)) (IsCollectablePosition(c, r));
      //return (Collectable.IsPosition += Player.IsPosition); } 
                      //collectable move in the same direction as the player:
                      //make the collectable movement equal to the player movements)
    //if we hae the coordinates of the player and position, can we determine if the player is 3 spaces 
    //from the collectable by comparing the coordinates rather than separating the c and the r? 
        

                                  
    public bool IsCollectablePosition(int c, int r) {
      return this.item.IsPosition(c, r); }

    public void Move() {
      Random rnd = new Random();
      var input = rnd.Next(4);

      if (input == 0) {
        item.MoveLeft();
      }
      if (input == 1) {
        item.MoveDown();
      }
      if (input == 2) {
        item.MoveUp();
      }
      if (input == 3) {
        item.MoveRight();
      }
    }

    }
  }
  
    // if the player gets within 3 spaces of the collectable, have the collectable move in the same 
    //direction, so as to run away
    //tasks: 
    //if function: if the player gets close, do this (would need it for each direction? 
    //or would we be able to say to move in the same direction as the player in a function?
    //have the collectable move 1 space every time the player approaches 1 space in his direction
    //when the player is within 3 spaces of the collectable. 
    //  public bool IsCollectablePosition(int collectC, int collectR) {
    //         return this.item.IsPosition(collectC, collectR);









                                                                