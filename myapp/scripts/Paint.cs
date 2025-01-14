using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
namespace MyApp.Scripts
{
    public static class Paint
    {
        public static void Sketch(string texturePath, Color? color, FlipMode flip = FlipMode.None, DrawMode drawMode = DrawMode.Smooth)
        {
            Texture texture = new Texture(texturePath);
            Sprite sprite = new Sprite(texture);
            Flip(sprite, flip);
            SetDrawMode(sprite, drawMode);
            sprite.Origin = new Vector2f(sprite.Texture.Size.X / 2, sprite.Texture.Size.Y / 2);
            sprite.Texture = texture;
            sprite.Color = color ?? Color.White;
            Engine.window.Draw(sprite);
        }
        static void SetDrawMode(Sprite sprite, DrawMode drawMode)
        {
            if(drawMode == DrawMode.None)
            {
                sprite.Texture.Smooth = false;
            }
            else if(drawMode == DrawMode.Smooth)
            {
                sprite.Texture.Smooth = true;
            }
        }
        static void Flip(Sprite sprite, FlipMode flip)
        {
            if (flip == FlipMode.None)
            {
                sprite.Scale = new Vector2f(1, 1);
            } if(flip == FlipMode.FlipX)
            {
                sprite.Scale = new Vector2f(-1, 1);
            }
            else if (flip == FlipMode.FlipY)
            {
                sprite.Scale = new Vector2f(1, -1);
            }
        }
        public enum DrawMode
        {
            None,
            Smooth,
        }
        public enum FlipMode
        {
            None,
            FlipX,
            FlipY
        }
    }
}