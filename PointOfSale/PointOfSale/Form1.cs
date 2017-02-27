using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Keypad;

namespace PointOfSale
{
	public partial class Form1 : Form
	{
        double lastDisplayedValue;
        int lastOperation; // add, subtract
        string lastButtonPressed = string.Empty; // one, two

        enum operations
        {
            Add,
            Subtract,
            Divide,
            Multiply,
            Equal
        };

		public Form1()
		{
			InitializeComponent();
		}

		private void Click1_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "1";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "1";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "1";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "1";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "1";
                                break;
                            }
                        default:
                            {
                                item.Text += "1";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "one";
        }

		private void Click2_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "2";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "2";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "2";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "2";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "2";
                                break;
                            }
                        default:
                            {
                                item.Text += "2";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "two";
        }

		private void Click3_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "3";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "3";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "3";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "3";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "3";
                                break;
                            }
                        default:
                            {
                                item.Text += "3";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "three";
        }

		private void Click4_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "4";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "4";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "4";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "4";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "4";
                                break;
                            }
                        default:
                            {
                                item.Text += "4";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "four";
        }

		private void Click5_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "5";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "5";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "5";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "5";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "5";
                                break;
                            }
                        default:
                            {
                                item.Text += "5";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "five";
        }

		private void Click6_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "6";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "6";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "6";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "6";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "6";
                                break;
                            }
                        default:
                            {
                                item.Text += "6";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "six";
        }

		private void Click7_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "7";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "7";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "7";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "7";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "7";
                                break;
                            }
                        default:
                            {
                                item.Text += "7";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "seven";
        }

		private void Click8_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "8";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "8";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "8";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "8";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "8";
                                break;
                            }
                        default:
                            {
                                item.Text += "8";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "eight";
        }

		private void Click9_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
                    switch (lastButtonPressed)
                    {
                        case "add":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "9";
                                break;
                            }
                        case "subtract":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "9";
                                break;
                            }
                        case "divide":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "9";
                                break;
                            }
                        case "multiply":
                            {
                                lastDisplayedValue = Convert.ToDouble(item.Text);
                                item.Text = "9";
                                break;
                            }
                        case "equals":
                            {
                                item.Text = "9";
                                break;
                            }
                        default:
                            {
                                item.Text += "9";
                                break;
                            }
                    }
                }
			}
            lastButtonPressed = "nine";
        }

		private void Click0_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{	
                        switch (lastButtonPressed)
                        {
                            case "add":
                                {
                                    lastDisplayedValue = Convert.ToDouble(item.Text);
                                    item.Text = "0";
                                    break;
                                }
                            case "subtract":
                                {
                                    lastDisplayedValue = Convert.ToDouble(item.Text);
                                    item.Text = "0";
                                    break;
                                }
                            case "divide":
                                {
                                    lastDisplayedValue = Convert.ToDouble(item.Text);
                                    item.Text = "0";
                                    break;
                                }
                            case "multiply":
                                {
                                    lastDisplayedValue = Convert.ToDouble(item.Text);
                                    item.Text = "0";
                                    break;
                                }
                            case "equals":
                                {
                                    item.Text = "0";
                                    break;
                                }
                            default:
                                {
                                    item.Text += "0";
                                    break;
                                }                   
                    }
				}
			}
            lastButtonPressed = "zero";
        }
        private void ClickClear_EventHandler(object sender, EventArgs e)
        {
            foreach (TextBox item in displayControl1.Controls)
            {
                if (item.Name == "txtDisplay")
                {   
                        item.Text = "";

                }
            }
            lastButtonPressed = "clear";
            lastOperation = 0;
        }

        private void ClickPlus_EventHandler(object sender, EventArgs e)
        {   
            lastOperation = (int)operations.Add;
            lastButtonPressed = "add";
        }

        private void ClickMinus_EventHandler(object sender, EventArgs e)
        {
            lastOperation = (int)operations.Subtract;
            lastButtonPressed = "subtract";
        }

        private void ClickMultiply_EventHandler(object sender, EventArgs e)
        {

            lastOperation = (int)operations.Multiply;
            lastButtonPressed = "multiply";
        }

        private void ClickDivide_EventHandler(object sender, EventArgs e)
        {
            lastOperation = (int)operations.Divide;
            lastButtonPressed = "divide";

        }
        private void ClickEquals_EventHandler(object sender, EventArgs e)
        {
            foreach (TextBox item in displayControl1.Controls)
            {
                if (item.Name == "txtDisplay")
                {
                    if (lastOperation == (int)operations.Add)
                    {
                        item.Text = (lastDisplayedValue + Convert.ToDouble(item.Text)).ToString();
                    }
                    else if (lastOperation == (int)operations.Subtract)
                    {
                        item.Text = (lastDisplayedValue - Convert.ToDouble(item.Text)).ToString();
                    }
                    else if (lastOperation == (int)operations.Multiply)
                    {
                        item.Text = (lastDisplayedValue * Convert.ToDouble(item.Text)).ToString();
                    }

                    else if (lastOperation == (int)operations.Divide)
                    {
                        item.Text = (lastDisplayedValue / Convert.ToDouble(item.Text)).ToString();
                    }

                }                
            }
            lastOperation = (int)operations.Equal;
            lastButtonPressed = "equals";
        }

        

        private void ClickDecimal_EventHandler(object sender, EventArgs e)
        {
            foreach (TextBox item in displayControl1.Controls)
            {
                if (item.Name == "txtDisplay")
                {
                    if(!item.Text.Contains("."))
                    item.Text += ".";

                }
            }
            lastButtonPressed = ".";
        }


    }
}
