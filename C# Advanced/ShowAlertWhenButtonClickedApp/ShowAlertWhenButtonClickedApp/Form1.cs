using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAlertWhenButtonClickedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Sumit", "Say Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good bye Sumit", "Say Bye");
        }
    }
}
