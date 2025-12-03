public abstract class BaseAccount
{
    // Attributes/Member Variables
    protected int _accountID;
    protected string _accountNumber;
    protected int _customerID;
    protected decimal _balance;
    protected DateTime _dateOpened;
    protected enum _accountStatus
    {
        Active,
        Frozen,
        Closed
    }
    protected decimal _interestRate;
    protected decimal _minimumBalance;


    // Constructor
    public BaseAccount()
    {
        
    }


    // Methods
    public virtual void Deposit(decimal amount)
    {
        
    }

    public virtual void Withdraw(decimal amount)
    {
        
    }

    public abstract decimal CalculateInterest();

    public void ApplyInterest()
    {
        
    }

    public void GetBalance()
    {
        
    }

    public void CanWithdraw(decimal amount)
    {
        
    }

    public void FreezeAccount()
    {
        
    }

    public void CloseAccount()
    {
        
    }

    public void DisplayAccountInfo()
    {
        
    }
}