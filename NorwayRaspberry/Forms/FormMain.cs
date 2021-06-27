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
           Misc.LoadUsersToComboBox(comboBoxValidUsers, true);

        }
        private void textBoxKgToBucket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxKgToBucket.Text))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                kgToBucket.Add(double.Parse(textBoxKgToBucket.Text));
                lblKgToBucket.Text = $"Iš viso: { kgToBucket.Sum()} kg";
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
                lblKgToPrivate.Text = $"Iš viso: { kgToPrivate.Sum()} kg";
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
                lblKorges.Text = $"Iš viso: { korges.Sum()} korgės(ių)";
                textBoxKorges.Clear();
            }
        }  private void textBoxMetres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(textBoxMetres.Text))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                metres.Add(Convert.ToInt32(textBoxMetres.Text));
                lblMetres.Text = $"Iš viso: { metres.Sum()} metrai(ų)";
                textBoxMetres.Clear();
            }
        }
        private void ButtonAddDay_Click(object sender, EventArgs e)
        {
            Guid key = ((KeyValuePair<Guid, string>)comboBoxValidUsers.SelectedItem).Key;

            collectedStuff.KgIntoBucket = kgToBucket;
            collectedStuff.KgIntoPrivate = kgToPrivate;
            collectedStuff.Korges = korges;
            collectedStuff.Metres = metres;
            collectedStuff.Date = DateTime.Now;
            collectedStuff.UserID = key;
            if (kgToBucket.Count == 0 && kgToPrivate.Count == 0 && korges.Count == 0 && metres.Count ==0)
            {
                MessageBox.Show("Įveskite bent vieną parametrą");
                return;
            }

            process.AddStatistic(collectedStuff);
            MessageBox.Show("Išsaugota");
            Clear();
            
            
        }
        public void Clear()
        {
            kgToBucket.Clear();
            kgToPrivate.Clear();
            metres.Clear();
            korges.Clear();
            collectedStuff = new CollectedStuffType();
            lblKgToBucket.Text = "";
            lblKgToPrivate.Text = "";
            lblKorges.Text = "";
            lblMetres.Text = "";

        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 46 && ch!= 8) // 46 - dot // 8 - backspace
            {
                e.Handled = true;
            }

        }

    }
}
