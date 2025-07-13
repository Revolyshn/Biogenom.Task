using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutritionAssessments.API.Data;
using NutritionAssessments.API.DTO;
using NutritionAssessments.API.Models;

namespace NutritionAssessments.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AssessmentsController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet("latest")]
    public async Task<IActionResult> GetLatestAssessment()
    {
        try
        {
            var latestAssessment = await context.NutritionAssessments
                .OrderByDescending(n => n.DateCompleted)
                .Select(n => new AssessmentResponse
                {
                    Id = n.Id,
                    DateCompleted = n.DateCompleted,
                    VitaminC = n.VitaminC,
                    VitaminD = n.VitaminD,
                    Water = n.Water,
                    Zinc = n.Zinc,
                    Energy = n.Energy,
                    Recommendations = n.Recommendations
                })
                .FirstOrDefaultAsync();

            return latestAssessment is null ? NotFound() : Ok(latestAssessment);
        }
        catch (Exception e)
        {
            return StatusCode(500, new
            {
                message = "Internal server error",
                details = e.Message
            });
        }
    }
}