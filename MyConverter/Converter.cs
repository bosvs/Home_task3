public class Converter
{
    public decimal UsdRate { get; }
    public decimal EurRate { get; }

    public Converter(decimal usdRate, decimal eurRate)
    {
        UsdRate = usdRate;
        EurRate = eurRate;
    }

    public decimal ConvertFromUahToUsd(decimal amountInUah)
    {
        return amountInUah / UsdRate;
    }

    public decimal ConvertFromUahToEur(decimal amountInUah)
    {
        return amountInUah / EurRate;
    }

    public decimal ConvertFromUsdToUah(decimal amountInUsd)
    {
        return amountInUsd * UsdRate;
    }

    public decimal ConvertFromEurToUah(decimal amountInEur)
    {
        return amountInEur * EurRate;
    }
}