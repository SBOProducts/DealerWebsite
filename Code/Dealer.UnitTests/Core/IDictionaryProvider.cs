using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Dealer.UnitTests
{
    public class IDictionaryProvider
    {
        public static IDictionary<string, string> ConvertToDictionary(object model)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            foreach (PropertyInfo property in model.GetType().GetProperties())
            {
                dictionary.Add(property.Name, property.GetValue(model).ToString());
            }

            return dictionary as IDictionary<string, string>;
        }
    }
}
