using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    private Sketch sketch = new Sketch();
    private Sketch sketch2 = new Sketch();
    public SATCollision collider = new SATCollision(new Vector2f[] { new Vector2f(0, 0), new Vector2f(100, 0), new Vector2f(100, 100), new Vector2f(0, 100) });
    public void Game()
    {
        sketch.Square(Color.Green, Vector2.Half);
        sketch.transform.Move(moveSpeed: 3f);
        sketch2.Circle(Color.Red);
        sketch2.transform.Location = new Vector2f(840, 360);
        if (sketch.Collider.IsColliding(sketch2.Collider))
        {
            Console.WriteLine("Collision!");
        }
        else
        {
            Console.WriteLine("No Collision!");
        }
        // sketch.Triangle(Color.Yellow, Vector2.Half, Transform.LocationPresets.Center);
        // sketch2.Circle(Color.Cyan, Vector2.Half, Transform.LocationPresets.Center);
        // sketch2.transform.Location = new Vector2f(840, 360);
    }
}