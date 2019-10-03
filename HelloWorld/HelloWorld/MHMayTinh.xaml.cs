using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MHMayTinh : ContentPage
	{
        private double number1 = 0;

        private double number2 = 0;

        private enum Status {number1, number2 };

        private Status status = Status.number1;

		public MHMayTinh ()
		{
			InitializeComponent ();
		}

        private void BtnC_Clicked(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            status = Status.number1;
            txtOperator.Text = "";
        }

        private void BtnOpposite_Clicked(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text[0] == '-' ? txtResult.Text.Substring(1) : $"-{txtResult.Text}";
        }

        private void BtnMod_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnDiv_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnNum7_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "7";
            else
                txtResult.Text += "7";
            
        }

        private void BtnNum8_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "8";
            else
                txtResult.Text += "8";
        }

        private void BtnNum9_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "9";
            else
                txtResult.Text += "9";
        }

        private void BtnMulti_Clicked(object sender, EventArgs e)
        {
            
        }

        private void BtnNum4_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "4";
            else
                txtResult.Text += "4";
        }

        private void BtnNum5_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "5";
            else
                txtResult.Text += "5";
        }

        private void BtnNum6_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "6";
            else
                txtResult.Text += "6";
        }

        private void BtnSub_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnNum1_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "1";
            else
                txtResult.Text += "1";
        }

        private void BtnNum2_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "2";
            else
                txtResult.Text += "2";
        }

        private void BtnNum3_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "3";
            else
                txtResult.Text += "3";
        }

        private void BtnPlus_Clicked(object sender, EventArgs e)
        {
            if (status == Status.number1)
            {
                number1 = double.Parse(txtResult.Text);
                txtOperator.Text = "+";
                txtResult.Text = "0";
                status = Status.number2;
            }
            else
            {
                number2 = double.Parse(txtResult.Text);
            }
        }

        private void BtnNum0_Clicked(object sender, EventArgs e)
        {
            if (txtResult.Text[0] == '0')
                txtResult.Text = "0";
            else
                txtResult.Text += "0";
        }

        private void BtnDoc_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEquad_Clicked(object sender, EventArgs e)
        {
            number2 = double.Parse(txtResult.Text);
            txtResult.Text = (number1 + number2).ToString();
            status = Status.number1;
            txtOperator.Text = "";
        }
    }
}