using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Net.Http.Headers;
public static class Engine
{
  public static Scene scene = new Scene();
  static Sketch sketch = new Sketch();
  private static VideoMode videoMode;
  public static RenderWindow? window;
  public static uint width = 1280;
  public static uint height = 720;
  private static ContextSettings setting = new ContextSettings(){AntialiasingLevel = 8};
  public static void Evoke(uint screenWidth = 1280, uint screenHeight = 720, string title = "UMER Engine", uint framerate = 60,Styles styles = Styles.Default, ContextSettings? settings = null)
  {
    Console.WriteLine("Evoke");
    width = screenWidth;
    height = screenHeight;
    // Create the main window
    videoMode = new VideoMode(screenWidth,screenHeight);
    window = new RenderWindow(videoMode, title, styles, settings ?? setting);
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
    var font = new Font("fonts/Roboto-Bold.ttf");
    var fpsText = new Text("FPS: 0", font, 20)
    {
      FillColor = Color.Green,
      Position = new Vector2f(10, 10)
    };

    // Clock for measuring frame time
    var clock = new Clock();
    float fps = 0;
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
        // scene.Game();
        //Calculating fps
        scene.Game();
        float elapsedTime = clock.Restart().AsSeconds();
        fps = 1.0f / elapsedTime;
        fpsText.DisplayedString = $"FPS: {fps:F2}";
        window.Draw(fpsText);
        window.Display();
        // Console.WriteLine("Updating");
      }
    }
  }
}