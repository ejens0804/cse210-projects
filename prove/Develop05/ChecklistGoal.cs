public class ChecklistGoal : BaseGoal
{
    public int _requiredTimesToComplete { get; set; }
    public int _completionQuantity { get; set; }
    public int _goalProgressPointValue { get; set; }

    public ChecklistGoal()
    {
        
    }

    public void CreateChecklistGoal()
    {
        base.SetTitle();
        base.SetDescription();
        SetQuantityToComplete();
        SetProgressPointValue();
        SetCompletionPointValue();
    }

    public void SetQuantityToComplete()
    {
        Console.Write("How many times to achieve this goal? ");
        _requiredTimesToComplete = int.Parse(Console.ReadLine());
    }

    public void SetProgressPointValue()
    {
        Console.Write("What is the amount of points earned each time you record this goal? ");
        _goalProgressPointValue = int.Parse(Console.ReadLine());
    }

    public override void SetCompletionPointValue()
    {
        Console.Write("How many bonus points for completing the goal? ");
        _completionPointValue = int.Parse(Console.ReadLine());
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_completionQuantity}/{_requiredTimesToComplete}] {_goalTitle} ({_goalDescription})");
    }

    public override int RecordPoints()
    {
        if (_completionQuantity == _requiredTimesToComplete)
        {
            return _completionPointValue + _goalProgressPointValue;
        }
        else if (_completionQuantity > _requiredTimesToComplete)
        {
            return _goalProgressPointValue;
        }
        else
        {
            return _goalProgressPointValue;
        }
    }

    public override void MarkComplete()
    {
        _completionQuantity++;
    }

    public int GetProgressPointValue()
    {
        return _goalProgressPointValue;
    }

    public void LoadPreviousGoalData(int goalType, string title, string description, int completionPointValue, bool completionStatus, int progressPointValue, int requiredTimesToComplete, int completionQuantity)
    {
        _goalType = goalType;
        _goalTitle = title;
        _goalDescription = description;
        _completionPointValue = completionPointValue;
        _completionStatus = completionStatus;
        _goalProgressPointValue = progressPointValue;
        _requiredTimesToComplete = requiredTimesToComplete;
        _completionQuantity = completionQuantity;
    }
}