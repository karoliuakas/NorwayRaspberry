namespace NorwayRaspberry.Forms
{
    partial class FormUsers
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
            this.ButtonAddUser = new System.Windows.Forms.Button();
            this.listBoxOfUsers = new System.Windows.Forms.ListBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonAddUser.FlatAppearance.BorderSize = 0;
            this.ButtonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddUser.Location = new System.Drawing.Point(202, 82);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(300, 23);
            this.ButtonAddUser.TabIndex = 0;
            this.ButtonAddUser.Text = "Pridėti naują vartotoją";
            this.ButtonAddUser.UseVisualStyleBackColor = false;
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // listBoxOfUsers
            // 
            this.listBoxOfUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxOfUsers.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOfUsers.FormattingEnabled = true;
            this.listBoxOfUsers.ItemHeight = 22;
            this.listBoxOfUsers.Location = new System.Drawing.Point(508, 32);
            this.listBoxOfUsers.Name = "listBoxOfUsers";
            this.listBoxOfUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxOfUsers.Size = new System.Drawing.Size(153, 354);
            this.listBoxOfUsers.TabIndex = 1;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(201, 50);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(144, 20);
            this.TextBoxName.TabIndex = 2;
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(351, 50);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(150, 20);
            this.TextBoxSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pavardė";
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnDeleteUser.FlatAppearance.BorderSize = 0;
            this.BtnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteUser.Location = new System.Drawing.Point(201, 363);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(300, 23);
            this.BtnDeleteUser.TabIndex = 7;
            this.BtnDeleteUser.Text = "Ištrinti vartotoją";
            this.BtnDeleteUser.UseVisualStyleBackColor = false;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.listBoxOfUsers);
            this.Controls.Add(this.ButtonAddUser);
            this.Name = "FormUsers";
            this.Text = "Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddUser;
        private System.Windows.Forms.ListBox listBoxOfUsers;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDeleteUser;
    }
}