using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Dojo_BankOcr
{
    public class OcrApplication
    {
        public string ConvertText(string[] theFile)
        {
            var line1 = theFile[0];
            var line2 = theFile[1];
            var line3 = theFile[2];

            var digit1 = line1.Substring(0, 3) + line2.Substring(0, 3) + line3.Substring(0, 3); 
            if (digit1 == DigitString.zero)
            {
                return "0";
            }          

        }

    }

    public class DigitString{
        public const string zero = " _ | ||_|";


    }
}