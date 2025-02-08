using System;

public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }

    public abstract void Start();
}