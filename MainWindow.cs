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
    // https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-create-mdi-child-forms
    public partial class MainWindow : Form
    {
        ViewDrivers viewDriversForm;
        ViewAdmins viewAdminsForm;
        ViewCustomers viewCustomersForm;
        AddAdmin addAdmin;
        AddDriver addDriver;

       
        public MainWindow()
        {
            InitializeComponent();

            InitData();

            viewDriversForm = new ViewDrivers();
            viewDriversForm.MdiParent = this;
            viewAdminsForm = new ViewAdmins();
            viewAdminsForm.MdiParent = this;
            viewCustomersForm = new ViewCustomers();
            viewCustomersForm.MdiParent = this;
            addDriver = new AddDriver(viewDriversForm);
            addDriver.MdiParent = this;
            addAdmin = new AddAdmin(viewAdminsForm);
            addAdmin.MdiParent = this;

            toolStripStatusLabel1.Text = "Manager";
        }

        private void InitData()
        {
            // admin
            Data.admins.Add(new Admins()
            {
                Id = 1,
                Name = "Crystal Henry",
                Username = "Pass123",
                Password = "Pass123"
            });

            Data.admins.Add(new Admins()
            {
                Id = 2,
                Name = "Nicolas Brown",
                Username = "Audi123",
                Password = "Audi123"
            });

            // customers
            Data.customers.Add(new Customers()
            {
                Id = 1,
                Name = "Brandy",
                Telephone = "8765456565",
                Destination = "New Kingston",
                Location = "Half Way Tree"
            });

            // drivers
            Data.drivers.Add(new Driver()
            {
                Id = 1,
                Name = "Brandy",
                CarType = "Honda",
                Post = "New Kingston"
            });
            Data.drivers.Add(new Driver()
            {
                Id = 2,
                Name = "Nicolas",
                CarType = "Audi",
                Post = "Half Way Tree"
            });
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void viewDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewDriversForm.Show();
            viewDriversForm.Focus();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void viewAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAdminsForm.Show();
            viewAdminsForm.Focus();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCustomersForm.Show();
            viewCustomersForm.Focus();
        }

        private void addNewDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDriver.Show();
            addDriver.Focus();
        }

        private void addNewAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAdmin.Show();
            addAdmin.Focus();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Closing");
            Application.Exit();
        }
    }
}
