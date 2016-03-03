using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,List<string>> book = new SortedDictionary<string, List<string>>();
            string line = Console.ReadLine();
            while (line != "search")
            {
                string[] temp = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = temp[0];
                string number = temp[1];              
                if (book.ContainsKey(name))
                {
                    if (!book[name].Contains(number))
                    {
                        book[name].Add(number);
                    }
                    book[temp[0]].Add(temp[1]);
                }
                else
                {
                    List<string> numbers = new List<string>();
                    numbers.Add(number);
                    book.Add(name,numbers);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine();
            while (true)
            {
                string contact = Console.ReadLine();
                Console.WriteLine();
                if (book.ContainsKey(contact))
                {
                    Console.WriteLine("{0} -> {1}", contact, string.Join(", ", book[contact]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", contact);
                }
                Console.WriteLine();
            }
        }
    }
}
