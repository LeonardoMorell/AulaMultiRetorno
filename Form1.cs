using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMultiRetorno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvai_Click(object sender, EventArgs e)
        {
            if (rbExec03.Checked)
            {
                new exec03().Show();
                this.Hide();
            }
        }
    }
}
