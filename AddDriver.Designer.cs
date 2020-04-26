namespace ZuberSample
{
    partial class AddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriver));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxadddrivername = new System.Windows.Forms.TextBox();
            this.textBoxadddriverpost = new System.Windows.Forms.TextBox();
            this.textBoxadddrivercartype = new System.Windows.Forms.TextBox();
            this.buttonsubmitadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Driver\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driver\'s Car Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Driver\'s Post";
            // 
            // textBoxadddrivername
            // 
            this.textBoxadddrivername.Location = new System.Drawing.Point(66, 134);
            this.textBoxadddrivername.Name = "textBoxadddrivername";
            this.textBoxadddrivername.Size = new System.Drawing.Size(160, 20);
            this.textBoxadddrivername.TabIndex = 4;
            // 
            // textBoxadddriverpost
            // 
            this.textBoxadddriverpost.Location = new System.Drawing.Point(64, 261);
            this.textBoxadddriverpost.Name = "textBoxadddriverpost";
            this.textBoxadddriverpost.Size = new System.Drawing.Size(160, 20);
            this.textBoxadddriverpost.TabIndex = 6;
            // 
            // textBoxadddrivercartype
            // 
            this.textBoxadddrivercartype.Location = new System.Drawing.Point(64, 199);
            this.textBoxadddrivercartype.Name = "textBoxadddrivercartype";
            this.textBoxadddrivercartype.Size = new System.Drawing.Size(160, 20);
            this.textBoxadddrivercartype.TabIndex = 7;
            // 
            // buttonsubmitadd
            // 
            this.buttonsubmitadd.BackColor = System.Drawing.Color.DimGray;
            this.buttonsubmitadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubmitadd.ForeColor = System.Drawing.Color.White;
            this.buttonsubmitadd.Location = new System.Drawing.Point(64, 305);
            this.buttonsubmitadd.Name = "buttonsubmitadd";
            this.buttonsubmitadd.Size = new System.Drawing.Size(53, 30);
            this.buttonsubmitadd.TabIndex = 8;
            this.buttonsubmitadd.Text = "Submit";
            this.buttonsubmitadd.UseVisualStyleBackColor = false;
            this.buttonsubmitadd.Click += new System.EventHandler(this.buttonsubmitadd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(182, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(123, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(347, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(344, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date";
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonsubmitadd);
            this.Controls.Add(this.textBoxadddrivercartype);
            this.Controls.Add(this.textBoxadddriverpost);
            this.Controls.Add(this.textBoxadddrivername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDriver";
            this.Text = "AddDriver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxadddrivername;
        private System.Windows.Forms.TextBox textBoxadddriverpost;
        private System.Windows.Forms.TextBox textBoxadddrivercartype;
        private System.Windows.Forms.Button buttonsubmitadd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}