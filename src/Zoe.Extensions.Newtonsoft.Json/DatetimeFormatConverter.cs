using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Zoe.Extensions.Newtonsoft.Json
{
    public class DatetimeFormatConverter : IsoDateTimeConverter
    {
        public DatetimeFormatConverter(string format)
        {
            DateTimeFormat = format;
        }

        public DatetimeFormatConverter(string format, DateTimeStyles style)
        {
            DateTimeFormat = format;
            DateTimeStyles = style;
        }
    }
}
