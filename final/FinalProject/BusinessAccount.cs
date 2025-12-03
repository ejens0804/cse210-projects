public class BusinessAccount : BaseAccount
{
    // Attributes/Member Variables
    private string _businessName;
    private decimal _transactionFeePerOperation;
    private int _freeTransactionLimit;
    private int _currentTransactionCount;


    // Constructor
    public BusinessAccount()
    {
        
    }


    // Methods
    public override void Withdraw(decimal amount)
    {
        
    }

    public override void Deposit(decimal amount)
    {
        
    }

    public override decimal CalculateInterest()
    {
        return 0m;
    }

    public void ResetMonthlyTransactionCount()
    {
        
    }

    public decimal CalculateTransactionFees()
    {
        return 0m;
    }
}