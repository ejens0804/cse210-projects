public class SavingsAccount : BaseAccount
{
    // Attributes/Member Variables
    private int _maximumWithdrawalsPerMonth;
    private int _currentWithdrawalCount;
    private DateTime _lastWithdrawalResetDate;


    // Constructor
    public SavingsAccount()
    {
        
    }


    // Methods
    public override void Withdraw(decimal amount)
    {
        
    }

    public override decimal CalculateInterest()
    {
        return 0m;
    }

    public void ResetMonthlyWithdrawal()
    {
        
    }

    public bool CheckIfWithdrawalLimitReached()
    {
        return true;
    }
}