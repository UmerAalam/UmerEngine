using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Transform
{
    public static bool rotRight = Keyboard.IsKeyPressed(Keyboard.Key.Right);
    public static bool rotLeft = Keyboard.IsKeyPressed(Keyboard.Key.Left);
    public Vector2f Location = new Vector2f(0, 0);
    public Vector2f Size = new Vector2f(1f, 1f);
    public float Rotation = 0;
    public Vector2f SetLocation(Vector2u windowSize, LocationPresets locationPreset = LocationPresets.Center, Vector2f? customLocation = null)
    {
        if (customLocation != null)
        {
            Location = (Vector2f)customLocation;
            return Location;
        }

        uint centerX = (uint)windowSize.X / 2;
        uint centerY = (uint)windowSize.Y / 2;

        switch (locationPreset)
        {
            case LocationPresets.Center:
                Location = new Vector2f(centerX, centerY);
                break;

            case LocationPresets.CenterTop:
                Location = new Vector2f(centerX, 0);
                break;

            case LocationPresets.CenterBottom:
                Location = new Vector2f(centerX, Engine.width);
                break;

            case LocationPresets.CenterLeft:
                Location = new Vector2f(0, centerY);
                break;

            case LocationPresets.CenterRight:
                Location = new Vector2f(Engine.height, centerY);
                break;

            case LocationPresets.TopLeft:
                Location = new Vector2f(0, 0);
                break;

            case LocationPresets.TopRight:
                Location = new Vector2f(Engine.height, 0);
                break;

            case LocationPresets.BottomLeft:
                Location = new Vector2f(0, Engine.width);
                break;

            case LocationPresets.BottomRight:
                Location = new Vector2f(Engine.height, Engine.width);
                break;

            default:
                throw new ArgumentException("Invalid position preset provided.");
        }
        return Location;
    }
    public void Move(float moveSpeed, bool up = false, bool down = false, bool left = false, bool right = false)
    {
        Vector2f movement = new Vector2f(0, 0);
        up = Keyboard.IsKeyPressed(Keyboard.Key.W);
        down = Keyboard.IsKeyPressed(Keyboard.Key.S);
        left = Keyboard.IsKeyPressed(Keyboard.Key.A);
        right = Keyboard.IsKeyPressed(Keyboard.Key.D);
        if (up)
        {
            movement.Y -= moveSpeed;
        }
        if (down)
        {
            movement.Y += moveSpeed;
        }
        if (left)
        {
            movement.X -= moveSpeed;
        }
        if (right)
        {
            movement.X += moveSpeed;
        }

        float magnitude = (float)Math.Sqrt((movement.X * movement.X) + (movement.Y * movement.Y));
        if (magnitude > 0)
        {
            movement.X /= magnitude;
            movement.Y /= magnitude;
        }

        movement.X *= moveSpeed;
        movement.Y *= moveSpeed;

        Location += movement;
    }
    public void Rotate(float rotationSpeed)
    {
        if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
        {
            Rotation -= rotationSpeed;
        }
        if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
        {
            Rotation += rotationSpeed;
        }
    }
    public enum LocationPresets
    {
        Custom,
        Center,
        CenterTop,
        CenterBottom,
        CenterLeft,
        CenterRight,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }
}