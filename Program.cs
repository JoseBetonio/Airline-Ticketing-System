using Microsoft.EntityFrameworkCore;
using TicketingAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<UserContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataProtection();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.Run("http://localhost:5001");
}
else
{
    app.UseHttpsRedirection();
    app.Run();
}