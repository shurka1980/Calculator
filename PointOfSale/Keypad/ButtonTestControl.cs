using System;
using System.Windows.Forms;

namespace Keypad
{
    public partial class ButtonTestControl : UserControl
    {
        public EventHandler TestButtonClick;
        public ButtonTestControl()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            TestButtonClick?.Invoke(this, e);
        }
    }
}
