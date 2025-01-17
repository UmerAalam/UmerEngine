using System;
using SFML.Graphics;
using SFML.System;
public class Sketch
{
    public Transform transform = new Transform();
    public Texture texture = new Texture("images/white.jpg");
    public Sprite sprite = new Sprite();
    public Color color = Color.White;
    public FlipMode flip = FlipMode.None;
    public DrawMode drawMode = DrawMode.Smooth;
    public Origin origin = Origin.Center;
    public Shapes shapes = new Shapes();
    // private variables
    private float sizeDivider = 50;
    public void Paint(string texturePath = "images/Shapes/Square.png", bool outline = false)
    {
        texture = new Texture(texturePath);
        sprite = new Sprite(texture);
        Flip(sprite, this.flip);
        sprite.Texture = texture;
        sprite.Color = color;
        SetOrigin(sprite, origin);
        sprite.Position = transform.Location;
        sprite.Rotation = transform.Rotation;
        sprite.Scale = Vector2.one;
        // sprite.Scale = GetSize(texturePath, transform.Size);
        SetDrawMode(sprite, drawMode);
        if (Engine.window != null)
            Engine.window.Draw(sprite);
    }
    Vector2f GetSize(string texturePath, Vector2f Size)
    {
        if (Shapes.Square == texturePath)
        {
            Size = transform.Size / sizeDivider;
        }
        else if (Shapes.Circle == texturePath)
        {
            Size = transform.Size / sizeDivider;
        }
        else if (Shapes.Circle == texturePath)
        {
            Size = transform.Size / sizeDivider;
        }
        else if (Shapes.Circle == texturePath)
        {
            Size = transform.Size / sizeDivider;
        }
        else if (Shapes.Circle == texturePath)
        {
            Size = transform.Size / sizeDivider;
        }
        else
        {
            Size = transform.Size / sizeDivider;;
        }
        // Console.WriteLine(Size);
        return Size;
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