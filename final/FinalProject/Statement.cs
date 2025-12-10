using System.Transactions;

namespace FinalProject
{
    public class Statement
    {
        // Attributes/Member Variables
        private int _accountID;
        private DateTime _statementPeriodStartDate;
        private DateTime _statementPeriodEndDate;
        private decimal _openingBalance;
        private decimal _closingBalance;
        private List<Transaction> _transactionList = new List<Transaction>();
        private decimal _totalDeposits;
        private decimal _totalWithdrawals;
        private decimal _totalFees;
        private decimal _interestEarned;
    
    
        // Constructor
        public Statement()
        {
            
        }
    
    
        // Methods
        public void GenerateStatement()
        {
            
        }
    
        public void CalcuateSummaryTotals()
        {
            
        }
    
        public void DisplayStatement()
        {
            
        }
    
        public void ExportToFile()
        {
            
        }
    
        public void FilterTransactionsByType(List<Transaction> transactionList)
        {
            
        }
    
        public List<Transaction> GetTransactionsForPeriod()
        {
            return _transactionList; // Placeholder
        }
    }
}