using System;
using System.Linq;

// https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
    {
      foreach (int s in seq){
        if (seq.Where(x => x == s).Count() % 2 == 1){
          return s;
        }  
    }
      return 0;
      }
       
    }
}
