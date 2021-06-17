using System;
using System.Linq;

namespace LambdaOperator
{
  public class Run
  {
    public Run()
    {
      string[] testWords = { "argentina", "mexico", "usa", "armenia" };
      WordFilter Word1 = new WordFilter(testWords);
      Console.WriteLine(Word1.minLength);
      Console.WriteLine(Word1.maxLength);
    }
  }
  class WordFilter
  {
    internal int minLength, maxLength;
    internal WordFilter(string[] words)
    {
      minLength = words.Where(w => w.StartsWith("a")).Min(w => w.Length);
      maxLength = words.Where(w => w.StartsWith("a")).Max(w => w.Length);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      string[] testWords = { "argentina", "mexico", "usa", "armenia"};
      WordFilter Word1 = new WordFilter(testWords);
      Console.WriteLine(Word1.minLength);
      Console.WriteLine(Word1.maxLength);

    }
  }
}
