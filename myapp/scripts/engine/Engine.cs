using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Net.Http.Headers;
public static class Engine
{
  public static Body body = new Body();
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
    window.Closed += (sender, e) => window.Close();
    window.SetFramerateLimit(framerate);
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
        body.sketch.Paint("images/white.jpg");
        body.sketch.color = Color.Red;
        body.transform.Size = new Vector2f(0.25f, 0.25f);
        // body.transform.location = new Vector2f(Engine.width / 2, Engine.height / 2);
        // body.transform.SetLocation(Transform.PositionPresets.Center);

        window.Display();
        Console.WriteLine("Updating");
      }
    }
  }
  // static void Move(Sprite sprite, float moveSpeed = 2)
  // {
  //   if (Keyboard.IsKeyPressed(Keyboard.Key.W))
  //   {
  //     sprite.Position += new Vector2f(0, -moveSpeed);
  //   }
  //   else if (Keyboard.IsKeyPressed(Keyboard.Key.S))
  //   {
  //     sprite.Position += new Vector2f(0, moveSpeed);
  //   }
  //   else if (Keyboard.IsKeyPressed(Keyboard.Key.A))
  //   {
  //     sprite.Position += new Vector2f(-moveSpeed, 0);
  //   }
  //   else if (Keyboard.IsKeyPressed(Keyboard.Key.D))
  //   {
  //     sprite.Position += new Vector2f(moveSpeed, 0);
  //   }
  // }
}