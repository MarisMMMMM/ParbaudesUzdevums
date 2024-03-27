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
    public partial class Form3_Modify : Form
    {
        List<UserModel> users = new List<UserModel>();
        public static UserModel selectedUser;

        public Form3_Modify()
        {
            InitializeComponent();

            LoadUsers();
        }

        private void LoadUsers()
        {
            users = SqliteDataAccess.LoadUsers();

            userList.DataSource = null;
            userList.DataSource = users;
            userList.DisplayMember = "FullName";
        }

        private void modifyUserButton_Click(object sender, EventArgs e)
        {
            Form modifyPopupForm = new Form5_ModifyPopup(users[userList.SelectedIndex]);

            modifyPopupForm.ShowDialog();
        }
    }
}
