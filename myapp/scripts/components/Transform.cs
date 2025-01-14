using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Transform
{
    public Vector2f Position = new Vector2f(Engine.height / 2, Engine.width / 2);
    public Vector2f Scale = new Vector2f(1, 1);
    public float Rotation = 0;
}