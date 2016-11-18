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
    /// Interaction logic for Admin_Search_Records.xaml
    /// </summary>
    public partial class Admin_Search_Records : Window
    {

        SS_UPADATEDEntities2 dbEntitiesCourses = new SS_UPADATEDEntities2();
        public Login_Table user = new Login_Table();
        List<Student_Table> studentlist = new List<Student_Table>();
        List<Course_Table> courseList = new List<Course_Table>();
        public Admin_Search_Records()
        {
            InitializeComponent();
        }
        private void mtdLoadStudents()
        {
            studentlist.Clear();
            foreach (var user in dbEntitiesCourses.Student_Table)
            {
                studentlist.Add(user);

                //   textBox1.Text = user.Course_ID;
                
            }
        //    dataGridsearch.ItemsSource = studentlist.DefaultIfEmpty();
           
        }

        private void mtdLoadCourses()
        {
            courseList.Clear();
            foreach (var user in dbEntitiesCourses.Course_Table)
            {
                courseList.Add(user);

               

            }
      //   dataGridsearch.ItemsSource = courseList.DefaultIfEmpty();
          
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Admin_Edit_Student_Record Edit_Student = new Admin_Edit_Student_Record();
            Edit_Student.ShowDialog();
        }

        private void btnFeesClick(object sender, RoutedEventArgs e)
        {
            
            Admin_Tuition_Screen fees = new Admin_Tuition_Screen();
            fees.ShowDialog();

        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            Student_Table userDetails = new Student_Table(); //new instance of student table for searching
            
            string searchUser = tbxSearch.Text.Trim();//removing spaces with trim  get user detials
            
         

               

            if (String.IsNullOrEmpty(tbxSearch.Text.Trim()) || (tbxSearch.Text =="Admin"))
            {

                MessageBox.Show("Error Invalid Search Term!", "Search Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                dataGridsearch.DataContext = null;
                mtdSearchUser(searchUser);//check if details exist in DB using method
            }
        }

        public Student_Table mtdSearchUser(string searchUser) //Method checks if entered details are in SQL DB
        {
            int SearchOk = 0; //variable to allow list to fill when valid search found
         // List<Student_Table> UserDetails = new List<School_Soft.Student_Table>();
            foreach (var user in dbEntitiesCourses.Student_Table )
            {
               
                studentlist.Clear();
                if (searchUser == user.UserID || searchUser== user.Course_ID )
                {
                    studentlist.Add (user);
                    dataGridsearch.ItemsSource = studentlist.DefaultIfEmpty();
                    SearchOk = 1;
                }
             
            }

            if (SearchOk == 1)
            {
                dataGridsearch.ItemsSource = studentlist.DefaultIfEmpty();
            }
            else
            {
                MessageBox.Show("No Record Found!", "Search Results",
                  MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return null;

        }
    
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


          mtdLoadCourses();
            mtdLoadStudents();
        }
    }
}
