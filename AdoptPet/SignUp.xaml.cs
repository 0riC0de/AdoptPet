using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace AdoptPet
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }
        
        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btnEnterSignUp(object sender, RoutedEventArgs e)
        {
            string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orioz\OneDrive\מסמכים\AnimalsBase.accdb";
            SqlConnection sqlcon = new SqlConnection(conStr);

            string checkUsernameQuery = $"SELECT COUNT(*) FROM tblUsers WHERE userName = '";
            SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, sqlcon);

            sqlcon.Open();
            int existingUserCount = (int)checkUsernameCmd.ExecuteScalar();
            sqlcon.Close();
        }

        private void LogInAcc_Click(object sender, RoutedEventArgs e)
        {
               MainWindow mainWindowobj = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindowobj.Show();
        }
    }
}
