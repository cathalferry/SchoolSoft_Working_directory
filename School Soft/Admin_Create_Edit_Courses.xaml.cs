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
using System.Data;
namespace School_Soft
{
    /// <summary>
    /// Interaction logic for Admin_Create_Edit_Courses.xaml
    /// </summary>
    public partial class Admin_Create_Edit_Courses : Window
    {
        SS_UPADATEDEntities2 dbEntitiesCourses = new SS_UPADATEDEntities2();
        public Login_Table user = new Login_Table();
        List<Student_Table> studentlist = new List<Student_Table>();
        List<Course_Table> courseList = new List<Course_Table>();
         
        public Admin_Create_Edit_Courses()
        {
            InitializeComponent();
        }

        private void mtdLoadCourses()
        {
            courseList.Clear();
            foreach (var user in dbEntitiesCourses.Course_Table)
            {
                courseList.Add(user);
               
             //   textBox1.Text = user.Course_ID;
               
            }
             dataGrid.ItemsSource = courseList.DefaultIfEmpty();
        
        }
       

        private void textBox_Add(object sender, System.EventArgs e)
        {
            
        }


        private void tbxStudentID_Copy2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {

   


            this.Hide();
        
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        
            
            mtdLoadCourses();
      
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
          //  textBox1.Clear();
          //  foreach (var selectedItem in courseList)
          //  {
          //      textBox1.AppendText(selectedItem.ToString() + Environment.NewLine);
          //  }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxClass3_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void dataGrid_RowClick(object sender, DataGridRow  e)
        {
            
        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

            // string ID = (dataGrid.SelectedCells[0].Column.GetCellContent() as TextBlock).Text;

        }
    }
    }

