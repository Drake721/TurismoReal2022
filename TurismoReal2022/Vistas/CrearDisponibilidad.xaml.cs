using CapaEntidad;
using CapaNegocio;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para CrearDisponibilidad.xaml
    /// </summary>
    public partial class CrearDisponibilidad : Page
    {
        readonly CN_Disponibilidad objeto_CN_Disponibilidad = new CN_Disponibilidad();
        readonly CE_Disponibilidad objeto_CE_Disponibilidad = new CE_Disponibilidad();   

        #region inicial
        public CrearDisponibilidad()
        {
            InitializeComponent();           
        }
        #endregion

        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Estado();
        }
        #endregion


        #region VALIDAR CAMPOS VACIOS
        public bool camposLlenos()
        {
            if (tbEstado.Text == "")
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
        public int id_disp;

        #region crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                objeto_CE_Disponibilidad.DESCR_ESTADO = tbEstado.Text;
                
                objeto_CN_Disponibilidad.Insertar(objeto_CE_Disponibilidad);
                Content = new Estado();

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
            var a = objeto_CN_Disponibilidad.Consultar(id_disp);
            tbEstado.Text = a.DESCR_ESTADO.ToString();                        
        }
        #endregion
        #region Modificar
        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                objeto_CE_Disponibilidad.ID_DISP = id_disp;
                objeto_CE_Disponibilidad.DESCR_ESTADO = tbEstado.Text;
                objeto_CN_Disponibilidad.ActualizarDatos(objeto_CE_Disponibilidad);

                Content = new Estado();
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
            objeto_CE_Disponibilidad.ID_DISP = id_disp;

            objeto_CN_Disponibilidad.Eliminar(objeto_CE_Disponibilidad);

            Content = new Estado();
        }
        #endregion
 
        #endregion
    }
}
