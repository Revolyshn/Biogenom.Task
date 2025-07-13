using Microsoft.EntityFrameworkCore;
using NutritionAssessments.API.Models;

namespace NutritionAssessments.API.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<NutritionAssessment> NutritionAssessments { get; set; }
}