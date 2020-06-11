using EventDrivenDemo.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenDemo.Services
{
    public class RefundService : IRefundService
    {
        public event EventHandler<TransactionProcessedEventArgs> OnTransactionProcessed;

        public void MakeRefund(decimal amount)
        {
            ProcessRefund(amount);
            if (OnTransactionProcessed != null)
            {
                OnTransactionProcessed(this, new TransactionProcessedEventArgs(amount, TransactionType.Refund));
            }
        }

        private void ProcessRefund(decimal amount)
        {
            // Processing logic here
        }
    }
}
