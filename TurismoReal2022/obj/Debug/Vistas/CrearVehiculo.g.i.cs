﻿#pragma checksum "..\..\..\Vistas\CrearVehiculo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "66E5F7191D7558E86E394E028A6490EE12BCD0D4B8486CB405F5C68C56D5C518"
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
    /// CrearVehiculo
    /// </summary>
    public partial class CrearVehiculo : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 124 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Titulo;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegresar;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnModificar;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrear;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEliminar;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPatente;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCodigo;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescVehi;
        
        #line default
        #line hidden
        
        
        #line 261 "..\..\..\Vistas\CrearVehiculo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbChofer;
        
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
            System.Uri resourceLocater = new System.Uri("/TurismoReal2022;component/vistas/crearvehiculo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\CrearVehiculo.xaml"
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
            
            #line 153 "..\..\..\Vistas\CrearVehiculo.xaml"
            this.BtnRegresar.Click += new System.Windows.RoutedEventHandler(this.BtnRegresa);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\..\Vistas\CrearVehiculo.xaml"
            this.BtnModificar.Click += new System.Windows.RoutedEventHandler(this.Modificar);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 186 "..\..\..\Vistas\CrearVehiculo.xaml"
            this.BtnCrear.Click += new System.Windows.RoutedEventHandler(this.Crear);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 203 "..\..\..\Vistas\CrearVehiculo.xaml"
            this.BtnEliminar.Click += new System.Windows.RoutedEventHandler(this.Eliminar);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbPatente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbCodigo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbDescVehi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cbChofer = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

