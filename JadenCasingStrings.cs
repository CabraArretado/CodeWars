using System;
using System.Globalization;

// https://www.codewars.com/kata/5390bac347d09b7da40006f6/train/csharp

public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    TextInfo ti = new CultureInfo("en-US",false).TextInfo;
    return ti.ToTitleCase( phrase ) ;
  }
}
