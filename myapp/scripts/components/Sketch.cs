using System;
using Microsoft.VisualBasic;
using SFML.Graphics;
using SFML.System;
using System.Text;
public class Sketch
{
    public Transform transform = new Transform();
    // public Texture texture = new Texture("images/white.jpg");
    // public Sprite sprite = new Sprite();
    public Color color = Color.White;
    public FlipMode flip = FlipMode.None;
    public DrawMode drawMode = DrawMode.Smooth;
    public Origin origin = Origin.Center;
    bool once = true;
    public RectangleShape square = new RectangleShape()
    {
        Size = new Vector2f(100, 100),
        Scale = new Vector2f(1, 1),
        Position = new Vector2f(Engine.width / 2f, Engine.height / 2f),
        FillColor = Color.White,
    };
    public CircleShape? circle = null;
    public CircleShape? triangle = null;
    public void Square(Color? color = null,Transform.LocationPresets locationPresets = Transform.LocationPresets.Center)
    {
        if(once)
        {
            if(Engine.window != null)
            square.Position = transform.SetLocation(Engine.window.Size,locationPresets,null);
            once = false;
        }
        square.FillColor = color ?? Color.Black;
        square.Position =  transform.Location;
        square.Rotation = transform.Rotation;
        square.Scale = transform.Size;
        square.Origin = SetOrigin(square.Size);
        if (Engine.window != null)
            Engine.window.Draw(square);
    }
    public Vector2f SetOrigin(Vector2f SpriteSize, Origin origin = Origin.Center)
    {
        if(origin == Origin.Center)
            return SpriteSize / 2;
        else if(origin == Origin.TopLeft)
            return new Vector2f(0, 0);
        else if(origin == Origin.TopRight)
            return new Vector2f(SpriteSize.X, 0);
        else if(origin == Origin.BottomLeft)
            return new Vector2f(0, SpriteSize.Y);
        else if(origin == Origin.BottomRight)
            return new Vector2f(SpriteSize.X, SpriteSize.Y);
        else if(origin == Origin.Custom)
            return SpriteSize;
        return SpriteSize;
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
    // public void Flip(Sprite sprite, FlipMode flip)
    // {
    //     if (flip == FlipMode.None)
    //     {
    //         sprite.Scale = new Vector2f(1, 1);
    //     }
    //     if (flip == FlipMode.FlipX)
    //     {
    //         sprite.Scale = new Vector2f(-1, 1);
    //     }
    //     else if (flip == FlipMode.FlipY)
    //     {
    //         sprite.Scale = new Vector2f(1, -1);
    //     }
    // }
    public enum Origin
    {
        Custom,
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