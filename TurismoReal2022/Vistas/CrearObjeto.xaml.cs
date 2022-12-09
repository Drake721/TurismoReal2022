using CapaEntidad;
using CapaNegocio;
using System;
using System.Windows;
using System.Windows.Controls;

namespace TurismoReal2022.Vistas
{
    /// <summary>
    /// Lógica de interacción para CrearObjeto.xaml
    /// </summary>
    public partial class CrearObjeto : Page
    {

        readonly CN_Objeto objeto_CN_Objeto = new CN_Objeto();
        readonly CE_Objeto objeto_CE_Objeto = new CE_Objeto();

        
        public CrearObjeto()
        {
            InitializeComponent();
        }

        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Objeto();
        }
        #endregion


        #region VALIDAR CAMPOS VACIOS

        public bool valor()
        {
            if (int.TryParse(tbValor.Text.ToString(), out int valor))
            {
                if (valor >= 0 && valor <= 999999999)
                {
                    return true;
                }
                return true;

            }
            else
            {
                try
                {
                    MessageBox.Show("El valor de la tarifa no puede superar los 9 digitos.");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("El valor de la tarifa no puede superar los 9 digitos.");
                }
                return false;
            }

        }
        public bool Codigo()
        {
            if (int.TryParse(tbCodigo.Text.ToString(), out int cod))
            {
                if (cod >= 0 && cod <= 999999999)
                {
                    return true;
                }
                return true;

            }
            else
            {
                try
                {
                    MessageBox.Show("El Numero de departamento no puede superar los 9 digitos.");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("El Numero de departamento no puede superar los 9 digitos.");
                }
                return false;
            }

        }

        public bool cantidad()
        {
            if (int.TryParse(tbcanti.Text.ToString(), out int cantidad))
            {
                if (cantidad >= 0 && cantidad <= 100)
                {
                    return true;
                }
                return true;

            }
            else
            {
                try
                {
                    MessageBox.Show("La capacidad no puede ser mayor a 100.");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("La capacidad no puede ser mayor a 100.");
                }
                return false;
            }

        }

        public bool camposLlenos()
        {
            if (tbCodigo.Text == "" || tbnomObj.Text == "" || tbcanti.Text == "" || tbValor.Text == "")
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
        public int id_obj;
        #region crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true && cantidad() == true && Codigo() == true && valor() == true)
            {
                objeto_CE_Objeto.Codigo_objeto = int.Parse(tbCodigo.Text); 
                objeto_CE_Objeto.Nombre_objeto = tbnomObj.Text;
                objeto_CE_Objeto.Cant_objeto = int.Parse(tbcanti.Text);
                objeto_CE_Objeto.Valor = int.Parse(tbValor.Text);

                objeto_CN_Objeto.Insertar(objeto_CE_Objeto);
                Content = new Objeto();
                MessageBox.Show("Creado con exito");

            }
            else
            {
                MessageBox.Show("Error al momento de crear objeto, reintente!");
            }
        }
        #endregion

        #region cosultas
        public void Consultar()
        {

            var a = objeto_CN_Objeto.Consultar(id_obj);
            tbCodigo.Text = a.Codigo_objeto.ToString();
            tbnomObj.Text = a.Nombre_objeto.ToString();
            tbcanti.Text = a.Cant_objeto.ToString();
            tbValor.Text = a.Valor.ToString();

        }
        #endregion

        #region Modificar
        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true && cantidad() == true && Codigo() == true && valor() == true)
            {
                
                objeto_CE_Objeto.Id_obj = id_obj;
                objeto_CE_Objeto.Codigo_objeto = int.Parse(tbCodigo.Text);
                objeto_CE_Objeto.Nombre_objeto = tbnomObj.Text;
                objeto_CE_Objeto.Cant_objeto = int.Parse(tbcanti.Text);
                objeto_CE_Objeto.Valor = int.Parse(tbValor.Text);
                objeto_CN_Objeto.ActualizarDatos(objeto_CE_Objeto);
                Content = new Objeto();
                MessageBox.Show("Modificado con exito");
            }
            else
            {
                MessageBox.Show("Error al momento de crear objeto, reintente!");
            }
        }
        #endregion

        #region Eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            objeto_CE_Objeto.Id_obj = id_obj;

            objeto_CN_Objeto.Eliminar(objeto_CE_Objeto);

            Content = new Objeto();
        }
        #endregion

        #endregion


    }
}
