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

namespace _1_GraphicalCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operation;
        int num1;
        public MainWindow()
        {
            InitializeComponent();
            Display.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button numbutton = (Button)sender;
            Display.Text += numbutton.Content.ToString();
           
            
        }

        private void Button_Click_clear(object sender, RoutedEventArgs e)
        {
            Button clearButton = (Button)sender;
            Display.Clear();
        }

        private void Button_Click_result(object sender, RoutedEventArgs e)
        {
            try
            {
                Result();
            }
            catch(Exception)
            {
                Display.Text = "Error";
            }
        }

        private void Result()
        {
            int num2 = Convert.ToInt32(Display.Text);
            if(operation == "+")
            {
                Display.Text = Convert.ToString(num1 + num2);
            }else if(operation == "-")
            {
                Display.Text = Convert.ToString(num1 - num2);
            }
            else if(operation == "*")
            {
                Display.Text = Convert.ToString(num1 * num2);
            }
            else if(operation == "/")
            {
                Display.Text = Convert.ToString(num1 / num2);
            }
            else
            {
                Display.Text = "Error";
            }
        }
        
        private void Button_Click_operator(object sender, RoutedEventArgs e)
        {
            Button operatorButton = (Button)sender;
            operation = operatorButton.Content.ToString();
            if (Display.Text != null)
            {
                num1 = Convert.ToInt32(Display.Text);
                Display.Clear();
            }
            else
            {
                Display.Text = "Error";
            }
        }
    }
}
