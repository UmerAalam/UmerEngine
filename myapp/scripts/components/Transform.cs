using System;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

public class Transform
{
    public Vector2f Location = new Vector2f(0, 0);
    public Vector2f Size = new Vector2f(1f, 1f);
    public float Rotation = 0;
    public Vector2f SetLocation(Vector2u windowSize,LocationPresets locationPreset = LocationPresets.Center, Vector2f? customLocation = null)
    {
        if (customLocation != null)
        {
            Location = (Vector2f)customLocation;
            return Location;
        }

        uint centerX = (uint)windowSize.X / 2;
        uint centerY = (uint)windowSize.Y / 2;

        switch (locationPreset)
        {
            case LocationPresets.Center:
                Location = new Vector2f(centerX, centerY);
                break;

            case LocationPresets.CenterTop:
                Location = new Vector2f(centerX, 0);
                break;

            case LocationPresets.CenterBottom:
                Location = new Vector2f(centerX, Engine.width);
                break;

            case LocationPresets.CenterLeft:
                Location = new Vector2f(0, centerY);
                break;

            case LocationPresets.CenterRight:
                Location = new Vector2f(Engine.height, centerY);
                break;

            case LocationPresets.TopLeft:
                Location = new Vector2f(0, 0);
                break;

            case LocationPresets.TopRight:
                Location = new Vector2f(Engine.height, 0);
                break;

            case LocationPresets.BottomLeft:
                Location = new Vector2f(0, Engine.width);
                break;

            case LocationPresets.BottomRight:
                Location = new Vector2f(Engine.height, Engine.width);
                break;

            default:
                throw new ArgumentException("Invalid position preset provided.");
        }
        return Location;
    }

    public enum LocationPresets
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