using System;
using SFML.Graphics;
using SFML.System;
public class Sketch
{
    public Transform transform = new Transform();
    public string texturePath = "images/umer.png";
    public Texture texture = new Texture("images/umer.png");
    public Sprite sprite = new Sprite();
    public Color? color = Color.White;
    public FlipMode flip = FlipMode.None;
    public DrawMode drawMode = DrawMode.Smooth;
    public Origin origin = Origin.Center;
    public void Paint()
    {
        texture = new Texture(texturePath);
        sprite = new Sprite(texture);
        Flip(sprite, flip);
        SetDrawMode(sprite, drawMode);
        SetOrigin(sprite, origin);
        sprite.Position = transform.location;
        sprite.Scale = transform.Scale;
        sprite.Rotation = transform.Rotation;
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