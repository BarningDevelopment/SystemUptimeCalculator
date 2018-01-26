using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculateFormApplication;

namespace BarningSystemUptimeCalculator
{
    public partial class BarningSystemUptimeCalculator : Form
    {
        public BarningSystemUptimeCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateForm con = new CalculateForm();
            con.Show();            
        }
    }
}

