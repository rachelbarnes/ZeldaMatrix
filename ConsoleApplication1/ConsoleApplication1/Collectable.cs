using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class Collectable {
    public MoveableItem _Item;
    private bool _PlayerGotTooClose;
    private bool _PlayerCollidedWithCollectable;

    public Collectable(int size) {
      this._Item = new MoveableItem((size / 4) + 1, (size / 4) + 1, size);
      this._PlayerGotTooClose = false;
    }

    public void UpdateWithPlayer(Player player) {
      // use player item and this.item to see if too close, if so, make PlayerGotTooClose = true;
      var calculateDistance = new DistanceCalculator();
      var distance = calculateDistance.distance(this._Item, player._Item);

      if (distance < 4) {
        _PlayerGotTooClose = true;
      }
      if (distance == 0) {
        _PlayerCollidedWithCollectable = true;
      }
    }

    public bool IsCollectablePosition(int c, int r) {
      if (_PlayerCollidedWithCollectable == true) {
        return false;
      } else { 
        return this._Item.IsPosition(c, r);
      }
    }



    public void Move() {
      if (_PlayerGotTooClose == true) {
        this._Item.MoveUp();
      }
      if (_PlayerGotTooClose == false) {

        Random rnd = new Random();
        var input = rnd.Next(4);

        if (input == 0) {
          _Item.MoveLeft();
        }
        if (input == 1) {
          _Item.MoveDown();
        }
        if (input == 2) {
          _Item.MoveUp();
        }
        if (input == 3) {
          _Item.MoveRight();
        }
      }

    }
  }

}

