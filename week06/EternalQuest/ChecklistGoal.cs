public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _targetCount = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        int earned = _points;

        if (_currentCount == _targetCount)
            earned += _bonus;

        return earned;
    }

    public override bool IsComplete()
        => _currentCount >= _targetCount;

    public override string GetStatus()
        => $"[{_currentCount}/{_targetCount}]";

    public override string GetStringRepresentation()
        => $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_currentCount},{_targetCount}";
}