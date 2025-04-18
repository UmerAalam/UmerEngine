using System;
using Microsoft.VisualBasic;
using SFML.Graphics;
using SFML.System;
using System.Text;

public class Sketch
{
    public Transform transform = new Transform();
    public Color color = Color.White;
    public FlipMode flip = FlipMode.None;
    public DrawMode drawMode = DrawMode.Smooth;
    public Origin origin = Origin.Center;
    private bool once = true;

    private RectangleShape square = new RectangleShape()
    {
        Size = new Vector2f(100, 100),
        Scale = new Vector2f(1, 1),
        Position = new Vector2f(Engine.width / 2f, Engine.height / 2f),
        FillColor = Color.White,
    };

    private CircleShape circle = new CircleShape()
    {
        Radius = 50f,
        Scale = new Vector2f(1, 1),
        Position = new Vector2f(Engine.width / 2f, Engine.height / 2f),
        FillColor = Color.White,
    };

    private CircleShape triangle = new CircleShape(radius: 70f, pointCount: 3)
    {
        Scale = new Vector2f(1, 1),
        Position = new Vector2f(Engine.width / 2f, Engine.height / 2f),
        FillColor = Color.White,
    };

    public SATCollision? Collider { get; private set; }

    public void Square(Color? color = null, Vector2f? Scale = null, Transform.LocationPresets locationPresets = Transform.LocationPresets.Center)
    {
        if (once)
        {
            if (Engine.window != null)
            {
                square.Position = transform.SetLocation(Engine.window.Size, locationPresets, null);
            }
            once = false;
        }
        square.FillColor = color ?? Color.Black;
        square.Position = transform.Location;
        square.Rotation = transform.Rotation;
        square.Scale = Scale ?? transform.Size;
        square.Origin = SetOrigin(square.Size);

        UpdateCollider(square);

        if (Engine.window != null)
            Engine.window.Draw(square);
    }

    public void Circle(Color? color = null, Vector2f? Scale = null, Transform.LocationPresets locationPresets = Transform.LocationPresets.Center)
    {
        if (once)
        {
            if (Engine.window != null)
            {
                circle.Position = transform.SetLocation(Engine.window.Size, locationPresets, null);
            }
            once = false;
        }
        circle.FillColor = color ?? Color.Black;
        circle.Position = transform.Location;
        circle.Rotation = transform.Rotation;
        circle.Scale = Scale ?? transform.Size;
        circle.Origin = SetOrigin(new Vector2f(circle.Radius * 2f, circle.Radius * 2f));

        UpdateCollider(circle);

        if (Engine.window != null)
            Engine.window.Draw(circle);
    }

    public void Triangle(Color? color = null, Vector2f? Scale = null, Transform.LocationPresets locationPresets = Transform.LocationPresets.Center)
    {
        if (once)
        {
            if (Engine.window != null)
            {
                triangle.Position = transform.SetLocation(Engine.window.Size, locationPresets, null);
            }
            once = false;
        }
        triangle.FillColor = color ?? Color.Black;
        triangle.Position = transform.Location;
        triangle.Rotation = transform.Rotation;
        triangle.Scale = Scale ?? transform.Size;
        triangle.Origin = new Vector2f(triangle.Radius, triangle.Radius);

        UpdateCollider(triangle);

        if (Engine.window != null)
            Engine.window.Draw(triangle);
    }

    public void Outline(Shape shape, Color? color = null, float thinkness = 1f)
    {
        shape.OutlineColor = color ?? Color.Black;
        shape.OutlineThickness = thinkness;
    }

    public Vector2f SetOrigin(Vector2f SpriteSize, Origin origin = Origin.Center)
    {
        if (origin == Origin.Center)
            return SpriteSize / 2;
        else if (origin == Origin.TopLeft)
            return Vector2.Xero;
        else if (origin == Origin.TopRight)
            return new Vector2f(SpriteSize.X, 0);
        else if (origin == Origin.BottomLeft)
            return new Vector2f(0, SpriteSize.Y);
        else if (origin == Origin.BottomRight)
            return new Vector2f(SpriteSize.X, SpriteSize.Y);
        else if (origin == Origin.Custom)
            return SpriteSize;
        return SpriteSize;
    }

    private void UpdateCollider(Shape shape)
    {
        FloatRect bounds = shape.GetGlobalBounds();
        Vector2f position = shape.Position;
        Vector2f[] vertices = new Vector2f[]
        {
            new Vector2f(bounds.Left, bounds.Top),
            new Vector2f(bounds.Left + bounds.Width, bounds.Top),
            new Vector2f(bounds.Left + bounds.Width, bounds.Top + bounds.Height),
            new Vector2f(bounds.Left, bounds.Top + bounds.Height)
        };

        Collider = new SATCollision(vertices);
    }

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
