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
    public RectangleShape? square = null;
    public CircleShape? circle = null;
    public CircleShape? triangle = null;
    bool callOnce = true;
    public void Paint(String shape = "Square")
    {
        if (callOnce)
        {
            if (shape == Shapes.Square)
            {
                square = new RectangleShape(new Vector2f(100, 100));
                var renderShape = square;
                square.FillColor = color;
                callOnce = false;
            }
            else if (shape == Shapes.Circle)
            {
                circle = new CircleShape(100, 100);
                circle.FillColor = color;
                var renderShape = square;
                callOnce = false;
            }
            else if (shape == Shapes.Triangle)
            {
                triangle = new CircleShape(100, 3);
                triangle.FillColor = color;
                var renderShape = square;
                callOnce = false;
            }
        }
        if (Engine.window != null)
            Engine.window.Draw(render);
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