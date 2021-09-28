
namespace MailClient
{
    partial class UserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.newMessageBtn = new System.Windows.Forms.Button();
            this.AddMessage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserPicBox = new System.Windows.Forms.PictureBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.WelcomeLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userEmails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.newMessageBtn);
            this.panel1.Controls.Add(this.AddMessage);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 418);
            this.panel1.TabIndex = 8;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.SkyBlue;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.ForeColor = System.Drawing.Color.Black;
            this.LogOut.Location = new System.Drawing.Point(82, 338);
            this.LogOut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(136, 38);
            this.LogOut.TabIndex = 15;
            this.LogOut.Text = "LogOutBtn";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // newMessageBtn
            // 
            this.newMessageBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.newMessageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newMessageBtn.FlatAppearance.BorderSize = 0;
            this.newMessageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.newMessageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMessageBtn.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newMessageBtn.ForeColor = System.Drawing.Color.Black;
            this.newMessageBtn.Location = new System.Drawing.Point(82, 53);
            this.newMessageBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.newMessageBtn.Name = "newMessageBtn";
            this.newMessageBtn.Size = new System.Drawing.Size(136, 38);
            this.newMessageBtn.TabIndex = 11;
            this.newMessageBtn.Text = "New Message";
            this.newMessageBtn.UseVisualStyleBackColor = false;
            this.newMessageBtn.Click += new System.EventHandler(this.newMessageBtn_Click);
            // 
            // AddMessage
            // 
            this.AddMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddMessage.Image = ((System.Drawing.Image)(resources.GetObject("AddMessage.Image")));
            this.AddMessage.Location = new System.Drawing.Point(3, 53);
            this.AddMessage.Name = "AddMessage";
            this.AddMessage.Size = new System.Drawing.Size(71, 38);
            this.AddMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddMessage.TabIndex = 14;
            this.AddMessage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 338);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.UserPicBox);
            this.panel2.Controls.Add(this.NameLable);
            this.panel2.Controls.Add(this.WelcomeLable);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 130);
            this.panel2.TabIndex = 9;
            // 
            // UserPicBox
            // 
            this.UserPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserPicBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPicBox.Image")));
            this.UserPicBox.Location = new System.Drawing.Point(3, 28);
            this.UserPicBox.Name = "UserPicBox";
            this.UserPicBox.Size = new System.Drawing.Size(71, 74);
            this.UserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicBox.TabIndex = 9;
            this.UserPicBox.TabStop = false;
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NameLable.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold);
            this.NameLable.ForeColor = System.Drawing.Color.Black;
            this.NameLable.Location = new System.Drawing.Point(145, 80);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(0, 31);
            this.NameLable.TabIndex = 6;
            this.NameLable.Click += new System.EventHandler(this.NameLable_Click);
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.AutoSize = true;
            this.WelcomeLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WelcomeLable.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold);
            this.WelcomeLable.ForeColor = System.Drawing.Color.Black;
            this.WelcomeLable.Location = new System.Drawing.Point(91, 28);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(117, 31);
            this.WelcomeLable.TabIndex = 5;
            this.WelcomeLable.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(430, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Benex Company";
            // 
            // userEmails
            // 
            this.userEmails.AllowUserToAddRows = false;
            this.userEmails.AllowUserToDeleteRows = false;
            this.userEmails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.userEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userEmails.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userEmails.Location = new System.Drawing.Point(247, 128);
            this.userEmails.Name = "userEmails";
            this.userEmails.ReadOnly = true;
            this.userEmails.RowHeadersWidth = 51;
            this.userEmails.Size = new System.Drawing.Size(585, 392);
            this.userEmails.TabIndex = 16;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 532);
            this.Controls.Add(this.userEmails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sylfaen", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserMenu";
            this.Text = "User Menu";
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEmails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox UserPicBox;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label WelcomeLable;
        private System.Windows.Forms.PictureBox AddMessage;
        private System.Windows.Forms.Button newMessageBtn;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userEmails;
    }
}