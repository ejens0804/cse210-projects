public class Menu
{
    private List<string> _menuOptions = new List<string>();
    private List<BaseGoal> _goalsBeingTracked = new List<BaseGoal>();

    public Menu()
    {
        _menuOptions.AddRange(new List<string> { "1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit" });

    }

    public void InitializeFromFile()
    {
        
    }

    public void SaveToFile()
    {
        
    }

    public void ResetProgram()
    {
        
    }

    public void DisplayMenu()
    {
        
    }

    public void RunMenuOption()
    {
        // instantiate the goals here so they can be added to the list
    }

    public void DisplayPointsAndMoolah()
    {
        
    }

    public void AddTrackedGoalToList()
    {
        
    }

    public void DisplayTrackedGoalList()
    {
        // put the code for running the child classes display goal method here when I'm iterating through the list
    }
}