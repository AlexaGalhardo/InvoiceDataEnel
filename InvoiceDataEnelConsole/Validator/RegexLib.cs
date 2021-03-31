using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace InvoiceDataEnelConsole.Validator
{
    class RegexLib
    {
        public bool IsMatchNumeros (string resp)
        {
            string er = @"^\d+$";
            return Regex.IsMatch(resp, er);
        }

        public bool IsMatchLetras(string resp)
        {
            string er = @"^[ a-zA-Z á]*$";
            return Regex.IsMatch(resp, er);
        }


    }
}
