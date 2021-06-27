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
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}