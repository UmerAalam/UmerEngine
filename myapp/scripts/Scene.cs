using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    public Body body = new Body();
    public void Game()
    {
        body.sketch.Paint();
        body.sketch.transform.SetLocation(Transform.PositionPresets.CenterBottom,null);
        Console.WriteLine(body.sketch.transform.Location);
        // body.sketch.transform.Rotation = 45;
        // body.transform.SetLocation();
    }
}