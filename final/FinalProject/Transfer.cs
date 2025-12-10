using System.Runtime.InteropServices.Marshalling;

namespace FinalProject
{
    public class Transfer : Transaction
    {
        // Attributes/Member Variables
        private int _fromAccountID;
        private int _toAccountID;
        private decimal _transferAmount;
        private DateTime _transferDate;
        private enum _transferStatus
        {
            Pending,
            Completed,
            Failed
        }
        private decimal _transferFee;


        // Constructor
        public Transfer()
        {

        }


        // Methods
        public void ExecuteTransfer()
        {

        }

        public void ValidateTransfer()
        {

        }

        public void RollbackTransfer()
        {

        }

        public void GetTransferDetails()
        {

        }
    }
}