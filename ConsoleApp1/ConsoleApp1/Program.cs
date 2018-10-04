using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string word = Convert.ToString(Console.ReadLine());
            int x = 0;
            char a = 'a';


            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==a)
                
                    x++;
                
            }
            Console.WriteLine("The ammount of 'A' letters is "+x);

           
        }
    }
}
