using CapaNegocio;
using System.Windows;
using System.Windows.Controls;

namespace TurismoReal2022.Vistas
{
    /// <summary>
    /// Lógica de interacción para Objeto.xaml
    /// </summary>
    public partial class Objeto : UserControl
    {
        readonly CN_Objeto objeto_CN_Objeto = new CN_Objeto();

        #region inicial
        public Objeto()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Inventario();
        }
        #endregion

        #region cargar usuarios
        void CargarDatos()
        {
            GridDatos.ItemsSource = objeto_CN_Objeto.CargarObjetos().DefaultView;

        }
        #endregion

        #region agregar
        private void Agregar(object sender, RoutedEventArgs e)
        {
            CrearObjeto ventana = new CrearObjeto();
            FrameObjeto.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }
        #endregion

        #region consultar
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearObjeto ventana = new CrearObjeto();
            ventana.id_obj = id;
            ventana.Consultar();
            FrameObjeto.Content = ventana;
            ventana.Titulo.Text = "Consultar Objeto";
            ventana.tbCodigo.IsEnabled = false;
            ventana.tbnomObj.IsEnabled = false;
            ventana.tbcanti.IsEnabled = false;
            ventana.tbValor.IsEnabled = false;

        }
        #endregion

        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearObjeto ventana = new CrearObjeto();
            ventana.id_obj = id;
            ventana.Consultar();
            FrameObjeto.Content = ventana;
            ventana.Titulo.Text = "Actualizar Objeto";
            ventana.tbCodigo.IsEnabled = true;
            ventana.tbnomObj.IsEnabled = true;
            ventana.tbcanti.IsEnabled = true;
            ventana.tbValor.IsEnabled = true;
            ventana.BtnModificar.Visibility = Visibility.Visible;
        }
        #endregion

        #region eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearObjeto ventana = new CrearObjeto();
            ventana.id_obj = id;
            ventana.Consultar();
            FrameObjeto.Content = ventana;
            ventana.Titulo.Text = "Eliminar Objeto";
            ventana.tbCodigo.IsEnabled = false;
            ventana.tbnomObj.IsEnabled = false;
            ventana.tbcanti.IsEnabled = false;
            ventana.tbValor.IsEnabled = false;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }
        #endregion
    }
}
