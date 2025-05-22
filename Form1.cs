

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
