using System;
using System.Linq;

//https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    return String.Join(" ", text.ToLower().ToCharArray().Where(x => Char.IsLetter(x)).Select(x => x - 96));
  }
}
