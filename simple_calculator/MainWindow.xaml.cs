using System;
using System.Collections.Generic;
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

namespace simple_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstNumber;
        string Operation;
        bool DecimalIsPresent = false;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if(numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "1";
            }
            else
            {
                numberBox.Text += "1";
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "2";
            }
            else
            {
                numberBox.Text += "2";
            }
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "3";
            }
            else
            {
                numberBox.Text += "3";
            }
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "4";
            }
            else
            {
                numberBox.Text += "4";
            }
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "5";
            }
            else
            {
                numberBox.Text += "5";
            }
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "6";
            }
            else
            {
                numberBox.Text += "6";
            }
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "7";
            }
            else
            {
                numberBox.Text += "7";
            }
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "8";
            }
            else
            {
                numberBox.Text += "8";
            }
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            if (numberBox.Text == "0" && numberBox.Text != null)
            {
                numberBox.Text = "9";
            }
            else
            {
                numberBox.Text += "9";
            }
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            numberBox.Text += "1";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            numberBox.Text = "0";
        }

        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            if(DecimalIsPresent == false)
            {
                numberBox.Text += ".";
                DecimalIsPresent = true;
            }   
        }

        private void AdditionButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(numberBox.Text);
            numberBox.Text = "0";
            Operation = "+";
        }

        private void Subtractionbutton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(numberBox.Text);
            numberBox.Text = "0";
            Operation = "-";
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(numberBox.Text);
            numberBox.Text = "0";
            Operation = "*";
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(numberBox.Text);
            numberBox.Text = "0";
            Operation = "/";
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double SecondNumber = Convert.ToDouble(numberBox.Text);
            double Result;

            if(Operation == "+")
            {
                Result = FirstNumber + SecondNumber;
                numberBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "-")
            {
                Result = FirstNumber - SecondNumber;
                numberBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if(Operation == "*")
            {
                Result = FirstNumber * SecondNumber;
                numberBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if(Operation == "/")
            {
                Result = FirstNumber / SecondNumber;
                numberBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}
