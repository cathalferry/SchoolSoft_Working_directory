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
        
 
        List<Login_Table> userList = new List<Login_Table>();
      //  SchoolSoftEntities dbEntities = new SchoolSoftEntities();
        SS_UPADATEDEntities2 dbEntities = new SS_UPADATEDEntities2();
        public MainWindow()
        {
            
            InitializeComponent();
            

        }
        private void mtdLoadUsers()  //preload user list on 'Window loaded' at runtime
        {
            userList.Clear();//clear list pre reload
            foreach (var user in dbEntities.Login_Table) //fill list 'UserList' with user data from DB
            {
                userList.Add(user);
            }

        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            Login_Table userDetails = new Login_Table(); //new instance of login table from SQL database
            string currentuser = tbxUser.Text.Trim();//removing spaces with trim  get user detials
            string curentpassword = tbxPassword.Password; //use password box to hide character entry
            userDetails = mtdGetUserDetails(currentuser, curentpassword);//check if details exist in DB

            if (userDetails.Admin_Status== 2)  //ADMIN details entered
            {
                Admin_Dashboard Admin = new Admin_Dashboard();//open admin dash
                
             

                Admin.login = userDetails; //pass userdetails to dashboard page
                this.Hide(); //hide login page
                Admin.ShowDialog(); //show admin dashboard
               
            }
            else if (userDetails.Admin_Status == 1)  //Student account
            {

                Student_Dash Student_View = new Student_Dash();  //new student dashboard instance
                Student_View.login = userDetails;  //pass login details to dashboard    
                this.Hide(); //hide login page
                Student_View.ShowDialog(); //show student dash
       
            }
            else
            {
                lblLoginInformation.Content = "Invalid Login Details!";
                tbxUser.Background = Brushes.Red;
                tbxPassword.Background = Brushes.Red;
                tbxPassword.Password = "";
                tbxUser.Text = "";
                tbxUser.Focus();
      
            }
        }


      public Login_Table mtdGetUserDetails(string username, string password) //Method checks if entered details are in SQL DB
        {
            Login_Table UserDetails = new School_Soft.Login_Table();
            foreach (var user in userList)
            {
                if (username == user.UserID && password == user.Password)
                {
                    UserDetails = user;
                }

            }
            return UserDetails;
         

        }



       

        

        private void tbxUser_TextChanged(object sender, TextChangedEventArgs e)
        {
      



        }

        private void tbxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
          

    
        }

        private void btnExit_Click(object sender, RoutedEventArgs e) //Exit button code, confirms application shutdown and gracefuly close
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit the Application", "Information", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                
                Close();
                Environment.Exit(0);
            }
           





        }
        private void Window_Loaded(object sender, RoutedEventArgs e)  //functions that are preloaded on runtime
        {
            mtdLoadUsers();  //get a list of users
        }
}
}
