public static class TimeFormat
{
  // https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp
    public static string GetReadableTime(int seconds)
    {
      if (seconds < 1) return "00:00:00";
          int h = seconds / 3600; seconds = seconds % 3600;
          int m = seconds / 60; seconds = seconds % 60;
          return $"{h.ToString("00")}:{m.ToString("00")}:{seconds.ToString("00")}";
    }
}
