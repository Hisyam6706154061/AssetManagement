using AssetManagement.UserControl;
using Common.Repository.Application;
using DataAccess.Context;
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

namespace AssetManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyContext myContext = new MyContext();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }
        private void Login()
        {
            LoginRepository loginRepository = new LoginRepository();
            if (loginRepository.CheckLogin(txb_email.Text, pwb_password.Password) == true)
            {
                this.Hide();
                if (loginRepository.CheckAdmin(txb_email.Text, pwb_password.Password) == true)
                {
                    UIDashboardAdmin dashboard = new UIDashboardAdmin();
                    dashboard.Show();
                }
                else if (loginRepository.CheckHeadDivision(txb_email.Text, pwb_password.Password) == true)
                {
                    UIDashboardHeadDivision dashboard = new UIDashboardHeadDivision();
                    dashboard.Show();
                }
                else
                {
                    DashboardEmployee dashboard = new DashboardEmployee();
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Login Failed", "Warning!", MessageBoxButton.OK, MessageBoxImage.Information);
                pwb_password.Clear();
                pwb_password.Focus();
            }
        }
    }
}
