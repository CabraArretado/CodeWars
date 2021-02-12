using System;
public class DigPow {
	public static long digPow(int n, int p) {
    //https://www.codewars.com/kata/5552101f47fc5178b1000050/train/csharp
    int total = 0;
    int po = p;
    foreach (char c in n.ToString())
      {
        double x = Char.GetNumericValue(c);
        total += (int)Math.Pow(x, po++);
      }
    if (total % n == 0) return total / n;
    else return -1;
	}
}
