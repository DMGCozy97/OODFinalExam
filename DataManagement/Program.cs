using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OODFinalExamSoo189364;

namespace DataManagement
{
    class Program
    {
        //working
        static void Main(string[] args)
        {
            Phone.PhoneData db = new Phone.PhoneData();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "images/s20.jpg");
                Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "images/iphone11.jpg");



                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added Phones To Database");


                db.SaveChanges();

                Console.WriteLine("saved to database");
            }

        }
    }
}
