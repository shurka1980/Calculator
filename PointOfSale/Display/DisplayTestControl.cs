using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Display
{
    public partial class DisplayTestControl : UserControl
    {
        public DisplayTestControl()
        {
            InitializeComponent();
        }
        
        //public void ClearTextBox(object sender, EventArgs e)
        //{
        //    textBox1.Clear();
        //}

        public void Subscribe(Control button)
        {
            //button.Click += ClearTextBox;
            textBox1.Clear();
        }
    }
}
