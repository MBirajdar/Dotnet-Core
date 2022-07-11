using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Final_code_base_test.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Final_code_base_testContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Final_code_base_testContext") ?? throw new InvalidOperationException("Connection string 'Final_code_base_testContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

app.Run();
