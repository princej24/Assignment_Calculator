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

namespace EXTRA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        // Variables to store the first and second operands, and the operato
        double first;
        double second;


        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the button that was clicked
            Button Btn = (Button)sender;
            Txtsign.Text = op.ToString();// diplay the sign that the user picked in a diffrent box 
            TxtResults.Text += Btn.Content.ToString();// Display the button content in TxtResults


        }

        private void Btndivide_Click(object sender, RoutedEventArgs e)
        {
            // Store the first operand
            first = double.Parse(TxtResults.Text);
            TxtResults2.Text = TxtResults.Text;
            second = double.Parse(TxtResults.Text);

            // Store the operator '/'
            op = '/';
            //clear text resualts 
            TxtResults.Clear();

        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(TxtResults.Text);
            TxtResults2.Text = TxtResults.Text;
            op = '*';

            TxtResults.Clear();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            first = double.Parse(TxtResults.Text);
            TxtResults2.Text = TxtResults.Text;
            op = '+';

            TxtResults.Clear();
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            first = double.Parse(TxtResults.Text);
            TxtResults2.Text = TxtResults.Text;
            op = '-';
            TxtResults.Clear();




        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            double second = Double.Parse(TxtResults.Text, System.Globalization.NumberStyles.AllowDecimalPoint);
            // convert the string in TxtResults to double and store it in variable second
            TxtResults2.Text += " " + op + " " + second;
            Txtsign.Text = op.ToString();

            double result = 0;
            // check if the operator is '+'
            if (op == '+')
            {
                // if true, add the value of first and second and store it in 'result
                result = first + second;
            }
            if (op == '-')
            {
                result = first - second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            else if (op == '/')
            {
                result = first / second;

            }
            // check if the TxtResults is equal to "0"
            if (TxtResults.Text == "0")
            {
                // if true, clear the text of TxtResults and TxtResults2
                // TxtResults2.Text = result.ToString();
                TxtResults.Clear();
                TxtResults2.Clear();
            }
            TxtResults.Text = result.ToString();
            if (op == '.')
            {
            }

        }

        private void BtnDecimal_Click(object sender, RoutedEventArgs e)
        {
            Button Btn = (Button)sender;
            if (Btn.Content.ToString() == ".")// checks if the button clicked is a decimal 
            {
                TxtResults.Text += ".";
            }
            else
            {
                // if false concatenate the content of the button to TxtResults and parse it to a double value and store it in first
                TxtResults.Text += Btn.Content.ToString();
                first = double.Parse(Txtsign.Text);
                //  TxtResults2.Text += Btn.Content.ToString();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtResults.Clear();
            TxtResults2.Clear();
            Txtsign.Clear();

        }

        private void BtnclearAll_Click(object sender, RoutedEventArgs e)
        {
            TxtResults.Clear();
            TxtResults2.Clear();
            Txtsign.Clear();

        }


    }
}

