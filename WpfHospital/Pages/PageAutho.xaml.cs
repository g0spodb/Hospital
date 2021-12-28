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
using Core;

namespace WpfHospital.Pages
{
    /// <summary>
    /// Interaction logic for PageAutho.xaml
    /// </summary>
    public partial class PageAutho : Page
    {
        public PageAutho()
        {
            InitializeComponent();
        }
        private void btnRegistClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.PageRegist());
        }
        private void btnConnectClick(object sender, RoutedEventArgs e)
        {
            var login = tblogin.Text;
            var password = pbpassword.Password;

            if (DataAccess.IsCorrectLogin(login, password))
            {
                NavigationService.Navigate(new Pages.Home());
            }
            else
            {
                MessageBox.Show("Invalid login or password", "Error");
            }
        }
    }
}
