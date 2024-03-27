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
    public partial class Form4_Delete : Form
    {
        List<UserModel> users = new List<UserModel>();

        public Form4_Delete()
        {
            InitializeComponent();

            LoadUsers();
        }

        private void LoadUsers()
        {
            users.Clear();
            users = SqliteDataAccess.LoadUsers();

            userList.DataSource = null;
            userList.DataSource = users;
            userList.DisplayMember = "FullName";
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteUser(users[userList.SelectedIndex]);
            LoadUsers();
        }
    }
}
