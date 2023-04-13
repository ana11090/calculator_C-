namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {

            this.labelResult.Text = "";
            this.lbSymbols.Text = "";
            this.lbText.Text = "";
        }

        private void paste0(object sender, EventArgs e)
        {
          if (this.labelResult.Text == "")
                this.labelResult.Text = "";
          else
            this.labelResult.Text = this.labelResult.Text + "0";
        }

        private void paste1(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "1";
            else
            this.labelResult.Text = this.labelResult.Text + "1";
        }

        private void paste2(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "2";
            else
                this.labelResult.Text = this.labelResult.Text + "2";
        }

        private void paste3(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "3";
            else
                this.labelResult.Text = this.labelResult.Text + "3";
        }

        private void paste4(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "4";
            else
                this.labelResult.Text = this.labelResult.Text + "4";
        }

        private void paste5(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "5";
            else
                this.labelResult.Text = this.labelResult.Text + "5";
        }

        private void paste6(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "6";
            else
                this.labelResult.Text = this.labelResult.Text + "6";
        }

        private void paste7(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "7";
            else
                this.labelResult.Text = this.labelResult.Text + "7";
        }

        private void paste8(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "8";
            else
                this.labelResult.Text = this.labelResult.Text + "8";
        }

        private void paste9(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "9";
            else
                this.labelResult.Text = this.labelResult.Text + "9";
        }

        private void buttonProcent_Click(object sender, EventArgs e)
        {
            this.lbText.Text = this.labelResult.Text;
            this.labelResult.Text = "";
            this.lbSymbols.Text = "%";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            this.lbText.Text = this.labelResult.Text;
            this.labelResult.Text = "";
            this.lbSymbols.Text = "X";
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            this.lbText.Text = this.labelResult.Text;
            this.labelResult.Text = "";
            this.lbSymbols.Text = "-";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            this.lbText.Text = this.labelResult.Text;
            this.labelResult.Text = "";
            this.lbSymbols.Text = "+";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (this.labelResult.Text == "")
                this.labelResult.Text = "0.";
            else
                this.labelResult.Text = this.labelResult.Text + ".";
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            /*this.lbText.Text = this.labelResult.Text*/;
            double firstNumber = double.Parse(this.lbText.Text);
            double secondNumber = double.Parse(this.labelResult.Text);
            string symbol = this.lbSymbols.Text;
            double result = resultNumber(firstNumber, secondNumber, symbol);
            this.labelResult.Text = result.ToString();
            this.lbSymbols.Text = "=";
        }

        private double resultNumber(double firstNumber, double secondNumer, string symbol)
        {
            double result = 0;
            if (symbol == "-")
            {
                result = firstNumber - secondNumer;
            }
            else if (symbol == "+")
            {
                result = firstNumber + secondNumer;
            }
            else if (symbol == "%")
            {
                result = firstNumber / secondNumer;
            }
            else if (symbol == "X")
            {
                result = firstNumber * secondNumer;
            }

            return  result;
        }

        private void lbText_Click(object sender, EventArgs e)
        {

        }
    }
}