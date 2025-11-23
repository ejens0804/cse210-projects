using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography;
// using System.Text.Json;
// using System.Text.Json.Serialization;
using Newtonsoft.Json;
// dotnet add package Newtonsoft.Json


public class Menu
{
    private List<string> _menuOptions = new List<string>();
    private List<BaseGoal> _goalsBeingTracked = new List<BaseGoal>();
    private int _menuChoice;

    public Menu()
    {
        _menuChoice = 0;
        _menuOptions.AddRange(new List<string>
        {
            "   1. Create New Goal",
            "   2. List Goals",
            "   3. Save Goals",
            "   4. Load Goals",
            "   5. Record Event",
            "   6. Reward Shop",
            "   7. Quit Program",
            "   8. Restart Program"
        });
    }

    public void SaveToFile(int xpPoints, int moolah, string currentLevel)
    {
        Console.Write("Please name your Save File (examplename.json): ");
        string fileName = Console.ReadLine();

        var saveData = new SaveData
        {
            _xp = xpPoints,
            _moolah = moolah,
            _goals = _goalsBeingTracked,
            _currentLevelName = currentLevel
        };

        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.Auto
        };
        string jsonString = JsonConvert.SerializeObject(saveData, settings);
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine($"Goals + Current Level + XP + Moolah saved to {fileName}");
    }

    public void InitializeFromFile(RewardSystem rewardSystem)
    {
        string currentDir = Directory.GetCurrentDirectory();
        string[] files = Directory.GetFiles(currentDir, "*.json");
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }

        Console.Write("\nSelect a File to Load: ");
        string fileName = Console.ReadLine();

        string jsonString = File.ReadAllText(fileName);

        // use Newtonsoft.Json with TypeNameHandling
        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto
        };

        SaveData saveData = JsonConvert.DeserializeObject<SaveData>(jsonString, settings);

        // restore values
        _goalsBeingTracked = saveData._goals;
        rewardSystem.SetMoolahBalance(saveData._moolah);
        rewardSystem.SetXpBalance(saveData._xp);
        rewardSystem.LoadCurrentLevelName(saveData._currentLevelName);

        Console.WriteLine("Save File Loaded");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        foreach (string option in _menuOptions)
        {
            Console.WriteLine(option);
        }
        Console.Write("Select a choice from the menu: ");
        _menuChoice = int.Parse(Console.ReadLine());
    }

    public void RunMenuOption()
    {
        Rewards rewardsObject = new Rewards();
        RewardSystem rs = new RewardSystem();
        // instantiate the goals here so they can be added to the list
        // "1. Create New Goal"
        // "2. List Goals"
        // "3. Save Goals"
        // "4. Load Goals"
        // "5. Record Event"
        // "6. Reward Shop"
        // "7. Quit"
        // "8. Restart Program"

        while (true)
        {
            Console.Clear();
            DisplayMenu();
            switch (_menuChoice)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? (Use a number): ");
                    int goalChoice = int.Parse(Console.ReadLine());


                    switch (goalChoice)
                    {
                        case 1: // Simple Goal
                            SimpleGoal sg = new SimpleGoal();
                            sg.SetGoalType(goalChoice);
                            sg.CreateSimpleGoal();
                            AddTrackedGoalToList(sg);
                            Console.WriteLine("Goal Created!");
                            Pause();
                            break;

                        case 2: // Eternal Goal
                            EternalGoal eg = new EternalGoal();
                            eg.SetGoalType(goalChoice);
                            eg.CreateEternalGoal();
                            AddTrackedGoalToList(eg);
                            Console.WriteLine("Goal Created!");
                            Pause();
                            break;

                        case 3: // Checklist Goal
                            ChecklistGoal cg = new ChecklistGoal();
                            cg.SetGoalType(goalChoice);
                            cg.CreateChecklistGoal();
                            AddTrackedGoalToList(cg);
                            Console.WriteLine("Goal Created!");
                            Pause();
                            break;
                    }
                    break;

                case 2: // list goals
                    DisplayTrackedGoalList();
                    Console.WriteLine($"Current XP: {rs.GetXpBalance()} \nCurrent Moolah: {rs.GetMoolahBalance()}");
                    Pause();
                    break;

                case 3: // save goals
                    int xpPoints = rs.GetXpBalance();
                    int moolah = rs.GetMoolahBalance();
                    string currentLevel = rs.GetLevelName();
                    SaveToFile(xpPoints, moolah, currentLevel);
                    Pause();
                    break;

                case 4: // load goals
                    InitializeFromFile(rs);
                    Pause();
                    break;

                case 5: // record event
                    DisplayTrackedGoalList();
                    Console.Write("Which goal would you like to record an event for? ");
                    int userChoice = int.Parse(Console.ReadLine());
                    userChoice = userChoice - 1;

                    BaseGoal selectedGoal = _goalsBeingTracked[userChoice];
                    selectedGoal.MarkComplete();
                    rs.AddXpBalance(selectedGoal.RecordPoints());
                    rs.AddMoolahBalance(10);

                    Console.WriteLine("Event Recorded!");
                    Console.WriteLine("You earned some XP and Moolah!");
                    Pause();
                    break;

                case 6: // reward shop
                    List<KeyValuePair<string, int>> rewardList = rewardsObject.ReturnRewardList();
                    rs.CheckLevelName();
                    rs.LoadRewards(rewardList);
                    rs.DisplayRewardDict(rs.GetMoolahBalance(), rs.GetXpBalance(), rs.GetLevelName());
                    Console.Write("Would you like to purchase an item? (yes/no): ");
                    string userResponse = Console.ReadLine();
                    userResponse = userResponse.ToLower();
                    if (userResponse == "yes")
                    {
                        rs.BuyReward();
                    }
                    Console.WriteLine("Thank you for coming to the Reward Shop!");
                    Pause();
                    break;

                case 7: // quit
                    Environment.Exit(0);
                    break;

                case 8: // restart program
                    Console.WriteLine("Warning: This will clear all unsaved data!");
                    Console.Write("Are you sure? (yes/no): ");
                    string confirm = Console.ReadLine().ToLower();
                    if (confirm == "yes")
                    {
                        ResetProgram();
                    }
                    break;
            }
        }
    }

    public void AddTrackedGoalToList(BaseGoal goalBeingAdded)
    {
        _goalsBeingTracked.Add(goalBeingAdded);
    }

    public void DisplayTrackedGoalList()
    {
        Console.Clear();
        Console.WriteLine("Goals Being Tracked: ");
        int i = 1;
        foreach (BaseGoal goal in _goalsBeingTracked)
        {
            Console.Write($"{i}. ");
            goal.DisplayGoal();
            i++;
        }
    }

    public void ResetProgram()
    {
        // string exePath = Process.GetCurrentProcess().MainModule.FileName;
        // Process.Start(exePath);
        // Environment.Exit(0);
        _goalsBeingTracked.Clear();
        Console.WriteLine("Program reset! All unsaved data cleared.");
        Pause();
    }

    public void Pause()
    {
        Console.Write("Press Enter to Continue...");
        Console.ReadLine();
    }
}