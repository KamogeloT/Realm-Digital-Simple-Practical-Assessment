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
using Realm_Digital_Simple_Practical;
using Tulpep.NotificationWindow;

namespace Realm_Digital_Simple_Practical
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiCaller.intializeApi();
        }

        private void Reminder_Click(object sender, RoutedEventArgs e)
        {
           

        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentYear = DateTime.Now;
            EmployeeModel emp = new EmployeeModel();
            EmployeeValidation empVal = new EmployeeValidation();            
            List<EmployeeModel> employeelist = new List<EmployeeModel>();
            employeelist = GetEmployees.LoadEmployees();
          
            foreach (EmployeeModel employee in employeelist)
            {
                if (currentYear == emp.dateOfBirth)
                {
                    if(empVal.CheckEmploymentStatus())
                    {
                        //using Tulpep Nuget to provide popup window
                        //Email config details where not provided thats why i used a popup
                        //Email class was developed

                        PopupNotifier popup = new PopupNotifier();
                        popup.Image = Properties.Resources.bday;
                        popup.TitleText = "BirthDay";
                        popup.ContentText = "Happy birth day " + emp.name + "" + emp.lastname;
                        popup.Popup();
                    }
                    
                }
               
            }
           

        }
    }
}
