using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnCallScheduler
{
    public partial class StaffNameAddEditForm : Form
    {
        StaffNameAndNumbers staff;
        int index;
        bool isadd;

        public StaffNameAddEditForm(StaffNameAndNumbers _staff, bool _isAdd, int _index)
        {
            InitializeComponent();

            staff = _staff;
            index = _index;
            isadd = _isAdd;
            if(isadd == false)
            {
                populateEditData();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {


            closeForm();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

            //test data first

            StringBuilder phoneNumber = new StringBuilder();
            phoneNumber.Append("(");
            phoneNumber.Append(areaCodeTextBox.Text);
            phoneNumber.Append(")");
            phoneNumber.Append(exchangeTextBox.Text);
            phoneNumber.Append("-");
            phoneNumber.Append(lineNumberTextBox.Text);

            if (isadd) //add new
            {
                staff.AddNewNameAndNumber((staffNameTextBox.Text.Trim(), phoneNumber.ToString()));
            }
            else //edit
            { 
            
            }
                closeForm();
        }

        private void populateEditData()
        {
            //grab data and put it in the proper text boxes
        }

        private void closeForm()
        {
            //made this method just in case it makes sense later to seperate it

            this.Close();
        }
    }
}
