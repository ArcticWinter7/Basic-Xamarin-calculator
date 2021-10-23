using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_calculator_6
{
    public partial class MainPage : ContentPage
    {
        public string equation = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Number_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;                     //i have no idea how this line works

            equation += button.Text.ToString();

            num.Text = equation;
        }
        private void calc_Clicked(object sender, EventArgs e)
        {
            solverClass solve = new solverClass();

            double solution = solve.Eval(equation);

            num.Text = solution.ToString();
        }
        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            equation = "";
            num.Text = "";
        }
        //private void toPositive_Clicked(object sender, EventArgs e)
        //{
            
        //}
        //private void toNegitive_Clicked(object sender, EventArgs e)
        //{

        //}
    }
}
