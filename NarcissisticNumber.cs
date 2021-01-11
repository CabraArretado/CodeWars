using System;

public class Kata
{
  // https://www.codewars.com/kata/5287e858c6b5a9678200083c/train/csharp
  public static bool Narcissistic(int value)
  {
    string str = value.ToString();
    double total = 0;
    foreach(char c in str){
      if (total > value) return false;
      else total += Math.Pow(int.Parse(c.ToString()), str.Length);
    }
    if (value == (int)total) return true;
    else return false;
  }
}
