namespace EventDrivenDemo.Services
{
    public interface IAuditService
    {
        void Subscribe(IAuditableService transactionService);
    }
}