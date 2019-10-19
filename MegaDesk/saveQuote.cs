using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tinker
{
    class SaveQuote
    {
        string customerName;
        int rushDays;
        DateTime quoteDate = DateTime.Now;
        double surfaceArea;
        double rushPricing;
        double materialCost;
        double quotePrice;
        double width;
        double depth;
        double height;
        int numDrawers;
        string materialString;

        public SaveQuote(string customerName, int rushDays, DateTime quoteDate, double surfaceArea, double rushPricing, double materialCost, double quotePrice, double width, double depth, double height, int numDrawers, string materialString)
        {
            this.customerName = customerName;
            this.rushDays = rushDays;
            this.quoteDate = quoteDate;
            this.surfaceArea = surfaceArea;
            this.rushPricing = rushPricing;
            this.materialCost = materialCost;
            this.quotePrice = quotePrice;
            this.width = width;
            this.depth = depth;
            this.height = height;
            this.numDrawers = numDrawers;
            this.materialString = materialString;
        }

        public string CustomerName { get => customerName; set => customerName = value; }
        public int RushDays { get => rushDays; set => rushDays = value; }
        public DateTime QuoteDate { get => quoteDate; set => quoteDate = value; }
        public double SurfaceArea { get => surfaceArea; set => surfaceArea = value; }
        public double RushPricing { get => rushPricing; set => rushPricing = value; }
        public double MaterialCost { get => materialCost; set => materialCost = value; }
        public double QuotePrice { get => quotePrice; set => quotePrice = value; }
        public double Width { get => width; set => width = value; }
        public double Depth { get => depth; set => depth = value; }
        public double Height { get => height; set => height = value; }
        public int NumDrawers { get => numDrawers; set => numDrawers = value; }
        public string MaterialString { get => materialString; set => materialString = value; }
    }
}
