
namespace MailClient
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.registerFormContiner = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorRegistration = new System.Windows.Forms.Label();
            this.ReservEmailBox = new System.Windows.Forms.TextBox();
            this.reservEmail = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLable = new System.Windows.Forms.Label();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.userNameLable = new System.Windows.Forms.Label();
            this.confirmPasswordLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registerFormContiner.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameBox
            // 
            this.userNameBox.BackColor = System.Drawing.Color.LightCyan;
            this.userNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameBox.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.userNameBox.Location = new System.Drawing.Point(202, 107);
            this.userNameBox.Multiline = true;
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(151, 26);
            this.userNameBox.TabIndex = 0;
            this.userNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameBox.TextChanged += new System.EventHandler(this.userNameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.LightCyan;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.PasswordBox.Location = new System.Drawing.Point(655, 16);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(151, 26);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // registerFormContiner
            // 
            this.registerFormContiner.BackColor = System.Drawing.Color.White;
            this.registerFormContiner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerFormContiner.BackgroundImage")));
            this.registerFormContiner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.registerFormContiner.Controls.Add(this.label7);
            this.registerFormContiner.Controls.Add(this.label6);
            this.registerFormContiner.Controls.Add(this.label5);
            this.registerFormContiner.Controls.Add(this.label4);
            this.registerFormContiner.Controls.Add(this.label3);
            this.registerFormContiner.Controls.Add(this.label2);
            this.registerFormContiner.Controls.Add(this.label1);
            this.registerFormContiner.Controls.Add(this.errorRegistration);
            this.registerFormContiner.Controls.Add(this.ReservEmailBox);
            this.registerFormContiner.Controls.Add(this.reservEmail);
            this.registerFormContiner.Controls.Add(this.cancelButton);
            this.registerFormContiner.Controls.Add(this.registerButton);
            this.registerFormContiner.Controls.Add(this.phoneNumberBox);
            this.registerFormContiner.Controls.Add(this.phoneNumberLable);
            this.registerFormContiner.Controls.Add(this.firstNameLable);
            this.registerFormContiner.Controls.Add(this.lastNameLable);
            this.registerFormContiner.Controls.Add(this.lastNameBox);
            this.registerFormContiner.Controls.Add(this.firstNameBox);
            this.registerFormContiner.Controls.Add(this.confirmPasswordBox);
            this.registerFormContiner.Controls.Add(this.PasswordLable);
            this.registerFormContiner.Controls.Add(this.userNameLable);
            this.registerFormContiner.Controls.Add(this.confirmPasswordLable);
            this.registerFormContiner.Controls.Add(this.userNameBox);
            this.registerFormContiner.Controls.Add(this.PasswordBox);
            this.registerFormContiner.Location = new System.Drawing.Point(-2, -5);
            this.registerFormContiner.Name = "registerFormContiner";
            this.registerFormContiner.Size = new System.Drawing.Size(889, 381);
            this.registerFormContiner.TabIndex = 3;
            this.registerFormContiner.TabStop = false;
            this.registerFormContiner.Enter += new System.EventHandler(this.registerFormContiner_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(358, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Benex Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(812, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(812, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(359, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(359, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorRegistration
            // 
            this.errorRegistration.AutoSize = true;
            this.errorRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorRegistration.ForeColor = System.Drawing.Color.Red;
            this.errorRegistration.Location = new System.Drawing.Point(308, 332);
            this.errorRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorRegistration.Name = "errorRegistration";
            this.errorRegistration.Size = new System.Drawing.Size(0, 15);
            this.errorRegistration.TabIndex = 21;
            // 
            // ReservEmailBox
            // 
            this.ReservEmailBox.BackColor = System.Drawing.Color.LightCyan;
            this.ReservEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReservEmailBox.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.ReservEmailBox.Location = new System.Drawing.Point(655, 110);
            this.ReservEmailBox.Multiline = true;
            this.ReservEmailBox.Name = "ReservEmailBox";
            this.ReservEmailBox.Size = new System.Drawing.Size(151, 26);
            this.ReservEmailBox.TabIndex = 20;
            this.ReservEmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reservEmail
            // 
            this.reservEmail.AutoSize = true;
            this.reservEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reservEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservEmail.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.reservEmail.ForeColor = System.Drawing.Color.Black;
            this.reservEmail.Location = new System.Drawing.Point(453, 110);
            this.reservEmail.Name = "reservEmail";
            this.reservEmail.Size = new System.Drawing.Size(170, 25);
            this.reservEmail.TabIndex = 19;
            this.reservEmail.Text = "Enter reserv email :";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SkyBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(351, 269);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 37);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.SkyBlue;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(458, 269);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(87, 37);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.BackColor = System.Drawing.Color.LightCyan;
            this.phoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberBox.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.phoneNumberBox.Location = new System.Drawing.Point(202, 170);
            this.phoneNumberBox.Multiline = true;
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(151, 24);
            this.phoneNumberBox.TabIndex = 16;
            this.phoneNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumberLable
            // 
            this.phoneNumberLable.AutoSize = true;
            this.phoneNumberLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.phoneNumberLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneNumberLable.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.phoneNumberLable.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberLable.Location = new System.Drawing.Point(17, 169);
            this.phoneNumberLable.Name = "phoneNumberLable";
            this.phoneNumberLable.Size = new System.Drawing.Size(191, 25);
            this.phoneNumberLable.TabIndex = 15;
            this.phoneNumberLable.Text = "Enter phone number :";
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firstNameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstNameLable.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.firstNameLable.ForeColor = System.Drawing.Color.Black;
            this.firstNameLable.Location = new System.Drawing.Point(17, 16);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(152, 25);
            this.firstNameLable.TabIndex = 12;
            this.firstNameLable.Text = "Enter first name :";
            this.firstNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastNameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastNameLable.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.lastNameLable.ForeColor = System.Drawing.Color.Black;
            this.lastNameLable.Location = new System.Drawing.Point(17, 61);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(147, 25);
            this.lastNameLable.TabIndex = 11;
            this.lastNameLable.Text = "Enter last name :";
            this.lastNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.Color.LightCyan;
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameBox.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.lastNameBox.Location = new System.Drawing.Point(202, 61);
            this.lastNameBox.Multiline = true;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(151, 26);
            this.lastNameBox.TabIndex = 10;
            this.lastNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = System.Drawing.Color.LightCyan;
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameBox.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.firstNameBox.Location = new System.Drawing.Point(202, 14);
            this.firstNameBox.Multiline = true;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(151, 26);
            this.firstNameBox.TabIndex = 9;
            this.firstNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.BackColor = System.Drawing.Color.LightCyan;
            this.confirmPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordBox.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.confirmPasswordBox.Location = new System.Drawing.Point(655, 62);
            this.confirmPasswordBox.Multiline = true;
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.PasswordChar = '*';
            this.confirmPasswordBox.Size = new System.Drawing.Size(151, 26);
            this.confirmPasswordBox.TabIndex = 6;
            this.confirmPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmPasswordBox.TextChanged += new System.EventHandler(this.confirmPasswordTextBox_TextChanged);
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordLable.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLable.ForeColor = System.Drawing.Color.Black;
            this.PasswordLable.Location = new System.Drawing.Point(453, 17);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(198, 25);
            this.PasswordLable.TabIndex = 5;
            this.PasswordLable.Text = "Please enter password :";
            // 
            // userNameLable
            // 
            this.userNameLable.AutoSize = true;
            this.userNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userNameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userNameLable.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.userNameLable.ForeColor = System.Drawing.Color.Black;
            this.userNameLable.Location = new System.Drawing.Point(17, 110);
            this.userNameLable.Name = "userNameLable";
            this.userNameLable.Size = new System.Drawing.Size(154, 25);
            this.userNameLable.TabIndex = 4;
            this.userNameLable.Text = "Enter user name :";
            this.userNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPasswordLable
            // 
            this.confirmPasswordLable.AutoSize = true;
            this.confirmPasswordLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.confirmPasswordLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPasswordLable.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.confirmPasswordLable.ForeColor = System.Drawing.Color.Black;
            this.confirmPasswordLable.Location = new System.Drawing.Point(453, 62);
            this.confirmPasswordLable.Name = "confirmPasswordLable";
            this.confirmPasswordLable.Size = new System.Drawing.Size(192, 25);
            this.confirmPasswordLable.TabIndex = 3;
            this.confirmPasswordLable.Text = "Enter password again :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(359, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(868, 362);
            this.Controls.Add(this.registerFormContiner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCreateAccount";
            this.Text = "Create Account";
            this.registerFormContiner.ResumeLayout(false);
            this.registerFormContiner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        

        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.GroupBox registerFormContiner;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label userNameLable;
        private System.Windows.Forms.Label confirmPasswordLable;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label phoneNumberLable;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox ReservEmailBox;
        private System.Windows.Forms.Label reservEmail;
        private System.Windows.Forms.Label errorRegistration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}