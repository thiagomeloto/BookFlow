using BookFlow.Application.Commands.CreateBorrowing;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookFlow.API.Controllers
{
    [ApiController]
    [Route("api/borrowing")]
    public class BorrowingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BorrowingController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBorrowingCommand command)
        {
            return Ok();
        }
    }
}
