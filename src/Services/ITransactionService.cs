using EventDrivenDemo.Events;
using System;

namespace EventDrivenDemo.Services
{
    public interface ITransactionService : IAuditableService
    {
        void MakeDeposit(decimal amount);

        void MakeWithdrawal(decimal amount);
    }
}