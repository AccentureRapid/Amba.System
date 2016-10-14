using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amba.System.Extensions;
using NUnit.Framework;

namespace Amba.System.Test
{
    [TestFixture]
    public class DateTimeTest
    {
        [Test]
        public void Test()
        {
            var dateTime = new DateTime(2013, 11, 29, 12, 10, 10);
            var unixTime = dateTime.ToUnixTime();
            var fromUnixTime = DateTimeHelper.UnixTimeStampToDateTime(unixTime);
            Assert.AreEqual(dateTime.ToString("yyy-MM-dd hh:mm:ss"), fromUnixTime.ToString("yyy-MM-dd hh:mm:ss"));
        }
    }
}
