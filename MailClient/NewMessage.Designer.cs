
namespace MailClient
{
    partial class NewMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessage));
            this.CloseButton = new System.Windows.Forms.Button();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.MessageEmailBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserPicBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1441, 1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(55, 44);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.BackColor = System.Drawing.Color.SkyBlue;
            this.SendEmailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendEmailButton.FlatAppearance.BorderSize = 0;
            this.SendEmailButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.SendEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendEmailButton.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendEmailButton.ForeColor = System.Drawing.Color.Black;
            this.SendEmailButton.Location = new System.Drawing.Point(757, 646);
            this.SendEmailButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(228, 60);
            this.SendEmailButton.TabIndex = 1;
            this.SendEmailButton.Text = "Send";
            this.SendEmailButton.UseVisualStyleBackColor = false;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // MessageEmailBox
            // 
            this.MessageEmailBox.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageEmailBox.Location = new System.Drawing.Point(604, 342);
            this.MessageEmailBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MessageEmailBox.Multiline = true;
            this.MessageEmailBox.Name = "MessageEmailBox";
            this.MessageEmailBox.Size = new System.Drawing.Size(656, 277);
            this.MessageEmailBox.TabIndex = 2;
            this.MessageEmailBox.TextChanged += new System.EventHandler(this.MessageEmailBox_TextChanged);
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.SubjectTextBox.Location = new System.Drawing.Point(604, 231);
            this.SubjectTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SubjectTextBox.Multiline = true;
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(656, 48);
            this.SubjectTextBox.TabIndex = 3;
            this.SubjectTextBox.TextChanged += new System.EventHandler(this.SubjectTextBox_TextChanged);
            // 
            // ToTextBox
            // 
            this.ToTextBox.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.ToTextBox.Location = new System.Drawing.Point(604, 135);
            this.ToTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ToTextBox.Multiline = true;
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(656, 48);
            this.ToTextBox.TabIndex = 4;
            this.ToTextBox.TextChanged += new System.EventHandler(this.ToTextBox_TextChanged);
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserNameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserNameLable.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold);
            this.UserNameLable.ForeColor = System.Drawing.Color.Black;
            this.UserNameLable.Location = new System.Drawing.Point(181, 28);
            this.UserNameLable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(134, 31);
            this.UserNameLable.TabIndex = 5;
            this.UserNameLable.Text = "User Name";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameLable.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold);
            this.NameLable.ForeColor = System.Drawing.Color.Black;
            this.NameLable.Location = new System.Drawing.Point(181, 99);
            this.NameLable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(0, 31);
            this.NameLable.TabIndex = 6;
            this.NameLable.Click += new System.EventHandler(this.NameLable_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-5, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 633);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.UserPicBox);
            this.panel2.Controls.Add(this.NameLable);
            this.panel2.Controls.Add(this.UserNameLable);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 183);
            this.panel2.TabIndex = 8;
            // 
            // UserPicBox
            // 
            this.UserPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserPicBox.BackgroundImage")));
            this.UserPicBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPicBox.Image")));
            this.UserPicBox.Location = new System.Drawing.Point(14, 28);
            this.UserPicBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.UserPicBox.Name = "UserPicBox";
            this.UserPicBox.Size = new System.Drawing.Size(127, 112);
            this.UserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicBox.TabIndex = 9;
            this.UserPicBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(473, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(473, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(475, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(731, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Benex Company";
            // 
            // NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1321, 745);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.MessageEmailBox);
            this.Controls.Add(this.SendEmailButton);
            this.Controls.Add(this.CloseButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "NewMessage";
            this.Text = "New Message";
            this.Load += new System.EventHandler(this.NewMessage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.TextBox MessageEmailBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox UserPicBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}