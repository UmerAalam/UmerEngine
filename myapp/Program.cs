using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.IO.Compression;
using System.Runtime.CompilerServices;
class Program 
{
    static void Main()
    {
        Engine.Evoke(1280, 720,"UMER Engine",60);
    }
}
// using SFML.Graphics;
// using SFML.System;
// using SFML.Window;

// class Program
// {
//     static void Main()
//     {
//         var font = new Font("fonts/Roboto-Bold.ttf"); 
//         var fpsText = new Text("FPS: 0", font, 20)
//         {
//             FillColor = Color.White,
//             Position = new Vector2f(10, 10)
//         };

//         // Clock for measuring frame time
//         var clock = new Clock();
//         float fps = 0;

//         // Event handling
//         window.Closed += (sender, e) => window.Close();

//         // Main game loop
//         while (window.IsOpen)
//         {
//             // Process events
//             window.DispatchEvents();

//             // Calculate FPS
//             float elapsedTime = clock.Restart().AsSeconds();
//             fps = 1.0f / elapsedTime;

//             // Update the FPS text
//             fpsText.DisplayedString = $"FPS: {fps:F2}";

//             // Clear, draw, and display
//             window.Clear(Color.Black);
//             window.Draw(fpsText);
//             window.Display();
//         }
//     }
// }

