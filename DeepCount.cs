using System;
using System.Linq;
using System.Collections.Generic;

// https://www.codewars.com/kata/596f72bbe7cd7296d1000029/train/csharp

public class Kata
{
  public static int DeepCount(object a)
  {
    object[] array = (object[])a;
    int cont = array.Length;
    foreach (var b in array)
    {
      cont += b.GetType().IsArray ? DeepCount(b) : 0;
    }
    return cont;
  }  
}
