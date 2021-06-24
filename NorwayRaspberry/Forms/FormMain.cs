using NorwayRaspberry.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorwayRaspberry.Forms
{
    public partial class FormMain : Form
    {
        CollectedStuffType collectedStuff = new CollectedStuffType();
        List <double> kgToBucket = new List<double>();
        List <double> kgToPrivate = new List<double>();
        List <int> metres = new List<int>();
        List <int> korges = new List<int>();
        ProcessManager process = new ProcessManager();
        

        public FormMain()
        {
            InitializeComponent();

            
        }
        private void textBoxKgToBucket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxKgToBucket.Text))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                kgToBucket.Add(double.Parse(textBoxKgToBucket.Text));
                textBoxKgToBucket.Clear();
            }
        }
        private void textBoxKgToPrivate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxKgToPrivate.Text))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                kgToPrivate.Add(double.Parse(textBoxKgToPrivate.Text));
                textBoxKgToPrivate.Clear();
            }
        }
        private void textBoxKorges_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxKorges.Text))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                korges.Add(Convert.ToInt32(textBoxKorges.Text));
                textBoxKorges.Clear();
            }
        }  private void textBoxMetres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxMetres.Text))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                metres.Add(Convert.ToInt32(textBoxMetres.Text));
                textBoxMetres.Clear();
            }
        }
        private void ButtonAddDay_Click(object sender, EventArgs e)
        {
            collectedStuff.KgIntoBucket = kgToBucket;
            collectedStuff.KgIntoPrivate = kgToPrivate;
            collectedStuff.Korges = korges;
            collectedStuff.Metres = metres;
            collectedStuff.Date = DateTime.Now;

            process.AddStatistic(collectedStuff);
            Clear();
        }
        public void Clear()
        {
            kgToBucket.Clear();
            kgToPrivate.Clear();
            metres.Clear();
            korges.Clear();
            
        }

    }
}
