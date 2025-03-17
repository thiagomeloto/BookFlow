﻿using BookFlow.Application.Commands.CreateBook;
using BookFlow.Application.Queries.GetBookById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BookFlow.API.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {            
            var book = await _mediator.Send(new GetBookByIdQuery { Id = id });

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookCommand command)
        {
            var bookId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetBookById), new { id = bookId }, command);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}
