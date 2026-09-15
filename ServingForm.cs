using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashierQueuing
{
    public partial class ServingForm : Form
    {
        public ServingForm()
        {
            InitializeComponent();
        }
        public void UpdateServingLabel(Queue<string> cashierQueue)
        {
            if (cashierQueue != null && cashierQueue.Count > 0 && cashierQueue.Contains(cashierQueue.Peek()))
            {
                //ipinapakita ang susunod na customer gamit ang Peek()
                lblServing.Text = cashierQueue.Peek();
            }
            else
            {
                //kung walang laman ang queue, ipapakita ang default na text.
                lblServing.Text = "P - XXXX";
            }
        }

        private void ServingForm_Load(object sender, EventArgs e)
        {

        }
    }
}