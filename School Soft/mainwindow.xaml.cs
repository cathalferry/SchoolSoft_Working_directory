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

namespace School_Soft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int textLogin = 0;
        int textPassword = 0;
      
    public MainWindow()
        {
            InitializeComponent();

            if ((textLogin == 1) && (textPassword == 1))
            {
                btnLogin.IsEnabled = true;
            }

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Admin_Dashboard Admin = new Admin_Dashboard();
 
            //Admin.Show();
            this.Hide();
            var Admin_dc = new Admin_Dashboard();
            Admin_dc.Closed += (s, args) => this.Close();
            Admin_dc.Show();

        }

        private void tbxUser_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void tbxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
          

            // if (tbxPassword.Text == String.Empty)
            //   {
            //       btnLogin.IsEnabled = false;
            //   }

            //   else
            //  {
            //   btnLogin.IsEnabled = true;
            //  }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {


            Close();
        }
        
}
}
