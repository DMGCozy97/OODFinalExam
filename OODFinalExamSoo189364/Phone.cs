using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODFinalExamSoo189364
{
    public class Phone
    {
        //prop
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OSImage { get; set; }
        public string PhoneImage { get; set; }

        public int ID { get; set; }
        public virtual Phone phone { get; set; }


        //ctor
        public Phone(string name, decimal price, string operatingSystem, string osImage, string phoneImage)
        {
            this.Name = name;
            this.Price = price;
            this.OperatingSystem = operatingSystem;
            this.OSImage = osImage;
            this.PhoneImage = phoneImage;
        }

        public virtual List<Phone> Phones { get; set ;}


        //Methods
        public void IncreasePrice(decimal percent)
        {
            Price = Price + (Price * percent);
        }

        public class PhoneData : DbContext
        {
            public PhoneData() : base("MyPhoneData") { }

            public DbSet<Phone> Phones { get; set; }

        }

    }
}
