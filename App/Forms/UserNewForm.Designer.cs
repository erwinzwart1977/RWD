namespace App.Forms
{
    partial class UserNewForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtAlergies = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(94, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtDoB
            // 
            this.txtDoB.Location = new System.Drawing.Point(130, 50);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.Size = new System.Drawing.Size(207, 23);
            this.txtDoB.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(94, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Day of birth";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 132);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(94, 23);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Email";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 90);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(94, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Current Team";
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(130, 90);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(207, 23);
            this.txtTeam.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(130, 175);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(207, 23);
            this.txtPhone.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 175);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(94, 23);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "Phone";
            // 
            // txtAlergies
            // 
            this.txtAlergies.Location = new System.Drawing.Point(130, 221);
            this.txtAlergies.Name = "txtAlergies";
            this.txtAlergies.Size = new System.Drawing.Size(207, 23);
            this.txtAlergies.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(12, 221);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(94, 23);
            this.textBox12.TabIndex = 11;
            this.textBox12.Text = "Alergies";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(130, 267);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(207, 23);
            this.txtRemarks.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(12, 267);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(94, 23);
            this.textBox14.TabIndex = 13;
            this.textBox14.Text = "Remarks";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UserNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.txtAlergies);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtDoB);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Name = "UserNewForm";
            this.Text = "UserNewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox4;
        private TextBox txtName;
        private TextBox textBox1;
        private TextBox txtDoB;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtTeam;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox textBox10;
        private TextBox txtAlergies;
        private TextBox textBox12;
        private TextBox txtRemarks;
        private TextBox textBox14;
        private Button btnAdd;
        private Button btnCancel;
    }
}