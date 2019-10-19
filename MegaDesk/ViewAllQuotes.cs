using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Tinker
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void displayData_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\CNTin\Source\repos\tinker-camren\MegaDesk\MegaDesk-Tinker\Config\quotes.json";
            StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            List<SaveQuote> quotes = new List<SaveQuote>();
            quotes = JsonConvert.DeserializeObject<List<SaveQuote>>(json);            
            viewAllQuotesGridView.ColumnCount = quotes[0].GetType().GetProperties().Length;
            foreach (var quote in quotes)
            {
                int i = 0;
                foreach (var propertyInfo in quote.GetType().GetProperties())
                {
                    viewAllQuotesGridView.Columns[i].Name = propertyInfo.Name;
                    i++;
                }
            }
            foreach (var quote in quotes)
            {
                viewAllQuotesGridView.Rows.Add(quote.CustomerName,
                    quote.RushDays,
                    quote.QuoteDate,
                    quote.SurfaceArea,
                    quote.RushPricing,
                    quote.MaterialCost,
                    quote.QuotePrice,
                    quote.Width,
                    quote.Depth,
                    quote.Height,
                    quote.NumDrawers,
                    quote.MaterialString
                    );
            } 
            reader.Close();
        }

            private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();


        }

        private void loadQuotes_Click_1(object sender, EventArgs e)
        {

        }
    }
}
