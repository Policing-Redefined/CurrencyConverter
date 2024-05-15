namespace CurrencyConverter;

public class CurrencyInvalidException : Exception
{
    public CurrencyInvalidException()
    {

    }

    public CurrencyInvalidException(string message)
        : base(message)
    {
    }

    public CurrencyInvalidException(string message, Exception inner)
        : base(message, inner)
    {
    }
}