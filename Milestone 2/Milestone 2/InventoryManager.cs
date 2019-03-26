using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2
{
    class InventoryManager
    {
        CurrentInventoryForm currentInv = new CurrentInventoryForm();
        private List<Inventory> inventoryList;
        
        public InventoryManager(List<Inventory> inventoryList)
        {
            this.inventoryList = inventoryList;
        }
        

        public void AddNewItem( Inventory item)
        {
           inventoryList.Add(item);
        }

        public void RemoveItem(string itemNumber)
        {
            inventoryList.Remove(inventoryList.Find(item => item.itemNumber == itemNumber));

        }

        public void ReStockItem(string itemNumber,int invAdjustment)
        {
           
            foreach(var item in inventoryList)
            {
               
                if(item.itemNumber == itemNumber)
                {
                    item.quantity += invAdjustment;
                }
            }
            
        }

       
        public string DisplayInventory()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in inventoryList)
            {
                
                string currentLine = item.type + " " + item.itemNumber + " " + item.quantity + " " + item.color + " " + item.size + " " + item.location;
                sb.AppendLine(currentLine + "," + "\n");
            }
            return sb.ToString();
        }
        
            
            
        
        public string SearchItem(string searchInput)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in inventoryList)
            {
                if(item.itemNumber == searchInput || item.size == searchInput)
                {
                    string results = item.itemNumber + " " + item.quantity + " " + item.color + " " + item.size + " " + item.location;
                    sb.Append("Search Results for: " + searchInput + "\n");
                    sb.AppendLine(results + "," + "\n");
                }
            }
            if (sb.Length == 0)
            {
                return "Nothing matches your entry";
            }
           
            return sb.ToString();
        }

        
    }
}


