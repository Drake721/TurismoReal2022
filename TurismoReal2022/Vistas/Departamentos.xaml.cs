using CapaNegocio;
using System.Windows;
using System.Windows.Controls;

namespace TurismoReal2022.Vistas
{
    /// <summary>
    /// Lógica de interacción para Departamentos.xaml
    /// </summary>
    public partial class Departamentos : UserControl
    {
        readonly CN_Departamento objeto_CN_Departamento = new CN_Departamento();

        #region inicial
        public Departamentos()
        {
            InitializeComponent();
            CargarDatos();
        }
        #endregion

        #region cargar Dpto
        void CargarDatos()
        {
            GridDatos.ItemsSource = objeto_CN_Departamento.CargarDepartamento().DefaultView;

        }
        #endregion

        private void Agregar(object sender, RoutedEventArgs e)
        {
            AgregarDPTO ventana = new AgregarDPTO();
            FrameDepartamentos.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }

        #region consultar
        private void ConsultarDPTO(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            AgregarDPTO ventana = new AgregarDPTO();
            ventana.ID_DPTO = id;
            ventana.Consultar();
            FrameDepartamentos.Content = ventana;
            ventana.Titulo.Text = "Consultar Departamento";
            ventana.tbNombreDPTO.IsEnabled = false;
            ventana.tbTARIFA.IsEnabled = false;
            ventana.tbDIRECCION.IsEnabled = false;
            ventana.tbNRODPTO.IsEnabled = false;
            ventana.tbCAPACIDAD.IsEnabled = false;
            ventana.cbRegion.IsEnabled = false;
            ventana.cbComuna.IsEnabled = false;
            ventana.cbDisponibilidad.IsEnabled = false;
            ventana.tbImagweb.IsEnabled = false;
            ventana.btnimagen.IsEnabled = false;
            ventana.btnimagen1.IsEnabled = false;
            ventana.btnimagen2.IsEnabled = false;
        }
        #endregion
        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            AgregarDPTO ventana = new AgregarDPTO();
            ventana.ID_DPTO = id;
            ventana.Consultar();
            FrameDepartamentos.Content = ventana;
            ventana.Titulo.Text = "Actualizar Departamento";
            ventana.tbNombreDPTO.IsEnabled = true;
            ventana.tbTARIFA.IsEnabled = true;
            ventana.tbDIRECCION.IsEnabled = true;
            ventana.tbNRODPTO.IsEnabled = true;
            ventana.tbCAPACIDAD.IsEnabled = true;
            ventana.cbRegion.IsEnabled = true;
            ventana.cbComuna.IsEnabled = true;
            ventana.cbDisponibilidad.IsEnabled = true;
            ventana.tbImagweb.IsEnabled = true;
            ventana.btnimagen.IsEnabled = true;
            ventana.btnimagen1.IsEnabled = true;
            ventana.btnimagen2.IsEnabled = true;
            ventana.BtnModificar.Visibility = Visibility.Visible;
        }
        #endregion
        #region eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            AgregarDPTO ventana = new AgregarDPTO();
            ventana.ID_DPTO = id;
            ventana.Consultar();
            FrameDepartamentos.Content = ventana;
            ventana.Titulo.Text = "Eliminar Departamento";
            ventana.tbNombreDPTO.IsEnabled = false;
            ventana.tbTARIFA.IsEnabled = false;
            ventana.tbDIRECCION.IsEnabled = false;
            ventana.tbNRODPTO.IsEnabled = false;
            ventana.tbCAPACIDAD.IsEnabled = false;
            ventana.cbRegion.IsEnabled = false;
            ventana.cbComuna.IsEnabled = false;
            ventana.cbDisponibilidad.IsEnabled = false;
            ventana.tbImagweb.IsEnabled = false;
            ventana.btnimagen.IsEnabled = false;
            ventana.btnimagen1.IsEnabled = false;
            ventana.btnimagen2.IsEnabled = false;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }
        #endregion

        #region buscar
        public void Buscar(string buscar)
        {
            GridDatos.ItemsSource = objeto_CN_Departamento.Buscar(buscar).DefaultView;
        }

        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
        #endregion
    }
}
