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
        CurrentInventoryForm currentInv = new CurrentInventoryForm();
        LuckyForm lucky = new LuckyForm();
        SearchInventoryForm searchInv = new SearchInventoryForm();
        List<Inventory> inventoryList = new List<Inventory>();
        private InventoryManager iManager;
       
        public MainForm()

        {
            InitializeComponent();
            iManager = new InventoryManager(inventoryList);
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
                    if(newShirt.quantity != 0)
                    {
                        iManager.AddNewItem(newShirt);
                        newShirt.type = "Shirt";
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
                    if(newPants.quantity != 0)
                    {
                        iManager.AddNewItem(newPants);
                        newPants.type = "Pants";
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
                    if(other.quantity != 0)
                    {
                        iManager.AddNewItem(other);
                        other.type = "Other";
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
            //int index = inventoryListBox.SelectedIndex;
           // MessageBox.Show("Current Available Inventory: " + inventoryList[index].quantity.ToString());

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
            currentInv.currentInventoryRichTextBox.Text = iManager.DisplayInventory();
            currentInv.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchInputTextBox.Text == "Lucky")
            {
                lucky.ShowDialog();
            }
            else
            {
                searchInv.searchResultsRichTextBox.Text = iManager.SearchItem(searchInputTextBox.Text);
                searchInv.ShowDialog();
            }

            
        }

        private void restockBtn_Click(object sender, EventArgs e)
        {
            iManager.ReStockItem(restockItemNumberTextInput.Text, int.Parse(qtyAdjustmentTextInput.Text));
            MessageBox.Show("Inventory of " + restockItemNumberTextInput.Text + " has been updated" + "\n" + iManager.DisplayInventory());
            

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            iManager.RemoveItem(removeItemTextBox.Text);
            MessageBox.Show("item has been removed");
        }

       
    }
}
