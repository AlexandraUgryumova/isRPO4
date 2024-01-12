using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item_Source.Model
{
    public class Valute
    {
        public string CharCode { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public Valute (string charCode, string name, double value)
        {
            this.CharCode = charCode;
            this.Name = name;
            this.Value = value;
        }
    }
}
