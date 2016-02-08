using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace ZeldaGridTests {
  [TestClass]
  public class UnitTest1 {
    [TestMethod]
    public void ColumnCoords() {
      var m1 = new MoveableItem(1, 1, 10);
      var m2 = new MoveableItem(1, 5, 10);

      var distanceCalc = new DistanceCalculator();
      int distance = distanceCalc.distance(m1, m2);

      Assert.AreEqual(4, distance);
    }

    [TestMethod]
    public void ColumnCoords2() {
      var m1 = new MoveableItem(1, 1, 10);
      var m2 = new MoveableItem(1, 7, 10);

      var distanceCalc = new DistanceCalculator();
      int distance = distanceCalc.distance(m1, m2);

      Assert.AreEqual(6, distance);
    }

    [TestMethod]
    public void ColumnCoords3() {
      var m1 = new MoveableItem(1, 7, 10);
      var m2 = new MoveableItem(1, 1, 10);

      var distanceCalc = new DistanceCalculator();
      int distance = distanceCalc.distance(m1, m2);

      Assert.AreEqual(6, distance);
    }

    [TestMethod]
    public void RowCoords() {
      var m1 = new MoveableItem(1, 1, 10);
      var m2 = new MoveableItem(6, 1, 10);

      var distanceCalc = new DistanceCalculator();
      int distance = distanceCalc.distance(m1, m2);

      Assert.AreEqual(5, distance);
    }
    //what can we do to make the column and the rows 
    //be calculated within the same class? 
    [TestMethod]
    public void RowCoords2() {
      var m1 = new MoveableItem(9, 1, 10);
      var m2 = new MoveableItem(5, 1, 10);

      var distanceCalc = new DistanceCalculator();
      int distance = distanceCalc.distance(m1, m2);

      Assert.AreEqual(4, distance);
    }

    [TestMethod]
    public void DefiningTheMs() {
      var m1 = new MoveableItem(8, 1, 10);
      var m2 = new MoveableItem(1, 5, 10);

      var distanceCalc = new DistanceCalculator();
      int distance = distanceCalc.distance(m1, m2);

      Assert.AreEqual(9, distance);
    }


    [TestMethod]
    public void CharacterCollision() {
      var m1 = new MoveableItem(1, 1, 10);
      var m2 = new MoveableItem(1, 1, 10);

      Assert.IsTrue(m1.CollidesWith(m2));
    }
  }
}

