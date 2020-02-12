namespace EventDrivenDemo.Services
{
    public class TransactionService : ITransactionService
    {
        public void MakeDeposit(decimal amount)
        {
            ProcessDeposit(amount);
        }

        public void MakeWithdrawal(decimal amount)
        {
            ProcessWithdrawal(amount);
        }

        private void ProcessDeposit(decimal amount)
        {
            // Processing logic here
        }

        private void ProcessWithdrawal(decimal amount)
        {
            // Processing logic here
        }
    }
}