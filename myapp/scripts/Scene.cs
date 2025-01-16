using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    public Body body = new Body();
    public void Game()
    {
        body.Show();
        body.sketch.color = Color.Blue;
        body.sketch.transform.Location += new Vector2f(0f, 0.5f);
    }
}