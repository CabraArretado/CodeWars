using System;
using System.Linq;

// https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp
public class Kata
{
  public static int[] TwoSum(int[] n, int target)
  {
    int[] r = new int[2];
    for(int i = 0; i < n.Length; i++)
    {
      for(int ii = i+1; ii < n.Length; ii++){
          if(n[i] + n[ii] == target)
            {
              r[0]=i; r[1]=ii;
            }
      }
    }
    return r;
  }
}
