﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication3 {

  public class BankOCR {
    public string test = "123456789";
    public string firstRow, secondRow, thirdRow, fourthRow;
    public int lengthOfSubstring = 3;
    public List<string> TextLines = new List<string>();
    public List<string> zerothCharacter, firstCharacter, secondCharacter, thirdCharacter, fourthCharacter, fifthCharacter, sixthCharacter, seventhCharacter, eigthCharacter;
    public List<string> MatrixedDigit = new List<string>(); 
    public static void Main(string[] args) {
      var bankOCR = new BankOCR();
      var TextLines = bankOCR.TextLines;
      Console.WriteLine(TextLines); 
      Console.WriteLine(bankOCR.zerothCharacter);  
      Console.ReadLine();
    }

    public int ReadFile(string v) {
      return 0;
    }
    public void ConvertingOneLineAtATime() {
      string line;
      var file = new System.IO.StreamReader("firstOCRFile.txt");
      while ((line = file.ReadLine()) != null) {
        Console.WriteLine(line);
        TextLines.Add(line);
      }
    }


    public List<string> GetNthCharacter(int CharacterMatrixIndex) {
      var bankOCR = new BankOCR();
      TextLines = bankOCR.TextLines; 
     /* string result = "";
      for(int i =0; i<=3; i++) {
        result += TextLines[i].Substring(CharacterMatrixIndex * 3, lengthOfSubstring);
      }
      */
      string firstRow = TextLines[0].Substring(CharacterMatrixIndex * 3, lengthOfSubstring);
      string secondRow = TextLines[1].Substring(CharacterMatrixIndex * 3, lengthOfSubstring);
      string thirdRow = TextLines[2].Substring(CharacterMatrixIndex * 3, lengthOfSubstring);
      string fourthRow = TextLines[3].Substring(CharacterMatrixIndex * 3, lengthOfSubstring);

      MatrixedDigit.Add(firstRow);
      MatrixedDigit.Add(secondRow);
      MatrixedDigit.Add(thirdRow);
      MatrixedDigit.Add(fourthRow);

      return MatrixedDigit;
    }

    public void AssigningCharactersToMatrixedCharacters() {
      
      zerothCharacter = GetNthCharacter(0);
      firstCharacter = GetNthCharacter(1);
      secondCharacter = GetNthCharacter(2);
      thirdCharacter = GetNthCharacter(3);
      fourthCharacter = GetNthCharacter(4);
      fifthCharacter = GetNthCharacter(5);
      sixthCharacter = GetNthCharacter(6);
      seventhCharacter = GetNthCharacter(7);
      eigthCharacter = GetNthCharacter(8);
    }

    public int? ComparingMatrixedDigitsWithCharacterValuesInDictionaries() { //will the return type be a List<int> or just int
      var DrawnNumberCharacters = new DrawnNumberCharacters();
    //  foreach (string s in MatrixedDigit) {//MatrixedDigit in TextLines) {
        if (zerothCharacter == DrawnNumberCharacters.Numbers[1])
          return 1;
        return null;

    }
    //then we can parse the strings in the matrix and compare them to the dictionary we've created

    //need to create a method that just does one drawnNumberSection and then you can call the method in the loop for each indexes section
    //and then we can call the method in a greater loop. No loop is needed in the GetNthCharacter(). 
    // populated TextLines


  }
}



        //if (firstCharacter == DrawnNumberCharacters.Numbers[1])
        //  return 1;
        //if (secondCharacter == DrawnNumberCharacters.Numbers[1])
        //  return 1;
        //if (thirdCharacter == DrawnNumberCharacters.Numbers[1])
        //  return 1;
        //if (fourthCharacter == DrawnNumberCharacters.Numbers[1])
        //  return 1;
        //if (fifthCharacter == DrawnNumberCharacters.Numbers[1])
        //  return 1;
        //if (sixthCharacter == DrawnNumberCharacters.Numbers[1])
        //  return 1;
        //if (seventhCharacter == DrawnNumberCharacters.Numbers[1])
        //  return 1;
        //if (eigthCharacter == DrawnNumberCharacters.Numbers[1])
        //  return 1;



