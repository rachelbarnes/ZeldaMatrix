using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class Player {
    public MoveableItem _Item;
    public int currentNumberOfCollectedItems;


    public Player(int size) {
      this._Item = new MoveableItem((size / 2), (size / 2), size);
      this.currentNumberOfCollectedItems = 0;
    }

    public bool IsPlayerPosition(int c, int r) {
      return this._Item.IsPosition(c, r);
    }
    public void MoveUp() {
      this._Item.MoveUp();
    }
    public void MoveDown() {
      this._Item.MoveDown();
    }
    public void MoveLeft() {
      this._Item.MoveLeft();
    }
    public void MoveRight() {
      this._Item.MoveRight();
    }
  }

}
