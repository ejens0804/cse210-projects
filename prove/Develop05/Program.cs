using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Rewards rewardsObject = new Rewards();
        List<KeyValuePair<string, int>> rewardList = rewardsObject.ReturnRewardList();

        RewardSystem rs = new RewardSystem();
        rs.LoadRewards(rewardList);
        rs.DisplayRewardDict(rs.GetMoolahBalance(), rs.GetXPBalance(), rs.GetLevelName());
    }
}