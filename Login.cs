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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            //todo: verify credentials
            var thepassword = "Manager";
            var theusername = "Zuber";
            string username = textBoxusername.Text.Trim();
            var password = textBoxpassword.Text;
            var isValid = true;

            try{

                if (username == null)
                {
                    MessageBox.Show("Please Enter Username");
                    isValid = false;
                }
                if (password== null)
                {
                    MessageBox.Show("Please Enter Password");
                    isValid = false;
                }


                if (username == theusername && password == thepassword)
                {


                    if (isValid)
                    {
                        // create new forms
                        var main = new MainWindow();
                        main.Show();
                        this.Close();
                    }
                }
                else if (username != theusername)
                {

                    MessageBox.Show("Username or Password is invalid");
                    textBoxpassword.Text = "";
                    textBoxusername.Text = "";
                }

                else if (password != thepassword)
                {
                    MessageBox.Show("Username or Password is invalid");
                    textBoxpassword.Text = "";
                    textBoxusername.Text = "";
                }
            }catch(InvalidCastException e){

                Console.WriteLine ("{0} exception caught.",e);
                            
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
