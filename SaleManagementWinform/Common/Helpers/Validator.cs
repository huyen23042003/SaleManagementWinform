using System.Text.RegularExpressions;

namespace SaleManagementWinform.Common.Helpers
{
    public static class Validator
    {
        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            return Regex.IsMatch(phone, @"^\d{9,11}$");
        }

        public static bool IsValidPositivePrice(string input, out decimal price)
        {
            price = 0;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            string cleanValue = input.Replace(".", "").Replace(",", "").Trim();

            return decimal.TryParse(cleanValue, out price) && price > 0;
        }
    }
}