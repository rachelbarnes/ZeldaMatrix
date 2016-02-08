using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
  public class DistanceCalculator {
    public int distance(MoveableItem m1, MoveableItem m2) {
      var x1 = m1._R;
      var y1 = m1._C;
      var x2 = m2._R;
      var y2 = m2._C;

      var d =  (Math.Sqrt((Math.Abs(Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)))));
      return (int)Math.Ceiling(d);
    }  
  }
}  
