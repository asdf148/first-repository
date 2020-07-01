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

namespace 계산기
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aa = 0, bb = 0, a = 0, b = 0, num = 0, n = 0, m = 0;
        float a2 = 0, b2 = 0, num2 = 0;
        string front,back;
        public MainWindow()
        {
            InitializeComponent();


        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            aa = 0;
            bb = 0;
            a = 0;
            b = 0;
            write.Content = 0;
            result.Content = 0;
        }
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            b = aa;
            if (bb == 1)
            {
                num = a + b;
                result.Content = front + write.Content + "=\n" + num;

            }
            else if (bb == 2)
            {
                num = a - b;
                result.Content = front + write.Content + "=\n" + num;
            }
            else if (bb == 3)
            {
                a2 = (float)a;
                b2 = (float)b;
                num2 = a2 / b2;
                result.Content = front + write.Content + "=\n" + num2;

            }
            else if (bb == 4)
            {
                num = a * b;
                result.Content = front + write.Content + "=\n" + num;
            }
            
            if (a == 0 && b == 0)
            {
                num = 0;
                result.Content = front + write.Content + "=\n" + num;
            }
            //result.Content = front + write.Content + "=" + num;
            a = 0;
            b = 0;
            aa = 0;
            front = " ";
            write.Content = 0;
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            bb = 4;
            result.Content = write.Content + "x";
            front = write.Content + "x";
            a = aa;
            aa = 0;
            write.Content = 0;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            bb = 3;
            result.Content = write.Content + "÷";
            front= write.Content + "÷";
            a = aa;
            aa = 0;
            write.Content = 0;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            bb = 2;
            result.Content = write.Content + "-";
            front = write.Content + "-";
            a = aa;
            aa = 0;
            write.Content = 0;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            bb = 1;
            result.Content = write.Content+ "+";
            front = write.Content + "+";
            a = aa;
            aa = 0;
            write.Content = 0;
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 1;
            aa = aa * 10 + 1;

        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 2;
            aa = aa * 10 + 2;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 3;
            aa = aa * 10 + 3;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 4;
            aa = aa * 10 + 4;
        }
        private void five_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 5;
            aa = aa * 10 + 5;
        }
        private void six_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 6;
            aa = aa * 10 + 6;
        }
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 7;
            aa = aa * 10 + 7;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 8;
            aa = aa * 10 + 8;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 9;
            aa = aa * 10 + 9;

        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            write.Content = aa * 10 + 0;
            aa = aa * 10 + 0;
        }
    }
}
