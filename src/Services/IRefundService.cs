using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventDrivenDemo.Services
{
    public interface IRefundService : IAuditableService
    {
        public void MakeRefund(decimal amount);
    }
}
