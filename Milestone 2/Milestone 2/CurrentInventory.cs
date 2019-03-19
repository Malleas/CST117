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
    public partial class CurrentInventory : Form
    {
        InventoryManager iManager = new InventoryManager();
        List<Inventory> inventory;
        public CurrentInventory()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getInvBtn_Click(object sender, EventArgs e)
        {
            //iManager.DisplayInventory(inputList)
        }
    }
}
