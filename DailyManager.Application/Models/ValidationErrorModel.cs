namespace DailyManager.Application.Models
{
    public sealed class ValidationErrorModel
    {
        public string PropertyName { get; private set; } = string.Empty;
        public string ErrorMessage { get; private set; } = string.Empty;

        public ValidationErrorModel(string propertyName, string errorMessage)
        {
            PropertyName = propertyName;
            ErrorMessage = errorMessage;
        }
    }
}
