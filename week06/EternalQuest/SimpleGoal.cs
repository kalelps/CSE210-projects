public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
        => IsComplete() ? $"[X] {base.GetDetailsString()}" 
                        : $"[ ] {base.GetDetailsString()}";

    public override string GetStringRepresentation()
        => $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
}
