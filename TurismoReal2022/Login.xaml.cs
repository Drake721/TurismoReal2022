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

namespace TurismoReal2022
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtUser.Text !="" && txtPass.Password != "")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos no pueden quedar vacios!");
            }
        }
        void Logins(string usuario, string clave)
        {
            
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pbMostrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
