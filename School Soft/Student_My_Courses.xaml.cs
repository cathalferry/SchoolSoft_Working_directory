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
    /// Interaction logic for Student_My_Courses.xaml
    /// </summary>
    public partial class Student_My_Courses : Window
    {
        SS_UPADATEDEntities2 dbEntitiesCourses = new SS_UPADATEDEntities2();
        public Login_Table user = new Login_Table();
        public Student_Table userDetails = new Student_Table();
        List<Course_Table> studentlistcourses = new List<Course_Table>();
        List<Student_Table> studentlist = new List<Student_Table>();
        public Student_My_Courses()
        {
            InitializeComponent();
        }
        private void mthLoadUsers()
        {
            studentlist.Clear();
            foreach (var user in dbEntitiesCourses.Student_Table)
            {
                studentlist.Add(user);
            }
        }

        private void mtdLoadStudents()
        {
                studentlist.Clear();
            foreach (var user in dbEntitiesCourses.Student_Table)
            {
                studentlist.Add(user);
            }
        }

        private void mtdLoadCourses()
        {
            studentlistcourses.Clear();
            foreach (var user in dbEntitiesCourses.Course_Table)
            {
                studentlistcourses.Add(user);
            }
        }
        private Student_Table mtdGetCourses()
        {
            Student_Table tuition_search = new Student_Table();
            foreach (var users in studentlist)
            {
                if (user.UserID == users.UserID)
                {
                    tuition_search = users;

                }

            }

            tbxCourseID.Text = tuition_search.Course_ID;

            Course_Table course_search = new Course_Table();
            foreach (var users in studentlistcourses)
            {
                if (tuition_search.Course_ID  == users.Course_ID)
                {
                    course_search = users;

                }

            }
            tbxCourseName.Text = course_search.Course_Title;
            tbxClass1.Text = course_search.Class_Detail;
            tbxClass2.Text = course_search.Class_Detail2;
            tbxClass3.Text = course_search.Class_Detail3;
            

            return null;
            //  return tuition_search;
        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
        this.Hide();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblUserinfo.Content = user.UserID;
            mtdLoadStudents();
            mtdLoadCourses();
            mtdGetCourses();
        }    }
}
