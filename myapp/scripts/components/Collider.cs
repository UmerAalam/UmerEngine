using SFML.Graphics;
using SFML.System;
using System;

public static class Collider
{
    public static bool CheckCollision(RectangleShape rect1, RectangleShape rect2)
    {
        FloatRect bounds1 = rect1.GetGlobalBounds();
        FloatRect bounds2 = rect2.GetGlobalBounds();
        return bounds1.Intersects(bounds2);
    }
    public static bool CheckCollision(CircleShape circle1, CircleShape circle2)
    {
        Vector2f delta = circle1.Position - circle2.Position;
        float distance = MathF.Sqrt(delta.X * delta.X + delta.Y * delta.Y);
        return distance <= (circle1.Radius + circle2.Radius);
    }
    public static bool CheckCollision(RectangleShape rect, CircleShape circle)
    {
        FloatRect rectBounds = rect.GetGlobalBounds();
        Vector2f circleCenter = circle.Position + new Vector2f(circle.Radius, circle.Radius);

        float closestX = MathF.Max(rectBounds.Left, MathF.Min(circleCenter.X, rectBounds.Left + rectBounds.Width));
        float closestY = MathF.Max(rectBounds.Top, MathF.Min(circleCenter.Y, rectBounds.Top + rectBounds.Height));

        float deltaX = circleCenter.X - closestX;
        float deltaY = circleCenter.Y - closestY;

        return (deltaX * deltaX + deltaY * deltaY) <= (circle.Radius * circle.Radius);
    }
}
