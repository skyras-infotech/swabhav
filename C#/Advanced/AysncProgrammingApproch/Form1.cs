using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AysncProgrammingApproch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello" + DateTime.Now.ToString("hh:MM:ss"));
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            new TimePrinter().Print();
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new TimePrinter().Print);
            thread.Start();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            Task.Run(new TimePrinter().Print);
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            Task<int> r = new TimePrinter().PrintAsync();
            MessageBox.Show(r.ToString());
        }

        private async void btnAsyncResult_Click(object sender, EventArgs e)
        {
            int r = await new TimePrinter().PrintAsync();
            MessageBox.Show(r.ToString());
        }
    }
}
