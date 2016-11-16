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
    /// Interaction logic for Student_Dash.xaml
    /// </summary>
    public partial class Student_Dash : Window
    {
      //  SchoolSoftEntities dbEntities = new SchoolSoftEntities();
        public Login_Table login = new Login_Table();
        public Student_Table userDetails= new Student_Table();
        List<Student_Table> students = new List<Student_Table>();
        
     

        public Student_Dash()
        {
            
            InitializeComponent();
        }

    

        private void btnCourse_Click(object sender, RoutedEventArgs e)
        {


            Student_My_Courses Student_Courses = new Student_My_Courses();

            Student_Courses.user = login;

            Student_Courses.ShowDialog();
    
            
        }

        private void btnFees_Click(object sender, RoutedEventArgs e)
        {
          //  Login_Table UserDetails = new Login_Table();
            Student_Tuition Student_Fees = new Student_Tuition();
            
            Student_Fees.user= login;
            
            Student_Fees.ShowDialog();
        }




 
   
        

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Are you sure you want to logout!", "Confirm Logout", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {

                MainWindow Main_Win = new MainWindow();
                this.Hide();
                Main_Win.ShowDialog();
            }

        }
 
       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            lblUser.Content = login.UserID;
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
          
            Window2 Student_Details = new Window2();
            Student_Details.user = login;

            Student_Details.ShowDialog();


        }
    }
}
