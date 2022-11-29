using CapaNegocio;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
                Logins(txtUser.Text, txtPass.Password);
                MainWindow mainWindow = new MainWindow();
            }
            else
            {
                MessageBox.Show("Los campos no pueden quedar vacios!");
            }
        }
        void Logins(string email, string clave)
        {
            CN_Usuario cn = new CN_Usuario();
            var a=cn.Login(email, clave);
            if (a.Id_usuario > 0 && a.Idcargo == 1)
            {
                Properties.Settings.Default.ID_USUARIO = a.Id_usuario;
                Properties.Settings.Default.IDCARGO = a.Idcargo;
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else if (a.Idcargo != 1)
            {
                MessageBox.Show("El usuario debe ser Administrador");
            }
            else
            {
                MessageBox.Show("Credenciales o Usuario incorrecto! Reintente");
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pbMostrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
