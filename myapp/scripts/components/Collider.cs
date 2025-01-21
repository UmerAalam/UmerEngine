using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;

public class Collider
{
    public Vector2f[] Vertices { get; private set; }

    public Collider(Vector2f[] vertices)
    {
        if (vertices.Length < 3)
            throw new ArgumentException("A collider must have at least three vertices.");

        Vertices = vertices;
    }

    public bool IsColliding(Collider other)
    {
        if (CheckSeparatingAxis(this, other))
            return false;

        if (CheckSeparatingAxis(other, this))
            return false;

        return true;
    }

    private static bool CheckSeparatingAxis(Collider colliderA, Collider colliderB)
    {
        foreach (var edge in GetEdges(colliderA.Vertices))
        {
            Vector2f axis = GetPerpendicular(edge);

            var projectionA = ProjectOntoAxis(colliderA.Vertices, axis);
            var projectionB = ProjectOntoAxis(colliderB.Vertices, axis);

            if (!ProjectionsOverlap(projectionA, projectionB))
                return true;
        }

        return false;
    }

    private static IEnumerable<Vector2f> GetEdges(Vector2f[] vertices)
    {
        for (int i = 0; i < vertices.Length; i++)
        {
            Vector2f start = vertices[i];
            Vector2f end = vertices[(i + 1) % vertices.Length];
            yield return new Vector2f(end.X - start.X, end.Y - start.Y);
        }
    }

    private static Vector2f GetPerpendicular(Vector2f edge)
    {
        return new Vector2f(-edge.Y, edge.X);
    }

    private static (float Min, float Max) ProjectOntoAxis(Vector2f[] vertices, Vector2f axis)
    {
        float min = DotProduct(vertices[0], axis);
        float max = min;

        for (int i = 1; i < vertices.Length; i++)
        {
            float projection = DotProduct(vertices[i], axis);

            if (projection < min)
                min = projection;
            if (projection > max)
                max = projection;
        }

        return (min, max);
    }

    private static bool ProjectionsOverlap((float Min, float Max) projectionA, (float Min, float Max) projectionB)
    {
        return !(projectionA.Max < projectionB.Min || projectionB.Max < projectionA.Min);
    }

    private static float DotProduct(Vector2f vectorA, Vector2f vectorB)
    {
        return vectorA.X * vectorB.X + vectorA.Y * vectorB.Y;
    }
}
