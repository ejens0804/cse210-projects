public class Transaction // Parent Class
{
    // Attributes/Member Variables
    protected int _transactionID;
    protected int _acountID;
    protected enum _transactionType
    {
        Deposit, 
        Withdrawal,
        Transfer, 
        Fee,
        Interest
    }
    protected decimal _amount;
    protected DateTime _transactionDate;
    protected string _description;
    protected decimal _balanceAfterTransaction;
    protected string _relatedTransactionID;


    // Constructor
    public Transaction()
    {
        
    }


    // Methods
    public void DisplayTransactionDetails()
    {
        
    }

    public string FormatTransactionForStatement()
    {
        return "";
    }

    public void IsSameDayAs(DateTime day)
    {
        
    }

    public string GetFormattedAmount()
    {
        return "";
    }
}