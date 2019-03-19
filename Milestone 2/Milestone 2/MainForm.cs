using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * All work is original content created by Matt Sievers on 03-06-19
 */

namespace Milestone_2
{
    public partial class MainForm : Form
    {
        InventoryManager iManager = new InventoryManager();
        CurrentInventory currentInventory = new CurrentInventory();
        List<Inventory> inventoryList = new List<Inventory>();
        public MainForm()

        {
            InitializeComponent();
        }

        private void GetInventoryItemDetails(Inventory item)
        {
            item.itemNumber = itemNumberTextBox.Text;
            try
            {
                item.quantity = int.Parse(quantityTextBox.Text);
            }catch(Exception e)
            {
                
            }
            item.color = colorTextBox.Text;
            item.size = sizeTextBox.Text;
            item.location = locationTextBox.Text;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (shirtRadioBtn.Checked || pantsRadioBtn.Checked || otherRadioBtn.Checked != false)
            {
                if (shirtRadioBtn.Checked == true)
                {
                    Inventory newShirt = new Inventory();
                    GetInventoryItemDetails(newShirt);
                    inventoryList.Add(newShirt);
                    if(newShirt.quantity != 0)
                    {
                        inventoryListBox.Items.Add("Shirt " + newShirt.itemNumber + " " + newShirt.quantity + " " + newShirt.color + " " + newShirt.size + " " + newShirt.location);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for Quantity");
                    }
                    
                }else if(pantsRadioBtn.Checked == true)
                {
                    Inventory newPants = new Inventory();
                    GetInventoryItemDetails(newPants);
                    inventoryList.Add(newPants);
                    if(newPants.quantity != 0)
                    {
                        inventoryListBox.Items.Add("Pants " + newPants.itemNumber + " " + newPants.quantity + " " + newPants.color + " " + newPants.size + " " + newPants.location);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for Quantity");
                    }
                    
                }else
                {
                    Inventory other = new Inventory();
                    GetInventoryItemDetails(other);
                    inventoryList.Add(other);
                    if(other.quantity != 0)
                    {
                        inventoryListBox.Items.Add("Other " + other.itemNumber + " " + other.quantity + " " + other.color + " " + other.size + " " + other.location);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for Quantity");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Please select a type");
            }
           
           
        }

        public void clearFields()
        {
            itemNumberTextBox.Text = "";
            colorTextBox.Text = "";
            quantityTextBox.Text = "";
            sizeTextBox.Text = "";
            locationTextBox.Text = "";
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = inventoryListBox.SelectedIndex;
            MessageBox.Show("Current Available Inventory: " + inventoryList[index].quantity.ToString());

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void currentInvBtn_Click(object sender, EventArgs e)
        {
            currentInventory.ShowDialog();
            iManager.DisplayInventory(inventoryList);
        }
    }
}
