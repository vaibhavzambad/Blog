using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace JustBlog
{
    public static class Extensions
    {
        public static string ToConfigLocalTime(this DateTime utdDt)
        {
            var istTZ = TimeZoneInfo.FindSystemTimeZoneById
                (ConfigurationManager.AppSettings["Timezone"]);
            return String.Format("{0} ({1})",
                TimeZoneInfo.ConvertTimeFromUtc(utdDt, istTZ),
                ConfigurationManager.AppSettings["TimezoneAbbr"]);
        }
    }
}