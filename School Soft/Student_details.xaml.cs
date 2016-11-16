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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Login_Table user = new Login_Table();
        public Student_Table student = new Student_Table();
        //  public Student_Table students = new Student_Table()
      //  SchoolSoftEntities dbEntitiesDetails = new SchoolSoftEntities();
        List<Student_Table> studentlistDetails = new List<Student_Table>();
        SS_UPADATEDEntities2 dbEntitiesDetails = new SS_UPADATEDEntities2();

        
        public Window2()
        {
            InitializeComponent();
        }

        private void mtdLoadUsersDetails()
        {
            studentlistDetails.Clear();
            foreach (var user in dbEntitiesDetails.Student_Table)
            {
                studentlistDetails.Add(user);
            }
        }

        private Student_Table mtdGetDetails()
        {
            Student_Table Details = new Student_Table();
            foreach (var users in studentlistDetails)
            {
                if (user.UserID == users.UserID)
                {
                    Details = users;

                }

            }
            tbxStudentID.Text = Details.UserID;
            tbxForename.Text = Details.Forename;
            tbxAddress1.Text = Details.Address1;
            tbxAddress2.Text = Details.Address2;
            tbxSurname.Text = Details.Surname;
            
            tbxContact.Text = Details.Contact.ToString();

        
            return null;
            //  return tuition_search;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
         
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)  //functions that are preloaded on runtime
        {
            mtdLoadUsersDetails();
            mtdGetDetails();
        }
    }



}
