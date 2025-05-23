

namespace OnCallScheduler
{
    public partial class MainForm : Form
    {
        // You need to hold onto the first date on the page and calculate the rest
        // You also need a pointer to know which staff is the first one on each page


        public MainForm()
        {
            InitializeComponent();

            LoadDatesInSchedule();
        }


        private void LoadDatesInSchedule()
        {

            displayListView.Items.Clear();

            for (int i = 0; i < 15; i++)
            {
                ListViewItem lvl = new ListViewItem((i + 1).ToString() + " April 4th - April 10th");

                lvl.SubItems.Add("Joe Pugliese - (908)635-4106");

                displayListView.Items.Add(lvl);
            }
        }

        private void CalculateDatesForPage()
        {
            //should return the 15 start and end dates

            DateTime date = new DateTime(2025, 4, 1);
            date = date.AddDays(7);

        }
        private string GetMonthName(DateTime date)
        {
            string name = string.Empty;

            switch(date.Month)
            {
                case 1:
                    name = "Jan.";
                    break;
                case 2:
                    name = "Feb.";
                    break;
                case 3:
                    name = "March";
                    break;
                case 4:
                    name = "April";
                    break;
                case 5:
                    name = "May";
                    break;
                case 6:
                    name = "June";
                    break;
                case 7:
                    name = "July";
                    break;
                case 8:
                    name = "Aug.";
                    break;
                case 9:
                    name = "Sept.";
                    break;
                case 10:
                    name = "Oct.";
                    break;
                case 11:
                    name = "Nov.";
                    break;
                case 12:
                    name = "Dec.";
                    break;
            }

            return name;
        }

        #region Buttons

        private void exitButton_Click(object sender, EventArgs e)
        {
            QuitApplication();
        }

        #endregion

        #region Other Methods

        private void QuitApplication()
        {
            Application.Exit();
        }

        #endregion

    }
}
