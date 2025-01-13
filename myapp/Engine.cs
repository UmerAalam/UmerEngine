using System;

public static class Engine
{
  static bool isRunning = true;
  public static void Start()
  {
    Console.WriteLine("Engine started!");
  }
  public static void Update()
  {
    while (isRunning)
    {
      Console.WriteLine("updating...");
      if (Console.KeyAvailable)
      {
        Console.ReadKey(intercept: true);
        Quit();
        break;
      }
    }
  }
  public static void Quit()
  {
    isRunning = false;
    Console.WriteLine("Engine stopped!");
  }
}