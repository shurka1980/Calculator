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
		double _lastDisplayedValue;
		int _lastOperation; // add, subtract
		string _lastButtonPressed = string.Empty; // one, two

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
            this.buttonTestControl1.TestButtonClick += new System.EventHandler(testButtonClicked_EventHandler);
        }

		private void Click1_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "1";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "1";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "1";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "one";
		}

		private void Click2_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "2";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "2";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "2";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "two";
		}

		private void Click3_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "3";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "3";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "3";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "three";
		}

		private void Click4_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "4";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "4";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "4";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "four";
		}

		private void Click5_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "5";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "5";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "5";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "five";
		}

		private void Click6_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "6";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "6";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "6";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "six";
		}

		private void Click7_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "7";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "7";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "7";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "seven";
		}

		private void Click8_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "8";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "8";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "8";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "eight";
		}

		private void Click9_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					switch (_lastButtonPressed)
					{
						case "add":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "9";
								break;
							}
						case "subtract":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "9";
								break;
							}
						case "divide":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
								item.Text = "9";
								break;
							}
						case "multiply":
							{
								_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "nine";
		}

		private void Click0_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{	
						switch (_lastButtonPressed)
						{
							case "add":
								{
									_lastDisplayedValue = Convert.ToDouble(item.Text);
									item.Text = "0";
									break;
								}
							case "subtract":
								{
									_lastDisplayedValue = Convert.ToDouble(item.Text);
									item.Text = "0";
									break;
								}
							case "divide":
								{
									_lastDisplayedValue = Convert.ToDouble(item.Text);
									item.Text = "0";
									break;
								}
							case "multiply":
								{
									_lastDisplayedValue = Convert.ToDouble(item.Text);
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
			_lastButtonPressed = "zero";
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
			_lastButtonPressed = "clear";
			_lastOperation = 0;
		}

		private void ClickPlus_EventHandler(object sender, EventArgs e)
		{   
			_lastOperation = (int)operations.Add;
			_lastButtonPressed = "add";
		}

		private void ClickMinus_EventHandler(object sender, EventArgs e)
		{
			_lastOperation = (int)operations.Subtract;
			_lastButtonPressed = "subtract";
		}

		private void ClickMultiply_EventHandler(object sender, EventArgs e)
		{

			_lastOperation = (int)operations.Multiply;
			_lastButtonPressed = "multiply";
		}

		private void ClickDivide_EventHandler(object sender, EventArgs e)
		{
			_lastOperation = (int)operations.Divide;
			_lastButtonPressed = "divide";

		}
		private void ClickEquals_EventHandler(object sender, EventArgs e)
		{
			foreach (TextBox item in displayControl1.Controls)
			{
				if (item.Name == "txtDisplay")
				{
					if (_lastOperation == (int)operations.Add)
					{
						item.Text = (_lastDisplayedValue + Convert.ToDouble(item.Text)).ToString();
					}
					else if (_lastOperation == (int)operations.Subtract)
					{
						item.Text = (_lastDisplayedValue - Convert.ToDouble(item.Text)).ToString();
					}
					else if (_lastOperation == (int)operations.Multiply)
					{
						item.Text = (_lastDisplayedValue * Convert.ToDouble(item.Text)).ToString();
					}

					else if (_lastOperation == (int)operations.Divide)
					{
						item.Text = (_lastDisplayedValue / Convert.ToDouble(item.Text)).ToString();
					}

				}                
			}
			_lastOperation = (int)operations.Equal;
			_lastButtonPressed = "equals";
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
			_lastButtonPressed = ".";
		}

		private void testButtonClicked_EventHandler(object sender, EventArgs e)
		{
			foreach (Button itemButton in buttonTestControl1.Controls)
			{
				if (itemButton.Name == "testButton")
				{
					displayTestControl1.Subscribe(itemButton);
				}
			}

		}
	}
}
