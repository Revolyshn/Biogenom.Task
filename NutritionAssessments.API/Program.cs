using Microsoft.EntityFrameworkCore;
using NutritionAssessments.API.Data;
using NutritionAssessments.API.Middleware;
using NutritionAssessments.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ILoggerService, LoggerService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();