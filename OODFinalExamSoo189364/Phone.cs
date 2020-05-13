using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODFinalExamSoo189364
{
    public class Phone
    {
        //prop
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OSImage{ get; set; }
        public string PhoneImage { get; set; }


    }

    //ctor
    public Phone(string name,double price, string operatingSystem, string osImage, string phoneImage)
    {
        this.Name = name;
        this.Price = price;
        this.OperatingSystem = operatingSystem;
        this.OSImage = osImage;
        this.PhoneImage = phoneImage
    }




    //Methods
    public void IncreasePrice(decimal percent)
    {
        Price = Price + (Price * percent);
    }

}
