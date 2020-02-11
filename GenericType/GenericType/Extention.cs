using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public static class Extention
    {
        public static bool MyContains(this string str,string part)
        {
            for (int i = 0; i < (str.Length-part.Length+1); i++)
            {
                if (str[i] == part[0])
                {
                    if (part.Length == 1)
                    {
                        return true;
                    }
                    for (int j = 1; j < part.Length; j++)
                    {
                        if (part[j] != str[i + j])
                        {
                            break;
                        }
                        if(j== part.Length - 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
