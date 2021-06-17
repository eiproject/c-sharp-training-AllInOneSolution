using System;

namespace UserInterfaceProgram
{
  class Program
  {
    
    static void Main(string[] args)
    {
      int theNumberInt = default;

      while (true)
      {
        Console.WriteLine(
          @"Hello!!
We have some application here. Please select your need:
1. Fields Training
2. Inheritance
3. Lamda Operation
4. Stock Market
5. Training Access Modifier

Enter number to choose:");
        string theNumber = Console.ReadLine();
        try
        {
          theNumberInt = Convert.ToInt32(theNumber);
          //if (theNumberInt > 5)
          //{
          //  Console.WriteLine("Your input number out of scope." + theNumber);
          //  continue;
          //}
        }
        catch (Exception ex)
        {
          Console.WriteLine("Input Error. " + theNumber.GetType());
          continue;
        }

        switch (theNumberInt)
        {
          case 1:
            Console.WriteLine("Fields Training Selected");
            FieldsTraining.Run App1 = new FieldsTraining.Run();
            continue;

          case 2:
            Console.WriteLine("Inheritance Selected");
            InheritanceTest.Run App2 = new InheritanceTest.Run();
            continue;

          case 3:
            Console.WriteLine("Lambda Operation Selected");
            LambdaOperator.Run App3 = new LambdaOperator.Run();
            continue;

          case 4:
            Console.WriteLine("Stock Market Selected");
            StockMarket.Run App4 = new StockMarket.Run();
            continue;

          case 5:
            Console.WriteLine("Training Access Modifier Selected");
            TrainingAccessModifier.Run App5 = new TrainingAccessModifier.Run();
            continue;

          default:
            Console.WriteLine("Your input number out of scope." + theNumber);
            continue;
        }
      }
    }
  }
}
