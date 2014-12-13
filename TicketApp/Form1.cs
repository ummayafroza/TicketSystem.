using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int totalPrice;

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(nameTextBox.Text);
            int ticketnumber = Convert.ToInt32(numberOfTicketTextBox.Text);
            totalPrice = ticketnumber*10;
            //totalPriceButton.Text = Convert.ToString(totalPrice);
             MessageBox.Show(name+ " Please Give " +totalPrice.ToString()+ " for Ticket  ");

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Custome Name   : " +nameTextBox.Text+  " \n Numer of Ticket   :  " +numberOfTicketTextBox.Text +  "\n Ticket Price   :" +totalPrice.ToString() );
        }
    }
}
