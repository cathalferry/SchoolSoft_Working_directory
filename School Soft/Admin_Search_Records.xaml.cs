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
        public Admin_Search_Records()
        {
            InitializeComponent();
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

        }
    }
}
