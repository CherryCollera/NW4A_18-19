namespace UsingParmeterizedConstructors
{
    partial class frmParameter
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
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.btnDisp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtAge.Location = new System.Drawing.Point(77, 31);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(240, 38);
            this.txtAge.TabIndex = 0;
            this.txtAge.Tag = "txt";
            this.txtAge.Text = "Age";
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.Click += new System.EventHandler(this.txtAge_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCourse.Location = new System.Drawing.Point(77, 83);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(240, 38);
            this.txtCourse.TabIndex = 1;
            this.txtCourse.Tag = "txt";
            this.txtCourse.Text = "Course";
            this.txtCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCourse.Click += new System.EventHandler(this.txtCourse_Click);
            // 
            // txtSec
            // 
            this.txtSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtSec.Location = new System.Drawing.Point(77, 135);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(240, 38);
            this.txtSec.TabIndex = 2;
            this.txtSec.Tag = "txt";
            this.txtSec.Text = "Section";
            this.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSec.Click += new System.EventHandler(this.txtSec_Click);
            // 
            // txtBirth
            // 
            this.txtBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBirth.Location = new System.Drawing.Point(77, 187);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(240, 38);
            this.txtBirth.TabIndex = 3;
            this.txtBirth.Tag = "txt";
            this.txtBirth.Text = "Birthday";
            this.txtBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBirth.Click += new System.EventHandler(this.txtBirth_Click);
            // 
            // btnDisp
            // 
            this.btnDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDisp.Location = new System.Drawing.Point(77, 248);
            this.btnDisp.Name = "btnDisp";
            this.btnDisp.Size = new System.Drawing.Size(240, 38);
            this.btnDisp.TabIndex = 4;
            this.btnDisp.Text = "Display";
            this.btnDisp.UseVisualStyleBackColor = true;
            this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
            // 
            // frmParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 316);
            this.Controls.Add(this.btnDisp);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtAge);
            this.Name = "frmParameter";
            this.Text = "Parameterized";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Button btnDisp;
    }
}

