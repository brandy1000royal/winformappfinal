namespace ZuberSample
{
    partial class DeleteDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDriver));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxdeletedriver = new System.Windows.Forms.TextBox();
            this.comboBoxdeletedriver = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttondeletedriver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ID of Driver to be Deleted";
            // 
            // textBoxdeletedriver
            // 
            this.textBoxdeletedriver.Location = new System.Drawing.Point(205, 164);
            this.textBoxdeletedriver.Name = "textBoxdeletedriver";
            this.textBoxdeletedriver.Size = new System.Drawing.Size(283, 20);
            this.textBoxdeletedriver.TabIndex = 1;
            // 
            // comboBoxdeletedriver
            // 
            this.comboBoxdeletedriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxdeletedriver.FormattingEnabled = true;
            this.comboBoxdeletedriver.Items.AddRange(new object[] {
            "Termination",
            "Resignation",
            "Vacation Leave"});
            this.comboBoxdeletedriver.Location = new System.Drawing.Point(205, 227);
            this.comboBoxdeletedriver.Name = "comboBoxdeletedriver";
            this.comboBoxdeletedriver.Size = new System.Drawing.Size(283, 21);
            this.comboBoxdeletedriver.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(278, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Reason for Delete";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttondeletedriver
            // 
            this.buttondeletedriver.BackColor = System.Drawing.Color.DimGray;
            this.buttondeletedriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondeletedriver.ForeColor = System.Drawing.Color.White;
            this.buttondeletedriver.Location = new System.Drawing.Point(222, 323);
            this.buttondeletedriver.Name = "buttondeletedriver";
            this.buttondeletedriver.Size = new System.Drawing.Size(81, 35);
            this.buttondeletedriver.TabIndex = 4;
            this.buttondeletedriver.Text = "Delete";
            this.buttondeletedriver.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(396, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(309, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttondeletedriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxdeletedriver);
            this.Controls.Add(this.textBoxdeletedriver);
            this.Controls.Add(this.label1);
            this.Name = "DeleteDriver";
            this.Text = "DeleteDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxdeletedriver;
        private System.Windows.Forms.ComboBox comboBoxdeletedriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttondeletedriver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}