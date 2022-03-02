using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Dojo_BankOcr
{
    public class OcrApplication
    {
        public string ConvertText(string[] theFile)
        {
            var line1 = theFile[0];
            var line2 = theFile[1];
            var line3 = theFile[2];
            var sb = new StringBuilder();
 
            for (int i = 0; i < 9; i++){
                var index = i*3;
                var digit = line1.Substring(index, 3) + line2.Substring(index, 3) + line3.Substring(index, 3); 
                if (digit == DigitString.zero)
                {
                    sb.Append("0");
                }
                
            }

            return sb.ToString();
            

        }

    }

    public class DigitString{
        public const string zero = " _ | ||_|";


    }
}