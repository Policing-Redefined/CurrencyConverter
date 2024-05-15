using static CurrencyConverter.CurrencyConverter.CurrencyData;

namespace CurrencyConverter.CurrencyConverter;

public static class ConversionMethods
{
    /// <summary>
    /// Converts the specified amount into the currency specified (eg usd to eur)
    /// </summary>
    /// <param name="currencyToConvertTo">What currency to convert to</param>
    /// <param name="amountToConvert">The amount to convert (e.g $69 - 69)</param>
    /// <see cref="CurrencyData.Currencies"/>
    /// <returns>amountToConvert in the specified currency</returns>
    internal static double ConvertFromUSD(string currencyToConvertTo, double amountToConvert)
    {
        double currencyWorth;
        if (!Currencies.TryGetValue(currencyToConvertTo, out currencyWorth)) throw new CurrencyInvalidException($"Currency {currencyToConvertTo} is not registered/valid!");
        return amountToConvert * currencyWorth;
    }
    
    // Convert to USD method
    /// <summary>
    /// Converts the specified amount into usd (eg eur to usd)
    /// </summary>
    /// <param name="currencyToConvertFrom">What currency to convert from</param>
    /// <param name="amountToConvert">The amount to convert (e.g $69 - 69)</param>
    /// <see cref="CurrencyData.Currencies"/>
    /// <returns>amountToConvert in usd</returns>
    internal static double ConvertToUSD(string currencyToConvertFrom, double amountToConvert)
    {
        double currencyWorth;
        if (!Currencies.TryGetValue(currencyToConvertFrom, out currencyWorth)) throw new CurrencyInvalidException($"Currency {currencyToConvertFrom} is not registered/valid!");
        return amountToConvert / currencyWorth;
    }
}