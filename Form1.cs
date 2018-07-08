using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModdingTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckboxCustomTimestamp_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxCustomTimestamp.Checked)
            {
                DatePicker.Enabled = true;
            }

            else
            {
                DatePicker.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
