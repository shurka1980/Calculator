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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 447);
            this.Controls.Add(this.displayControl1);
            this.Controls.Add(this.registerKeypad1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            registerKeypad1.ButtonClick1 += new System.EventHandler(Click1_EventHandler);
            registerKeypad1.ButtonClick2 += new System.EventHandler(Click2_EventHandler);
            registerKeypad1.ButtonClick3 += new System.EventHandler(Click3_EventHandler);
            registerKeypad1.ButtonClick4 += new System.EventHandler(Click4_EventHandler);
            registerKeypad1.ButtonClick5 += new System.EventHandler(Click5_EventHandler);
            registerKeypad1.ButtonClick6 += new System.EventHandler(Click6_EventHandler);
            registerKeypad1.ButtonClick7 += new System.EventHandler(Click7_EventHandler);
            registerKeypad1.ButtonClick8 += new System.EventHandler(Click8_EventHandler);
            registerKeypad1.ButtonClick9 += new System.EventHandler(Click9_EventHandler);
            registerKeypad1.ButtonClick0 += new System.EventHandler(Click0_EventHandler);
            registerKeypad1.ButtonClickClear += new System.EventHandler(ClickClear_EventHandler);
            registerKeypad1.ButtonClickPlus += new System.EventHandler(ClickPlus_EventHandler);
            registerKeypad1.ButtonClickEquals += new System.EventHandler(ClickEquals_EventHandler);
            registerKeypad1.ButtonClickMinus += new System.EventHandler(ClickMinus_EventHandler);
            registerKeypad1.ButtonClickMultiply += new System.EventHandler(ClickMultiply_EventHandler);
            registerKeypad1.ButtonClickDivide += new System.EventHandler(ClickDivide_EventHandler);
            registerKeypad1.ButtonClickDecimal += new System.EventHandler(ClickDecimal_EventHandler);


        }

        #endregion

        private Keypad.RegisterKeypad registerKeypad1;
        private Display.DisplayControl displayControl1;
    }
}

