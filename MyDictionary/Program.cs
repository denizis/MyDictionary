using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyList<int, string> myDictionary = new MyList<int, string>();

            
            myDictionary.Add(1, "Deniz");
            myDictionary.Add(2, "Cengiz");

          
            int[] keys = myDictionary.GetKeys();
            string[] values = myDictionary.GetValues();

            // Ekrana yazdırıyoruz
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: {0} Value: {1}", keys[i], values[i]);
            }

            Console.Read();

        }
    }
}
