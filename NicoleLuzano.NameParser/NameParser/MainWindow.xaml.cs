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

namespace NameParser
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string fullName = txtFullName.Text;

            var firstComma = fullName.IndexOf(",");
            var lastName = fullName.Substring(0, firstComma);
            lblLastName.Content = "Last Name: " + lastName;

            var secondComma = fullName.IndexOf(",");
            var firstName = fullName.Substring(firstComma + 1, secondComma!);
            lblFistName.Content = ("First Name " + firstName);


        }
    }
}