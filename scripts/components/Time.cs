using System;
using System.Diagnostics;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System.Globalization;
public static class Time
{
    private static Stopwatch stopwatch;
    private static double lastFrameTime; 
    public static double deltaTime { get; private set; }

    static Time()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
        lastFrameTime = 0;
        deltaTime = 0;
    }
    public static double DeltaTime()
    {
        double currentFrameTime = stopwatch.Elapsed.TotalSeconds;
        deltaTime = currentFrameTime - lastFrameTime;
        lastFrameTime = currentFrameTime;
        Console.WriteLine(deltaTime);
        return deltaTime;
    }
}
