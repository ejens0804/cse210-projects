public class CheckingAccount : BaseAccount
{
    // Attributes/Member Variables
    private decimal _overdraftLimit;
    private decimal _overdraftFee;
    private bool _hasOverdraftProtection;
    private decimal _monthlyMaintenanceFee;


    // Constructor
    public CheckingAccount()
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

    public void ChargeOverdraftFee()
    {
        
    }

    public void ChargeMaintenanceFee()
    {
        
    }

    public void GetAvailableBalance()
    {
        
    }
}