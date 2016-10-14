using System;

namespace Amba.System.Extensions
{
    public static class DateTimeExtensions
    {
        public static double ToUnixTime(this DateTime dateTime)
        {
            return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }
    }
}
