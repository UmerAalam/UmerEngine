using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    public Sketch sketch = new Sketch();
    public void Game()
    {
        sketch.Triangle(Color.Black);
        // sketch.Circle(Color.Red);
        // sketch.Square(Color.Green);
    }
}