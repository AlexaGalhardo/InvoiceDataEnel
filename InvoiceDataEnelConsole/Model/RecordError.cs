using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceDataEnelConsole.Model
{
    public class RecordError
    {
        public string Error { get; set; }
        public int Line { get; set; }
        public string Field { get; set; }
    }
}
