using System;
using System.Globalization;

namespace FieldsTraining
{
  internal class FormulatrixMember
  {
    internal string Name;
    internal int Age;
    internal float Weight;
    internal float Height;

    internal FormulatrixMember(
      string name, int age, float weight = default, float height = default)
    {
      Name = name;
      Age = age;
      Weight = weight;
      Height = height;
    }

    internal float MemberBMI()
    {
      CalculatorBMI BMI = new CalculatorBMI(weight: Weight, height: Height);
      return BMI.BMI;
    }
  }

  internal class CalculatorBMI
  {
    internal float BMI;
    internal CalculatorBMI(float weight, float height)
    {
      BMI = weight / (height * height);
    }
  }

  public class Run
  {
    public Run()
    {
      // Input example: Razif#22#1.70#55
      Console.Write("Input your information: " + "(name#age#height#weight)".ToUpper());
      string userInputInformation = Console.ReadLine();
      string[] userInformation = userInputInformation.Split("#");

      FormulatrixMember M1 = new FormulatrixMember(
        name: userInformation[0],
        age: Convert.ToInt32(userInformation[1]),
        height: float.Parse(userInformation[2], CultureInfo.InvariantCulture.NumberFormat),
        weight: float.Parse(userInformation[3], CultureInfo.InvariantCulture.NumberFormat)
        );

      float BMI_Result = M1.MemberBMI();
      Console.WriteLine("Hello, (" + userInformation[0] +
        "(" + userInformation[1] + "), You have " + userInformation[2] +
        "m tall, and " + userInformation[3] + "kg weight.");
      Console.WriteLine("Your BMI is: " + BMI_Result.ToString());
    }
  }

  public class Program 
  {
    public static void Main()
    {
      // Input example: Razif#22#1.70#55
      Console.Write("Input your information: " + "(name#age#height#weight)".ToUpper());
      string userInputInformation = Console.ReadLine();
      string[] userInformation = userInputInformation.Split("#");
      
      FormulatrixMember M1 = new FormulatrixMember(
        name: userInformation[0], 
        age: Convert.ToInt32(userInformation[1]),
        height: float.Parse(userInformation[2], CultureInfo.InvariantCulture.NumberFormat),
        weight: float.Parse(userInformation[3], CultureInfo.InvariantCulture.NumberFormat)
        );

      float BMI_Result = M1.MemberBMI();
      Console.WriteLine("Hello, (" + userInformation[0] + 
        "(" + userInformation[1] + "), You have " + userInformation[2] + 
        "m tall, and " + userInformation[3] + "kg weight.");
      Console.WriteLine("Your BMI is: " + BMI_Result.ToString());
      
      //Console.WriteLine(M1.Name);
      //Console.WriteLine(M1.Age);
      //Console.WriteLine(M1.Height);
      //Console.WriteLine(M1.Weight);
      //Console.WriteLine();
    }
  }
}
