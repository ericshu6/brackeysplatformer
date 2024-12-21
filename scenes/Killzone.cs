using Godot;
using System;

public partial class Killzone : Area2D
{
    private void OnBodyEntered(Node2D body)
    {
        var timer = GetNode<Timer>("Timer");
        GD.Print("Death");
        timer.Start();
    }

    private void OnTimerTimeout()
    {
        GetTree().ReloadCurrentScene();
        GD.Print("Respawn");
    }
}
