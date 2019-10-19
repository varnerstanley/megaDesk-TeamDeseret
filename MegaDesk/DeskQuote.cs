using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_Tinker
{
    class DeskQuote
    {
        string customerName;
        int rushDays;
        DateTime quoteDate = DateTime.Now;
        double surfaceArea;
        Desk deskObject = new Desk();
        bool largeSurfaceArea;
        double rushPricing;
        double materialCost;
        double quotePrice;
        static string rushValuesPath = @"C:\Users\CNTin\Source\Repos\tinker-camren\MegaDesk\MegaDesk-Tinker\Config\rushOrderPrices.txt";        
        static string[] rushValuesStr = File.ReadAllLines(rushValuesPath);
        static List<double> rushValues = new List<double>(); 

        public string CustomerName { get => customerName; set => customerName = value; }
        public int RushDays { get => rushDays; set => rushDays = value; }
        public DateTime QuoteDate { get => quoteDate; set => quoteDate = value; }
        internal Desk DeskObject { get => deskObject; set => deskObject = value; }
        public double QuotePrice { get => quotePrice; set => quotePrice = value; }
        public double RushPricing { get => rushPricing; set => rushPricing = value; }
        public double MaterialCost { get => materialCost; set => materialCost = value; }
        public double SurfaceArea { get => surfaceArea; set => surfaceArea = value; }

        public static void getRushValues() 
        {
        foreach (string str in rushValuesStr) 
            {
                rushValues.Add(Double.Parse(str));
            }
        }
        
        public void calcSurfaceArea()
        {
            surfaceArea = deskObject.Width * deskObject.Depth;

            if (surfaceArea > 1000)
                largeSurfaceArea = true;

            return;
        }

        public void calcRushPricing()
        {
            if (rushDays == 3)
            {
                rushPricing = rushValues[0];
                if (surfaceArea > 1000 && surfaceArea < 2000)
                    rushPricing = rushValues[1];
                else if (surfaceArea > 2000)
                    rushPricing = rushValues[2];
            }
            else if (rushDays == 5)
            {
                rushPricing = rushValues[3];
                if (surfaceArea > 1000 && surfaceArea < 2000)
                    rushPricing = rushValues[4];
                else if (surfaceArea > 2000)
                    rushPricing = rushValues[5];
            }
            else if (rushDays == 7)
            {
                rushPricing = rushValues[6];
                if (surfaceArea > 1000 && surfaceArea < 2000)
                    rushPricing = rushValues[7];
                else if (surfaceArea > 2000)
                    rushPricing = rushValues[8];
            } 
            else
            {
                rushPricing = 0;
            }
        }

        //Match the material price with the material
        public void getMaterialPrice()
        {
            switch (deskObject.MaterialString)
            {
                case "Oak":
                    materialCost = 200;
                    break;
                case "Laminate":
                    materialCost = 100;
                    break;
                case "Pine":
                    materialCost = 50;
                    break;
                case "Rosewood":
                    materialCost = 300;
                    break;
                case "Veneer":
                    materialCost = 125;
                    break;
                default:
                    materialCost = 0;
                    break;
            }
        }

        //Calculates the total cost of the desk
        public void calcTotalCost()
        {
            quotePrice = Desk.BASE_PRICE + (deskObject.NumDrawers * 50) + materialCost + rushPricing;

            if (largeSurfaceArea == true)
                quotePrice += surfaceArea; //Adds $1 per square inch if the surface area is large
        }

    }
}
