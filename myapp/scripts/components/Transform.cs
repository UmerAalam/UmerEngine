using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Transform
{
    public Vector2f Location;
    public Vector2f Size = new Vector2f(1, 1);
    public float Rotation = 0;
    public PositionPresets? PositionPreset = PositionPresets.Center;
    public Transform()
    {
        SetLocation();
    }
    public void SetLocation(PositionPresets? positionPreset = PositionPresets.Center, Vector2f? customLocation = null)
    {
        if (customLocation == null)
        {
            if (PositionPreset == PositionPresets.Center)
            {
                Location = new Vector2f(Engine.height / 2, Engine.width / 2);
            }
        }
        else if (PositionPreset == PositionPresets.CenterTop)
        {
            Location = new Vector2f(Engine.height / 2, 0);
        }
        else if (PositionPreset == PositionPresets.CenterBottom)
        {
            Location = new Vector2f(Engine.height / 2, Engine.width);
        }
        else if (PositionPreset == PositionPresets.CenterLeft)
        {
            Location = new Vector2f(0, Engine.width / 2);
        }
        else if (PositionPreset == PositionPresets.CenterRight)
        {
            Location = new Vector2f(Engine.height, Engine.width / 2);
        }
        else if (PositionPreset == PositionPresets.TopLeft)
        {
            Location = new Vector2f(0, 0);
        }
        else if (PositionPreset == PositionPresets.TopRight)
        {
            Location = new Vector2f(Engine.height, 0);
        }
        else if (PositionPreset == PositionPresets.BottomLeft)
        {
            Location = new Vector2f(0, Engine.width);
        }
        else if (PositionPreset == PositionPresets.BottomRight)
        {
            Location = new Vector2f(Engine.height, Engine.width);
        }
        else
        {
            Location = (Vector2f)customLocation;
        }

    }
    public enum PositionPresets
    {
        Custom,
        Center,
        CenterTop,
        CenterBottom,
        CenterLeft,
        CenterRight,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }
}