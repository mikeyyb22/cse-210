public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetPoints()
    {
        if (_amountCompleted == _target)
        {
            return base.GetPoints() + _bonus;
        }
        else
        {
            return base.GetPoints();
        }
    }

    public override string GetStringRepresentation()
    {
        string stringRep = $"{base.GetDetailsString()},{IsComplete()},{_amountCompleted},{_target}";
        return stringRep;
    }

    public override string GetDetailsString()
    {
        string detailString = $"{base.GetDetailsString()} - ({_amountCompleted}/{_target})";
        return detailString;
    }
}