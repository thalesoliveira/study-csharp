using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class ExtensionMethod
    {
        public static int ContadorDePalavras(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
