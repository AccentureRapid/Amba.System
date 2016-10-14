using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amba.System.Extensions.Csv;
using NUnit.Framework;

namespace Amba.System.Test
{
    [TestFixture]
    public class CsvTest
    {
        public class TestClass
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        
        [Test]
        public void Test()
        {
            var obj = new TestClass(){Name = "Vasya", Age = 10};
            var header = obj.GetCsvHeader();
            Assert.AreEqual(header, "Name;Age");
            var csv =  obj.ToCsv();
            Assert.AreEqual(csv, "Vasya;10");
        }
    }
}
