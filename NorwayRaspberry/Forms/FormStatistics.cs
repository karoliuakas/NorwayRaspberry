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
    public partial class FormStatistics : Form
    {
        ProcessManager process = new ProcessManager();
        public FormStatistics()
        {
            InitializeComponent();

            Misc.LoadUsersToComboBox(ComboBoxUsers, false);
        }

        private void ComboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid key = ((KeyValuePair<Guid, string>)ComboBoxUsers.SelectedItem).Key;

            //Kg in buckets
            var listOfListsKgInBucket = process._statistics.Where(a => a.UserID == key).Select(p => p.KgIntoBucket);
            double totalValueKgInBucket = listOfListsKgInBucket.SelectMany(list => list).Sum();
            lblKgToBucket.Text = totalValueKgInBucket.ToString();

            //Kg in private
            var listOfListsKgInPrivate = process._statistics.Where(a => a.UserID == key).Select(p => p.KgIntoPrivate);
            double totalValueKgInPrivate = listOfListsKgInPrivate.SelectMany(list => list).Sum();
            lblKgToPrivate.Text = totalValueKgInPrivate.ToString();

            //Korges
            var listOfListsKorges = process._statistics.Where(a => a.UserID == key).Select(p => p.Korges);
            int totalValueKorges = listOfListsKorges.SelectMany(list => list).Sum();
            lblKorges.Text = totalValueKorges.ToString();

            //Metres
            var listOfListsMetres = process._statistics.Where(a => a.UserID == key).Select(p => p.Metres);
            int totalValueMetres = listOfListsMetres.SelectMany(list => list).Sum();
            lblMetres.Text = totalValueMetres.ToString();

        }
    }
}
