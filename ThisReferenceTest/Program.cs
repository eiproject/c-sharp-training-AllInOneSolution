using System;

namespace InheritanceTest
{
  public class Measurement
  {
    public string Name;
  }

  public class SeaLevel : Measurement
  {
    public float DaySeaLevel;
    public float NightSeaLevel;
  }

  public class Salinity : Measurement
  {
    public float WaterSalinity;
  }

  public class Run
  {
    public Run()
    {
      SeaLevel DeathLake = new SeaLevel
      {
        Name = "Death Sea",
        DaySeaLevel = 1.22F,
        NightSeaLevel = 4.32F
      };

      Console.WriteLine(DeathLake);
    }
  }

  class Program
  {
    static void Main()
    {
      SeaLevel DeathLake = new SeaLevel
      {
        Name = "Death Sea",
        DaySeaLevel = 1.22F,
        NightSeaLevel = 4.32F
      };

      Console.WriteLine(DeathLake);
    }
  }
}
