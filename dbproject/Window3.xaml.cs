﻿using System;
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
        }

           private void Window3_Load (object sender, EventArgs e)
        {
            gridbind();
        }

        private void gridbind()
        {
            String connString = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            
                
                SqlCommand cmd = new SqlCommand("Procedure_SelectAllEmployees", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt= new DataTable();
                dt.Load(reader);
                EmployeeTable.DataContext = dt;
                conn.Close();
                dt.Rows[0]

                
            
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