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
        Inventory inventory = new Inventory();
       
       

        public void AddNewItem(List<Inventory> inputList, Inventory item)
        {
          //  inputList.AddRange(item);
        }

        public void RemoveItem(List<Inventory> inputList, string itemNumber)
        {
            inputList.Remove(itemNumber);
              
            
          
        }

        public void ReStockItem(List<Inventory> inputList,string itemNumber,int invAdjustment)
        {
           
            foreach(var item in inputList)
            {
                if(item.itemNumber == itemNumber)
                {
                    item.quantity += invAdjustment;
                }
            }
            
        }

        public string DisplayInventory(List<Inventory> inputList)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in inputList)
            {
                
                string currentLine = item.itemNumber + " " + item.quantity + " " + item.color + " " + item.size + " " + item.location;
                sb.AppendLine(currentLine + "," + "\n");
            }
            return sb.ToString();
        }
        
            
            
        
        public string SearchItem(List<Inventory> inputList, string searchInput)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in inputList)
            {
                if(item.itemNumber == searchInput || item.size == searchInput)
                {
                    string results = item.itemNumber + " " + item.quantity + " " + item.color + " " + item.size + " " + item.location;
                    sb.Append("Search Results for: " + searchInput + "\n");
                    sb.AppendLine(results + "," + "\n");
                }
                else 
                {
                    return "Noting matches your entry";
                }
            }
            return sb.ToString();
        }

        
    }
}
