using BonsaiApi.Repositories;
using BonsaiStore.Data;
using BonsaiStore.Interfaces;
using BonsaiStore.Models;
using BonsaiStore.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
