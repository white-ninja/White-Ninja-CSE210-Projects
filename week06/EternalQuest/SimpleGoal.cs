public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
        => _isComplete ? "[X]" : "[ ]";

    public override string GetStringRepresentation()
        => $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
}