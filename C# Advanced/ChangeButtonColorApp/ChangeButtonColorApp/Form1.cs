using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeButtonColorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Font = new Font("Arial",12);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
            button2.ForeColor = Color.White;
            button2.Font = new Font("Arial", 12);
        }
    }
}
