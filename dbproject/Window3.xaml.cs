using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Threading;
using System.Data.SqlClient;
using System.Configuration;

namespace dbproject
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 

    public partial class Window3 : Window
    {


        /* public class Employee
         {

             public String FirstName { get; set; }
             public String LastName { get; set; }
             public int NationalCode { get; set; }
             public int PhoneNumber { get; set; }
             public string Email { get; set; }
             public int TelNumber { get; set; }
             public string BirthDate { get; set; }
             public String? Address { get; set; }
             public String FatherName { get; set; }
             public String MaritalStatus { get; set; }
             public String StartDate { get; set; }
             public String EndDate { get; set; }
             public int BankAccNum { get; set; }
             public int ChildNum { get; set; }
             public int FamNum { get; set; }
             public int SebbaticalDays { get; set; }
             public String Position { get; set; }

             public String Education { get; set; }
             public int WorkExpe { get; set; }
             public String PreWorkPlace { get; set; }
             public String PreWordAddress { get; set; }
             public String PreWordTelNum { get; set; }
             public String AgencyBranchCode { get; set; }

             public String Resume { get; set; }





         }
        */


        public Window3()
        {
            InitializeComponent();
            binddatagrid();


        }

        private void binddatagrid()
        }

        private void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [EMPLOYEE]";
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Employees");
            da.Fill(dt);
            EmployeeTable.ItemsSource = dt.DefaultView;
        }

        
        {
         
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Procedure_SelectAllEmployees";
            cmd.Connection = conn;
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Employees");
            //cmd.ExecuteNonQuery();
          
            
          // var reader = cmd.ExecuteReader();
          
          adapter.Fill(dt);


          //  dt.Load(reader);
            EmployeeTable.ItemsSource = dt.DefaultView;
          //  conn.Close();
            

 
            
            
            

            /* for (int i = 0; i < dt.Rows.Count; i++)
             {
                 EmployeeTable.Items.Add(dt.Rows[i][2] + " " + dt.Rows[i][3]);
             }



             */

        }
      /*  private readonly String[] positions =
          private void BindListBox()
        {
            Position.ItemsSource = positions;

        }
      */
    }
}



        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }
    
   

        }


        /*   var ListOfemployees = new List<Employee>();
           {

               new Employee() { FirstName = "sara", LastName = "movahhed" };


           }




            private void FNfocus (object sender, RoutedEventArgs e)
            {

               FN.Text = "";



            }
           private void LNfocus(object sender, RoutedEventArgs e)
           {


               LN.Text = "";



           }

           private void NCfocus(object sender, RoutedEventArgs e)
           {


               NC.Text = "";


           }










           private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
           {

           }

           private void Border_Drop(object sender, DragEventArgs e)
           {

           }

           private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
           {


           }

           private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
           {

           }

           private void Button_Click(object sender, RoutedEventArgs e)
           {

           } 
       }

       private void Delete_Btn_MouseEnter(object sender, MouseEventArgs e)
       {
           var converter = new System.Windows.Media.BrushConverter();
           var brush = (Brush) converter.ConvertFromString("#FFF7F1FF");
           Delete_Btn.Background = brush;
       }

       private void Update_Btn_MouseEnter(object sender, MouseEventArgs e)
       {
           var converter = new System.Windows.Media.BrushConverter();
           var brush = (Brush)converter.ConvertFromString("#FFF7F1FF");
           Delete_Btn.Background = brush;
       }


       private void Delete_Btn_Click(object sender, RoutedEventArgs e)
       {

       }
   */
    }
}

