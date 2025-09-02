using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnCallScheduler
{
    public partial class AddNewSiteAndDate : Form
    {
        public Sites NewSite { get; } = new Sites();

        public bool Cancelled { get; set; } = false;

        public AddNewSiteAndDate()
        {
            InitializeComponent();
        }

        //todo - Change the title and add button name when editing and take a Sites class in

        private void addButton_Click(object sender, EventArgs e)
        {
            if (siteNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("You need a name for this site(s)");
                return;
            }

            if (TestForValidDates() == false)
            {
                MessageBox.Show("Your starting dates are not valid.");
                return;
            }

            NewSite.SiteName = siteNameTextBox.Text.Trim();

            //int.Parse should be fine as it will of been tested already
            NewSite.Day = int.Parse(dayTextBox.Text);
            NewSite.Month = int.Parse(monthTextBox.Text);
            NewSite.Year = int.Parse(yearTextBox.Text);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            this.Close();
        }

        private bool TestForValidDates()
        {
            bool validDates = false;

            try
            {
                int a = int.Parse(monthTextBox.Text);
                a = int.Parse(dayTextBox.Text);
                a = int.Parse(yearTextBox.Text);
            }
            catch (FormatException)
            {
                validDates = false;
                return validDates;
            }

            string input = yearTextBox.Text + "-" + monthTextBox.Text + "-" + dayTextBox.Text;
            DateTime result; //throw away

            validDates = DateTime.TryParse(input, out result);

            if (int.Parse(yearTextBox.Text) < 2020) validDates = false;

            return validDates;
        }
    }
}
