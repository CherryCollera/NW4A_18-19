namespace UsingPrivateConstructor
{
    partial class frmPrivate
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDisplay.Location = new System.Drawing.Point(45, 123);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(330, 38);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click_1);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtLname.Location = new System.Drawing.Point(45, 75);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(330, 38);
            this.txtLname.TabIndex = 4;
            this.txtLname.Tag = "txt";
            this.txtLname.Text = "Lastname";
            this.txtLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLname.Click += new System.EventHandler(this.txtLname_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtName.Location = new System.Drawing.Point(45, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 38);
            this.txtName.TabIndex = 3;
            this.txtName.Tag = "txt";
            this.txtName.Text = "Firstname";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
            // 
            // frmPrivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 188);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtName);
            this.Name = "frmPrivate";
            this.Text = "Private";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        public System.Windows.Forms.TextBox txtLname;
        public System.Windows.Forms.TextBox txtName;
    }
}

