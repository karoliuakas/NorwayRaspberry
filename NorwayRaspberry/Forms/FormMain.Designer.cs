namespace NorwayRaspberry.Forms
{
    partial class FormMain
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
            this.comboBoxValidUsers = new System.Windows.Forms.ComboBox();
            this.textBoxKgToBucket = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKgToPrivate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKorges = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMetres = new System.Windows.Forms.TextBox();
            this.ButtonAddDay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxValidUsers
            // 
            this.comboBoxValidUsers.FormattingEnabled = true;
            this.comboBoxValidUsers.Location = new System.Drawing.Point(332, 44);
            this.comboBoxValidUsers.Name = "comboBoxValidUsers";
            this.comboBoxValidUsers.Size = new System.Drawing.Size(143, 21);
            this.comboBoxValidUsers.TabIndex = 0;
            this.comboBoxValidUsers.Text = "-- Pasirinkite naudotoją --";
            // 
            // textBoxKgToBucket
            // 
            this.textBoxKgToBucket.Location = new System.Drawing.Point(133, 139);
            this.textBoxKgToBucket.Name = "textBoxKgToBucket";
            this.textBoxKgToBucket.Size = new System.Drawing.Size(100, 20);
            this.textBoxKgToBucket.TabIndex = 1;
            this.textBoxKgToBucket.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKgToBucket_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kg į kibirus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Privatūs kg";
            // 
            // textBoxKgToPrivate
            // 
            this.textBoxKgToPrivate.Location = new System.Drawing.Point(264, 139);
            this.textBoxKgToPrivate.Name = "textBoxKgToPrivate";
            this.textBoxKgToPrivate.Size = new System.Drawing.Size(100, 20);
            this.textBoxKgToPrivate.TabIndex = 3;
            this.textBoxKgToPrivate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKgToPrivate_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Korges";
            // 
            // textBoxKorges
            // 
            this.textBoxKorges.Location = new System.Drawing.Point(413, 139);
            this.textBoxKorges.Name = "textBoxKorges";
            this.textBoxKorges.Size = new System.Drawing.Size(100, 20);
            this.textBoxKorges.TabIndex = 5;
            this.textBoxKorges.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKorges_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Metrai";
            // 
            // textBoxMetres
            // 
            this.textBoxMetres.Location = new System.Drawing.Point(562, 139);
            this.textBoxMetres.Name = "textBoxMetres";
            this.textBoxMetres.Size = new System.Drawing.Size(100, 20);
            this.textBoxMetres.TabIndex = 7;
            this.textBoxMetres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMetres_KeyDown);
            // 
            // ButtonAddDay
            // 
            this.ButtonAddDay.BackColor = System.Drawing.Color.BurlyWood;
            this.ButtonAddDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDay.Location = new System.Drawing.Point(264, 370);
            this.ButtonAddDay.Name = "ButtonAddDay";
            this.ButtonAddDay.Size = new System.Drawing.Size(292, 33);
            this.ButtonAddDay.TabIndex = 10;
            this.ButtonAddDay.Text = "UŽSAUGOTI";
            this.ButtonAddDay.UseVisualStyleBackColor = false;
            this.ButtonAddDay.Click += new System.EventHandler(this.ButtonAddDay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonAddDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMetres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxKorges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKgToPrivate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKgToBucket);
            this.Controls.Add(this.comboBoxValidUsers);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxValidUsers;
        private System.Windows.Forms.TextBox textBoxKgToBucket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKgToPrivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKorges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMetres;
        private System.Windows.Forms.Button ButtonAddDay;
        private System.Windows.Forms.Label label5;
    }
}