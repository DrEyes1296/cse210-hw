public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Returns a negative value to deduct points
        return -_points;
    }

    public override bool IsComplete()
    {
        return false; // Negative goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}