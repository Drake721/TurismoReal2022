using System.Windows;
using System.Windows.Input;
using TurismoReal2022.Vistas;

namespace TurismoReal2022
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
            Login lg =new Login();
            lg.Show();
            this.Close();
        }

        private void TbShow(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 0.5;
        }

        private void TbHide(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 1;
        }

        private void PreviewMouseLeftBouttom(object sender, MouseButtonEventArgs e)
        {
            btnShowhide.IsChecked=false;
        }

        private void Usuarios_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Usuarios();
        }

        private void Dpto_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Departamentos();
        }
        private void Mantencion_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Mantenimiento();
        }
    }
}
