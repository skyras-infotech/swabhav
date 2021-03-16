using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeFormColorApp
{
    public partial class ColorChangedForm : Form
    {
        public ColorChangedForm()
        {
            InitializeComponent();
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }
    }
}
