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
            Person person = new Person();
            person.Name = txtName.Text;
            person.UserName = txtUsername.Text;
            person.Email = txtEmail.Text;
            person.SurName = txtSurName.Text;
            person.PassWord = txtPassword.Password;
            person.IsAdmin = false;
            person.Phone = Convert.ToInt32(txtPhone.Text);
            //person.adrees = new adress(...data);
            PersonsDb db = new PersonsDb();
            db.InsertPerson(person);
            MessageBox.Show("Name :" + txtName.Text + "SurName :" + txtSurName.Text + "UserName :" + txtUsername.Text);
        }

        private void LogInAcc_Click(object sender, RoutedEventArgs e)
        {
               MainWindow mainWindowobj = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindowobj.Show();
        }
    }
}
