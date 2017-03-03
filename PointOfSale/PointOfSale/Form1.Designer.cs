namespace PointOfSale
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayControl1 = new Display.DisplayControl();
            this.registerKeypad1 = new Keypad.RegisterKeypad();
            this.displayTestControl1 = new Display.DisplayTestControl();
            this.buttonTestControl1 = new Keypad.ButtonTestControl();
            this.SuspendLayout();
            // 
            // displayControl1
            // 
            this.displayControl1.Location = new System.Drawing.Point(35, 17);
            this.displayControl1.Name = "displayControl1";
            this.displayControl1.Size = new System.Drawing.Size(304, 43);
            this.displayControl1.TabIndex = 1;
            // 
            // registerKeypad1
            // 
            this.registerKeypad1.Location = new System.Drawing.Point(35, 66);
            this.registerKeypad1.Name = "registerKeypad1";
            this.registerKeypad1.Size = new System.Drawing.Size(305, 365);
            this.registerKeypad1.TabIndex = 0;
            this.registerKeypad1.ButtonClick1 += new System.EventHandler(this.Click1_EventHandler);
            this.registerKeypad1.ButtonClick2 += new System.EventHandler(this.Click2_EventHandler);
            this.registerKeypad1.ButtonClick3 += new System.EventHandler(this.Click3_EventHandler);
            this.registerKeypad1.ButtonClick4 += new System.EventHandler(this.Click4_EventHandler);
            this.registerKeypad1.ButtonClick5 += new System.EventHandler(this.Click5_EventHandler);
            this.registerKeypad1.ButtonClick6 += new System.EventHandler(this.Click6_EventHandler);
            this.registerKeypad1.ButtonClick7 += new System.EventHandler(this.Click7_EventHandler);
            this.registerKeypad1.ButtonClick8 += new System.EventHandler(this.Click8_EventHandler);
            this.registerKeypad1.ButtonClick9 += new System.EventHandler(this.Click9_EventHandler);
            this.registerKeypad1.ButtonClick0 += new System.EventHandler(this.Click0_EventHandler);
            this.registerKeypad1.ButtonClickClear += new System.EventHandler(this.ClickClear_EventHandler);
            this.registerKeypad1.ButtonClickPlus += new System.EventHandler(this.ClickPlus_EventHandler);
            this.registerKeypad1.ButtonClickEquals += new System.EventHandler(this.ClickEquals_EventHandler);
            this.registerKeypad1.ButtonClickMinus += new System.EventHandler(this.ClickMinus_EventHandler);
            this.registerKeypad1.ButtonClickMultiply += new System.EventHandler(this.ClickMultiply_EventHandler);
            this.registerKeypad1.ButtonClickDivide += new System.EventHandler(this.ClickDivide_EventHandler);
            this.registerKeypad1.ButtonClickDecimal += new System.EventHandler(this.ClickDecimal_EventHandler);
            // 
            // displayTestControl1
            // 
            this.displayTestControl1.Location = new System.Drawing.Point(402, 66);
            this.displayTestControl1.Name = "displayTestControl1";
            this.displayTestControl1.Size = new System.Drawing.Size(180, 88);
            this.displayTestControl1.TabIndex = 2;
            // 
            // buttonTestControl1
            // 
            this.buttonTestControl1.Location = new System.Drawing.Point(419, 145);
            this.buttonTestControl1.Name = "buttonTestControl1";
            this.buttonTestControl1.Size = new System.Drawing.Size(150, 150);
            this.buttonTestControl1.TabIndex = 3;
            //this.buttonTestControl1.TestButtonClick += new System.EventHandler(testButtonClicked_EventHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 447);
            this.Controls.Add(this.buttonTestControl1);
            this.Controls.Add(this.displayTestControl1);
            this.Controls.Add(this.displayControl1);
            this.Controls.Add(this.registerKeypad1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Keypad.RegisterKeypad registerKeypad1;
        private Display.DisplayControl displayControl1;
        private Display.DisplayTestControl displayTestControl1;
        private Keypad.ButtonTestControl buttonTestControl1;
    }
}

