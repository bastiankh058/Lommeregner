using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Lommeregner1
{
    public partial class MainWindow : Window
    {
        public MainWindow(){
            InitializeComponent();
        }

        private void Addition_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("+");
        }

        private void Subtraction_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("-");
        }

        private void Multiplication_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("*");
        }

        private void Division_ButtonClicked(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("/");
        }
        private void CalculateWithOperator(string operatorString)
        {

            string firstInput = firstinput_textbox.Text;
            string secondInput = secondinput_textbox.Text;
            string firstInputFormatted = Regex.Replace(firstInput, @"\s+", "");
            string secondInputFormatted = Regex.Replace(secondInput, @"\s+", "");
            if (Regex.IsMatch(firstInputFormatted, @"^-?[0-9]+,?([0-9]+)?$") && Regex.IsMatch(secondInputFormatted, @"^-?[0-9]+,?([0-9]+)?$"))
            {
                firstinput_textbox.Text = firstInputFormatted;
                secondinput_textbox.Text = secondInputFormatted;
                error_Textbox.Text = "";

                if (firstInputFormatted != "" && secondInputFormatted != "")
                {

                    double firstinput = Convert.ToDouble(firstInputFormatted);
                    double secondinput = Convert.ToDouble(secondInputFormatted);

                    double result = 0;

                    switch (operatorString)
                    {
                        case "+":
                            result = firstinput + secondinput;
                            break;
                        case "-":
                            result = firstinput - secondinput;
                            break;
                        case "*":
                            result = firstinput * secondinput;
                            break;
                        case "/":
                            result = firstinput / secondinput;
                            break;
                    }
                    result_Textbox.Text = result + "";
                }

            }
            else
            {
                error_Textbox.Text = "Kæmpe FEJL!";
                return;
            }
        }
       
    }
}
