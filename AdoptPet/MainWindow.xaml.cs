using Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;
using System.Data.OleDb;

namespace AdoptPet
{
    public partial class MainWindow : Window
    {
        private PersonsDb personsDb = new PersonsDb();
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orioz\OneDrive\מסמכים\AnimalsBase.accdb";

        public MainWindow()
        {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrEmpty(username))
            {
                //cange the box color
                ErrorText.Text = "Username cannot be empty!";
                return;
            }
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                //change the box color
                ErrorText.Text = "Password must be at least 8 characters!";
                return;
            }
            Person loginSuccessful = personsDb.CheckLogin(username, password);

           // using (OleDbConnection conn = new OleDbConnection(connectionString))
           // {
            //    conn.Open();
                if (loginSuccessful != null)
                {
                    MessageBox.Show("Login sec!");
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }

            //    conn.Close();

          //  }
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

        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUp objSignUp = new SignUp();
            this.Visibility = Visibility.Hidden;
            objSignUp.Show();
        }
    }
}
