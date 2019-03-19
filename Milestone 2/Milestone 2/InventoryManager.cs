using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2
{
    class InventoryManager
    {
        List<Inventory> currentInvetory = new List<Inventory>();
        CurrentInventory ciForm = new CurrentInventory();

        public void AddNewItem(string itemNumber, int quantity, string color, string size, string location)
        {

        }

        public void RemoveItem(string itemNumber, int quantity)
        {

        }

        public void ReStockItem(string itemNumber, int quantity, string color, string size, string location)
        {

        }

        public void DisplayInventory(List<Inventory> inventoryList)
        {
            this.currentInvetory = inventoryList;
            foreach(var item in currentInvetory)
            {
                ciForm.currentInvListBox.Items.Add(item);
            }
        }
        public void SearchItem(string location, string itemNumer)
        {

        }
        
    }
}
