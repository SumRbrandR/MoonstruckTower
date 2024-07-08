using Godot;
using System;

public partial class BossButtonSwitch : ButtonLock
{
    Timer timer;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        timer = GetNode<Timer>("Timer");
        timer.Timeout += LockMe;
        BodyEntered += UnlockMe;
        sprite = GetNode<Sprite2D>("Sprite2D");
        unlocked = false;
        //        BodyExited -= (node) => LockMe();
    }

    protected override void UnlockMe(Node2D node)
    {
        GD.Print("Unlocked");
        base.UnlockMe(node);
        timer.Start();
    }

    public override void LockMe()
    {
        base.LockMe();
        GD.Print("Locked");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        base._Process(delta);
    }
}
