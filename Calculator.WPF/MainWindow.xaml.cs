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

namespace Calculator.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNum;
        string op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "1";
            }
            else
            {
                textbox.Text = textbox.Text + "1";
            }
        }
        
        private void button_2_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "2";
            }
            else
            {
                textbox.Text = textbox.Text + "2";
            }
        }
        
        private void button_3_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "3";
            }
            else
            {
                textbox.Text = textbox.Text + "3";
            }
        }
        
        private void button_4_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "4";
            }
            else
            {
                textbox.Text = textbox.Text + "4";
            }
        }
        
        private void button_5_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "5";
            }
            else
            {
                textbox.Text = textbox.Text + "5";
            }
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "6";
            }
            else
            {
                textbox.Text = textbox.Text + "6";
            }
        }private void button_7_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "7";
            }
            else
            {
                textbox.Text = textbox.Text + "7";
            }
        }private void button_8_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "8";
            }
            else
            {
                textbox.Text = textbox.Text + "8";
            }
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "0" && textbox.Text != null)
            {
                textbox.Text = "9";
            }
            else
            {
                textbox.Text = textbox.Text + "9";
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
                       
                textbox.Text = textbox.Text + "0";
            
        }

        private void button_dev_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(textbox.Text);
            op = "/";
            textbox.Clear();
        }
        private void button_mult_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(textbox.Text);
            op = "*";
            textbox.Clear();
        }
        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(textbox.Text);
            op = "-";
            textbox.Clear();
        }
        private void button_sub_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(textbox.Text);
            op = "+";
            textbox.Clear();
        }

        private void button_kok_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(textbox.Text);
            op = "^";
        }
        private void button_del_Click(object sender, RoutedEventArgs e)
        {
            textbox.Clear();
        }

        private void button_equal_Click(object sender, RoutedEventArgs e)
        {
            double secondNum;
            secondNum = Convert.ToDouble(textbox.Text);

            double result;
            if (op == "+")
            {
                result = (firstNum + secondNum);
                textbox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (op == "-")
            {
                result = (firstNum - secondNum);
                textbox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (op == "*")
            {
                result = (firstNum * secondNum);
                textbox.Text = Convert.ToString(result);
                firstNum = result;
            }
            if (op == "/")
            {
                if (secondNum == 0)
                {
                    textbox.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (firstNum / secondNum);
                    textbox.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
            if (op == "^")
            {
                result = Math.Round(Math.Sqrt(firstNum));
                textbox.Text = Convert.ToString(result);
                firstNum = result;
            }
        }

    }
}
