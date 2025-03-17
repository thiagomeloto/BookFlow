using MediatR;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using BookFlow.Infrastructure.Persistence;
using BookFlow.Core.Repositories;
using BookFlow.Infrastructure.Persistence.Repositories;
using BookFlow.Application.Commands.CreateBook;
using BookFlow.Application.Queries.GetBookById;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("BookFlowCs");

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBorrowingRepository, BorrowingRepository>();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(
        Assembly.GetExecutingAssembly(),
        typeof(CreateBookCommand).Assembly,
        typeof(GetBookByIdQuery).Assembly
    ));

//Registra todos os assemblies de commands e queries
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

//Registra o DbContext
builder.Services.AddDbContext<BookFlowDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
