namespace EventDrivenDemo.Services
{
    public interface ITransactionService
    {
        void MakeDeposit(decimal amount);

        void MakeWithdrawal(decimal amount);
    }
}