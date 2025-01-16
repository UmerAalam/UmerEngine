using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Net.Http.Headers;
public static class Engine
{
  public static Scene scene = new Scene();
  private static VideoMode videoMode;
  public static RenderWindow? window;
  public static uint width = 1280;
  public static uint height = 720;
  public static void Evoke(uint screenWidth = 1280, uint screenHeight = 720, string title = "UMER Engine", uint framerate = 60)
  {
    Console.WriteLine("Evoke");
    width = screenWidth;
    height = screenHeight;
    // Create the main window
    videoMode = new VideoMode(screenWidth, screenHeight);
    window = new RenderWindow(videoMode, title);
    // For setting icon
    // window.SetIcon();
    window.Closed += (sender, e) => window.Close();
    window.SetFramerateLimit(framerate);
    Begin();
  }
  public static void Begin()
  {
    Console.WriteLine("Begin");
    Update();
  }
  public static void Update()
  {
    if (window == null)
    {
      Console.WriteLine("Window is null");
      return;
    }
    else
    {
      while (window.IsOpen)
      {
        window.DispatchEvents();
        window.Clear(Color.White);
        scene.Game();
        window.Display();
        // Console.WriteLine("Updating");
      }
    }
  }
}