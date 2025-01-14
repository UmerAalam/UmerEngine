using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using SFML.Graphics.Glsl;
public class Sketch
{
    public void Paint(string texturePath, Vector2f? Position, Color? color, FlipMode flip = FlipMode.None, DrawMode drawMode = DrawMode.Smooth, Origin origin = Origin.Center)
    {
        Texture texture = new Texture(texturePath);
        Sprite sprite = new Sprite(texture);
        Flip(sprite, flip);
        SetDrawMode(sprite, drawMode);
        SetOrigin(sprite, origin);
        if(Position != null)
        sprite.Position = Position ?? new Vector2f(Engine.height / 2, Engine.width / 2);
        sprite.Origin = new Vector2f(sprite.Texture.Size.X / 2, sprite.Texture.Size.Y / 2);
        sprite.Texture = texture;
        sprite.Color = color ?? Color.White;
        if (Engine.window != null)
            Engine.window.Draw(sprite);
    }
    public void SetOrigin(Sprite sprite, Origin origin)
    {
        if (origin == Origin.Center)
        {
            sprite.Origin = new Vector2f(sprite.Texture.Size.X / 2, sprite.Texture.Size.Y / 2);
        }
        else if (origin == Origin.TopLeft)
        {
            sprite.Origin = new Vector2f(0, 0);
        }
        else if (origin == Origin.TopRight)
        {
            sprite.Origin = new Vector2f(sprite.Texture.Size.X, 0);
        }
        else if (origin == Origin.BottomLeft)
        {
            sprite.Origin = new Vector2f(0, sprite.Texture.Size.Y);
        }
        else if (origin == Origin.BottomRight)
        {
            sprite.Origin = new Vector2f(sprite.Texture.Size.X, sprite.Texture.Size.Y);
        }
    }
    public void SetDrawMode(Sprite sprite, DrawMode drawMode)
    {
        if (drawMode == DrawMode.None)
        {
            sprite.Texture.Smooth = false;
        }
        else if (drawMode == DrawMode.Smooth)
        {
            sprite.Texture.Smooth = true;
        }
    }
    public void Flip(Sprite sprite, FlipMode flip)
    {
        if (flip == FlipMode.None)
        {
            sprite.Scale = new Vector2f(1, 1);
        }
        if (flip == FlipMode.FlipX)
        {
            sprite.Scale = new Vector2f(-1, 1);
        }
        else if (flip == FlipMode.FlipY)
        {
            sprite.Scale = new Vector2f(1, -1);
        }
    }
    public enum Origin
    {
        Center,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
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