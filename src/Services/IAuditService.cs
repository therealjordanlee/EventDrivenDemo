namespace EventDrivenDemo.Services
{
    public interface IAuditService
    {
        void WriteAuditLog(string log);
    }
}