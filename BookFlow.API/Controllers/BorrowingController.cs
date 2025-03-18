using BookFlow.Application.Commands.CreateBorrowing;
using BookFlow.Application.Queries.GetBookById;
using BookFlow.Application.Queries.GetBorrowingById;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBorrowingById(int id)
        {
            var borrowing = await _mediator.Send(new GetBorrowingByIdQuery { Id = id });

            if (borrowing == null)
                return NotFound();

            return Ok(borrowing);            
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBorrowingCommand command)
        {
            var bookId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetBorrowingById), new { id = bookId }, command);
        }
    }
}
