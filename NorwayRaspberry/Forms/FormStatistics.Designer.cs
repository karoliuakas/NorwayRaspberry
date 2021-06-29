namespace NorwayRaspberry.Forms
{
    partial class FormStatistics
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
            this.ComboBoxUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKgToBucket = new System.Windows.Forms.Label();
            this.lblKgToPrivate = new System.Windows.Forms.Label();
            this.lblKorges = new System.Windows.Forms.Label();
            this.lblMetres = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKgToBucketTotal = new System.Windows.Forms.Label();
            this.lblKgToPrivateTotal = new System.Windows.Forms.Label();
            this.lblKorgesTotal = new System.Windows.Forms.Label();
            this.lblMetresTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBoxUsers
            // 
            this.ComboBoxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxUsers.FormattingEnabled = true;
            this.ComboBoxUsers.Location = new System.Drawing.Point(284, 26);
            this.ComboBoxUsers.Name = "ComboBoxUsers";
            this.ComboBoxUsers.Size = new System.Drawing.Size(246, 21);
            this.ComboBoxUsers.Sorted = true;
            this.ComboBoxUsers.TabIndex = 0;
            this.ComboBoxUsers.Text = "------SELECT USER------";
            this.ComboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iš viso kg į kibirus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iš viso kg į private:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Iš viso korgių:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Iš viso metrų: ";
            // 
            // lblKgToBucket
            // 
            this.lblKgToBucket.AutoSize = true;
            this.lblKgToBucket.Location = new System.Drawing.Point(122, 76);
            this.lblKgToBucket.Name = "lblKgToBucket";
            this.lblKgToBucket.Size = new System.Drawing.Size(0, 13);
            this.lblKgToBucket.TabIndex = 5;
            // 
            // lblKgToPrivate
            // 
            this.lblKgToPrivate.AutoSize = true;
            this.lblKgToPrivate.Location = new System.Drawing.Point(297, 75);
            this.lblKgToPrivate.Name = "lblKgToPrivate";
            this.lblKgToPrivate.Size = new System.Drawing.Size(0, 13);
            this.lblKgToPrivate.TabIndex = 6;
            // 
            // lblKorges
            // 
            this.lblKorges.AutoSize = true;
            this.lblKorges.Location = new System.Drawing.Point(490, 76);
            this.lblKorges.Name = "lblKorges";
            this.lblKorges.Size = new System.Drawing.Size(0, 13);
            this.lblKorges.TabIndex = 7;
            // 
            // lblMetres
            // 
            this.lblMetres.AutoSize = true;
            this.lblMetres.Location = new System.Drawing.Point(674, 76);
            this.lblMetres.Name = "lblMetres";
            this.lblMetres.Size = new System.Drawing.Size(0, 13);
            this.lblMetres.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bendrai sudėjus visus\r\n       KG į kibirus :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bendrai sudėjus visus\r\n       KG į private :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bendrai sudėjus visas \r\n          Korges :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(593, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 40);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bendrai sudėjus visus \r\n           Metrus :";
            // 
            // lblKgToBucketTotal
            // 
            this.lblKgToBucketTotal.AutoSize = true;
            this.lblKgToBucketTotal.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgToBucketTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKgToBucketTotal.Location = new System.Drawing.Point(52, 375);
            this.lblKgToBucketTotal.Name = "lblKgToBucketTotal";
            this.lblKgToBucketTotal.Size = new System.Drawing.Size(0, 20);
            this.lblKgToBucketTotal.TabIndex = 13;
            // 
            // lblKgToPrivateTotal
            // 
            this.lblKgToPrivateTotal.AutoSize = true;
            this.lblKgToPrivateTotal.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgToPrivateTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKgToPrivateTotal.Location = new System.Drawing.Point(238, 375);
            this.lblKgToPrivateTotal.Name = "lblKgToPrivateTotal";
            this.lblKgToPrivateTotal.Size = new System.Drawing.Size(0, 20);
            this.lblKgToPrivateTotal.TabIndex = 14;
            // 
            // lblKorgesTotal
            // 
            this.lblKorgesTotal.AutoSize = true;
            this.lblKorgesTotal.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorgesTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblKorgesTotal.Location = new System.Drawing.Point(419, 375);
            this.lblKorgesTotal.Name = "lblKorgesTotal";
            this.lblKorgesTotal.Size = new System.Drawing.Size(0, 20);
            this.lblKorgesTotal.TabIndex = 15;
            // 
            // lblMetresTotal
            // 
            this.lblMetresTotal.AutoSize = true;
            this.lblMetresTotal.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetresTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMetresTotal.Location = new System.Drawing.Point(625, 375);
            this.lblMetresTotal.Name = "lblMetresTotal";
            this.lblMetresTotal.Size = new System.Drawing.Size(0, 20);
            this.lblMetresTotal.TabIndex = 16;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMetresTotal);
            this.Controls.Add(this.lblKorgesTotal);
            this.Controls.Add(this.lblKgToPrivateTotal);
            this.Controls.Add(this.lblKgToBucketTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMetres);
            this.Controls.Add(this.lblKorges);
            this.Controls.Add(this.lblKgToPrivate);
            this.Controls.Add(this.lblKgToBucket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxUsers);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKgToBucket;
        private System.Windows.Forms.Label lblKgToPrivate;
        private System.Windows.Forms.Label lblKorges;
        private System.Windows.Forms.Label lblMetres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKgToBucketTotal;
        private System.Windows.Forms.Label lblKgToPrivateTotal;
        private System.Windows.Forms.Label lblKorgesTotal;
        private System.Windows.Forms.Label lblMetresTotal;
    }
}