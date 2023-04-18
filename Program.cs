using ConsoleApp7.Models;
using ConsoleApp7.DAL;
using ConsoleApp7.Enums;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            do
            {
                Console.WriteLine("Menumuza xos geldiniz");
                Console.WriteLine("0.Exit");
               
                input = Console.ReadLine();

                
                switch (input)
                {
                    case "1": Category.CreateCategory();
                        break;
                        case "2":Medicine.CreateMedicine(); 
                        break;
                        default: Console.WriteLine("duzgun yaradin");
                        break;
                }
            }
            while (input != "0");
        }
    }
}