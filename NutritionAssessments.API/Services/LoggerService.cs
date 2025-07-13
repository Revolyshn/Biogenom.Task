namespace NutritionAssessments.API.Services;

public class LoggerService(ILogger<LoggerService> logger) : ILoggerService
{
    public void LogCritical(string message, Exception ex)
    {
        logger.LogCritical(ex, message);
    }

    public void LogInformation(string message)
    {
        logger.LogInformation(message);
    }
}