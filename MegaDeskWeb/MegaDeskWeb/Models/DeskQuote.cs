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
        [Required]
        public int RushDays { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }        
        public double QuotePrice { get; set; }
        public double RushPricing { get; set; }
        public double MaterialCost { get; set; }
        public double SurfaceArea { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Depth { get; set; }
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
    }
}
