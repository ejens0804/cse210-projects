public abstract class BaseGoal
{
    protected string _goalTitle;
    protected string _goalDescription;
    protected int _completionPointValue;
    protected int _goalType;
    protected bool _completionStatus;

    // Write a function to set the goal type
    public BaseGoal()
    {
        
    }

    public void SetGoalType()
    {
        
    }

    public abstract void DisplayGoal();

    public void SetDescription()
    {
        
    }

    public void SetTitle()
    {
        
    }

    public void SetCompletionPointValue()
    {
        
    }

    public abstract void MarkComplete();
    public abstract void RecordPoints();

    public string GetTitle()
    {
        return "";
    }

    public string GetDescription()
    {
        return "";
    }

    public int GetCompletionPointValue()
    {
        return 0;
    }
}