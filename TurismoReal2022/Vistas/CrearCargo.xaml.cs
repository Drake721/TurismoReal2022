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
    public partial class CrearCargo : Page
    {
        readonly CN_Cargo objeto_CN_Cargo = new CN_Cargo();
        readonly CE_Cargo objeto_CE_Cargo = new CE_Cargo();
        
        public CrearCargo()
        {
            InitializeComponent();
        }

        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Cargo();
        }
        #endregion

        #region VALIDAR CAMPOS VACIOS
        public bool camposLlenos()
        {
            if (tbCodCar.Text == "" || tbNomCar.Text == "" || tbDescCar.Text == "" )
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
        public int id;

        #region crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                
                objeto_CE_Cargo.Codigo = int.Parse(tbCodCar.Text);
                objeto_CE_Cargo.Nombrecargo = tbNomCar.Text;
                objeto_CE_Cargo.Descripcion = tbDescCar.Text;
                

                objeto_CN_Cargo.Insertar(objeto_CE_Cargo);
                Content = new Cargo();

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
            var a = objeto_CN_Cargo.Consultar(id);

            tbCodCar.Text = a.Codigo.ToString();
            tbNomCar.Text = a.Nombrecargo.ToString();
            tbDescCar.Text = a.Descripcion.ToString();
            
        }
        #endregion

        #region Modificar
        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                objeto_CE_Cargo.Id = id;
                objeto_CE_Cargo.Codigo = int.Parse(tbCodCar.Text);
                objeto_CE_Cargo.Nombrecargo = tbNomCar.Text;
                objeto_CE_Cargo.Descripcion = tbDescCar.Text;
                
                objeto_CN_Cargo.ActualizarDatos(objeto_CE_Cargo);
                Content = new Cargo();
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
            objeto_CE_Cargo.Id = id;

            objeto_CN_Cargo.Eliminar(objeto_CE_Cargo);

            Content = new Cargo();
        }
        #endregion
        #endregion
    }
}
