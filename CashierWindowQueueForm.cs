using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashierQueuing
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            //tinitignan kung may laman pa ba ang queue.
            if (CashierClass.CashierQueue.Count > 0)
            {

                //tinatanggal ang nasa peek ng queue.
                CashierClass.CashierQueue.Dequeue();
                //Nirerefresh ang listbox para makita ang updated na queue.
                DisplayCashierQueue(CashierClass.CashierQueue);
            }

            //Ito naman ang nag didisplay ng value sa label na nasa ServingForm. Ginagamit natin dito ang OpenForms para ma-access ang ServingForm instance at ma-update ang label nito.
            ServingForm servingFormInstance = Application.OpenForms.OfType<ServingForm>().FirstOrDefault();

            if (servingFormInstance != null)
            {
                if (CashierClass.CashierQueue.Count > 0)
                {
                    //dito naman pinapalitan nya ng value ang label sa serving form na nagrereflect sa peek ng queue.
                    servingFormInstance.UpdateServingLabel(CashierClass.CashierQueue);
                }
                else
                {
                    //else naman kung ang listbox ay wala ng laman, ang value ng label na nasa ServingForm ay mag "P - XXXX"
                    servingFormInstance.UpdateServingLabel(null);
                }
            }
        }
    }
}