using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Drawing;
public class Body
{
    // bool callOnce = true;
    public Sketch sketch = new Sketch();

    public void Paint(string shape = "images/Shapes/Square.png", Transform.LocationPresets locationPreset = Transform.LocationPresets.Center)
    {
        // sketch.Paint(shape);
        // if (callOnce)
        // {
        //     sketch.origin = Sketch.Origin.Center;
        //     sketch.transform.SetLocation(locationPreset);
        //     callOnce = false;
        // }
    }
}
