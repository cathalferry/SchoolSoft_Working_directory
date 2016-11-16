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

namespace School_Soft
{
    /// <summary>
    /// Interaction logic for Admin_Dashboard.xaml
    /// </summary>
    public partial class Admin_Dashboard : Window
    {
        public Login_Table login = new Login_Table();
      

        public Admin_Dashboard()
        {
            InitializeComponent();
        }

 

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Admin_Create_Student_Account create_student = new Admin_Create_Student_Account();
            create_student.ShowDialog();
        }

        private void btnCourse_Click(object sender, RoutedEventArgs e)
        {
            Admin_Create_Edit_Courses edit_course = new Admin_Create_Edit_Courses();
            edit_course.ShowDialog();
        }

        private void btnFees_Copy_Click(object sender, RoutedEventArgs e)
        {
            Admin_Search_Records  search = new Admin_Search_Records();
            search.ShowDialog();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to logout!", "Confirm Logout", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow Main_Win = new MainWindow();


                this.Hide();
                var Main_dc = new MainWindow();
                Main_dc.Closed += (s, args) => this.Close();
                Main_dc.Show();

           
            }
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblUserinfo.Content = login.UserID;
        }
    }
}
