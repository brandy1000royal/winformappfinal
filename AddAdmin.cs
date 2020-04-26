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
    public partial class AddAdmin : Form
    {
        ViewAdmins viewAdmins;
        public AddAdmin(ViewAdmins viewAdmins)
        {
            this.viewAdmins = viewAdmins;
            InitializeComponent();
        }

        private void buttonaddnewadmin_Click(object sender, EventArgs e)
        {
            Data.admins.Add(new Models.Admins()
            {
                Name = textBoxaddadminname.Text,
                Username = textBoxaddadminusername.Text,
                Password = textBoxaddadminpassword.Text,
                Date = dateTimePicker1.Value.Date,
            }) ;

            this.Close();

            MessageBox.Show("New Administrator Added");

            viewAdmins.RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxaddadminname.Clear();
            textBoxaddadminpassword.Clear();
            textBoxaddadminusername.Clear();
            dateTimePicker1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
