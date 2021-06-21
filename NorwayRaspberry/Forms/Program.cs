using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorwayRaspberry
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(childForm);
            this.panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUsers(), sender);
        }


        private void ButtonMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMain(), sender);
        }

        private void ButtonStatistic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStatistics(), sender);
        }

        private void ButtonAllDays_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAllDays(), sender);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
