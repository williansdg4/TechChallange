namespace Core.Errors
{
    public class CustomErrors : Exception
    {
        public CustomErrors(string? message) : base(message)
        {
        }
    }

    public class BadRequestException : CustomErrors
    {
        public BadRequestException(string? message) : base(message)
        {
        }
    }
}
