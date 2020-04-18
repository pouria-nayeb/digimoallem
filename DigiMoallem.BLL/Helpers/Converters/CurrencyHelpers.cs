namespace DigiMoallem.BLL.Helpers.Converters
{
    public static class CurrencyHelpers
    {
        public static string ThreeDigitSeperator(this int walletBalance) {
            return walletBalance.ToString("#,0 تومان");
        }
    }
}
