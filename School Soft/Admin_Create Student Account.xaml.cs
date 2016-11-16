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
    /// Interaction logic for Admin_Create_Student_Account.xaml
    /// </summary>
    public partial class Admin_Create_Student_Account : Window
    {
        public Admin_Create_Student_Account()
        {
            InitializeComponent();
        }

    

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void tbxCourseID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
