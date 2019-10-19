using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Tinker
{
    public partial class AddQuote : Form
    {
        Desk desk = new Desk();
        DeskQuote deskQuote = new DeskQuote();
        public AddQuote()
        {
            InitializeComponent();
            materialDropDown.Items.AddRange(typeof(Desk.Material).GetEnumNames());
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void materialDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(widthBox.Text, "double", "width"))
            {
                e.Cancel = !Validate(widthBox.Text, "double", "width");
                MessageBox.Show("Invalid input for width. Please make sure the width is between " + Desk.MIN_WIDTH + " and " + Desk.MAX_WIDTH, "Invalid Width");
                widthBox.BackColor = Color.LightPink;
                widthBox.Focus();
            } 
            else
            {
                widthBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void heightBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(heightBox.Text, "double", "height"))
            {
                e.Cancel = !Validate(heightBox.Text, "double", "height");
                MessageBox.Show("Invalid input for height. Please make sure the width is between " + Desk.MIN_HEIGHT + " and " + Desk.MAX_HEIGHT, "Invalid Height");
                heightBox.BackColor = Color.LightPink;
                heightBox.Focus();
            }
            else
            {
                heightBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void depthBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(depthBox.Text, "double", "depth"))
            {
                e.Cancel = !Validate(depthBox.Text, "double", "depth");
                MessageBox.Show("Invalid input for depth. Please make sure the width is between " + Desk.MIN_DEPTH + " and " + Desk.MAX_DEPTH, "Invalid Depth");
                depthBox.BackColor = Color.LightPink;
                depthBox.Focus();
            }
            else
            {
                depthBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }
        private void drawerBox_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate(drawerBox.Text, "int", "drawers"))
            {
                e.Cancel = !Validate(drawerBox.Text, "double", "drawers");
                MessageBox.Show("Invalid input for drawers. Please make sure the number of drawers is between " + Desk.MIN_DRAWERS + " and " + Desk.MAX_DRAWERS, "Invalid Number of Drawers");
                drawerBox.BackColor = Color.LightPink;
                drawerBox.Focus();
            }
            else
            {
                drawerBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private bool Validate(string text, string dataType, string property )
        {
            double parsedTextDouble = -1;
            int parsedTextInt = -1;

            //Datatype validation
            if (dataType.Equals("double"))
            {
                try
                {
                    parsedTextDouble = double.Parse(text);
                }
                catch
                {
                    return false;
                }
                
            } else if (dataType.Equals("int"))
            {
                try
                {
                    parsedTextInt = int.Parse(text);
                }
                catch
                {
                    return false;
                }
            }

            switch (property)
            {
                case "width":
                    if (parsedTextDouble >= Desk.MIN_WIDTH && parsedTextDouble <= Desk.MAX_WIDTH)
                        //MessageBox.Show("test" + parsedTextDouble.ToString());
                        return true;
                    break;
                case "height":
                    if (parsedTextDouble >= Desk.MIN_HEIGHT && parsedTextDouble <= Desk.MAX_HEIGHT)
                        return true;
                    break;
                case "depth":
                    if (parsedTextDouble >= Desk.MIN_DEPTH && parsedTextDouble <= Desk.MAX_DEPTH)
                        return true;
                    break;
                case "drawers":
                    if (parsedTextInt >= Desk.MIN_DRAWERS && parsedTextInt <= Desk.MAX_DRAWERS)
                        return true;
                    break;
            }

                return false;
        }

        private void getQuote_Click(object sender, EventArgs e)
        {
            //Return and don't execute the rest of this function if these don't validate and/or are empty
            if (string.IsNullOrEmpty(drawerBox.Text))
                return;
            if (string.IsNullOrEmpty(depthBox.Text))
                return;
            if (string.IsNullOrEmpty(heightBox.Text))
                return;
            if (string.IsNullOrEmpty(widthBox.Text))
                return;
            if (string.IsNullOrEmpty(customerNameBox.Text))
            {
                MessageBox.Show("Please specify the customer's name");
                return;
            }
            if (rushDaysDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the Rush Days drop down menu");
                return;
            }
            if (materialDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from the Material drop down menu");
                return;
            }

            try
            {
                desk.Height = double.Parse(heightBox.Text);
                desk.Depth = double.Parse(depthBox.Text);
                desk.Width = double.Parse(widthBox.Text);
                desk.NumDrawers = int.Parse(drawerBox.Text);
                desk.MaterialString = materialDropDown.Text;
                deskQuote.RushDays = int.Parse(rushDaysDropDown.Text);
                deskQuote.CustomerName = customerNameBox.Text;
                deskQuote.DeskObject = desk;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //View the quote
            DisplayQuote displayQuote = new DisplayQuote();
            displayQuote.Quote = deskQuote;
            displayQuote.Tag = this;
            displayQuote.Show(this);

        }
    }
}
