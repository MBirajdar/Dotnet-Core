﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web_API_Mini_Project.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Web_API_Mini_ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Web_API_Mini_ProjectContext") ?? throw new InvalidOperationException("Connection string 'Web_API_Mini_ProjectContext' not found.")));

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
app.UseCors(Builder => Builder
                     .AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader());

app.Run();
