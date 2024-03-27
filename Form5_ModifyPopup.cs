using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParbaudesUzdevums
{
    public partial class Form5_ModifyPopup : Form
    {
        private UserModel _userToModify;
        public Form5_ModifyPopup(UserModel userToModify)
        {
            InitializeComponent();

            InitializeFields(userToModify);
        }

        private void InitializeFields(UserModel userToModify)
        {
            _userToModify = userToModify;

            firstNameField.Text = _userToModify.FirstName;
            LastNameField.Text = _userToModify.LastName;
            emailField.Text = _userToModify.EmailAddress;
            mobilePhoneField.Text = _userToModify.MobilePhone.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _userToModify.FirstName = firstNameField.Text;
            _userToModify.LastName = LastNameField.Text;
            _userToModify.EmailAddress = emailField.Text;
            if (Int32.TryParse(mobilePhoneField.Text, out int val))
            {

                _userToModify.MobilePhone = val;
            }
            else
            {
                MessageBox.Show("Nekorekts telefona numurs", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _userToModify.EmailAddress = emailField.Text;

            if (UserValidator.IsUserModelValid(_userToModify))
            {
                SqliteDataAccess.UpdateUser(_userToModify);
            }

            MessageBox.Show("Izmaiņas saglabātas");
        }
    }
}
