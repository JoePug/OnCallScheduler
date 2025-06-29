using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //test data first, test for invalad number also
            if (TestForValidNumber() == false)
            {
                MessageBox.Show("Your Phone Number is not Vaild. Please check and try again");
                return;
            }

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
                staff.EditOneName((staffNameTextBox.Text.Trim(), phoneNumber.ToString()), index);
            }
                closeForm();
        }

        private void populateEditData()
        {
            //grab data and put it in the proper text boxes
            (string, string) name = staff.GetOneName(index);
            
            staffNameTextBox.Text = name.Item1.ToString();
            areaCodeTextBox.Text = name.Item2.ToString().Substring(1, 3);
            exchangeTextBox.Text = name.Item2.ToString().Substring(5, 3);
            lineNumberTextBox.Text = name.Item2.ToString().Substring(9, 4);
        }

        private bool TestForValidNumber()
        {
            if (areaCodeTextBox.Text.ToString().Length != 3) return false;
            if (exchangeTextBox.Text.ToString().Length != 3) return false;
            if (lineNumberTextBox.Text.ToString().Length != 4) return false;

            if (!int.TryParse(areaCodeTextBox.Text, out _)) return false;
            if (!int.TryParse(exchangeTextBox.Text, out _)) return false;
            if (!int.TryParse(lineNumberTextBox.Text, out _)) return false;

            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void closeForm()
        {
            //made this method just in case it makes sense later to seperate it

            this.Close();
        }
    }
}
