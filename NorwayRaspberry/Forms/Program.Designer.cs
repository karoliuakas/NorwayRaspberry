namespace NorwayRaspberry
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ButtonMain = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.ButtonAllDays = new System.Windows.Forms.Button();
            this.ButtonStatistic = new System.Windows.Forms.Button();
            this.ButtonUsers = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonOtherStuff = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Moccasin;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.ButtonOtherStuff);
            this.panelMenu.Controls.Add(this.ButtonMain);
            this.panelMenu.Controls.Add(this.lblDate);
            this.panelMenu.Controls.Add(this.ButtonAllDays);
            this.panelMenu.Controls.Add(this.ButtonStatistic);
            this.panelMenu.Controls.Add(this.ButtonUsers);
            this.panelMenu.Location = new System.Drawing.Point(-1, -2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 582);
            this.panelMenu.TabIndex = 0;
            // 
            // ButtonMain
            // 
            this.ButtonMain.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonMain.FlatAppearance.BorderSize = 0;
            this.ButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMain.Location = new System.Drawing.Point(-12, 143);
            this.ButtonMain.Name = "ButtonMain";
            this.ButtonMain.Size = new System.Drawing.Size(214, 28);
            this.ButtonMain.TabIndex = 5;
            this.ButtonMain.Text = "PAGRINDINIS";
            this.ButtonMain.UseVisualStyleBackColor = false;
            this.ButtonMain.Click += new System.EventHandler(this.ButtonMain_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 21);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "2021-06-19";
            // 
            // ButtonAllDays
            // 
            this.ButtonAllDays.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonAllDays.FlatAppearance.BorderSize = 0;
            this.ButtonAllDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAllDays.Location = new System.Drawing.Point(-12, 280);
            this.ButtonAllDays.Name = "ButtonAllDays";
            this.ButtonAllDays.Size = new System.Drawing.Size(214, 28);
            this.ButtonAllDays.TabIndex = 3;
            this.ButtonAllDays.Text = "VISOS DIENOS";
            this.ButtonAllDays.UseVisualStyleBackColor = false;
            this.ButtonAllDays.Click += new System.EventHandler(this.ButtonAllDays_Click);
            // 
            // ButtonStatistic
            // 
            this.ButtonStatistic.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonStatistic.FlatAppearance.BorderSize = 0;
            this.ButtonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStatistic.Location = new System.Drawing.Point(-12, 234);
            this.ButtonStatistic.Name = "ButtonStatistic";
            this.ButtonStatistic.Size = new System.Drawing.Size(214, 28);
            this.ButtonStatistic.TabIndex = 2;
            this.ButtonStatistic.Text = "STATISTIKA";
            this.ButtonStatistic.UseVisualStyleBackColor = false;
            this.ButtonStatistic.Click += new System.EventHandler(this.ButtonStatistic_Click);
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonUsers.FlatAppearance.BorderSize = 0;
            this.ButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUsers.Location = new System.Drawing.Point(-12, 189);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(214, 28);
            this.ButtonUsers.TabIndex = 1;
            this.ButtonUsers.Text = "RINKĖJAI";
            this.ButtonUsers.UseVisualStyleBackColor = false;
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonUsers_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(935, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(22, 19);
            this.ButtonClose.TabIndex = 4;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panelForms
            // 
            this.panelForms.Location = new System.Drawing.Point(185, 82);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(775, 498);
            this.panelForms.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raspberry picking system";
            // 
            // ButtonOtherStuff
            // 
            this.ButtonOtherStuff.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonOtherStuff.FlatAppearance.BorderSize = 0;
            this.ButtonOtherStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOtherStuff.Location = new System.Drawing.Point(-12, 326);
            this.ButtonOtherStuff.Name = "ButtonOtherStuff";
            this.ButtonOtherStuff.Size = new System.Drawing.Size(214, 28);
            this.ButtonOtherStuff.TabIndex = 6;
            this.ButtonOtherStuff.Text = "KITA";
            this.ButtonOtherStuff.UseVisualStyleBackColor = false;
            this.ButtonOtherStuff.Click += new System.EventHandler(this.ButtonOtherStuff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(962, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button ButtonUsers;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonAllDays;
        private System.Windows.Forms.Button ButtonStatistic;
        private System.Windows.Forms.Button ButtonMain;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonOtherStuff;
    }
}

