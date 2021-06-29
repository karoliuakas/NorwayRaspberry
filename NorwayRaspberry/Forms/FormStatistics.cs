using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorwayRaspberry.Objects;

namespace NorwayRaspberry.Forms
{
    public partial class FormStatistics : Form
    {
        ProcessManager process = new ProcessManager();
        public FormStatistics()
        {
            InitializeComponent();

            Misc.LoadUsersToComboBox(ComboBoxUsers, false);
            TotalSum();
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
        private void TotalSum()
        {
            int counter = 0;
            double total = 0;
            List <Guid> validUsersId = new List<Guid>();
            foreach(UserType user in process._users)
            {
                if(user.Valid) validUsersId.Add(user.Id);
            }

            double totalValueKgInBucket = 0;
            double totalValueKgInPrivate = 0;
            int totalValueKorges = 0;
            int totalValueMetres = 0;
            foreach (Guid id in validUsersId)
            {
                var listOfListsKgInBucket = process._statistics.Where(a => a.UserID == id).Select(p => p);
                totalValueKgInBucket += listOfListsKgInBucket.SelectMany(list => list.KgIntoBucket).Sum();
                totalValueKgInPrivate += listOfListsKgInBucket.SelectMany(list => list.KgIntoPrivate).Sum();
                totalValueKorges += listOfListsKgInBucket.SelectMany(list => list.Korges).Sum();
                totalValueMetres += listOfListsKgInBucket.SelectMany(list => list.Metres).Sum();
            }
            lblKgToBucketTotal.Text = totalValueKgInBucket.ToString() + " KG";
            lblKgToPrivateTotal.Text = totalValueKgInPrivate.ToString() + " KG";
            lblKorgesTotal.Text = totalValueKorges.ToString() + " Korgės(ių)";
            lblMetresTotal.Text = totalValueMetres.ToString() + " Metrai(ų)";
        }
    }
}
