using Microsoft.EntityFrameworkCore;
using WDC.Orders.Core;
using WDC.Orders.Infrastructure.Context;
using WDC.Orders.Infrastructure;
using WDC.Orders.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connect to DataBase
builder.Services.AddDbContext<ApplicationDbContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#region Dependecies inject

//Dependcies inject


builder.Services.AddInfrastructureDependencies();

builder.Services.AddServiceDependencies();

builder.Services.AddCoreDependencies();

#endregion

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

