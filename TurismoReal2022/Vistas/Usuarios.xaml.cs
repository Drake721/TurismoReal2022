using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using CapaNegocio;


namespace TurismoReal2022.Vistas
{
    public partial class Usuarios : UserControl
    {
        readonly CN_Usuario objeto_CN_Usuario = new CN_Usuario();
        #region inicial
        public Usuarios()
        {
            InitializeComponent();
            CargarDatos();
        }
        #endregion

        #region cargar usuarios
        void CargarDatos()
        {
            GridDatos.ItemsSource = objeto_CN_Usuario.CargarUsuarios().DefaultView;

        }
        #endregion

        #region agregar
        private void Agregar(object sender,RoutedEventArgs e)
        {
            agregarUsuario ventana = new agregarUsuario();
            FrameUsuarios.Content = ventana;
            ventana.BtnCrear.Visibility=Visibility.Visible;
        }
        #endregion

        #region consultar
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            agregarUsuario ventana =new agregarUsuario();
            ventana.id_usuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            ventana.Titulo.Text = "Consultar Usuario";
            ventana.tbNombres.IsEnabled = false;
            ventana.tbApellido.IsEnabled = false;
            ventana.tbsegApellido.IsEnabled = false;
            ventana.tbCelular.IsEnabled = false;
            ventana.tbCorreo.IsEnabled = false;
            ventana.tbClave.IsEnabled = false;
            ventana.tbRut.IsEnabled = false;
            ventana.tbNombres.IsEnabled = false;
            ventana.cbCargo.IsEnabled = false;
            ventana.btnimagen.IsEnabled = false;
        }
        #endregion

        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            agregarUsuario ventana = new agregarUsuario();
            ventana.id_usuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            ventana.Titulo.Text = "Actualizar Usuario";
            ventana.tbNombres.IsEnabled = true;
            ventana.tbApellido.IsEnabled = true;
            ventana.tbsegApellido.IsEnabled = true;
            ventana.tbCelular.IsEnabled = true;
            ventana.tbCorreo.IsEnabled = true;
            ventana.tbClave.IsEnabled = true;
            ventana.tbRut.IsEnabled = true;
            ventana.cbCargo.IsEnabled = true;
            ventana.btnimagen.IsEnabled = true;
            ventana.BtnModificar.Visibility = Visibility.Visible; 
        }
        #endregion

        #region eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            agregarUsuario ventana = new agregarUsuario();
            ventana.id_usuario = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            ventana.Titulo.Text = "Eliminar Usuario";
            ventana.tbNombres.IsEnabled = false;
            ventana.tbApellido.IsEnabled = false;
            ventana.tbsegApellido.IsEnabled = false;
            ventana.tbCelular.IsEnabled = false;
            ventana.tbCorreo.IsEnabled = false;
            ventana.tbClave.IsEnabled = false;
            ventana.tbRut.IsEnabled = false;
            ventana.tbNombres.IsEnabled = false;
            ventana.cbCargo.IsEnabled = false;
            ventana.btnimagen.IsEnabled = false;
            ventana.BtnEliminar.Visibility=Visibility.Visible;
        }

        #endregion

        #region buscar
        public void Buscar(string buscar)
        {
            GridDatos.ItemsSource = objeto_CN_Usuario.Buscar(buscar).DefaultView;
        }

        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
        #endregion
    }
}
