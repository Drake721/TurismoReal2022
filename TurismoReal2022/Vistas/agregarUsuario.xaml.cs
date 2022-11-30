using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CapaEntidad;
using CapaNegocio;
using System.Collections.Generic;

namespace TurismoReal2022.Vistas
{
    public partial class agregarUsuario : Page
    {
        readonly CN_Usuario objeto_CN_Usuario = new CN_Usuario();
        readonly CE_Usuario objeto_CE_Usuario = new CE_Usuario();
        readonly CN_Cargo objeto_CN_CARGO = new CN_Cargo();

        #region inicial
        public agregarUsuario()
        {
            InitializeComponent();
            CargarCB();
        }
        #endregion

        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Usuarios();
        }
        #endregion

        #region cargar cargos
        void CargarCB()
        {
            List<string> Cargo = objeto_CN_CARGO.ListarCargos();
            for (int i = 0; i < Cargo.Count; i++)
            {
                cbCargo.Items.Add(Cargo[i]);
            }
        }
        #endregion

        #region VALIDAR CAMPOS VACIOS
        public bool camposLlenos()
        {
            if (tbNombres.Text == "" || tbApellido.Text == "" || tbsegApellido.Text == "" || tbRut.Text == "" || tbCorreo.Text == "" || tbCelular.Text == "" || cbCargo.Text == "")
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
        public string patron = "ENCRIPTA";

        #region crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if(camposLlenos()== true && tbClave.Text !="")
            {
                int Cargo = objeto_CN_CARGO.ID(cbCargo.Text);
                objeto_CE_Usuario.Email = tbCorreo.Text;
                objeto_CE_Usuario.Clave = tbClave.Text;
                objeto_CE_Usuario.Celular = int.Parse(tbCelular.Text);
                objeto_CE_Usuario.Rut = tbRut.Text;
                objeto_CE_Usuario.Nombres = tbNombres.Text;
                objeto_CE_Usuario.Apellidopaterno = tbApellido.Text;
                objeto_CE_Usuario.Apellidomaterno = tbsegApellido.Text;
                objeto_CE_Usuario.Img = data;
                objeto_CE_Usuario.Idcargo = Cargo;
                objeto_CE_Usuario.Patron = patron;

                objeto_CN_Usuario.Insertar(objeto_CE_Usuario);
                Content = new Usuarios();

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
            var a = objeto_CN_Usuario.Consultar(id_usuario);
            tbCorreo.Text = a.Email.ToString();
            tbCelular.Text = a.Celular.ToString();
            tbRut.Text = a.Rut.ToString();
            tbNombres.Text = a.Nombres.ToString();
            tbApellido.Text = a.Apellidopaterno.ToString();
            tbsegApellido.Text = a.Apellidomaterno.ToString();
            var b = objeto_CN_CARGO.nombrecargo(a.Idcargo);
            cbCargo.Text = b.Nombrecargo;

            ImageSourceConverter imgs = new ImageSourceConverter();
            imagen.Source = (ImageSource)imgs.ConvertFrom(a.Img);

        }
        #endregion

        #region Modificar
        private void Modificar(object sender, RoutedEventArgs e)
        {
            if(camposLlenos()==true)
            {
                int Cargo = objeto_CN_CARGO.ID(cbCargo.Text);

                objeto_CE_Usuario.Id_usuario = id_usuario;
                objeto_CE_Usuario.Email = tbCorreo.Text;
                objeto_CE_Usuario.Celular = int.Parse(tbCelular.Text);
                objeto_CE_Usuario.Rut = tbRut.Text;
                objeto_CE_Usuario.Nombres = tbNombres.Text;
                objeto_CE_Usuario.Apellidopaterno = tbApellido.Text;
                objeto_CE_Usuario.Apellidomaterno = tbsegApellido.Text;
                objeto_CE_Usuario.Idcargo = Cargo;
                objeto_CN_Usuario.ActualizarDatos(objeto_CE_Usuario);
                Content = new Usuarios();
            }
            else
            {
                MessageBox.Show("Los campos a modificar no pueden quedar vacios");
            }
            if (tbClave.Text != "")
            {
                objeto_CE_Usuario.Id_usuario = id_usuario;
                objeto_CE_Usuario.Clave = tbClave.Text;
                objeto_CE_Usuario.Patron = patron;

                objeto_CN_Usuario.ActualizarClave(objeto_CE_Usuario);
                Content = new Usuarios();

            }
            if (imagenSubida==true)
            {
                objeto_CE_Usuario.Id_usuario = id_usuario;
                objeto_CE_Usuario.Img = data;

                objeto_CN_Usuario.ActualizarIMG(objeto_CE_Usuario);

                Content = new Usuarios();
            }
        }
        #endregion

        #region Eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            objeto_CE_Usuario.Id_usuario = id_usuario;

            objeto_CN_Usuario.Eliminar(objeto_CE_Usuario);

            Content = new Usuarios();
        }
        #endregion

        #region imagen procesamiento
        byte[] data;
        private bool imagenSubida = false;
        private void Subirimg(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==true)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                ImageSourceConverter imgs = new ImageSourceConverter();
                imagen.SetValue(Image.SourceProperty, imgs.ConvertFromString(ofd.FileName.ToString()));
            }
            imagenSubida = true;
        }
        #endregion

        #endregion
    }
}
