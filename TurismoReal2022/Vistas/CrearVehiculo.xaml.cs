using CapaEntidad;
using CapaNegocio;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TurismoReal2022.Vistas
{
    /// <summary>
    /// Lógica de interacción para CrearVehiculo.xaml
    /// </summary>
    public partial class CrearVehiculo : Page
    {
        readonly CN_Vehiculo objeto_CN_Vehiculo = new CN_Vehiculo();
        readonly CE_Vehiculo objeto_CE_Vehiculo = new CE_Vehiculo();
        readonly CN_Usuario objeto_CN_Usuario = new CN_Usuario();
        CN_Cargo ca = new CN_Cargo();

        #region inicial
        public CrearVehiculo()
        {
            InitializeComponent();
            CargarCB();
        }
        #endregion

        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Vehiculo();
        }
        #endregion

        #region cargar Usuarios
        void CargarCB()
        {
            List<string> Usuario = objeto_CN_Usuario.ListarUsuario();
            for (int i = 0; i < Usuario.Count; i++)
            {
                                
                    cbChofer.Items.Add(Usuario[i]);
                
            }


        }

        
        #endregion

        #region VALIDAR CAMPOS VACIOS
        public bool camposLlenos()
        {
            if (tbPatente.Text == "" || tbCodigo.Text == "" || tbDescVehi.Text == "" )
            {
                MessageBox.Show("Los campos no pueden quedar vacios");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion 

        #region crud usuarios
        public int id_usuario;
        public int id_vehiculo;
    
        #region crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                int usuario = objeto_CN_Usuario.id_usuario(cbChofer.Text);
                objeto_CE_Vehiculo.Patente = tbPatente.Text;
                objeto_CE_Vehiculo.Codigo = int.Parse(tbCodigo.Text);
                objeto_CE_Vehiculo.Descripcion = tbDescVehi.Text;
                objeto_CE_Vehiculo.Id_usuario = usuario;                

                objeto_CN_Vehiculo.Insertar(objeto_CE_Vehiculo);
                Content = new Vehiculo();

            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios!");
            }
        }
        #endregion

        #region cosultas
        public void Consultar()
        {
            var a = objeto_CN_Vehiculo.Consultar(id_vehiculo);
            var b = objeto_CN_Usuario.nombres(a.Id_usuario);
            tbPatente.Text = a.Patente.ToString();
            tbCodigo.Text = a.Codigo.ToString();
            tbDescVehi.Text = a.Descripcion.ToString();
            cbChofer.Text = b.Nombres.ToString();
            
              
        }
        #endregion

        #region Modificar
        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                int usuario = objeto_CN_Usuario.id_usuario(cbChofer.Text);
                objeto_CE_Vehiculo.Id_vehiculo = id_vehiculo;
                objeto_CE_Vehiculo.Patente = tbPatente.Text;
                objeto_CE_Vehiculo.Codigo = int.Parse(tbCodigo.Text);
                objeto_CE_Vehiculo.Descripcion = tbDescVehi.Text;
                objeto_CE_Vehiculo.Id_usuario = usuario;
                objeto_CN_Vehiculo.ActualizarDatos(objeto_CE_Vehiculo);
                Content = new Vehiculo();
            }
            else
            {
                MessageBox.Show("Los campos a modificar no pueden quedar vacios");
            }            
        }
        #endregion

        #region Eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            objeto_CE_Vehiculo.Id_vehiculo = id_vehiculo;

            objeto_CN_Vehiculo.Eliminar(objeto_CE_Vehiculo);

            Content = new Vehiculo();
        }
        #endregion  
        
        #endregion
        
    }
}
