﻿#pragma checksum "..\..\..\Vistas\Asignar inventario.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE44CBC6A2F438474380B80FEF952C90DC31581E2414ECFD73493D82517B67A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TurismoReal2022.Vistas;


namespace TurismoReal2022.Vistas {
    
    
    /// <summary>
    /// Asignar_inventario
    /// </summary>
    public partial class Asignar_inventario : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 123 "..\..\..\Vistas\Asignar inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Titulo;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\Vistas\Asignar inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegresar;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\Vistas\Asignar inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEliminar;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\Vistas\Asignar inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnModificar;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\Vistas\Asignar inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrear;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\Vistas\Asignar inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDpto;
        
        #line default
        #line hidden
        
        
        #line 230 "..\..\..\Vistas\Asignar inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbObj;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\..\Vistas\Asignar inventario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNomDes;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TurismoReal2022;component/vistas/asignar%20inventario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\Asignar inventario.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BtnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 152 "..\..\..\Vistas\Asignar inventario.xaml"
            this.BtnRegresar.Click += new System.Windows.RoutedEventHandler(this.BtnRegresa);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\..\Vistas\Asignar inventario.xaml"
            this.BtnEliminar.Click += new System.Windows.RoutedEventHandler(this.Eliminar);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 185 "..\..\..\Vistas\Asignar inventario.xaml"
            this.BtnModificar.Click += new System.Windows.RoutedEventHandler(this.Modificar);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\..\Vistas\Asignar inventario.xaml"
            this.BtnCrear.Click += new System.Windows.RoutedEventHandler(this.Crear);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbDpto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.cbObj = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.tbNomDes = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
