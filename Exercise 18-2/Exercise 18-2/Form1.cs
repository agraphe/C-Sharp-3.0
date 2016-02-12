using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise_18_2
{
    public partial class frmHelloGoodbye : Form
    {
        bool isHello = true;
        public frmHelloGoodbye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                this.button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                this.button1.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            isHello = !isHello;
            if (isHello)
            {
                label1.Text = "Hello";
            }
            else
            {
                label1.Text = "Goodbye";
            }
        }
    }
}
