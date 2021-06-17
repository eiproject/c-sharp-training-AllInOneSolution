using System;

namespace NuillExpressionTest
{
  class Program
  {
    static void Main(string[] args)
    {
      string str_A = null;
      string str_B = str_A ?? "dia null";
      string str_C = str_A?.ToString();

      Console.WriteLine(str_B);
    }
  }
}
