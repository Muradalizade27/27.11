using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Methods
{
    internal static class Contains
    {
        public static bool CContains(this string sentence, string search)
        {

            string toLower = sentence.ToLower();

            string whiteSpace = " ";

            String.IsNullOrWhiteSpace(whiteSpace);

            bool startWith = toLower.StartsWith(search);

            bool endWith = toLower.EndsWith(search);

            string[] arrayString = toLower.Split();

            foreach (var item in arrayString)
            {
                if (item == search)
                {
                    return true;
                }
                else if (item.ToUpper() == search.ToUpper())
                {
                    return true;
                }
                else if (startWith)
                {
                    return true;
                }
                else if (endWith)
                {
                    return true;
                }
                else if (item.StartsWith(search))
                {
                    return true;
                }
                else if (item.EndsWith(search))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
