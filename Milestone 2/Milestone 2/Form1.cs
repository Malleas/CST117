using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_2
{
    public partial class Form1 : Form
    {
        string itemNumber;
        string color;
        string size;
        string quantity;
        string location;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void entryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            itemNumberTextBox.Text = itemNumber;
            quantityTextBox.Text = quantity;
            colorTextBox.Text = color;
            sizeTextBox.Text = size;
            locationTextBox.Text = location;
            

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            entryTextBox.Text = "";
            itemNumberTextBox.Text = "";
            colorTextBox.Text = "";
            quantityTextBox.Text = "";
            sizeTextBox.Text = "";
            locationTextBox.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
        
            Inventory inventory = new Inventory(itemNumberTextBox.Text, quantityTextBox.Text, colorTextBox.Text, sizeTextBox.Text, locationTextBox.Text){
            };
            itemNumber = inventory.getItemNumber();
            quantity = inventory.getQuantity();
            color = inventory.getColor();
            size = inventory.getSize();
            location = inventory.getLocation();
            entryTextBox.Text = "";
            itemNumberTextBox.Text = "";
            colorTextBox.Text = "";
            quantityTextBox.Text = "";
            sizeTextBox.Text = "";
            locationTextBox.Text = "";
        }
    }
}
