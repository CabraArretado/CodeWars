using System;
using System.Linq;
using System.Collections.Generic;

// https://www.codewars.com/kata/52742f58faf5485cae000b9a/train/csharp

public class HumanTimeFormat{
  
  // Helper Function: Transform a KeyValuePair in a string with the plural according to the number of the value
  // Input: {"minute": 2} 
  // Output: "2 minutes"
  static string PluralMaker(KeyValuePair<string, int> kvp)
  {
    string str = kvp.Value.ToString() + " " + kvp.Key;
    return kvp.Value > 1 ? str + "s" : str;
  }
  
  
  // Actual main function of the problem
  public static string formatDuration(int s){
    if ( s < 1) return "now";
    int rest = s;
    Dictionary<string, int> dict = new Dictionary<string, int>()
    {
      {"year", 0},
      {"day", 0},
      {"hour", 0},
      {"minute", 0},
      {"second", 0}
    };

    dict["year"] = s / (365 * 24 * 60 * 60); rest -= dict["year"] * (365 * 24 * 60 * 60);
    dict["day"] = rest / (24 * 60 * 60); rest -= dict["day"] * (24 * 60 * 60);
    dict["hour"] = rest / (60 * 60); rest -= dict["hour"] * (60 * 60);
    dict["minute"] = rest / 60; rest -= dict["minute"] * 60;
    dict["second"] = rest;

    var dict2 = dict.Where(x => x.Value > 0).Select(PluralMaker);

    string r = "";

    if (dict2.Count() < 3)
    {
      r += String.Join(" and ", dict2);
    }
    else if (dict2.Count() > 2)
    {
      r += String.Join(", ", dict2.ToArray().Take(dict2.Count() - 1)) + " and " + dict2.Last();
    }
    
    return r;
  }
}
