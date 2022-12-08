using CapaNegocio;
using System.Windows;
using System.Windows.Controls;

namespace TurismoReal2022.Vistas
{
    /// <summary>
    /// Lógica de interacción para Vehiculo.xaml
    /// </summary>
    public partial class Vehiculo : UserControl
    {
        readonly CN_Vehiculo objeto_CN_Vehiculo = new CN_Vehiculo();

        #region inicial
        public Vehiculo()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Mantenimiento();
        }
        #endregion

        #region cargar usuarios
        void CargarDatos()
        {
            GridDatos.ItemsSource = objeto_CN_Vehiculo.CargarVehiculos().DefaultView;

        }
        #endregion

        #region agregar
        private void Agregar(object sender, RoutedEventArgs e)
        {
            CrearVehiculo ventana = new CrearVehiculo();
            FrameVehiculo.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }
        #endregion

        #region consultar
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearVehiculo ventana = new CrearVehiculo();
            ventana.id_vehiculo = id;
            ventana.Consultar();
            FrameVehiculo.Content = ventana;
            ventana.Titulo.Text = "Consultar Vehiculo";
            ventana.tbPatente.IsEnabled = false;
            ventana.tbCodigo.IsEnabled = false;
            ventana.tbDescVehi.IsEnabled = false;
            ventana.cbChofer.IsEnabled = false;
       
        }
        #endregion

        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearVehiculo ventana = new CrearVehiculo();
            ventana.id_vehiculo = id;
            ventana.Consultar();
            FrameVehiculo.Content = ventana;
            ventana.Titulo.Text = "Actualizar Vehiculo";
            ventana.tbPatente.IsEnabled = true;
            ventana.tbCodigo.IsEnabled = true;
            ventana.tbDescVehi.IsEnabled = true;
            ventana.cbChofer.IsEnabled = true;           
            ventana.BtnModificar.Visibility = Visibility.Visible;
        }
        #endregion

        #region eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearVehiculo ventana = new CrearVehiculo();
            ventana.id_vehiculo = id;
            ventana.Consultar();
            FrameVehiculo.Content = ventana;
            ventana.Titulo.Text = "Eliminar Vehiculo";
            ventana.tbPatente.IsEnabled = false;
            ventana.tbCodigo.IsEnabled = false;
            ventana.tbDescVehi.IsEnabled = false;
            ventana.cbChofer.IsEnabled = false;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }
        #endregion

    }
}
