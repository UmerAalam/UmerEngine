using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public static class Shapes
{
    public static RectangleShape square {get;private set;} = new RectangleShape(new Vector2f(100, 100));
    public static CircleShape circle {get;private set;} = new CircleShape(100,100);
    public static CircleShape triangle {get;private set;} = new CircleShape(100,3);
}
