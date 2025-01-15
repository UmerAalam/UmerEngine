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
        if(Engine.window != null)
        while (Engine.window.IsOpen)
        {
            transform.Location = sketch.sprite.Position;
            transform.Rotation = sketch.sprite.Rotation;
            transform.Size = sketch.sprite.Scale;
        }
    }
}
