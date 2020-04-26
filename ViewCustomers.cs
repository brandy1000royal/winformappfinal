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
    // https://stackoverflow.com/questions/15811254/how-to-set-datasource-to-a-datagridview-control-in-c-sharp
    public partial class ViewCustomers : Form
    {

        public ViewCustomers()
        {
            InitializeComponent();
            RefreshData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var item = Data.customers[e.RowIndex];
                var form = new UpdateCustomers();
                form.setdata(item);
                form.ShowDialog();
                RefreshData();

            }
        }


        internal void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();


            //https://stackoverflow.com/questions/7916919/adding-a-button-to-a-winforms-datagridview/7930582#7930582?newreg=5e0f4c7397e94074aeedf619beef2642
            DataGridViewCheckBoxColumn btn = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Name = "check";
            btn.FalseValue = false;
            btn.TrueValue = true;

            dataGridView1.DataSource = Data.customers;

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn1);
            btn1.HeaderText = "";
            btn1.Text = "Update";
            btn1.Name = "btn";
            btn1.UseColumnTextForButtonValue = true;
            dataGridView1.Update();

        }


        // https://stackoverflow.com/questions/2021681/hide-form-instead-of-closing-when-close-button-clicked
        private void ViewCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void button1delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.admins.Count; i++)
            {
                if (dataGridView1[0, i].Value == null)
                {
                    continue;
                }
                if ((bool)dataGridView1[0, i].Value == true)
                {

                    Data.admins.RemoveAt(i);

                    i--;
                    MessageBox.Show("Item Deleted");

                }
            }


            RefreshData();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.customers.Count; i++)
            {
                if (dataGridView1[0, i].Value == null)
                {
                    continue;
                }
                if ((bool)dataGridView1[0, i].Value == true)
                {

                    Data.customers.RemoveAt(i);

                    i--;
                    MessageBox.Show("Item Deleted");

                }
            }


            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
