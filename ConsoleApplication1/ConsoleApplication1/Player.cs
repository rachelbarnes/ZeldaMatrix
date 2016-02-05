using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class Player {
    public MoveableItem item;
    public int currentPlayerCPosition;
    public int currentPlayerRPosition;

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

}
