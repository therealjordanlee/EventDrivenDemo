using EventDrivenDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventDrivenDemo.Controllers
{
    [Route("transaction")]
    public class TransactionController : Controller
    {
        private ITransactionService _transactionService;
        private IAuditService _auditService;
        private IRefundService _refundService;

        public TransactionController(ITransactionService transactionService, IAuditService auditService, IRefundService refundService)
        {
            _transactionService = transactionService;
            _auditService = auditService;
            _auditService.Subscribe(_transactionService);
            _refundService = refundService;
            _auditService.Subscribe(_refundService);
        }

        [HttpPost("deposit")]
        public IActionResult MakeDeposit([FromQuery]decimal amount)
        {
            _transactionService.MakeDeposit(amount);
            return Ok();
        }

        [HttpPost("withdrawal")]
        public IActionResult MakeWithdrawal([FromQuery]decimal amount)
        {
            _transactionService.MakeWithdrawal(amount);
            return Ok();
        }

        [HttpPost("refund")]
        public IActionResult MakeRefund([FromQuery] decimal amount)
        {
            _refundService.MakeRefund(amount);
            return Ok();
        }
    }
}