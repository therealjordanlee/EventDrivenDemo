using System;

namespace EventDrivenDemo.Services
{
    public class AuditService : IAuditService
    {
        public void WriteAuditLog(string log)
        {
            Console.WriteLine($"AUDIT LOG: {log}");
        }
    }
}