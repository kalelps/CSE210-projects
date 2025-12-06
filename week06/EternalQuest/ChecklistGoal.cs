public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted == _target)
            return _points + _bonus;

        return _points;
    }

    public override bool IsComplete()
        => _timesCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_timesCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
        => $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_timesCompleted}";
}
