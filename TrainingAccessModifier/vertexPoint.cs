using System;

namespace TrainingAccessModifier{
  class VertexQuadratic{
    internal static float[] vertexPoint;
    private float h = 0F;
    private float k = 0F;  
    internal VertexQuadratic(float a, float b, float c){
      h = -b / (2*a);
      k = a * h * h + b * h + c;

      // Console.Write(h);
      // Console.Write(" ");
      // Console.WriteLine(k);

      vertexPoint = new float[]{h, k};
    }
  }
}