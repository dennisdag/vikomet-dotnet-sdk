using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKomet.Framework.Common
{
    public static class DateTimeExtensions
    {
        public static string ToTimeAgo(this DateTime dt)
        {
            return ToTimeAgo(dt, false);
        }


        public static string ToTimeAgo(this DateTime dt, bool isUTCDate)
        {
            TimeSpan span = DateTime.Now - dt;

            if (isUTCDate)
            {
                span = DateTime.UtcNow - dt;
            }

            if (span.Days > 365)
            {
                int years = (span.Days / 365);
                if (span.Days % 365 != 0)
                    years += 1;
                return String.Format("há {0} {1} atrás",
                years, years == 1 ? "ano" : "anos");
            }
            if (span.Days > 30)
            {
                int months = (span.Days / 30);
                if (span.Days % 31 != 0)
                    months += 1;
                return String.Format("há {0} {1} atrás",
                months, months == 1 ? "mês" : "meses");
            }
            if (span.Days > 0)
                return String.Format("há {0} {1} atrás",
                span.Days, span.Days == 1 ? "dia" : "dias");
            if (span.Hours > 0)
                return String.Format("há {0} {1} atrás",
                span.Hours, span.Hours == 1 ? "hora" : "horas");
            if (span.Minutes > 0)
                return String.Format("há {0} {1} atrás",
                span.Minutes, span.Minutes == 1 ? "minuto" : "minutos");
            if (span.Seconds > 5)
                return String.Format("há {0} segundos atrás", span.Seconds);
            if (span.Seconds <= 5)
                return "agora";
            return string.Empty;
        }

    }
}
