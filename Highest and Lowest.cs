using System;

// Link: https://www.codewars.com/kata/554b4ac871d6813a03000035/train/csharp

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    string[] subs = numbers.Split(' ');
    int max = Int32.Parse(subs[0]);
    int min = Int32.Parse(subs[0]);
    foreach (string i in subs){
      int result = Int32.Parse(i);
      if (Int32.Parse(i) > max){
        max = Int32.Parse(i);
      } else if (Int32.Parse(i) < min){
        min = Int32.Parse(i);
      }
    }
    return max.ToString() + " " + min.ToString();
  }
}
