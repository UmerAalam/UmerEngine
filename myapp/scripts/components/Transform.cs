using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Transform
{
    public Vector2f location = new Vector2f(Engine.height / 2, Engine.width / 2);
    public Vector2f Scale = new Vector2f(1, 1);
    public float Rotation = 0;
    public PositionPresets? PositionPreset = PositionPresets.Center;
    public void SetPosition(PositionPresets positionPreset)
    {

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