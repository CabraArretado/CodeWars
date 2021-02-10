using System;
using System.Linq;
using System.Collections.Generic;

//https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp

public class Kata
{
  public static int DuplicateCount(string str)
    {
      // Just training my IEnumerables chain skills. This code is not supposed to be clear.
      string s = str.ToLower();
      var hash = new List<char>(s.ToCharArray().Where(x => s.Count(y => x == y) >= 2)).ToHashSet();
      return hash.ToHashSet().Count;
    }
}
