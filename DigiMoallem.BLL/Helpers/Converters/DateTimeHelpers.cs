using System;
using System.Globalization;

namespace DigiMoallem.BLL.Helpers.Converters
{
    public static class DateTimeHelpers
    {
        public static string ToPersianDate(this DateTime dateTime) {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(dateTime).ToString()}/{pc.GetMonth(dateTime).ToString("00")}/{pc.GetDayOfMonth(dateTime).ToString("00")}";
        }
    }
}
