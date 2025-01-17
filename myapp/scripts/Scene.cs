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
    public RectangleShape square = new RectangleShape(new Vector2f(100, 100));
    // int counting = 0;
    public void Game()
    {
        // sketch.Paint(Shapes.Square);
        // sketch.transform.Location = new Vector2f(640, 360);
        // sketch.color = Color.Black;
        // body1.Paint(Shapes.Square());
        // body1.sketch.color = Color.Blue;
        RectangleShape square = new RectangleShape(new Vector2f(100, 100));
        square.FillColor = Color.Black;
        if (Engine.window != null)
            Engine.window.Draw(square);
    }
}