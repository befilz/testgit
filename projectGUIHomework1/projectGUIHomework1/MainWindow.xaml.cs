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

namespace projectGUIHomework1
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


        private void txt_Income_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_Target_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double income = double.Parse(txt_Income.Text);
                double expenses = double.Parse(txt_Expenses.Text);
                double target = double.Parse(txt_Target.Text);


                if (income > expenses)
                {
                    double total = target / (income - expenses);
                    txt_Total.Text = total.ToString();
                }

                else
                {
                    MessageBox.Show("You don't have enough funds for this");
                }


            }
            catch
            {
                try
                {

                    if ((txt_Income.Text == "") || (txt_Expenses.Text == "") || (txt_Target.Text == ""))
                    {

                        MessageBox.Show("Please fill your infomation completely ");

                    }
                    else
                    {

                        MessageBox.Show("Can't process");

                    }
                }
                catch
                {
                    MessageBox.Show("Please Try again");
                }
                

            }

        }

        private void txt_Total_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

   

}
