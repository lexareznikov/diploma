using System;
using System.Windows.Forms;

namespace Demography.Infrastructure.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToStringFormat(this DateTime? date, string format)
        {
            var str = "";
            if (date.HasValue)
                str = date.Value.ToString(format);

            return str;
        }
        public static DateTime? NullableValue(this DateTimePicker dtp)
        {
            return dtp.Checked ? dtp.Value : (DateTime?)null;
        }

        public static void NullableValue(this DateTimePicker dtp, DateTime? value)
        {
            dtp.Checked = value.HasValue;
            if (value.HasValue) { dtp.Value = value.Value; }
            else { dtp.Value = dtp.MinDate; };
        }
        public static int GetCountYears(this DateTime date)
        {
            int years = DateTime.Now.Year - date.Year;
            if (date.DayOfYear > DateTime.Now.DayOfYear)
                years--;
            return years;
        }
    }
}