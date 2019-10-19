using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tinker
{
    class Desk
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
        double width;
        double depth;
        double height;
        int numDrawers;
        string materialString;

        public Desk(double width, double depth, double height, int numDrawers, string materialString)
        {
            this.width = width;
            this.depth = depth;
            this.height = height;
            this.numDrawers = numDrawers;
            this.materialString = materialString;
        }

        public Desk()
        {
        }

        public enum Material
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        public double Width 
        {
            get;
            set; 
        }
        public double Depth 
        { 
            get; 
            set; 
        }
        public double Height 
        { 
            get; 
            set; 
        }
        public int NumDrawers 
        { 
            get; 
            set; 
        }
        public string MaterialString 
        { 
            get; 
            set; 
        }


    }
}
