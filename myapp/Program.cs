using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
class Program
{
    static void Main()
    {
        float moveSpeed = 2;
        // Create the main window
        uint width = 1280;
        uint height = 720;
        VideoMode videoMode = new VideoMode(width, height);
        RenderWindow window = new RenderWindow(videoMode, "Umer Engine");
        window.Closed += (sender, e) => window.Close();
        window.SetFramerateLimit(60);
        window.SetVerticalSyncEnabled(true);
        Texture texture = new Texture("images/umer.png");
        Sprite sprite = new Sprite(texture);
        sprite.Origin = new Vector2f(144, 144);
        sprite.Position = new Vector2f(width /2, height /2);
        texture.Smooth = true;

        // Create the texture
        while (window.IsOpen)
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.Space))
                Console.WriteLine("Space Key Is Pressed!");
            window.DispatchEvents();
            window.Clear(Color.White);
            window.Draw(sprite);
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

            window.Display();
            Console.WriteLine("Updating");
        }
    }
}
