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
    public partial class Form1_Main : Form
    {
        public Form1_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addForm = new Form2_Add();
            addForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form modifyForm = new Form3_Modify();
            modifyForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form deleteForm = new Form4_Delete();
            deleteForm.ShowDialog();
        }
    }
}
