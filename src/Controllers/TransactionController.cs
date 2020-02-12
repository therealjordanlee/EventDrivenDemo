using EventDrivenDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventDrivenDemo.Controllers
{
    [Route("transaction")]
    public class TransactionController : Controller
    {
        private ITransactionService _transactionService;
        private IAuditService _auditService;

        public TransactionController(ITransactionService transactionService, IAuditService auditService)
        {
            _transactionService = transactionService;
            _auditService = auditService;
        }

        [HttpPost("deposit")]
        public IActionResult MakeDeposit([FromQuery]decimal amount)
        {
            _transactionService.MakeDeposit(amount);
            _auditService.WriteAuditLog($"Deposit for ${amount} processed");
            return Ok();
        }

        [HttpPost("withdrawal")]
        public IActionResult MakeWithdrawal([FromQuery]decimal amount)
        {
            _transactionService.MakeWithdrawal(amount);
            _auditService.WriteAuditLog($"Withdrawal for ${amount} processed");
            return Ok();
        }
    }
}