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

namespace myfirstwpfapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastnumber, ansresult;
        SelectedOperator selectedOperator;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void acButton_Click(object sender, RoutedEventArgs e)
        {
            result.Content = "0";
            ansresult = 0;
            lastnumber = 0;
        }

        private void negativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(result.Content.ToString(),out lastnumber))
            {
                lastnumber = lastnumber * -1;
                result.Content = lastnumber.ToString();
            }
        }

        private void percentageButton_Click(object sender, RoutedEventArgs e)
        {
            double tempnumber;
            if (double.TryParse(result.Content.ToString(), out tempnumber))
            {
                tempnumber = tempnumber /100;
                if (lastnumber!=0)
                {
                    tempnumber *= lastnumber;
                }
                result.Content = tempnumber.ToString();
            }
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString()=="0")
            {
                result.Content = "7";
            }
            else
            {
                result.Content = $"{ result.Content}7";
            }
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "8";
            }
            else
            {
                result.Content = $"{ result.Content}8";
            }
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "9";
            }
            else
            {
                result.Content = $"{ result.Content}9";
            }
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "4";
            }
            else
            {
                result.Content = $"{ result.Content}4";
            }
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "5";
            }
            else
            {
                result.Content = $"{ result.Content}5";
            }
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "6";
            }
            else
            {
                result.Content = $"{ result.Content}6";
            }
        }

        private void substractButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "1";
            }
            else
            {
                result.Content = $"{ result.Content}1";
            }
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "2";
            }
            else
            {
                result.Content = $"{ result.Content}2";
            }
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "3";
            }
            else
            {
                result.Content = $"{ result.Content}3";
            }
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString() == "0")
            {
                result.Content = "0";
            }
            else
            {
                result.Content = $"{ result.Content}0";
            }
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            if (result.Content.ToString().Contains("."))
            {
                //Do nothing
            }
            else
            {
                result.Content = $"{ result.Content}.";
            }
        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            double newnumber;
            if (double.TryParse(result.Content.ToString(), out newnumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Add:
                        ansresult = SimpleMath.Add(lastnumber, newnumber);
                        result.Content = ansresult;
                        break;
                    case SelectedOperator.Division:
                        ansresult = SimpleMath.Division(lastnumber, newnumber);
                        result.Content = ansresult;
                        break;
                    case SelectedOperator.Multiplication:
                        ansresult = SimpleMath.Multiplication(lastnumber, newnumber);
                        result.Content = ansresult;
                        break;
                    case SelectedOperator.Substract:
                        ansresult = SimpleMath.Substract(lastnumber, newnumber);
                        result.Content = ansresult;
                        break;
                }
            }
        }
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(result.Content.ToString(), out lastnumber))
            {
                result.Content = "0";
            }
            if (sender == multiplyButton )
            {
                selectedOperator = SelectedOperator.Multiplication;
            }
            if (sender == divisionButton)
            {
                selectedOperator = SelectedOperator.Division;
            }
            if (sender == plusButton)
            {
                selectedOperator = SelectedOperator.Add;
            }
            if (sender == substractButton)
            {
                selectedOperator = SelectedOperator.Substract;
            }
        }
        public enum SelectedOperator
        {
            Add,
            Substract,
            Division,
            Multiplication
 
        }
        public class SimpleMath
        {
            public static double Add(double n1, double n2)
            {
                return n1 + n2;
            }
            public static double Substract(double n1, double n2)
            {
                return n1 - n2;
            }
            public static double Division(double n1, double n2)
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Division by 0 is not supported", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
                    return 0;
                }
                return n1 / n2;
            }
            public static double Multiplication(double n1, double n2)
            {
                return n1 * n2;
            }
        }
    }
}
