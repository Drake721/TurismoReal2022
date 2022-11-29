using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace TurismoReal2022.Vistas
{

    public partial class CrearMantenimiento : Page
    {
        readonly CN_Mantenimiento objeto_CN_MANTENIMIENTO = new CN_Mantenimiento();
        readonly CE_MANTENIMIENTO objeto_CE_MANTENIMIENTO = new CE_MANTENIMIENTO();
        readonly CN_Disponibilidad objeto_CN_Disponibilidad = new CN_Disponibilidad();
        readonly CN_Departamento objeto_CN_Departamento = new CN_Departamento();
        readonly CE_Departamento objeto_CE_Departamento = new CE_Departamento();

        public CrearMantenimiento()
        {
            InitializeComponent();
            CargarCB();
            CargarCB1();
        }
        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Mantenimiento();
        }
        #endregion

        #region cargarDPTO   
        void CargarCB()
        {
            List<string> Departamento = objeto_CN_Departamento.ListarDPTO();
            for (int i = 0; i < Departamento.Count; i++)
            {
                cbDepartamento.Items.Add(Departamento[i]);
            }
        }
        #endregion

        #region cargarDisponibilidad   
        void CargarCB1()
        {
            List<string> Disponibilidad = objeto_CN_Disponibilidad.ListarDisponibilidad();
            for (int i = 0; i < Disponibilidad.Count; i++)
            {
                cbDisponibilidad.Items.Add(Disponibilidad[i]);
            }
        }
        #endregion

        #region VALIDAR CAMPOS VACIOS
        public bool camposLlenos()
            {
                if (cbDepartamento.Text == "" || tbNombreMant.Text == "" || tbDescMant.Text == "" || clFechIni.Text == "" || clFechTerm.Text == "" || cbDisponibilidad.Text == "" || tbCosMant.Text == "")
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
        public int id_mant;
        public int id_dpto;
        #region crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                int Departamento = objeto_CN_Departamento.id_dpto(cbDepartamento.Text);
                int Disponibilidad = objeto_CN_Disponibilidad.ID_DISP(cbDisponibilidad.Text);             
                objeto_CE_MANTENIMIENTO.Id_dpto = Departamento;
                objeto_CE_MANTENIMIENTO.Nombre_mant = tbNombreMant.Text;
                objeto_CE_MANTENIMIENTO.Descripcion_mant = tbDescMant.Text;
                objeto_CE_MANTENIMIENTO.Fecha_inicio = DateTime.Parse(clFechIni.Text);
                objeto_CE_MANTENIMIENTO.Fecha_termino = DateTime.Parse(clFechTerm.Text);
                objeto_CE_MANTENIMIENTO.Disponibilidad = Disponibilidad;
                objeto_CE_MANTENIMIENTO.Costo_mantencion = int.Parse(tbCosMant.Text);

                objeto_CE_Departamento.ID_DPTO = id_dpto;
                objeto_CE_Departamento.DISPONIBILIDAD = Disponibilidad;
                objeto_CN_Departamento.ActualizarEstado(objeto_CE_Departamento);


                objeto_CN_MANTENIMIENTO.Insertar(objeto_CE_MANTENIMIENTO);
                Content = new Mantenimiento();

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
            var a = objeto_CN_MANTENIMIENTO.Consultar(id_mant);
            var b = objeto_CN_Departamento.nombre_dpto(a.Id_dpto);
            var d = objeto_CN_Disponibilidad.DESCR_ESTADO(a.Disponibilidad);

            cbDepartamento.Text = b.NOMBRE_DPTO.ToString();
            tbNombreMant.Text = a.Nombre_mant.ToString();
            tbDescMant.Text = a.Descripcion_mant.ToString();
            clFechIni.Text = a.Fecha_inicio.ToString();
            clFechTerm.Text = a.Fecha_termino.ToString();
            cbDisponibilidad.Text = d.DESCR_ESTADO;
            tbCosMant.Text = a.Costo_mantencion.ToString();


        }
        #endregion

        #region Modificar
        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                int Departamento = objeto_CN_Departamento.id_dpto(cbDepartamento.Text);
                int Disponibilidad = objeto_CN_Disponibilidad.ID_DISP(cbDisponibilidad.Text);
                objeto_CE_MANTENIMIENTO.Id_mant = id_mant;
                objeto_CE_MANTENIMIENTO.Id_dpto = Departamento;
                objeto_CE_MANTENIMIENTO.Nombre_mant = tbNombreMant.Text;
                objeto_CE_MANTENIMIENTO.Descripcion_mant = tbDescMant.Text;
                objeto_CE_MANTENIMIENTO.Fecha_inicio = DateTime.Parse(clFechIni.Text);
                objeto_CE_MANTENIMIENTO.Fecha_termino = DateTime.Parse(clFechTerm.Text);
                objeto_CE_MANTENIMIENTO.Disponibilidad = Disponibilidad;
                objeto_CE_MANTENIMIENTO.Costo_mantencion = int.Parse(tbCosMant.Text);
                objeto_CN_MANTENIMIENTO.ActualizarDatos(objeto_CE_MANTENIMIENTO);
                objeto_CE_Departamento.ID_DPTO = Departamento;
                objeto_CE_Departamento.DISPONIBILIDAD = Disponibilidad;
                objeto_CN_Departamento.ActualizarEstado(objeto_CE_Departamento);

                
                Content = new Mantenimiento();
            }
            else
            {
                MessageBox.Show("Los campos a modificar no pueden quedar vacios");
            }
            #endregion

            #endregion
        }
    }
}
