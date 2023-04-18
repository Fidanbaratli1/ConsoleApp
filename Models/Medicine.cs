using ConsoleApp7.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    internal class Medicine
    {
        public string MedicineName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Medicine(string medicinename)
        {
            MedicineName = medicinename;
        }
        public static void CreateMedicine()
        {
            Console.WriteLine("Zehmet olmasa dermanin adini qeyd edin");
            string name = Console.ReadLine();
            Medicine medicine = new Medicine(name);
            Context.medicines.Add(medicine);
        }
        
    }
}
