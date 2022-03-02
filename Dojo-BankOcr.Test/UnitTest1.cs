using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace Dojo_BankOcr.Test
{
    public class UnitTest1
    {
        private string _dir = AppDomain.CurrentDomain.BaseDirectory + "\\Files";  

        [Fact]
        public void AllZeros()
        {
            var file = _dir + "/" + "TextFile1.txt";
            var theFile = File.ReadAllLines(file);


            var app = new OcrApplication();
            var actual = app.ConvertText(theFile);
            var expexted = "000000000";

            Assert.Equal(expexted, actual);
        }


    }
}
