using ConsoleApplication3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
  [TestFixture]
  public class Class1 {
    [Test]
    public void TestingComparingMatrixedCharacterswithCharacterValuesInDIctionary() {
      var bankOCR = new BankOCR();
      var drawnNumberCharacters = new DrawnNumberCharacters();
        

      Assert.AreEqual(bankOCR.zerothCharacter, drawnNumberCharacters.Numbers[1]);
    }

    [Test]
    public void TestingFirstOCRFile() {
      var bankOCR = new BankOCR(); 
      List<string> input = new List<string> {
        "111222333",
        "444555666",
        "777888999",
        "         "
       };
      bankOCR.TextLines = input; 
      
      Assert.AreEqual(input, bankOCR.ReadFile("firstOCRFile.txt")); 
    }

    [Test]
    public void TestingTheComparisonBetweenTheDrawnAndTheInts() {
      var bankOCR = new BankOCR();
      var drawnNumberCharacters = new DrawnNumberCharacters();


    }

    [Test]
    public void GetNthCharacter_FirstCharacter() {
      var bankOCR = new BankOCR();
      var input = new List<string> {
        "111222333",
        "444555666",
        "777888999",
        "         "
      };

      var expected = new List<string> {
        "111",
        "444",
        "777",
        "   "
      };

      bankOCR.TextLines = input;
      //this works because it assigns the list of the input to the list of the TextLines
      //this is something that Lou was showing me... definitley incredibly helpful and
      //this is the reason why it passes, otherwise GetNthCharacter doesn't have anything to 
      //perform a substring off of, hence it's out of index. 
      Assert.AreEqual(expected, bankOCR.GetNthCharacter(0));
    }

    [Test]
    public void TestingDictionaryMatrixCharacter(){
      var bankOCR = new BankOCR();
      var drawnNumberCharacters = new DrawnNumberCharacters();
      List<string> testForDrawnNumberOne = new List<string> {
        "   ",
        "  |",
        "  |",
        "   " };
      // bankOCR.TextLines = testForDrawnNumberOne; 
      Assert.AreEqual(testForDrawnNumberOne, drawnNumberCharacters.Numbers[1]);
    }

    [Test]
    public void TestToCompareMatrixedCharacterWithCharacterListValeus() {
      var bankOCR = new BankOCR();
      var dictionaryOfNumbers = new DrawnNumberCharacters();

      Assert.AreEqual(bankOCR.zerothCharacter, dictionaryOfNumbers.one);
    }

    [Test]
    public void TestingSubstrings() {
      string test = "123456789";

      Assert.AreEqual("123", test.Substring(0, 3));
    }

    [Test]
    public void GettingInputToWork() {
      var bankOCR = new BankOCR();
      var input = new List<string> {
        "111222333",
        "444555666",
        "777888999",
        "         "
      };
      var expected = new List<string> {
        "111222333",
        "444555666",
        "777888999",
        "         "
      };
      Assert.AreEqual(expected, input);
    }


    [Test]
    public void GetNthCharacter_SecondCharacter() {
      var bankOCR = new BankOCR();
      var input = new List<String> {
        "111222333",
        "444555666",
        "777888999",
        "         "
      };
      var expected = new List<String> {
        "222",
        "555",
        "888",
        "   "
      };
      bankOCR.TextLines = input;
      Assert.AreEqual(expected, bankOCR.GetNthCharacter(1));
    }
  }
}
