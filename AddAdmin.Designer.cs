namespace ZuberSample
{
    partial class AddAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxaddadminname = new System.Windows.Forms.TextBox();
            this.textBoxaddadminpassword = new System.Windows.Forms.TextBox();
            this.textBoxaddadminusername = new System.Windows.Forms.TextBox();
            this.buttonaddnewadmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Black;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(101, 126);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(63, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textBoxaddadminname
            // 
            this.textBoxaddadminname.Location = new System.Drawing.Point(93, 87);
            this.textBoxaddadminname.Name = "textBoxaddadminname";
            this.textBoxaddadminname.Size = new System.Drawing.Size(126, 20);
            this.textBoxaddadminname.TabIndex = 3;
            // 
            // textBoxaddadminpassword
            // 
            this.textBoxaddadminpassword.Location = new System.Drawing.Point(93, 195);
            this.textBoxaddadminpassword.Name = "textBoxaddadminpassword";
            this.textBoxaddadminpassword.Size = new System.Drawing.Size(126, 20);
            this.textBoxaddadminpassword.TabIndex = 4;
            // 
            // textBoxaddadminusername
            // 
            this.textBoxaddadminusername.Location = new System.Drawing.Point(93, 142);
            this.textBoxaddadminusername.Name = "textBoxaddadminusername";
            this.textBoxaddadminusername.Size = new System.Drawing.Size(126, 20);
            this.textBoxaddadminusername.TabIndex = 5;
            // 
            // buttonaddnewadmin
            // 
            this.buttonaddnewadmin.BackColor = System.Drawing.Color.DimGray;
            this.buttonaddnewadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddnewadmin.ForeColor = System.Drawing.Color.White;
            this.buttonaddnewadmin.Location = new System.Drawing.Point(93, 244);
            this.buttonaddnewadmin.Name = "buttonaddnewadmin";
            this.buttonaddnewadmin.Size = new System.Drawing.Size(68, 30);
            this.buttonaddnewadmin.TabIndex = 6;
            this.buttonaddnewadmin.Text = "Submit";
            this.buttonaddnewadmin.UseVisualStyleBackColor = false;
            this.buttonaddnewadmin.Click += new System.EventHandler(this.buttonaddnewadmin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(236, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(167, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date";
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonaddnewadmin);
            this.Controls.Add(this.textBoxaddadminusername);
            this.Controls.Add(this.textBoxaddadminpassword);
            this.Controls.Add(this.textBoxaddadminname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Name = "AddAdmin";
            this.Text = "Add Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxaddadminname;
        private System.Windows.Forms.TextBox textBoxaddadminpassword;
        private System.Windows.Forms.TextBox textBoxaddadminusername;
        private System.Windows.Forms.Button buttonaddnewadmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}