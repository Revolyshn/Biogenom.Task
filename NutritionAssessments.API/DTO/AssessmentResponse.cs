namespace NutritionAssessments.API.DTO;

public class AssessmentResponse
{
    public int Id { get; set; }
    public DateTime DateCompleted { get; set; }
    public decimal VitaminC { get; set; }
    public decimal VitaminD { get; set; }
    public decimal Water { get; set; }
    public decimal Zinc { get; set; }
    public decimal Energy { get; set; }
    public string Recommendations { get; set; } = string.Empty;
}