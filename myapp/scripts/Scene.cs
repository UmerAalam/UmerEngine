using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    Vector2f size = new Vector2f(5f, 5f);
    Body body = new Body();
    Body body1 = new Body();
    Body body2 = new Body();
    public void Game()
    {
        // body.sketch.color = Color.Green;
        // body1.sketch.color = Color.Blue;
        // body2.sketch.color = Color.Red;
        // body.sketch.transform.Size = size;
        body.sketch.transform.Location = new Vector2f(Engine.width / 2, Engine.height / 2);
        // body1.sketch.transform.Location = new Vector2f(640, 360);
        // body2.sketch.transform.Location = new Vector2f(840, 360);
        // body1.sketch.transform.Size = size;
        // body2.sketch.transform.Size = size;
        body.sketch.color = Color.Black;
        body.Paint(Shapes.Circle());
        // body1.Paint(Shapes.Square());
        // body2.Paint(Shapes.Triangle());
    }
}