namespace NutritionAssessments.API.Services;

public interface ILoggerService
{
    void LogCritical(string message, Exception ex);
    void LogInformation(string message);
}