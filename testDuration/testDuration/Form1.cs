using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDuration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DurationSettings duration = new DurationSettings();

        private void Form1_Load(object sender, EventArgs e)
        {
            duration.Value = 300;
            labDuration.DataBindings.Add("Text", duration.timer, "DisplayAll");
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (duration.Value > 0)
                duration.Value -= 1;
        }
    }
}