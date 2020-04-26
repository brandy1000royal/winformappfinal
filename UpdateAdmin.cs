using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZuberSample.Models;

namespace ZuberSample
{
    public partial class UpdateAdmin : Form
    {
        Admins admin;
        public UpdateAdmin()
        {
            InitializeComponent();
        }

        public void setdata(Admins admin)
        {
            this.admin = admin;
            this.textBoxName.Text = admin.Name;
            this.textBoxPassword.Text = admin.Password;
            this.textBoxusername.Text = admin.Username;
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonsubmitupdate_Click(object sender, EventArgs e)
        {
        
            admin.Name = textBoxName.Text;
            admin.Password = textBoxName.Text;
            admin.Username = textBoxusername.Text;
            admin.Date = dateTimePicker1.Value.Date;
            this.Close();
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxPassword.Clear();
            textBoxusername.Clear();
            dateTimePicker1.Refresh();
        }
    }
}
