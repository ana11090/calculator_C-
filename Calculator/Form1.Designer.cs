namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnProcent = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.lbSymbols = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 46);
            this.button1.TabIndex = 0;
            this.button1.Tag = "buttonC";
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // btnProcent
            // 
            this.btnProcent.Location = new System.Drawing.Point(231, 70);
            this.btnProcent.Name = "btnProcent";
            this.btnProcent.Size = new System.Drawing.Size(67, 46);
            this.btnProcent.TabIndex = 1;
            this.btnProcent.Tag = "buttonProcent";
            this.btnProcent.Text = "%";
            this.btnProcent.UseVisualStyleBackColor = true;
            this.btnProcent.Click += new System.EventHandler(this.buttonProcent_Click);
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(12, 24);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(286, 31);
            this.labelResult.TabIndex = 12;
            this.labelResult.Tag = "labelResult";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 46);
            this.button3.TabIndex = 13;
            this.button3.Tag = "button7";
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.paste7);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 46);
            this.button4.TabIndex = 14;
            this.button4.Tag = "button8";
            this.button4.Text = "8";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.paste8);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(158, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 46);
            this.button5.TabIndex = 15;
            this.button5.Tag = "button9";
            this.button5.Text = "9";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.paste9);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(231, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 46);
            this.button6.TabIndex = 16;
            this.button6.Tag = "buttonMultiplicatin";
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 183);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 46);
            this.button7.TabIndex = 17;
            this.button7.Tag = "button4";
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.paste4);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(85, 183);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 46);
            this.button8.TabIndex = 18;
            this.button8.Tag = "button5";
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.paste5);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(158, 183);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 46);
            this.button9.TabIndex = 19;
            this.button9.Tag = "button6";
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.paste6);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(231, 183);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 46);
            this.button10.TabIndex = 20;
            this.button10.Tag = "buttonSubstraction";
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 235);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 46);
            this.button11.TabIndex = 21;
            this.button11.Tag = "button1";
            this.button11.Text = "1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.paste1);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(85, 235);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 46);
            this.button12.TabIndex = 22;
            this.button12.Tag = "button2";
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.paste2);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(158, 235);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(67, 46);
            this.button13.TabIndex = 23;
            this.button13.Tag = "button3";
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.paste3);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(231, 235);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 46);
            this.button14.TabIndex = 24;
            this.button14.Tag = "buttonAddition";
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 287);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 46);
            this.button15.TabIndex = 25;
            this.button15.Tag = "buttonPoint";
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(85, 287);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(67, 46);
            this.button16.TabIndex = 26;
            this.button16.Tag = "button0";
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.paste0);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(158, 287);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(140, 46);
            this.button17.TabIndex = 27;
            this.button17.Tag = "buttonEqual";
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // lbSymbols
            // 
            this.lbSymbols.AutoSize = true;
            this.lbSymbols.Location = new System.Drawing.Point(286, 9);
            this.lbSymbols.Name = "lbSymbols";
            this.lbSymbols.Size = new System.Drawing.Size(0, 15);
            this.lbSymbols.TabIndex = 28;
            // 
            // lbText
            // 
            this.lbText.Location = new System.Drawing.Point(12, 3);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(256, 15);
            this.lbText.TabIndex = 29;
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbText.Click += new System.EventHandler(this.lbText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 364);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbSymbols);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnProcent);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnProcent;
        private Label labelResult;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Label lbSymbols;
        private Label lbText;
    }
}