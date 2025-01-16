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
        body.sketch.transform.Location = new Vector2f(440,360);
        body.Paint(Shapes.Circle());
        body.sketch.color = Color.Red;
        body1.sketch.transform.Location = new Vector2f(640,360);
        body1.Paint(Shapes.Square());
        body1.sketch.color = Color.Blue;
        body2.sketch.transform.Location = new Vector2f(840,360);
        body2.Paint(Shapes.Triangle());
        body2.sketch.color = Color.Green;

    }
}