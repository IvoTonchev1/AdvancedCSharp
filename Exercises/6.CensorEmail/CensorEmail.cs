using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CensorEmail
{
    class CensorEmail
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string text = Console.ReadLine();
            int index = email.IndexOf("@");
            string username = email.Substring(0, index);
            string domain = email.Substring(index);
            string dots = new string('*', username.Length);
            string replacement = dots + domain;
            string result = text.Replace(email, replacement);
            Console.WriteLine(result);
        }
    }
}
