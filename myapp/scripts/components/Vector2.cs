using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Dynamic;
public static class Vector2
{
    public static Vector2f Xero { get; private set; } = new Vector2f(0f, 0f);
    public static Vector2f Quater { get; private set; } = new Vector2f(0.25f, 0.25f);
    public static Vector2f Half { get; private set; } = new Vector2f(0.5f, 0.5f);
    public static Vector2f One { get; private set; } = new Vector2f(1f, 1f);
    public static Vector2f Two { get; private set; } = new Vector2f(2f, 2f);
    public static Vector2f Three { get; private set; } = new Vector2f(3f, 3f);

    public static Vector2f Magnitude(float x, float y)
    {
        float magnitude = (float)Math.Sqrt((x * x) + (y * y));
        if(magnitude == 0)
        {
            return Vector2.Xero;
        }
        return new Vector2f(x / magnitude, y / magnitude);
    }
}
