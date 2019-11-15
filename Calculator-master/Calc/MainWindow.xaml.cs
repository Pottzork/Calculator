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


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private double total1 = 0;
        private double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonClicked = false;
        bool percentageButtonClicked = false;



        private void AppendValue(int value)
        {
            if (textBox_Result.Text == "0")
            {
                textBox_Result.Text = value.ToString();
            }
            else
            {
                textBox_Result.AppendText(value.ToString());
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text = "0";
            //labelCurrentOperation.Content = "";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text = "0";
            labelCurrentOperation.Content = "";

        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = total1 + "+" + double.Parse(textBox_Result.Text);
                textBox_Result.Text = total2.ToString();
                total1 = 0;
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = total1 + "-" + double.Parse(textBox_Result.Text);
                textBox_Result.Text = total2.ToString();
                total1 = 0;
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = total1 + "*" + double.Parse(textBox_Result.Text);
                textBox_Result.Text = total2.ToString();
                total1 = 0;
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = total1 + "/" + double.Parse(textBox_Result.Text);
                textBox_Result.Text = total2.ToString();
                total1 = 0;
            }
            //else if (percentageButtonClicked == true)
            //{
            //    //A + (A × B/100) 
            //    total2 = total1 + (total1 * double.Parse(textBox_Result.Text));
            //    labelCurrentOperation.Content = total1 + "%" + double.Parse(textBox_Result.Text);
            //    textBox_Result.Text = total2.ToString();
            //    total1 = 0;
            //}
            //else if (sqrRootButtonClicled == true)
            //{
            //    total2 = total1;
            //    total2 = Math.Sqrt(total2);
            //    labelCurrentOperation.Content = "√" + double.Parse(textBox_Result.Text);
            //    textBox_Result.Text = total2.ToString();
            //    total1 = 0;
            //}
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            int i = textBox_Result.Text.Length;
            if (textBox_Result.Text.Length > 0)
            {
                textBox_Result.Text = textBox_Result.Text.Substring(0, textBox_Result.Text.Length - 1);
            }
            

        }

        private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_Result.Text.StartsWith("-"))
            {
                //It's negative now, so strip the `-` sign to make it positive
                textBox_Result.Text = textBox_Result.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(textBox_Result.Text) && decimal.Parse(textBox_Result.Text) != 0)
            {
                //It's positive now, so prefix the value with the `-` sign to make it negative
                textBox_Result.Text = "-" + textBox_Result.Text;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(9);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(6);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(3);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            AppendValue(0);
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "+";
            textBox_Result.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "-";
            textBox_Result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "*";
            textBox_Result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result.Text + "/";
            textBox_Result.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if (!textBox_Result.Text.Contains(","))
            {
                textBox_Result.Text += ",";
            }
            
        }

        private void btnSqrRoot_Click(object sender, RoutedEventArgs e)
        {
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = "√" + "(" + textBox_Result.Text + ")";
            textBox_Result.Text = Math.Sqrt(total1).ToString();
            total1 = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            
        }

        private void btnPercentage_Click(object sender, RoutedEventArgs e)
        {
            //A + (A × B/100) 
            
            total2 = total1 + (total1 * double.Parse(textBox_Result.Text) / 100);
            total1 += double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = textBox_Result + "%";
            textBox_Result.Text = total2.ToString();
            total1 = 0;

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            //percentageButtonClicked = true;
        }
    }
}
