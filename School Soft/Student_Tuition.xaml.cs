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
    /// Interaction logic for Student_Tuition.xaml
    /// </summary>
    public partial class Student_Tuition : Window
    {
       
        public Login_Table user = new Login_Table();
        public Student_Table student = new Student_Table();
        SS_UPADATEDEntities2 dbEntitiesFess = new SS_UPADATEDEntities2();
        List<Student_Table> studentlistfees = new List<Student_Table>();
        public Student_Tuition()
        {
            InitializeComponent();
            
        }
        
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
          


            this.Hide();
       
        }
     
        private void mthLoadUsersFees()
        {
            studentlistfees.Clear();
            foreach (var user in dbEntitiesFess.Student_Table)
            {
                studentlistfees.Add(user);
            }
        }

       private Student_Table mtdGetFees()
        {
            Student_Table tuition_search = new Student_Table();
            foreach (var users in studentlistfees)
            {
                if (user.UserID==users.UserID)
                {
                   tuition_search = users;
                    
                }
               
            }
            if(tuition_search.Fee_Status==1)
            { 
                tbxFees.Text = " Fees unpaid";
                tbxFees.Background = Brushes.Red;
            }
            else if (tuition_search.Fee_Status==2)
            {
                tbxFees.Text = "Fees Paid!";
                tbxFees.Background = Brushes.LightGreen;
            }
            tbxCourseName.Text = tuition_search.Course_ID;
            return null;
          //  return tuition_search;
        }

        private void tbxFees_TextChanged(object sender, TextChangedEventArgs e)
        {
         //   tbxFees.Text = login.UserID;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mthLoadUsersFees();
            //    tbxFees.Text = user.UserID;
            mtdGetFees();
            lbltext.Content = user.UserID;
        }
    }
}
