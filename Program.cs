using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conappswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode;
            string lang;
            Console.WriteLine("enter country code");
            cCode = Console.ReadLine();
            switch (cCode)
            {
                case "uk":
                    {
                        lang = "Dari,Pashto";
                        break;
                    }
                case "in":
                    {
                        lang = "hindi,english,tamil,telugu";
                        break;
                    }
                case "uae":
                    {
                        lang = "arabic";
                        break;

                    }

                default:
                    {
                        Console.WriteLine($"sorry!! you country {cCode} is not in ourdb");
                        lang = "not found!!!";
                        break;
                    } 
            }
            Console.WriteLine("country code " + cCode + "languages(s)" + lang);
            Console.ReadKey();
        } } 
}
