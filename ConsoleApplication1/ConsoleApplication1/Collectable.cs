using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class Collectable {
    public MoveableItem item;
    private bool DidPlayerGetTooClose;


    public Collectable(int size) {
      this.item = new MoveableItem((size / 4) + 1, (size / 4) + 1, size);
      this.item = new MoveableItem((size / 4) + 1, (size / 4) + 1, size);
      //  this.DidPlayerGetTooClose = false;
    }

    //public void UpdateWithPlayer(Player player) {

    // use player item and this.item to see if too close, if so, make DidPlayerGetTooClose = true;
    //  throw new NotImplementedException();


    //public bool IsCollectablePosition(int c, int r) {
    //  return this.item.IsPosition(c, r);


    public bool IsCollectablePosition(int c, int r) {
      return this.item.IsPosition(c, r);
    }

    public void Move() {
      // if DidPlayerGetTooClose == true then....
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