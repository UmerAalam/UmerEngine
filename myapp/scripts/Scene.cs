using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    Vector2f size = new Vector2f(5f, 5f);
    // Body body = new Body();
    // Body body1 = new Body();
    // Body body2 = new Body();
    public Sketch sketch = new Sketch();
    // int counting = 0;
    public void Game()
    {
        sketch.Paint(Shapes.Square);
        // body1.Paint(Shapes.Square());
        // body1.sketch.color = Color.Blue;
    }
}