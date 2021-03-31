using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceDataEnelConsole.Models
{
    public partial class RecordError
    {
        public string Error { get; set; }
        public int Line { get; set; }
        public string Field { get; set; }
    }
}
