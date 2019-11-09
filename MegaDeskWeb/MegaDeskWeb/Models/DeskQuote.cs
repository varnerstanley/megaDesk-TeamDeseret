using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public class DeskQuote
    {
        public const double MIN_WIDTH = 24;
        public const double MAX_WIDTH = 96;
        public const double MIN_DEPTH = 12;
        public const double MAX_DEPTH = 48;
        public const double MIN_HEIGHT = 24;
        public const double MAX_HEIGHT = 72;
        public const double MIN_DRAWERS = 0;
        public const double MAX_DRAWERS = 7;
        public const double BASE_PRICE = 200;

        public int ID { get; set; }
        [StringLength(40, MinimumLength = 3)]
        [Required]
        public string CustomerName { get; set; }
        [Range(3, 14)]
        public int RushDays { get; set; }
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
        public double QuotePrice { get; set; }
        public double RushPricing { get; set; }
        public double MaterialCost { get; set; }
        public double SurfaceArea { get; set; }
        [Range(24, 96)]
        [Required]
        public double Width { get; set; }
        [Range(24, 96)]
        [Required]
        public double Height { get; set; }
        [Range(12, 48)]
        [Required]
        public double Depth { get; set; }
        [Range(0, 7)]
        [Required]
        public int NumDrawers { get; set; }
        public string MaterialString { get; set; }        
        public enum Material
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
        private bool largeSurfaceArea = false;

        public void setQuoteDate()
        {
            QuoteDate = DateTime.Now.Date;
        }

        public void calcSurfaceArea()
        {
            SurfaceArea = Width * Depth;

            if (SurfaceArea > 1000)
                largeSurfaceArea = true;

            return;
        }

        public void calcRushPricing()
        {
            if (RushDays < 5)
            {
                RushPricing = 60;
                if (SurfaceArea > 1000 && SurfaceArea < 2000)
                    RushPricing = 70;
                else if (SurfaceArea > 2000)
                    RushPricing = 80;
            }
            else if (RushDays < 7)
            {
                RushPricing = 40;
                if (SurfaceArea > 1000 && SurfaceArea < 2000)
                    RushPricing = 50;
                else if (SurfaceArea > 2000)
                    RushPricing = 60;
            }
            else if (RushDays < 14)
            {
                RushPricing = 30;
                if (SurfaceArea > 1000 && SurfaceArea < 2000)
                    RushPricing = 35;
                else if (SurfaceArea > 2000)
                    RushPricing = 40;
            }
            else
            {
                RushPricing = 0;
            }
        }

        public void getMaterialPrice()
        {
            switch (MaterialString)
            {
                case "Oak":
                    MaterialCost = 200;
                    break;
                case "Laminate":
                    MaterialCost = 100;
                    break;
                case "Pine":
                    MaterialCost = 50;
                    break;
                case "Rosewood":
                    MaterialCost = 300;
                    break;
                case "Veneer":
                    MaterialCost = 125;
                    break;
                default:
                    MaterialCost = 0;
                    break;
            }
        }

        public void calcTotalCost()
        {
            QuotePrice = BASE_PRICE + (NumDrawers * 50) + MaterialCost + RushPricing;

            if (largeSurfaceArea == true)
                QuotePrice += SurfaceArea; //Adds $1 per square inch if the surface area is large
        }
    }
}
