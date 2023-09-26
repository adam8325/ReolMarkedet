using ReolMarkedet.Models;
using ReolMarkedet.ViewModels;
using ReolMarkedet.Views;
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

namespace ReolMarkedet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _mainViewModel = new MainViewModel();
        public MainWindow()
        {
            DataContext = _mainViewModel;
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var button = (sender as Button);
            var shelfTenant = (button?.DataContext as ShelfTenant);
            if (shelfTenant != null)
            {
                var viewModel = new BillingViewModel(shelfTenant.ShelfTenantId);
                Opacity = 0.4;
                BillingWindow1 billingwindow = new BillingWindow1(viewModel);
                billingwindow.ShowDialog();

                Opacity = 1;
            }
        }
    }
}
