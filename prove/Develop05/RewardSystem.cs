using System.Collections;

public class RewardSystem
{
    private string _currentLevel;
    private int _xpTotal;
    private int _moolah;
    private Dictionary<int, KeyValuePair<string, int>> _rewardDict;
    private List<string> _levelNamesList = new List<string>();
    // private List<string> _purchasedItemsToUse;


    public RewardSystem()
    {
        _moolah = 0;
        _xpTotal = 0;
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

    public void LoadRewards(List<KeyValuePair<string, int>> rewardList)
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
        Console.Clear();
        Console.WriteLine($"Current Level: {levelName}");
        Console.WriteLine($"Current XP: {xpTotal}");
        Console.WriteLine($"Current Moolah: {currentMoolah}¤\n\n");

        foreach (var rewardItem in _rewardDict)
        {
            Console.WriteLine($"{rewardItem.Key}. {rewardItem.Value.Key} {rewardItem.Value.Value}¤");
        }
    }

    public void BuyReward()
    {
        Console.Write("Which reward would you like to buy? ");
        int chosenReward = int.Parse(Console.ReadLine());

        if (_moolah >= _rewardDict[chosenReward].Value)
        {
            Console.WriteLine("Purchase Successful!");
            _moolah = _moolah - _rewardDict[chosenReward].Value;
            Console.WriteLine($"You purchased the {_rewardDict[chosenReward].Key} item!");
        }
        else
        {
            Console.WriteLine("Insufficent funds!");
            Console.WriteLine($"You need {_rewardDict[chosenReward].Value - _moolah} more Moolah to purchase this item.");
            Console.WriteLine("Please come back with more moolah!");
        }
    }

    public void SetMoolahBalance(int balance)
    {
        _moolah = balance;
    }

    public void SetXpBalance(int balance)
    {
        _xpTotal = balance;
    }

    public int GetMoolahBalance()
    {
        return _moolah;
    }

    public int GetXpBalance()
    {
        return _xpTotal;
    }

    public string GetLevelName()
    {
        return _currentLevel;
    }

    public void AddMoolahBalance(int quantity)
    {
        _moolah = _moolah + quantity;
    }

    public void AddXpBalance(int quantity)
    {
        _xpTotal = _xpTotal + quantity;
    }

    public void CheckLevelName()
    {
        int levelListIndex;

        if (_xpTotal >= 100)
        {
            levelListIndex = (_xpTotal / 100) - 1;

            // Make sure we don't exceed the max level
            if (levelListIndex >= _levelNamesList.Count)
            {
                levelListIndex = _levelNamesList.Count - 1;
            }
        }
        else
        {
            levelListIndex = 0; // XP less than 100 = first level
        }

        _currentLevel = _levelNamesList[levelListIndex];
    }

    public void LoadCurrentLevelName(string name)
    {
        _currentLevel = name;
    }

    public void ResetXpAndMoolah()
    {
        _xpTotal = 0;
        _moolah = 0;
    }
}