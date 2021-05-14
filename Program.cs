using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__02
{
    class Bike
    {
        public string Brand;
        public string Country;
        public string Region;
        public int Price;
        public double Weight;
        public double Lenghth;
        public bool HasHydraulicBrake;
        public bool HasHydraulicSeatPost;
        public double GetYearIncomePerInhabitant()
        {
            return Price / Weight;
        }

        static void Main()
        {
            Console.Write("Введiть назву Бренду Велосипеда: ");
            string sBrand = Console.ReadLine();
            Console.Write("Введiть назву краiни виробника: ");
            string sCountry = Console.ReadLine();
            Console.Write("Введiть назву регiону виробництва: ");
            string sRegion = Console.ReadLine();
            Console.Write("Введiть ціну: ");
            string sPrice = Console.ReadLine();
            Console.Write("Вага Г: ");
            string sWeight = Console.ReadLine();
            Console.Write("Довжина, см: ");
            string sLenghth = Console.ReadLine();
            Console.Write("Гідравлічні гальма? (y-так, n-нi): ");
            ConsoleKeyInfo keyHasHydraulicBrake = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Гідравлічний підсідільний штир? (y-так, n-нi): "); ConsoleKeyInfo keyHasHydraulicSeatPost = Console.ReadKey();
            Console.WriteLine();
            Bike OurBike = new Bike();
            OurBike.Brand = sBrand;
            OurBike.Country = sCountry;
            OurBike.Region = sRegion;
            OurBike.Price = int.Parse(sPrice);
            OurBike.Weight = double.Parse(sWeight);
            OurBike.Lenghth = double.Parse(sLenghth);
            OurBike.HasHydraulicBrake = keyHasHydraulicBrake.Key == ConsoleKey.Y ? true : false; OurBike.HasHydraulicSeatPost = keyHasHydraulicSeatPost.Key == ConsoleKey.Y ? true : false;
            double YearIncomePerInhabitant = OurBike.GetYearIncomePerInhabitant();
            Console.WriteLine();
            Console.WriteLine(" "); Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("");
            Console.WriteLine("Назва: " + OurBike.Brand);
            Console.WriteLine("Країна: " + OurBike.Country);
            Console.WriteLine("Регiон: " + OurBike.Region);
            Console.WriteLine("Ціна: " +
            OurBike.Price.ToString());
            Console.WriteLine("Вага: " +
            OurBike.Weight.ToString("0.00"));
            Console.WriteLine("Довжина: " + OurBike.Lenghth.ToString("0.000")); Console.WriteLine(OurBike.HasHydraulicBrake ? "Гідравлічні гальма Є" : "Гідравлічних гальм немає");
            Console.WriteLine(OurBike.HasHydraulicBrake ? "Гідравлічний підсиділ Є" : "Гідравлічного підсиділу немає");
            Console.WriteLine();
            Console.WriteLine("Ціна одного Грама: " + YearIncomePerInhabitant.ToString("0.00"));
            Console.ReadKey();

        }
    }


}

