using CapaEntidad;
using CapaNegocio;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TurismoReal2022.Vistas.ValidacionesDepto;

namespace TurismoReal2022.Vistas
{
    /// <summary>
    /// Lógica de interacción para Asignar_inventario.xaml
    /// </summary>
    public partial class Asignar_inventario : Page
    {
        //readonly CN_Departamento objeto_CN_Departamento = new CN_Departamento();
        readonly CE_Inventario_DPTO objeto_CE_Inventario_DPTO = new CE_Inventario_DPTO();
        readonly CN_Inventario objeto_CN_Inventario = new CN_Inventario();
        readonly CN_Objeto objeto_CN_Objeto = new CN_Objeto();
        readonly CN_Departamento objeto_CN_Departamento = new CN_Departamento();


        BindingList<string> errores = new BindingList<string>();

        public Asignar_inventario()
        {
            
            InitializeComponent();
            CargarCB();
            CargarCB1();
        }

        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Inventario();
        }
        #endregion

        #region cargarObjeto
        void CargarCB()
        {
            List<string> Objeto = objeto_CN_Objeto.ListarObjeto();
            for (int i = 0; i < Objeto.Count; i++)
            {
                cbObj.Items.Add(Objeto[i]);
            }
        }
        #endregion

        #region cargarDPTO   
        void CargarCB1()
        {
            List<string> Departamento = objeto_CN_Departamento.ListarDPTO();
            for (int i = 0; i < Departamento.Count; i++)
            {
                cbDpto.Items.Add(Departamento[i]);
            }
        }
        #endregion

        #region VALIDAR CAMPOS

        
        public bool camposLlenos()
        {
            if (cbDpto.Text == "" || cbObj.Text == "" || tbNomDes.Text == "" )
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
        public int Id_inv;

        #region crear
        private void Crear(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true )
            {
                int Departamento = objeto_CN_Departamento.id_dpto(cbDpto.Text);
                int Objeto = objeto_CN_Objeto.id_obj(cbObj.Text);
                
                objeto_CE_Inventario_DPTO.Id_dpto = Departamento;
                objeto_CE_Inventario_DPTO.Id_objeto = Objeto;
                objeto_CE_Inventario_DPTO.Nombre_inventario = tbNomDes.Text;  
                MessageBox.Show("Creado con exito");
                objeto_CN_Inventario.Insertar(objeto_CE_Inventario_DPTO);
                Content = new Inventario();
                


            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. No se podido crear, Reintente!");
            }
        }
        #endregion

        #region cosultas
        public void Consultar()
        {
            var a = objeto_CN_Inventario.Consultar(Id_inv);
            var c = objeto_CN_Objeto.nombre_objeto(a.Id_objeto);
            var b = objeto_CN_Departamento.nombre_dpto(a.Id_dpto);
            cbObj.Text = c.Nombre_objeto;
            cbDpto.Text = b.NOMBRE_DPTO;
            tbNomDes.Text = a.Nombre_inventario.ToString();
           
        }
        #endregion

        #region Modificar
        private void Modificar(object sender, RoutedEventArgs e)
        {
            if (camposLlenos() == true)
            {
                int Departamento = objeto_CN_Departamento.id_dpto(cbDpto.Text);
                int Objeto = objeto_CN_Objeto.id_obj(cbObj.Text);
                objeto_CE_Inventario_DPTO.Id_inv = Id_inv;
                objeto_CE_Inventario_DPTO.Id_dpto = Departamento;
                objeto_CE_Inventario_DPTO.Id_objeto = Objeto;
                objeto_CE_Inventario_DPTO.Nombre_inventario = tbNomDes.Text;
                MessageBox.Show("Modificado con exito");
                objeto_CN_Inventario.ActualizarDatos(objeto_CE_Inventario_DPTO);
                Content = new Inventario();

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. No se podido modificar, Reintente!");
            }           
        }
        #endregion

        #region Eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            objeto_CE_Inventario_DPTO.Id_inv = Id_inv;

            objeto_CN_Inventario.Eliminar(objeto_CE_Inventario_DPTO);

            Content = new Inventario();
        }
        #endregion
       
        #endregion

        
    }
}
