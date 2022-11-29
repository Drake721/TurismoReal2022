using CapaNegocio;
using System.Windows;
using System.Windows.Controls;

namespace TurismoReal2022.Vistas
{

    public partial class Mantenimiento : UserControl
    {
        readonly CN_Mantenimiento objeto_CN_Mantenimiento = new CN_Mantenimiento();

        #region inicial
        public Mantenimiento()
        {
            InitializeComponent();
            CargarDatos();
        }
        #endregion

        #region cargar mant
        void CargarDatos()
        {
            GridDatos.ItemsSource = objeto_CN_Mantenimiento.CargarMantencion().DefaultView;

        }
        #endregion

        private void Agregar(object sender, RoutedEventArgs e)
        {
            CrearMantenimiento ventana = new CrearMantenimiento();
            FrameMantenimiento.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }

        private void EstadoClick(object sender, RoutedEventArgs e)
        {
            Estado ventana = new Estado();
            FrameMantenimiento.Content = ventana;
        }
        private void VehiculoClick(object sender, RoutedEventArgs e)
        {
            Vehiculo ventana = new Vehiculo();
            FrameMantenimiento.Content = ventana;
        }
        private void CargoClick(object sender, RoutedEventArgs e)
        {
            Cargo ventana = new Cargo();
            FrameMantenimiento.Content = ventana;
        }
        #region consultar
        private void ConsultarMant(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearMantenimiento ventana = new CrearMantenimiento();
            ventana.id_mant = id;
            ventana.Consultar();
            FrameMantenimiento.Content = ventana;
            ventana.Titulo.Text = "Consultar Estado";
            ventana.cbDepartamento.IsEnabled = false;
            ventana.tbNombreMant.IsEnabled = false;
            ventana.tbDescMant.IsEnabled = false;
            ventana.clFechIni.IsEnabled = false;
            ventana.clFechTerm.IsEnabled = false;
            ventana.cbDisponibilidad.IsEnabled = false;
            ventana.tbCosMant.IsEnabled = false;
        }
        #endregion
        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearMantenimiento ventana = new CrearMantenimiento();
            ventana.id_mant = id;
            ventana.Consultar();
            FrameMantenimiento.Content = ventana;
            ventana.Titulo.Text = "Actualizar Estado";
            ventana.cbDepartamento.IsEnabled = true;
            ventana.tbNombreMant.IsEnabled = true;
            ventana.tbDescMant.IsEnabled = true;
            ventana.clFechIni.IsEnabled = true;
            ventana.clFechTerm.IsEnabled = true;
            ventana.cbDisponibilidad.IsEnabled = true;
            ventana.tbCosMant.IsEnabled = true;
            ventana.BtnModificar.Visibility = Visibility.Visible;
        }
        #endregion
    }
}
