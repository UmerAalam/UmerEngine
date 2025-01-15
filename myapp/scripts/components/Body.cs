using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Body
{
    public Transform transform = new Transform();
    public Sketch sketch = new Sketch();

    public Body()
    {
        Update();
    }
    void Update()
    {
        if (Engine.window != null)
            while (Engine.window.IsOpen)
            {
                sketch.sprite.Position = transform.Location;
                Console.WriteLine(sketch.sprite.Position);
                sketch.sprite.Rotation = transform.Rotation;
                sketch.sprite.Scale = transform.Size;
            }
        else
        {
            Console.WriteLine("Window is null");
        }
    }
}
