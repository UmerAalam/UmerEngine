using System;
using System.IO;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using SFML.Graphics.Glsl;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        // Create the main window
        VideoMode videoMode = new VideoMode(800, 600);
        RenderWindow window = new RenderWindow(videoMode,"Umer Engine");
        window.Closed += (sender,e) => window.Close();
        window.SetFramerateLimit(60);
        window.SetVerticalSyncEnabled(true);
        Texture texture = new Texture("images/umer.png");
        Sprite sprite = new Sprite(texture);
        texture.Smooth = true; 
        // sprite.TextureRect = new IntRect(0,0,100,100);
        // sprite.Position = new Vector2f(100,100);
        // sprite.Scale = new Vector2f(0.5f,0.5f);

        // Create the texture
        while(window.IsOpen)
        {
            if(Keyboard.IsKeyPressed(Keyboard.Key.Space))
            Console.WriteLine("Space Key Is Pressed!");
            window.DispatchEvents();
            window.Clear(Color.White);
            window.Draw(sprite);
            window.Display();
            Console.WriteLine("Updating");
        }
    }
}
