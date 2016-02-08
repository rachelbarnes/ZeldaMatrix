using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class MoveableItem {
    public int _C;
    public int _R;
    public int _Size;
    //what i changed to make this work future Rachel:
    //i decared the field (directly above) and then defined
    //the third parameter of size (direclty below)
    public MoveableItem(int C, int R, int size) {
      this._C = C;
      this._R = R;
      this._Size = size;
    }
    public bool IsPosition(int c, int r) {
      return _R == r && _C == c;
    }
    public void MoveUp() {
      if (this._R > 0) {
        this._R--;
      }
    }
    public void MoveDown() {
      if (this._R < (this._Size - 1)) {
        this._R++;
      }
    }
    public void MoveLeft() {
      if (_C > 0) {
        _C--;
      }
    }
    public void MoveRight() {
      if (_C < (_Size - 1)) {
        _C++;
      }
    }



    public bool CollidesWith(MoveableItem other) {
      return _C == other._C && _R == other._R;

    }
  }
}
