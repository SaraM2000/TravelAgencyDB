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
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.Common;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Configuration;


namespace dbproject
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public Employee()
        {
            InitializeComponent();
            BindListBox();
            BindListBox1();
        }
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UUJ3DJ6;Initial Catalog=TravelAgency;Integrated Security=True");
            SqlCommand com = new SqlCommand("Procedure_InsEmployee", con) { CommandType = System.Data.CommandType.StoredProcedure };
            con.Open();
            com.Parameters.AddWithValue("@agencyBranchCode", agencyBranchCode.Text); ///////// list
            com.Parameters.AddWithValue("@employeeNationalCode", NationalCode.Text);
            com.Parameters.AddWithValue("@employeeFirstName", FirstName.Text);
            com.Parameters.AddWithValue("@employeeLastName", LastName.Text);
            com.Parameters.AddWithValue("@employeeBirthDate", BirthDate.Text); ////////// date
            com.Parameters.AddWithValue("@Employee_Address", Address.Text);
            com.Parameters.AddWithValue("@employeePhoneNum", PhoneNumber.Text);
            com.Parameters.AddWithValue("@employeeTelNum", TelNumber.Text);
            com.Parameters.AddWithValue("@Employee_Email", Email.Text);
            com.Parameters.AddWithValue("@employeeBankAccNum", BAInfo.Text);
            com.Parameters.AddWithValue("@employeeFatherName", FathersName.Text);
            com.Parameters.AddWithValue("@employeeFamNum", FamilyNumber.Text);
            com.Parameters.AddWithValue("@employeeStartDate", StartDate.Text);/////// date
            com.Parameters.AddWithValue("@employeeMaritalStatus", MartialStatus.SelectedItem);/// list
            com.Parameters.AddWithValue("@employeeChildNum", ChildNumber.Text);
            com.Parameters.AddWithValue("@employeeEndDate", EndDate.Text); /////////// date
            com.Parameters.AddWithValue("@Employee_Education", Education.Text);
            com.Parameters.AddWithValue("@employeeWorkExpe", WorkExpe.Text);
            com.Parameters.AddWithValue("@employeePreWorkPlace", PreWorkPlace.Text);
            com.Parameters.AddWithValue("@employeePreWorkAddress", PreWorkAddress.Text);
            com.Parameters.AddWithValue("@employeePreWorkTelNum", PreWorkTelNum.Text);
            com.Parameters.AddWithValue("@employeeSabbaticalDays", Sebbaticaldays.Text);
            com.Parameters.AddWithValue("@Employee_Position", Position.SelectedItem);/////// list

            com.ExecuteNonQuery();

        }
        private void Confirm_button(object sender, RoutedEventArgs e)
        {
            Window1 ob = new Window1();
            this.Visibility = Visibility.Hidden;
            ob.Show();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private readonly String[] positions = { "Select...", "Manager", "Accountant", "Flight Agent", "Tourism Agent" };
        private void BindListBox()
        {
            Position.ItemsSource = positions;

        }
        private readonly String[] MStatus = { "Select...", "Single", "Married" };
        private void BindListBox1()
        {
            MartialStatus.ItemsSource = MStatus;

        }
    }


}
