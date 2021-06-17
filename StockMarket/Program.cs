using System;

namespace StockMarket
{
  public class StockMarketProgram
  {
    decimal CurrentPrice;
    public decimal MarketPrice
    {
      get { return CurrentPrice; }
      set { CurrentPrice = value; }
    }
  }

  public class Run
  {
    public Run()
    {
      StockMarketProgram SM1 = new StockMarketProgram();
      SM1.MarketPrice = 100;
      SM1.MarketPrice += 20;

      Console.WriteLine(SM1.MarketPrice);
    }
  }

  class Program
  {
    static void Main()
    {
      StockMarketProgram SM1 = new StockMarketProgram();
      SM1.MarketPrice = 100;
      SM1.MarketPrice += 20;

      Console.WriteLine(SM1.MarketPrice);
    }
  }
}

