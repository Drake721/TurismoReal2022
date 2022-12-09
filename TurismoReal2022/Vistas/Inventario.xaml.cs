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
    
    public partial class Inventario : UserControl
    {
        readonly CN_Inventario objeto_CN_Inventario = new CN_Inventario();

        public Inventario()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void ObjetoClick(object sender, RoutedEventArgs e)
        {
            Objeto ventana = new Objeto();
            Frameinventario.Content = ventana;
        }

        #region cargar Dpto
        void CargarDatos()
        {
            GridDatos.ItemsSource = objeto_CN_Inventario.Cargarinventario().DefaultView;

        }
        #endregion

        #region consultar
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            Asignar_inventario ventana = new Asignar_inventario();
            ventana.Id_inv = id;
            ventana.Consultar();
            Frameinventario.Content = ventana;
            ventana.Titulo.Text = "Consultar Inventario";
            ventana.cbDpto.IsEnabled = false;
            ventana.cbObj.IsEnabled = false;
            ventana.tbNomDes.IsEnabled = false;
            
        }
        #endregion
        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            Asignar_inventario ventana = new Asignar_inventario();
            ventana.Id_inv = id;
            ventana.Consultar();
            Frameinventario.Content = ventana;
            ventana.Titulo.Text = "Actualizar Inventario";
            ventana.cbDpto.IsEnabled = true;
            ventana.cbObj.IsEnabled = true;
            ventana.tbNomDes.IsEnabled = true;
            ventana.BtnModificar.Visibility = Visibility.Visible;
        }
        #endregion
        #region eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            Asignar_inventario ventana = new Asignar_inventario();
            ventana.Id_inv = id;
            ventana.Consultar();
            Frameinventario.Content = ventana;
            ventana.Titulo.Text = "Eliminar Inventario";
            ventana.Titulo.Text = "Consultar Inventario";
            ventana.cbDpto.IsEnabled = false;
            ventana.cbObj.IsEnabled = false;
            ventana.tbNomDes.IsEnabled = false;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }

        private void CrearInvClick(object sender, RoutedEventArgs e)
        {
            Asignar_inventario ventana = new Asignar_inventario();
            Frameinventario.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }
        #endregion

        /*#region buscar
        public void Buscar(string buscar)
        {
            GridDatos.ItemsSource = objeto_CN_Departamento.Buscar(buscar).DefaultView;
        }

        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
        #endregion
        */
    }
}
