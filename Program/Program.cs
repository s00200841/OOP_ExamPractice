using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_ExamPractice;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                // Create Phones 
                Phone phone1 = new Phone("Samsung", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phone phone2 = new Phone("iPhone 12", 600, "IOS", "/images/apple.png", "/images/iphone11.png");

                Console.WriteLine("Creating Phones");

                // Adds phones to db
                db.Phones.Add(phone1);
                db.Phones.Add(phone2);

                Console.WriteLine("Adding Phones to Database");

                // saves DataBase
                db.SaveChanges();

                Console.WriteLine("Saved To Database");
                Console.WriteLine("Press Enter To Continue");
                Console.ReadLine();
            }
        }
    }
}
