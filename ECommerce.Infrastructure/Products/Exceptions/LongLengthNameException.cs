namespace ECommerce.Infrastructure.Products.Exceptions;

using BuildingBlocks.Exception;

public class LongLengthNameException : BadRequestException
{
    public LongLengthNameException(string name, int maxLength)
        : base($"Name: '{name}' cannot be longer than {maxLength} characters")
    {
    }
}