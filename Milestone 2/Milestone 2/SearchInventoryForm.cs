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
    public partial class SearchInventoryForm : Form
    {
        public SearchInventoryForm()
        {
            InitializeComponent();
        }

        private void searchResultsExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
