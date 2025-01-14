using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
namespace MyApp.Scripts
{
    public static class Draw
    {
        public static void DrawSprite(Sprite? sprite, Vector2f? position, Vector2f? Scale, Color? color, bool FlipX = false, bool FlipY = false)
        {
            if (sprite != null)
            {
                sprite.Position = position ?? new Vector2f(0, 0);
                if (FlipX)
                {
                    sprite.Scale = new Vector2f(-1, 1);
                }
                else if (FlipY)
                {
                    sprite.Scale = new Vector2f(1, -1);
                }
                else sprite.Scale = Scale ?? new Vector2f(1, 1);
                sprite.Color = color ?? Color.White;
                Engine.window.Draw(sprite);
            }
            else
            {
                Console.WriteLine("You are sprite is null");
            }
        }
    }
}