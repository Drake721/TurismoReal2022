using CapaNegocio;
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

namespace TurismoReal2022.Vistas
{
    /// <summary>
    /// Lógica de interacción para Estado.xaml
    /// </summary>
    public partial class Estado : UserControl
    {
        readonly CN_Disponibilidad objeto_CN_Disponibilidad = new CN_Disponibilidad();

        #region inicial
        public Estado()            
        {
            InitializeComponent();
            CargarDatos();
        }
        #endregion
        #region cargar Estados
        void CargarDatos()
        {
            GridDatos.ItemsSource = objeto_CN_Disponibilidad.Cargardisponibilidad().DefaultView;

        }
        #endregion
        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Mantenimiento();
        }
        #endregion
        #region agregar
        private void Agregar(object sender, RoutedEventArgs e)
        {
            CrearDisponibilidad ventana = new CrearDisponibilidad();
            FrameEstado.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }
        #endregion
        #region consultar
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearDisponibilidad ventana = new CrearDisponibilidad();
            ventana.id_disp = id;
            ventana.Consultar();
            FrameEstado.Content = ventana;
            ventana.Titulo.Text = "Consultar Estados";
            ventana.tbEstado.IsEnabled = false;

        }
        #endregion
        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearDisponibilidad ventana = new CrearDisponibilidad();
            ventana.id_disp = id;
            ventana.Consultar();
            FrameEstado.Content = ventana;
            ventana.Titulo.Text = "Actualizar Estados";
            ventana.tbEstado.IsEnabled = true;
 
            ventana.BtnModificar.Visibility = Visibility.Visible;
        }
        #endregion
        #region eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearDisponibilidad ventana = new CrearDisponibilidad();
            ventana.id_disp = id;
            ventana.Consultar();
            FrameEstado.Content = ventana;
            ventana.Titulo.Text = "Eliminar Estados";
            ventana.tbEstado.IsEnabled = false;

            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }
        #endregion
    }
}
