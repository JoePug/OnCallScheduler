



namespace OnCallScheduler
{
    public partial class MainForm : Form
    {
        // You need to hold onto the first date on the page and calculate the rest
        // You also need a pointer to know which staff is the first one on each page

        int year = 2025;
        int month = 4;
        int day = 4;
        int currentStaff = 0;

        public MainForm()
        {
            InitializeComponent();

            LoadDatesInSchedule();
        }


        private void LoadDatesInSchedule()
        {
            DateHandler dh = new DateHandler(month, day, year);

            displayListView.Items.Clear();

            for (int i = 0; i < 15; i++)
            {
                ListViewItem lvl = new ListViewItem(dh.GetNextLine());

                lvl.SubItems.Add("Joe Pugliese - (908)635-4106");

                displayListView.Items.Add(lvl);
            }
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
