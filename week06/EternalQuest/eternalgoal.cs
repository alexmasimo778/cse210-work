class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress for '{_shortName}'. Earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false;  // Eternal goals never complete
    }

    public override string GetStringRepresentation()
    {
        return $"[EternalGoal] {_shortName}";
    }
}

    