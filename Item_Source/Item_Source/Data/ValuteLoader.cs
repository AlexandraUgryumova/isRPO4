using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Item_Source.Model;

namespace Item_Source.Data
{
    public static class ValuteLoader
    {
        public static List<Valute> LoadValutes (string xmltext)
        {
            List<Valute> valute = new List<Valute>();
            XDocument doc = XDocument.Parse(xmltext);

            var names = doc.Element("ValCurs")
                .Elements("Valute");

            foreach (var name in names)
            {
                string charCode = Convert.ToString(name.Element("CharCode").Value);
                string Name = Convert.ToString(name.Element("Name").Value);
                double value = Convert.ToDouble(name.Element("Value").Value);

                Valute v = new Valute(
                    charCode,
                    Name,
                    value
                    );

                valute.Add(v);
            }
            return valute;
        }
    }
}
