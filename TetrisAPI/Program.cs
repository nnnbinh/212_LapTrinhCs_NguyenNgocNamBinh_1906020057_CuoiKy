using TetrisAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TetrisAPI.Models;
using Microsoft.Net.Http.Headers;
using System;

var builder = WebApplication.CreateBuilder(args);
string sConnection = builder.Configuration.GetConnectionString("TetrisConnection");

// Add services to the container.

builder.Services.AddDbContext<TetrisDbContext>(opt => opt.UseSqlServer(sConnection));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tetris", Version = "v1"});
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
