public class EternalGoal : BaseGoal
{
    public int _quantityCompleted  { get; set; }
    
    public void CreateEternalGoal()
    {
        base.SetTitle();
        base.SetDescription();
        base.SetCompletionPointValue();
        _quantityCompleted = 0;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_quantityCompleted}] {_goalTitle} ({_goalDescription})");
    }

    public override void MarkComplete()
    {
        _quantityCompleted++;
    }

    public void LoadPreviousGoalData(int goalType, string title, string description, int completionPointValue, bool completionStatus, int completionQuantity)
    {
        _goalType = goalType;
        _goalTitle = title;
        _goalDescription = description;
        _completionPointValue = completionPointValue;
        _completionStatus = completionStatus;
        _quantityCompleted = completionQuantity;
    }
}