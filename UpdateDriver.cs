using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuberSample.Models
{
    public partial class UpdateDriver : Form
    {
        Driver drivers;

        public UpdateDriver()
        {
            InitializeComponent();
        }

        public void setdata(Driver drivers)
        {
            this.drivers = drivers;
            this.textBoxcartypeupdate.Text = drivers.CarType;
            this.textBoxName.Text = drivers.Name;
            this.textBoxpostupdate.Text = drivers.Post;
            drivers.Date = dateTimePicker1.Value.Date;



        }

        private void buttonsubmitupdate_Click(object sender, EventArgs e)
        {
            drivers.Post = textBoxpostupdate.Text;
            drivers.Name = textBoxName.Text;
            drivers.CarType = textBoxcartypeupdate.Text;
            drivers.Date = dateTimePicker1.Value.Date;
            
            this.Close();
        }

    }
}
