using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using Zoe.Extensions.Newtonsoft.Json;
using Zoe.Extensions.Newtonsoft.Json.Test.TestModels;

namespace Tests.Converters
{
    [TestFixture]
    public class DateFormatConverterTest
    {

        [Test]
        public void Deserialize1()
        {
            var d = "20190101122321";
            string json = "{\"Date\":\"" + d + "\"}";
            var obj = JsonConvert.DeserializeObject<DateFormatConverterModel>(json);
            Assert.AreEqual(DateTime.ParseExact(d, "yyyyMMddHHmmss", System.Globalization.CultureInfo.DefaultThreadCurrentCulture), obj.Date);
        }

        [Test]
        public void Deserialize2()
        {
            var d = "20190101122321";
            string json = "{\"Date\":\"" + d + "\"}";
            var obj = JsonConvert.DeserializeObject<DateFormatConverterModel>(json, new DatetimeFormatConverter("yyyyMMddHHmmss"));
            Assert.AreEqual(DateTime.ParseExact(d, "yyyyMMddHHmmss", System.Globalization.CultureInfo.DefaultThreadCurrentCulture), obj.Date);
        }
    }
}