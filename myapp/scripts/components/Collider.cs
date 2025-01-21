using SFML.Graphics;
using SFML.System;
using System;

public class Collider
{
    public static bool IsColliding(FloatRect rect1, FloatRect rect2)
    {
        return rect1.Intersects(rect2);
    }
    public static bool IsColliding(Vector2f center1, float radius1, Vector2f center2, float radius2)
    {
        float dx = center2.X - center1.X;
        float dy = center2.Y - center1.Y;
        float distanceSquared = dx * dx + dy * dy;
        float radiusSum = radius1 + radius2;

        return distanceSquared <= radiusSum * radiusSum;
    }
    public static bool IsPointInsideRect(Vector2f point, FloatRect rect)
    {
        return rect.Contains(point.X, point.Y);
    }
    public static bool IsPointInsideCircle(Vector2f point, Vector2f center, float radius)
    {
        float dx = point.X - center.X;
        float dy = point.Y - center.Y;
        float distanceSquared = dx * dx + dy * dy;

        return distanceSquared <= radius * radius;
    }

    public static bool IsColliding(FloatRect rect, Vector2f circleCenter, float circleRadius)
    {

        float closestX = Math.Clamp(circleCenter.X, rect.Left, rect.Left + rect.Width);
        float closestY = Math.Clamp(circleCenter.Y, rect.Top, rect.Top + rect.Height);

        float dx = circleCenter.X - closestX;
        float dy = circleCenter.Y - closestY;

        return (dx * dx + dy * dy) <= (circleRadius * circleRadius);
    }

    public static Vector2f ResolveCollision(FloatRect rect1, FloatRect rect2)
    {
        if (!IsColliding(rect1, rect2))
            return new Vector2f(0, 0);

        float overlapX = Math.Min(rect1.Left + rect1.Width - rect2.Left, rect2.Left + rect2.Width - rect1.Left);
        float overlapY = Math.Min(rect1.Top + rect1.Height - rect2.Top, rect2.Top + rect2.Height - rect1.Top);

        if (overlapX < overlapY)
        {
            return new Vector2f(rect1.Left < rect2.Left ? -overlapX : overlapX, 0);
        }
        else
        {
            return new Vector2f(0, rect1.Top < rect2.Top ? -overlapY : overlapY);
        }
    }
}
