// // using SFML.Graphics;
// // using SFML.System;
// // using System;
// // using System.Collections.Generic;

// // public class Collider
// // {
// //     public Vector2f[] Vertices { get; private set; }

// //     public Collider(Vector2f[] vertices)
// //     {
// //         if (vertices.Length < 3)
// //             throw new ArgumentException("A collider must have at least three vertices.");

// //         Vertices = vertices;
// //     }

// //     public bool IsColliding(Collider other)
// //     {
// //         if (CheckSeparatingAxis(this, other))
// //             return false;

// //         if (CheckSeparatingAxis(other, this))
// //             return false;

// //         return true;
// //     }

// //     private static bool CheckSeparatingAxis(Collider colliderA, Collider colliderB)
// //     {
// //         foreach (var edge in GetEdges(colliderA.Vertices))
// //         {
// //             Vector2f axis = GetPerpendicular(edge);

// //             var projectionA = ProjectOntoAxis(colliderA.Vertices, axis);
// //             var projectionB = ProjectOntoAxis(colliderB.Vertices, axis);

// //             if (!ProjectionsOverlap(projectionA, projectionB))
// //                 return true;
// //         }

// //         return false;
// //     }

// //     private static IEnumerable<Vector2f> GetEdges(Vector2f[] vertices)
// //     {
// //         for (int i = 0; i < vertices.Length; i++)
// //         {
// //             Vector2f start = vertices[i];
// //             Vector2f end = vertices[(i + 1) % vertices.Length];
// //             yield return new Vector2f(end.X - start.X, end.Y - start.Y);
// //         }
// //     }

// //     private static Vector2f GetPerpendicular(Vector2f edge)
// //     {
// //         return new Vector2f(-edge.Y, edge.X);
// //     }

// //     private static (float Min, float Max) ProjectOntoAxis(Vector2f[] vertices, Vector2f axis)
// //     {
// //         float min = DotProduct(vertices[0], axis);
// //         float max = min;

// //         for (int i = 1; i < vertices.Length; i++)
// //         {
// //             float projection = DotProduct(vertices[i], axis);

// //             if (projection < min)
// //                 min = projection;
// //             if (projection > max)
// //                 max = projection;
// //         }

// //         return (min, max);
// //     }

// //     private static bool ProjectionsOverlap((float Min, float Max) projectionA, (float Min, float Max) projectionB)
// //     {
// //         return !(projectionA.Max < projectionB.Min || projectionB.Max < projectionA.Min);
// //     }

// //     private static float DotProduct(Vector2f vectorA, Vector2f vectorB)
// //     {
// //         return vectorA.X * vectorB.X + vectorA.Y * vectorB.Y;
// //     }
// // }
// using SFML.Graphics;
// using SFML.System;
// using System;
// using System.Collections.Generic;

// public class Collider
// {
//     public Vector2f[] Vertices { get; private set; }

//     public Collider(Vector2f[] vertices)
//     {
//         if (vertices.Length < 3)
//             throw new ArgumentException("A collider must have at least three vertices.");

//         Vertices = vertices;
//     }

//     // Main SAT collision check
//     public bool IsColliding(Collider other)
//     {
//         // Check all axes from this collider
//         foreach (var axis in GetAxes(this.Vertices))
//         {
//             if (!OverlapOnAxis(other, axis))
//                 return false;
//         }

//         // Check all axes from other collider
//         foreach (var axis in GetAxes(other.Vertices))
//         {
//             if (!OverlapOnAxis(other, axis))
//                 return false;
//         }

//         return true;
//     }

//     // Get all potential separating axes (normals to each edge)
//     private static List<Vector2f> GetAxes(Vector2f[] vertices)
//     {
//         List<Vector2f> axes = new List<Vector2f>();

//         for (int i = 0; i < vertices.Length; i++)
//         {
//             Vector2f p1 = vertices[i];
//             Vector2f p2 = vertices[(i + 1) % vertices.Length];
            
//             Vector2f edge = p2 - p1;
//             Vector2f normal = new Vector2f(-edge.Y, edge.X);
            
//             // Normalize the axis to get proper projections
//             float length = (float)Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y);
//             if (length > 0)
//             {
//                 normal.X /= length;
//                 normal.Y /= length;
//             }
            
//             axes.Add(normal);
//         }

//         return axes;
//     }

//     // Check if projections overlap on a specific axis
//     private bool OverlapOnAxis(Collider other, Vector2f axis)
//     {
//         Projection proj1 = Project(axis);
//         Projection proj2 = other.Project(axis);
        
//         return proj1.Overlaps(proj2);
//     }

//     // Project all vertices onto an axis
//     private Projection Project(Vector2f axis)
//     {
//         float min = DotProduct(Vertices[0], axis);
//         float max = min;

//         for (int i = 1; i < Vertices.Length; i++)
//         {
//             float p = DotProduct(Vertices[i], axis);
            
//             if (p < min) min = p;
//             if (p > max) max = p;
//         }

//         return new Projection(min, max);
//     }

//     private static float DotProduct(Vector2f a, Vector2f b)
//     {
//         return a.X * b.X + a.Y * b.Y;
//     }

//     // Helper struct to store projection results
//     private struct Projection
//     {
//         public float Min { get; }
//         public float Max { get; }

//         public Projection(float min, float max)
//         {
//             Min = min;
//             Max = max;
//         }

//         public bool Overlaps(Projection other)
//         {
//             return !(Max < other.Min || other.Max < Min);
//         }
//     }
// }
