using CapaEntidad;
using CapaNegocio;
using MaterialDesignThemes.Wpf;
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
    /// Lógica de interacción para InventarioFiltrado.xaml
    /// </summary>
    public partial class InventarioFiltrado : UserControl
    {
        readonly CE_Inventario_DPTO objeto_CE_Inventario_DPTO = new CE_Inventario_DPTO();
        readonly CE_Departamento objeto_CE_Departamento = new CE_Departamento();
        readonly CN_Inventario objeto_CN_Inventario = new CN_Inventario();
        readonly CN_Departamento objeto_CN_Departamento = new CN_Departamento();

        public InventarioFiltrado()
        {
            InitializeComponent();            
            CargarCB1();
        }
        #region cargar
        void CargarCB1()
        {
            List<string> Departamento = objeto_CN_Departamento.ListarDPTO();
            for (int i = 0; i < Departamento.Count; i++)
            {
                cbDpto.Items.Add(Departamento[i]);
            }
        }
        #endregion
        public int ID_DPTO;
        #region regresar
        private void BtnRegresa(object sender, RoutedEventArgs e)
        {
            Content = new Inventario();
        }
        #endregion
        
        #region cargar Dpto
        void CargarDatos()
        {

            GridDatos.ItemsSource = objeto_CN_Inventario.CargarDptoinv(ID_DPTO).DefaultView;

        }


        #endregion

        private void CrearInvClick(object sender, RoutedEventArgs e)
        {
            int Departamento = objeto_CN_Departamento.id_dpto(cbDpto.Text);
            ID_DPTO = Departamento;
            CargarDatos();
        }

    
            
        
    }
}
