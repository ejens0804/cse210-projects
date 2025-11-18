public class Rewards
{
    private List<KeyValuePair<string, int>> _rewardList = new List<KeyValuePair<string, int>>();

    public Rewards()
    {
        _rewardList.AddRange(new List<KeyValuePair<string,int>>()
        {
            new KeyValuePair<string, int>("Movie Night", 50),
            new KeyValuePair<string, int>("Game Night", 50),
            new KeyValuePair<string, int>("Fancy Dinner", 100),
            new KeyValuePair<string, int>("Ice Cream", 30),
            new KeyValuePair<string, int>("Buy Wish List Item", 100),
            new KeyValuePair<string, int>("Eat Favorite Treat", 30),
            new KeyValuePair<string, int>("Mini Vacation", 400)
        });
    }

    public List<KeyValuePair<string,int>> ReturnRewardList()
    {
        return _rewardList;
    }
}