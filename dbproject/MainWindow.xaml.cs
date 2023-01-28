using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.Common;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Configuration;
using System.Data.SqlTypes;

namespace dbproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>




    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }



        
        private void SignUp_button(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            this.Visibility = Visibility.Hidden;
            employee.Show();
        }
        private void Login_Btn(object sender, RoutedEventArgs e)
        {
            Window1 Search_employees = new Window1();
            this.Visibility = Visibility.Hidden;
            Search_employees.Show();
        }





    }
}


    

