using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CapaEntidad;
using CapaNegocio;
using System.Collections.Generic;
using MaterialDesignThemes.Wpf;
using System;
using System.ComponentModel;
using FluentValidation.Results;
using TurismoReal2022.Vistas.ValidacionesUsuario;
using TurismoReal2022.Vistas.ValidacionesDepto;

namespace TurismoReal2022.Vistas
{
    public partial class AgregarDPTO : Page
    {
        readonly CN_Departamento objeto_CN_Departamento = new CN_Departamento();
        readonly CE_Departamento objeto_CE_Departamento = new CE_Departamento();
        readonly CN_Comuna objeto_CN_Comuna = new CN_Comuna();
        readonly CN_Region objeto_CN_Region = new CN_Region();
        readonly CN_Disponibilidad objeto_CN_Disponibilidad = new CN_Disponibilidad();

        BindingList<string> errores = new BindingList<string>();

        public AgregarDPTO()
        {
            InitializeComponent();
            CargarCB();
            CargarCB1();
            CargarCB2();
        }

        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Departamentos();
        }
        #endregion

        #region cargarREGION
        void CargarCB()
        {
            List<string> Region = objeto_CN_Region.ListarRegion();
            for (int i = 0; i < Region.Count; i++)
            {
                cbRegion.Items.Add(Region[i]);
            }
        }
        #endregion

        #region cargarCOMUNA   
        void CargarCB1()
        {
            List<string> Comuna = objeto_CN_Comuna.ListarComuna();
            for (int i = 0; i < Comuna.Count; i++)
            {
                cbComuna.Items.Add(Comuna[i]);
            }
        }
        #endregion

        #region cargarDisponibilidad   
        void CargarCB2()
        {
            List<string> Disponibilidad = objeto_CN_Disponibilidad.ListarDisponibilidad();
            for (int i = 0; i < Disponibilidad.Count; i++)
            {
                cbDisponibilidad.Items.Add(Disponibilidad[i]);
            }
        }
        #endregion

        #region VALIDAR CAMPOS

