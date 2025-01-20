using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    public Sketch sketch = new Sketch();
    public Sketch sketch2 = new Sketch();
    public void Game()
    {
        sketch.Square(Color.Green,Vector2.Half);
        sketch.transform.Move(moveSpeed: 3f);
        sketch2.Square(Color.Red);
        sketch2.transform.Location = new Vector2f(840, 360);

    }
}