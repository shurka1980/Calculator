using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keypad
{
	public partial class RegisterKeypad : GenericKeypad
	{
		public RegisterKeypad()
		{
			InitializeComponent();
		}

        public event EventHandler ButtonClick1;
        public event EventHandler ButtonClick2;
        public event EventHandler ButtonClick3;
        public event EventHandler ButtonClick4;
        public event EventHandler ButtonClick5;
        public event EventHandler ButtonClick6;
        public event EventHandler ButtonClick7;
        public event EventHandler ButtonClick8;
        public event EventHandler ButtonClick9;
        public event EventHandler ButtonClick0;
        public event EventHandler ButtonClickClear;
        public event EventHandler ButtonClickPlus;
        public event EventHandler ButtonClickEquals;
        public event EventHandler ButtonClickMinus;
        public event EventHandler ButtonClickMultiply;
        public event EventHandler ButtonClickDivide;
        public event EventHandler ButtonClickDecimal;

        private void btn1_Click(object sender, EventArgs e)
        {
            this.ButtonClick1?.Invoke(this, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.ButtonClick2?.Invoke(this, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.ButtonClick3?.Invoke(this, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.ButtonClick4?.Invoke(this, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.ButtonClick5?.Invoke(this, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.ButtonClick6?.Invoke(this, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.ButtonClick7?.Invoke(this, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.ButtonClick8?.Invoke(this, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.ButtonClick9?.Invoke(this, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.ButtonClick0?.Invoke(this, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ButtonClickClear?.Invoke(this, e);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.ButtonClickPlus?.Invoke(this, e);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.ButtonClickEquals?.Invoke(this, e);

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.ButtonClickMinus?.Invoke(this, e);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.ButtonClickMultiply?.Invoke(this, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.ButtonClickDivide?.Invoke(this, e);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            this.ButtonClickDecimal?.Invoke(this, e);
        }
    }
}
