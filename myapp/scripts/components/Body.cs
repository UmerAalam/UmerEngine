using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
public class Body
{
    bool callOnce = true;
    public Sketch sketch = new Sketch();

    public void Show(string texturePath = "images/white.jpg", Transform.LocationPresets locationPreset = Transform.LocationPresets.Center)
    {
        sketch.Paint(texturePath);
        if (callOnce)
        {
            sketch.origin = Sketch.Origin.Center;
            sketch.transform.SetLocation(locationPreset);
            callOnce = false;
        }
    }
}
