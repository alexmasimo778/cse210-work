class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Progress recorded for '{_shortName}' ({_amountCompleted}/{_target}). Earned {_points} points.");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Goal '{_shortName}' completed! Bonus {_bonus} points awarded!");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"[ChecklistGoal] {_shortName} - Completed: {_amountCompleted}/{_target}";
    }
}
