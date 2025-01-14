using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using MyApp.Scripts;
public static class Engine
{

  static uint width = 1280;
  static uint height = 720;
  static VideoMode videoMode;
  public static RenderWindow window;
  public static void Evoke()
  {
    Console.WriteLine("Evoke");
    // Create the main window
    videoMode = new VideoMode(width, height);
    window = new RenderWindow(videoMode, "Umer Engine");
    window.Closed += (sender, e) => window.Close();
    window.SetFramerateLimit(60);
    window.SetVerticalSyncEnabled(true);
  }
  public static void Begin()
  {
    Console.WriteLine("Begin");
    Update();
  }
  public static void Update()
  {
    while (window.IsOpen)
    {
      window.DispatchEvents();
      window.Clear(Color.White);
      Paint.Sketch("images/umer.png",Color.White,Paint.FlipMode.FlipX);
      window.Display();
      Console.WriteLine("Updating");
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