        public bool tarifamenora()
        {
            if (int.TryParse(tbTARIFA.Text.ToString(), out int tarifa))
            {
                if (tarifa >= 0 && tarifa <= 999999999)
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
        public bool nrodptomenora()
        {
            if (int.TryParse(tbNRODPTO.Text.ToString(), out int nrodpto))
            {
                if (nrodpto >= 0 && nrodpto <= 999999999)
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

        public bool capacidadmenora()
        {
            if (int.TryParse(tbCAPACIDAD.Text.ToString(), out int capacidad))
            {
                if (capacidad >= 0 && capacidad <= 10)
                {
                    return true;
                }
                return true;              

            }
            else
            {
                try
                {
                    MessageBox.Show("La capacidad no puede ser mayor a 10.");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("La capacidad no puede ser mayor a 10.");
                }
                return false;
            }

        }

        public bool camposLlenos()
        {
            if (tbNombreDPTO.Text == "" || tbTARIFA.Text == "" || tbDIRECCION.Text == "" || tbNRODPTO.Text == "" || tbCAPACIDAD.Text == "" || cbRegion.Text == "" || cbComuna.Text == "" || cbDisponibilidad.Text == "")
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
        public int ID_DPTO;

        #region crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true && capacidadmenora() == true && nrodptomenora() == true && tarifamenora() == true)
            {
                int Region = objeto_CN_Region.ID_REGION(cbRegion.Text);
                int Comuna = objeto_CN_Comuna.ID_COMUNA(cbComuna.Text);
                int Disponibilidad = objeto_CN_Disponibilidad.ID_DISP(cbDisponibilidad.Text);
                objeto_CE_Departamento.NOMBRE_DPTO = tbNombreDPTO.Text;
                objeto_CE_Departamento.TARIFA_DIARIA = int.Parse(tbTARIFA.Text);
                objeto_CE_Departamento.DIRECCION = tbDIRECCION.Text;
                objeto_CE_Departamento.NRO_DPTO = int.Parse(tbNRODPTO.Text);
                objeto_CE_Departamento.CAPACIDAD = int.Parse(tbCAPACIDAD.Text);
                objeto_CE_Departamento.ID_COMUNA = Comuna;
                objeto_CE_Departamento.DISPONIBILIDAD = Disponibilidad;
                objeto_CE_Departamento.IMAGEN = tbImagweb.Text;
                objeto_CE_Departamento.IMG = data;
                objeto_CE_Departamento.IMG1 = data1;
                objeto_CE_Departamento.IMG2 = data2;



                ValidacionesDpto validator = new ValidacionesDpto();
                FluentValidation.Results.ValidationResult resultados = validator.Validate(objeto_CE_Departamento);

                if (resultados.IsValid == false)
                {
                    foreach (ValidationFailure item in resultados.Errors)
                    {
                        MessageBox.Show("Error", item.ErrorMessage);
                    }
                }
                else
                {

                    MessageBox.Show("Creado con exito");
                    objeto_CN_Departamento.Insertar(objeto_CE_Departamento);
                    Content = new Departamentos();
                }


            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. No se podido crear el usuario, Reintente!");
            }
        }
            #endregion

            #region cosultas
            public void Consultar()
        {
            var a = objeto_CN_Departamento.Consultar(ID_DPTO);
            var c = objeto_CN_Region.NOMBRE_REGION(a.ID_COMUNA);
            var b = objeto_CN_Comuna.NOMBRE_COMUNA(a.ID_COMUNA);
            var d = objeto_CN_Disponibilidad.DESCR_ESTADO(a.DISPONIBILIDAD);
            tbNombreDPTO.Text = a.NOMBRE_DPTO.ToString();
            tbTARIFA.Text = a.TARIFA_DIARIA.ToString();
            tbDIRECCION.Text = a.DIRECCION.ToString();
            tbNRODPTO.Text = a.NRO_DPTO.ToString();
            tbCAPACIDAD.Text = a.CAPACIDAD.ToString();
            cbRegion.Text = c.NOMBRE_REGION;
            cbComuna.Text = b.NOMBRE_COMUNA;
            cbDisponibilidad.Text = d.DESCR_ESTADO;
            tbImagweb.Text = a.IMAGEN.ToString();

            ImageSourceConverter imgs = new ImageSourceConverter();
            imagen.Source = (ImageSource)imgs.ConvertFrom(a.IMG);

            ImageSourceConverter imgs1 = new ImageSourceConverter();
            imagen1.Source = (ImageSource)imgs1.ConvertFrom(a.IMG1);

            ImageSourceConverter imgs2 = new ImageSourceConverter();
            imagen2.Source = (ImageSource)imgs2.ConvertFrom(a.IMG2);
        }
        #endregion

        #region Modificar
        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true && capacidadmenora() == true && nrodptomenora() == true && tarifamenora() == true)
            {
                int Region = objeto_CN_Region.ID_REGION(cbRegion.Text);
                int Comuna = objeto_CN_Comuna.ID_COMUNA(cbComuna.Text);
                int Disponibilidad = objeto_CN_Disponibilidad.ID_DISP(cbDisponibilidad.Text);
                objeto_CE_Departamento.ID_DPTO = ID_DPTO;
                objeto_CE_Departamento.NOMBRE_DPTO = tbNombreDPTO.Text;
                objeto_CE_Departamento.TARIFA_DIARIA = int.Parse(tbTARIFA.Text);
                objeto_CE_Departamento.DIRECCION = tbDIRECCION.Text;
                objeto_CE_Departamento.NRO_DPTO = int.Parse(tbNRODPTO.Text);
                objeto_CE_Departamento.CAPACIDAD = int.Parse(tbCAPACIDAD.Text);
                objeto_CE_Departamento.ID_COMUNA = Comuna;
                objeto_CE_Departamento.DISPONIBILIDAD = Disponibilidad;
                objeto_CE_Departamento.IMAGEN = tbImagweb.Text;
                objeto_CN_Departamento.ActualizarDatos(objeto_CE_Departamento);
                Content = new Departamentos();
            }
            else
            {
                MessageBox.Show("Los campos a modificar no pueden quedar vacios");
            }
            if (imagenSubida == true)
            {
                objeto_CE_Departamento.ID_DPTO = ID_DPTO;
                objeto_CE_Departamento.IMG = data;

                objeto_CN_Departamento.ActualizarIMG(objeto_CE_Departamento);

                Content = new Departamentos();
            }
            if (imagenSubida1 == true)
            {
                objeto_CE_Departamento.ID_DPTO = ID_DPTO;
                objeto_CE_Departamento.IMG1 = data1;

                objeto_CN_Departamento.ActualizarIMG1(objeto_CE_Departamento);

                Content = new Departamentos();
            }
            if (imagenSubida2 == true)
            {
                objeto_CE_Departamento.ID_DPTO = ID_DPTO;
                objeto_CE_Departamento.IMG2 = data2;

                objeto_CN_Departamento.ActualizarIMG2(objeto_CE_Departamento);

                Content = new Departamentos();
            }
        }
        #endregion

        #region Eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            objeto_CE_Departamento.ID_DPTO = ID_DPTO;

            objeto_CN_Departamento.Eliminar(objeto_CE_Departamento);

            Content = new Departamentos();
        }
        #endregion
        #region imagen procesamiento
        byte[] data;
        byte[] data1;
        byte[] data2;
        private bool imagenSubida = false;
        private bool imagenSubida1 = false;
        private bool imagenSubida2 = false;

        private void Subirimg(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
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

        private void Subirimg1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                data1 = new byte[fs.Length];
                fs.Read(data1, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                ImageSourceConverter imgs1 = new ImageSourceConverter();
                imagen1.SetValue(Image.SourceProperty, imgs1.ConvertFromString(ofd.FileName.ToString()));
            }
            imagenSubida1 = true;
        }


        private void Subirimg2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                data2 = new byte[fs.Length];
                fs.Read(data2, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                ImageSourceConverter imgs2 = new ImageSourceConverter();
                imagen2.SetValue(Image.SourceProperty, imgs2.ConvertFromString(ofd.FileName.ToString()));
            }
            imagenSubida2 = true;
        }


        #endregion
        #endregion
    }
}
