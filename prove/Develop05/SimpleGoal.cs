public class SimpleGoal : BaseGoal
{
    public SimpleGoal()
    {
        
    }

    public override void DisplayGoal()
    {
        base.GetCompletionPointValue();
        base.GetCompletionStatus();
        base.GetDescription();
        base.GetTitle();
    }

    

    public override void RecordPoints()
    {
        
    }

    public override void MarkComplete()
    {
        
    }
}