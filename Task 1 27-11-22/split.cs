using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Methods
{
    internal static class Split
    {
        public static string[] CSplit(this string sentence, char? splitChar = null)
        {

            if (splitChar == null)
            {
                splitChar = ' ';
            }

            char[] arrayChar = sentence.ToCharArray();


            string[] arrayString = new string[0];

            string temporaryString = string.Empty;

            for (int i = 0; i <= arrayChar.Length; i++)
            {
                if (i == arrayChar.Length || arrayChar[i] == splitChar)
                {

                    Array.Resize(ref arrayString, arrayString.Length + 1);

                    arrayString.SetValue(temporaryString, arrayString.Length - 1);

                    temporaryString = string.Empty;

                }
                else
                {
                    temporaryString += arrayChar[i];

                }
            }

            return arrayString;
        }
    }
}
