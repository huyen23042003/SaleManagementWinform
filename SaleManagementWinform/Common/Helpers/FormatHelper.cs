using System.Globalization;

namespace SaleManagementWinform.Common.Helpers
{
    public static class FormatHelper
    {
        public static string FormatCurrency(decimal value)
        {
            return value.ToString("N0", new CultureInfo("vi-VN"));
        }
    }
}