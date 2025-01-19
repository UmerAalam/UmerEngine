using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    public Sketch sketch = new Sketch();
    public Sketch sketch2 = new Sketch();
    public Sketch sketch3 = new Sketch();
    public void Game()
    {
        sketch.Square(Color.Green);
        sketch2.Triangle(Color.Black);
        sketch2.Circle(Color.Blue,Vector2.Quater);
        sketch3.Circle(Color.Red);
        sketch3.Square(Color.White,Vector2.Quater);
        sketch.transform.Location = new Vector2f(440, 360);
        sketch2.transform.Location = new Vector2f(640, 360);
        sketch3.transform.Location = new Vector2f(840, 360);
        sketch.transform.Rotation += 3f;
        sketch2.transform.Rotation += 3f;
        sketch3.transform.Rotation += 3f;

    }
}