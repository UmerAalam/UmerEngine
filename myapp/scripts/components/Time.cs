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
    public static double DeltaTime { get; private set; }

    static Time()
    {
        stopwatch = new Stopwatch();
        stopwatch.Start();
        lastFrameTime = 0;
        DeltaTime = 0;
    }
    public static void Update()
    {
        double currentFrameTime = stopwatch.Elapsed.TotalSeconds;
        DeltaTime = currentFrameTime - lastFrameTime;
        lastFrameTime = currentFrameTime;
        Console.WriteLine(DeltaTime);
    }
}
