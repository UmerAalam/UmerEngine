// using SFML.System;
// using System;
// using System.Collections.Generic;
//
// public class CircleCollider
// {
//     public Vector2f Center { get; private set; }
//     public float Radius { get; private set; }
//
//     public CircleCollider(Vector2f center, float radius)
//     {
//         if (radius <= 0)
//             throw new ArgumentException("Radius must be greater than zero.");
//
//         Center = center;
//         Radius = radius;
//     }
//
//     public bool IsColliding(CircleCollider other)
//     {
//         float dx = Center.X - other.Center.X;
//         float dy = Center.Y - other.Center.Y;
//         float distanceSq = dx * dx + dy * dy;
//
//         float radiusSum = Radius + other.Radius;
//         return distanceSq <= radiusSum * radiusSum;
//     }
//
//     public bool IsColliding(SATCollision polygon)
//     {
//         // 1. Check all polygon edge normals
//         foreach (var axis in GetAxes(polygon.Vertices))
//         {
//             if (!OverlapOnAxis(polygon, axis))
//                 return false;
//         }
//
//         // 2. Check axis from circle center to closest polygon vertex
//         Vector2f closest = GetClosestPoint(polygon.Vertices, Center);
//         Vector2f axis = Center - closest;
//
//         // Prevent zero-length axis
//         if (axis.X == 0 && axis.Y == 0)
//             axis = new Vector2f(1, 0); // Arbitrary
//
//         Normalize(ref axis);
//
//         if (!OverlapOnAxis(polygon, axis))
//             return false;
//
//         return true;
//     }
//
//     // --- Helper Methods ---
//
//     private List<Vector2f> GetAxes(Vector2f[] vertices)
//     {
//         List<Vector2f> axes = new List<Vector2f>();
//
//         for (int i = 0; i < vertices.Length; i++)
//         {
//             Vector2f p1 = vertices[i];
//             Vector2f p2 = vertices[(i + 1) % vertices.Length];
//
//             Vector2f edge = p2 - p1;
//             Vector2f normal = new Vector2f(-edge.Y, edge.X);
//
//             Normalize(ref normal);
//             axes.Add(normal);
//         }
//
//         return axes;
//     }
//
//     private bool OverlapOnAxis(SATCollision polygon, Vector2f axis)
//     {
//         // Circle projection
//         float centerProj = Dot(Center, axis);
//         float minCircle = centerProj - Radius;
//         float maxCircle = centerProj + Radius;
//
//         // Polygon projection
//         float minPoly = Dot(polygon.Vertices[0], axis);
//         float maxPoly = minPoly;
//
//         for (int i = 1; i < polygon.Vertices.Length; i++)
//         {
//             float proj = Dot(polygon.Vertices[i], axis);
//             if (proj < minPoly) minPoly = proj;
//             if (proj > maxPoly) maxPoly = proj;
//         }
//
//         return !(maxCircle < minPoly || maxPoly < minCircle);
//     }
//
//     private Vector2f GetClosestPoint(Vector2f[] vertices, Vector2f point)
//     {
//         Vector2f closest = vertices[0];
//         float minDist = DistanceSquared(point, closest);
//
//         for (int i = 1; i < vertices.Length; i++)
//         {
//             float dist = DistanceSquared(point, vertices[i]);
//             if (dist < minDist)
//             {
//                 minDist = dist;
//                 closest = vertices[i];
//             }
//         }
//
//         return closest;
//     }
//
//     private float Dot(Vector2f a, Vector2f b)
//     {
//         return a.X * b.X + a.Y * b.Y;
//     }
//
//     private float DistanceSquared(Vector2f a, Vector2f b)
//     {
//         float dx = a.X - b.X;
//         float dy = a.Y - b.Y;
//         return dx * dx + dy * dy;
//     }
//
//     private void Normalize(ref Vector2f vec)
//     {
//         float length = (float)Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y);
//         if (length > 0)
//         {
//             vec.X /= length;
//             vec.Y /= length;
//         }
//     }
// }


using SFML.System;
using System;

public class CircleCollider
{
    public Vector2f Center { get; private set; }
    public float Radius { get; private set; }

    public CircleCollider(Vector2f center, float radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero.");

        Center = center;
        Radius = radius;
    }

    public bool IsColliding(CircleCollider other)
    {
        float dx = Center.X - other.Center.X;
        float dy = Center.Y - other.Center.Y;
        float distanceSq = dx * dx + dy * dy;

        float radiusSum = Radius + other.Radius;
        return distanceSq <= radiusSum * radiusSum;
    }
}
