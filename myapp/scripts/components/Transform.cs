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
    public void SetLocation(PositionPresets? positionPreset = PositionPresets.Center, Vector2f? customLocation = null)
    {
        if (customLocation != null)
        {
            Location = (Vector2f)customLocation;
            return;
        }

        uint centerX = Engine.height / 2;
        Console.WriteLine(centerX);
        uint centerY = Engine.width / 2;
        Console.WriteLine(centerY);


        switch (positionPreset)
        {
            case PositionPresets.Center:
                Location = new Vector2f(centerX, centerY);
                break;

            case PositionPresets.CenterTop:
                Location = new Vector2f(centerX, 0);
                break;

            case PositionPresets.CenterBottom:
                Location = new Vector2f(centerX, Engine.width);
                break;

            case PositionPresets.CenterLeft:
                Location = new Vector2f(0, centerY);
                break;

            case PositionPresets.CenterRight:
                Location = new Vector2f(Engine.height, centerY);
                break;

            case PositionPresets.TopLeft:
                Location = new Vector2f(0, 0);
                break;

            case PositionPresets.TopRight:
                Location = new Vector2f(Engine.height, 0);
                break;

            case PositionPresets.BottomLeft:
                Location = new Vector2f(0, Engine.width);
                break;

            case PositionPresets.BottomRight:
                Location = new Vector2f(Engine.height, Engine.width);
                break;

            default:
                throw new ArgumentException("Invalid position preset provided.");
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