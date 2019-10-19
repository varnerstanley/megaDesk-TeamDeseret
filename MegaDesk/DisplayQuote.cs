using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MegaDesk_Tinker
{
    public partial class DisplayQuote : Form
    {
        DeskQuote quote;
        List<DeskQuote> quoteList = new List<DeskQuote>();
        public DisplayQuote()
        {
            InitializeComponent();
        }

        internal DeskQuote Quote { get => quote; set => quote = value; }

        private void displayData_Load(object sender, EventArgs e)
        {
            //Perform some functions to get all the needed data
            quote.calcSurfaceArea();
            quote.calcRushPricing();
            quote.calcTotalCost();

            heightBox.Text = Convert.ToString(Quote.DeskObject.Height);
            widthBox.Text = Convert.ToString(Quote.DeskObject.Width);
            depthBox.Text = Convert.ToString(Quote.DeskObject.Depth);
            drawersBox.Text = Convert.ToString(Quote.DeskObject.NumDrawers);
            materialBox.Text = Convert.ToString(Quote.DeskObject.MaterialString);
            dateBox.Text = Convert.ToString(Quote.QuoteDate);
            customerNameBox.Text = Convert.ToString(Quote.CustomerName);
            rushDaysBox.Text = Convert.ToString(Quote.RushDays);
            totalCostBox.Text = Convert.ToString(Quote.QuotePrice);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void saveQuote_Click(object sender, EventArgs e)
        {
            SaveQuote saveQuote = new SaveQuote(
                quote.CustomerName,
                quote.RushDays,
                quote.QuoteDate,
                quote.SurfaceArea,
                quote.RushPricing,
                quote.MaterialCost,
                quote.QuotePrice, 
                quote.DeskObject.Width, 
                quote.DeskObject.Depth, 
                quote.DeskObject.Height, 
                quote.DeskObject.NumDrawers, 
                quote.DeskObject.MaterialString);
            string filePath = @"C:\Users\CNTin\Source\repos\tinker-camren\MegaDesk\MegaDesk-Tinker\Config\quotes.json";
            StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            List<SaveQuote> quotes = new List<SaveQuote>();

            quotes = JsonConvert.DeserializeObject<List<SaveQuote>>(json);

            reader.Close();
            quotes.Add(saveQuote);
            StreamWriter writer = new StreamWriter(filePath);
            string jsonString = JsonConvert.SerializeObject(quotes);

            writer.Write(jsonString);
            writer.Close();
        }

    }
}
