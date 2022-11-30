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
    /// Lógica de interacción para Cargo.xaml
    /// </summary>
    public partial class Cargo : UserControl
    {
        readonly CN_Cargo objeto_CN_Cargo = new CN_Cargo();

        #region inicial
        public Cargo()
        {
            InitializeComponent();
            CargarDatos();
        }
        #endregion
        #region cargar usuarios
        void CargarDatos()
        {
            GridDatos.ItemsSource = objeto_CN_Cargo.CargarCargo().DefaultView;

        }
        #endregion

        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Mantenimiento();
        }

        #region agregar
        private void Agregar(object sender, RoutedEventArgs e)
        {
            CrearCargo ventana = new CrearCargo();
            FrameCargo.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }
        #endregion
        #region consultar
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearCargo ventana = new CrearCargo();
            ventana.id = id;
            ventana.Consultar();
            FrameCargo.Content = ventana;
            ventana.Titulo.Text = "Consultar Cargo";
            ventana.tbCodCar.IsEnabled = false;
            ventana.tbNomCar.IsEnabled = false;
            ventana.tbDescCar.IsEnabled = false;
        }
        #endregion
        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearCargo ventana = new CrearCargo();
            ventana.id = id;
            ventana.Consultar();
            FrameCargo.Content = ventana;
            ventana.Titulo.Text = "Actualizar Cargo";
            ventana.tbCodCar.IsEnabled = true;
            ventana.tbNomCar.IsEnabled = true;
            ventana.tbDescCar.IsEnabled = true;
            ventana.BtnModificar.Visibility = Visibility.Visible;
        }
        #endregion
        #region eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrearCargo ventana = new CrearCargo();
            ventana.id = id;
            ventana.Consultar();
            FrameCargo.Content = ventana;
            ventana.Titulo.Text = "Eliminar Cargo";
            ventana.tbCodCar.IsEnabled = false;
            ventana.tbNomCar.IsEnabled = false;
            ventana.tbDescCar.IsEnabled = false;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }
        #endregion
    }
}
