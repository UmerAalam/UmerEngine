using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    Body body = new Body();
    Body body1 = new Body();
    Body body2 = new Body();
    public void Game()
    {
        body.sketch.color = Color.Green;
        body.sketch.transform.Rotation = 15;
        body1.sketch.color = Color.Blue;
        body1.sketch.transform.Rotation = 30;
        body2.sketch.color = Color.Red;
        body2.sketch.transform.Rotation = 45;
        body.Show();
        body1.Show();
        body2.Show();
    }
}