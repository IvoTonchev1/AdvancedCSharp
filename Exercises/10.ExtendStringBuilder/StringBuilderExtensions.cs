using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtendStringBuilder
{
    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder sb, int startIndex, int count)
        {
            StringBuilder substring = new StringBuilder();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                substring.Append(sb[i]);
            }
            return substring.ToString();
        }
    }
}
