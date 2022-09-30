using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueLocaleLauncher
{
    public class ComboBoxItem
    {
        public string Value;
        public ComboBoxItem(string value) => Value = value;

        public override string ToString()
        {
            return Translation.Translate(Value);
        }
    }
}
