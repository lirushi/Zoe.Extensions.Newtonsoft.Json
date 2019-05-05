using Newtonsoft.Json;
using System;

namespace Zoe.Extensions.Newtonsoft.Json.Test.TestModels
{
    internal class DateFormatConverterModel
    {
        [JsonConverter(typeof(DatetimeFormatConverter), "yyyyMMddHHmmss")]
        public DateTime Date { get; set; }
    }
}