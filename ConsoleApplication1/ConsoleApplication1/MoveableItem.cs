using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class MoveableItem {
    public int C;
    public int R;
    public int size;   
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
}
