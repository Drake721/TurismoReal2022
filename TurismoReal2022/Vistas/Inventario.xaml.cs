﻿using System;
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
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : UserControl
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void ObjetoClick(object sender, RoutedEventArgs e)
        {
            Objeto ventana = new Objeto();
            Frameinventario.Content = ventana;
        }

    }
}
