using Microsoft.EntityFrameworkCore;
using Bookshop.Components.Contexts;
using Bookshop.Components.DbInit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<BookshopContext>(opt =>
    opt.UseInMemoryDatabase("BookList"));
builder.Services.AddScoped<DbInitialiser>(); //Adds a DbInitialiser connection, so that data may be seeded

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseItToSeedSqlServer(); //Calls the method to populate the DbSet with the initial data
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();