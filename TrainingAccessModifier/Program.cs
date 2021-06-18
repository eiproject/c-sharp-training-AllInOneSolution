using System;

namespace TrainingAccessModifier
{
  class RunVertex
  {
    internal RunVertex(float a, float b, float c)
    {
      VertexQuadratic V1 = new VertexQuadratic(a, b, c);
      float x = VertexQuadratic.vertexPoint[0];
      float y = VertexQuadratic.vertexPoint[1];
      Console.WriteLine("Vertex Point coordinate: " + x.ToString() + " , " + y.ToString());
    }
  }

  class RunSplitingSentences
  {
    internal RunSplitingSentences(string sentence)
    {
      SplittingSentences S1 = new SplittingSentences(sentence);
      Console.WriteLine(S1.Words[1]);
      S1.Words[1] = "Java";
      Console.WriteLine(S1.Words[1]);
    }
  }

  public class Run
  {
    public Run()
    {
      Console.WriteLine("Enter a, b, and c: (Format: A B C)");
      string consoleInput = Console.ReadLine();
      string[] arrInput = consoleInput.Split(" ");
      if (arrInput.Length == 3)
      {
        var arrInputFloat = Array.ConvertAll(arrInput, i => float.Parse(i));
        RunVertex V = new RunVertex(a: arrInputFloat[0], b: arrInputFloat[1], c: arrInputFloat[2]);

        RunSplitingSentences T = new RunSplitingSentences(
          sentence: "Learning C# Language From Scratch");
      }
      else
      {
        Console.WriteLine("Input not match.");
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      /*RunVertex V = new RunVertex(a: 1.1F, b: 0.2F, c: 1.5F);

      RunSplitingSentences T = new RunSplitingSentences(
        sentence: "Learning C# Language From Scratch");*/

      Run App = new Run();
    }
  }
}

// namespace Vertex{
//   class runVertex{
//     static void  countVertexPoint(){
//       VertexQuadratic V1 = new VertexQuadratic(1, 1, 1);
//     }
    
    
//   }
// }