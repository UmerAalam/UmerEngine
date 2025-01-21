using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    public Sketch sketch = new Sketch();
    public Sketch sketch2 = new Sketch();
    public Collider collider = new Collider(new Vector2f[] { new Vector2f(0, 0), new Vector2f(100, 0), new Vector2f(100, 100), new Vector2f(0, 100) });
    public void Game()
    {
        sketch.Square(Color.Green,Vector2.Half);
        sketch.transform.Move(moveSpeed: 3f);
        sketch2.Square(Color.Red);
        sketch2.transform.Location = new Vector2f(840, 360);
        if (sketch.Collider.IsColliding(sketch2.Collider))
        {
            Console.WriteLine("Collision!");
        }
        else
        {
            Console.WriteLine("No Collision!");
        }
    }
}