using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParbaudesUzdevums
{
    public partial class Form2_Add : Form
    {
        public Form2_Add()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void AddUser()
        {
            UserModel user = new UserModel();
            user.FirstName = firstNameField.Text;
            user.LastName = LastNameField.Text;

            if (Int32.TryParse(mobilePhoneField.Text, out int val))
            {

                user.MobilePhone = val;
            }
            else
            {
                MessageBox.Show("Nekorekts telefona numurs", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user.EmailAddress = emailField.Text;

            if (UserValidator.IsUserModelValid(user)) 
            {
                SqliteDataAccess.SaveUser(user);
                this.Close();
            }
        }
    }
}
