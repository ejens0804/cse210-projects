using System.Collections;

public class RewardSystem
{
    private string _currentLevel;
    private int _xpTotal;
    private int _moolah;
    private Dictionary<int, KeyValuePair<string, int>> _rewardDict;
    private List<string> _levelNamesList;
    // private List<string> _purchasedItemsToUse;
    

    public RewardSystem()
    {
        _rewardDict = new Dictionary<int, KeyValuePair<string, int>>();
        _levelNamesList.AddRange(new List<string>{
            "Professional Procrastinator", 
            "Master of 'I'll Start Tomorrow'", 
            "Goal Observer",
            "Task Avoidance Specialist", 
            "Half-Finished Project Enthusiast", 
            "Checklist Admirer",
            "Goal Attempt Initiator", 
            "Task Starter",
            "Breaker of One Bad Habit (Maybe)", 
            "To-Do List Wrangler", 
            "Momentum Gainer", 
            "Goal Finisher (Small Edition)",
            "Habit Machine-in-Training", 
            "Daily Goal Conqueror", 
            "Productivity Wizard",
            "Master of Momentum", 
            "Legendary Goal Slayer", 
            "Unstoppable Task Titan", 
            "Reality-Reshaping Productivity Overlord", 
            "The Final Achiever (Achieves ALL Goals)"
        });
    }
    
    public void LoadRewards(List<KeyValuePair<string,int>> rewardList)
    {
        
        int key = 1;
        foreach (var reward in rewardList)
        {
            _rewardDict[key] = reward;
            key++;
        }
    }

    public void DisplayRewardDict(int currentMoolah, int xpTotal, string levelName)
    {
        Console.WriteLine($"Current Level: {levelName}");
        Console.WriteLine($"Current XP: {xpTotal}");
        Console.WriteLine($"Current Moolah: {currentMoolah}\n\n");

        foreach (var rewardItem in _rewardDict)
        {
            Console.WriteLine($"{rewardItem.Key}. {rewardItem.Value.Key} {rewardItem.Value.Value}¤");
        }
    }

    public void BuyReward()
    {
        Console.WriteLine("Which reward would you like to buy?");
        int chosenReward = int.Parse(Console.ReadLine());

        if (_moolah >= _rewardDict[chosenReward].Value)
        {
            Console.WriteLine("Purchase Successful!");
            _moolah = _moolah - _rewardDict[chosenReward].Value;
        }
        else
        {
            Console.WriteLine("Insufficent funds!");
            Console.WriteLine($"You need {_rewardDict[chosenReward].Value - _moolah} more Moolah to purchase this item.");
        }
    }

    public int GetMoolahBalance()
    {
        return _moolah;
    }

    public int GetXPBalance()
    {
        return _xpTotal;
    }

    public string GetLevelName()
    {
        return _currentLevel;
    }

    public void SetMoolahBalance(int quantity)
    {
        _moolah = _moolah + quantity;
    }

    public void SetLevelName()
    {
        int levelListIndex;

        if (_xpTotal > 0)
        {
            levelListIndex = (_xpTotal/100) - 1;
        }
        else
        {
            levelListIndex = 0;
        }
        _currentLevel = _levelNamesList[levelListIndex];
    }
}