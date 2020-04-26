using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuberSample
{
    public partial class UpdateCustomers : Form
    {
        Models.Customers customer;
        public UpdateCustomers()
        {
            InitializeComponent();
        }

        public void setdata(Models.Customers customer)
        {
            this.customer = customer;
            this.textBoxdestinationupdate.Text= customer.Destination;
            this.textBoxlocationupdate.Text = customer.Location;
            this.textBoxnameupdate.Text = customer.Name;
            this.textBoxtelephoneupdate.Text = customer.Telephone;

        }

        private void buttonsubmitupdate_Click(object sender, EventArgs e)
        {

            customer.Destination = textBoxdestinationupdate.Text;
            customer.Location = textBoxlocationupdate.Text;
            customer.Name = textBoxnameupdate.Text;
            customer.Telephone = textBoxtelephoneupdate.Text;
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxdestinationupdate.Clear();
            textBoxlocationupdate.Clear();
            textBoxnameupdate.Clear();
            textBoxtelephoneupdate.Clear();

        }
    }
}
