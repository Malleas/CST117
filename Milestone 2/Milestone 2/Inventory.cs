using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * All work is original content created by Matt Sievers on 03-06-19
 */

namespace Milestone_2
{
    class Inventory
    {
        public string itemNumber;
        public int quantity;
        public string color;
        public string size;
        public string location;
      

        public Inventory(string itemNumber, int quantity, string color, string size, string location)
        {
            this.itemNumber = itemNumber;
            this.quantity = quantity;
            this.color = color;
            this.size = size;
            this.location = location;
        }

        public Inventory() { }

        public String getItemNumber()
        {
            return itemNumber;
        }

        public void setItemNumber(String itemNumber)
        {
            this.itemNumber = itemNumber;
        }

        public int getQuantity()
        {
            return quantity;
        }

        
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public String getColor()
        {
            return color;
        }

        public void setColor(String color)
        {
            this.color = color;
        }
        public String getSize()
        {
            return size;
        }

        public void setSize(String size)
        {
            this.size = size;
        }
        public String getLocation()
        {
            return location;
        }

        public void setLocation(String location)
        {
            this.location = location;
        }

    }
}
