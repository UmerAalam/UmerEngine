using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Security.Cryptography.X509Certificates;
public static class Engine
{
  static uint width = 1280;
  static uint height = 720;
  static VideoMode videoMode;
  public static RenderWindow window;
  public static void Evoke()
  {
    // Create the main window
    videoMode = new VideoMode(width, height);
    window = new RenderWindow(videoMode, "Umer Engine");
    window.Closed += (sender, e) => window.Close();
    window.SetFramerateLimit(60);
    window.SetVerticalSyncEnabled(true);
  }
  public static void Begin()
  {

  }
  public static void Update()
  {
    while (window.IsOpen)
    {
      window.DispatchEvents();
      window.Clear(Color.White);
      window.Display();
      Console.WriteLine("Updating");
    }
  }
  public static void Late()
  {

  }
  public static void Stop()
  {

  }
  static void Move(Sprite sprite, float moveSpeed = 2)
  {
    if (Keyboard.IsKeyPressed(Keyboard.Key.W))
    {
      sprite.Position += new Vector2f(0, -moveSpeed);
    }
    else if (Keyboard.IsKeyPressed(Keyboard.Key.S))
    {
      sprite.Position += new Vector2f(0, moveSpeed);
    }
    else if (Keyboard.IsKeyPressed(Keyboard.Key.A))
    {
      sprite.Position += new Vector2f(-moveSpeed, 0);
    }
    else if (Keyboard.IsKeyPressed(Keyboard.Key.D))
    {
      sprite.Position += new Vector2f(moveSpeed, 0);
    }
  }

}