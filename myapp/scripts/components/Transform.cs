using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Transform
{
    public Vector2f location;
    public Vector2f Scale = new Vector2f(1, 1);
    public float Rotation = 0;
    public PositionPresets? PositionPreset = PositionPresets.Center;
    public void SetPosition(PositionPresets positionPreset)
    {
        if(PositionPreset == PositionPresets.Center)
        {
            location = new Vector2f(Engine.height / 2, Engine.width / 2);
        }
        else if(PositionPreset == PositionPresets.CenterTop)
        {
            location = new Vector2f(Engine.height / 2, 0);
        }
        else if(PositionPreset == PositionPresets.CenterBottom)
        {
            location = new Vector2f(Engine.height / 2, Engine.width);
        }
        else if(PositionPreset == PositionPresets.CenterLeft)
        {
            location = new Vector2f(0, Engine.width / 2);
        }
        else if(PositionPreset == PositionPresets.CenterRight)
        {
            location = new Vector2f(Engine.height, Engine.width / 2);
        }
        else if(PositionPreset == PositionPresets.TopLeft)
        {
            location = new Vector2f(0, 0);
        }
        else if(PositionPreset == PositionPresets.TopRight)
        {
            location = new Vector2f(Engine.height, 0);
        }
        else if(PositionPreset == PositionPresets.BottomLeft)
        {
            location = new Vector2f(0, Engine.width);
        }
        else if(PositionPreset == PositionPresets.BottomRight)
        {
            location = new Vector2f(Engine.height, Engine.width);
        }
    }
    public enum PositionPresets
    {
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