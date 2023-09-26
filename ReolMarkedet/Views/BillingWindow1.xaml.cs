using ReolMarkedet.ViewModels;
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
using System.Windows.Shapes;

namespace ReolMarkedet.Views
{
    /// <summary>
    /// Interaction logic for BillingWindow1.xaml
    /// </summary>
    public partial class BillingWindow1 : Window
    {
        public BillingWindow1(BillingViewModel billingViewModel)
        {
            DataContext = billingViewModel.Billing;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Udbetaling gennemført", "Udbetaling", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
