using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Scene
{
    public Sketch sketch = new Sketch();
    public void Game()
    {
        sketch.Square();
    }
}