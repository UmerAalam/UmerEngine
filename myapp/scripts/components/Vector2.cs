using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Dynamic;
public static class Vector2
{
    public static Vector2f Xero { get; private set; } = new Vector2f(0f, 0f);
    public static Vector2f Half { get; private set; } = new Vector2f(0.5f, 0.5f);
    public static Vector2f one { get; private set; } = new Vector2f(1f, 1f);
    public static Vector2f Two { get; private set; } = new Vector2f(2f, 2f);
    public static Vector2f Three { get; private set; } = new Vector2f(3f, 3f);
}
