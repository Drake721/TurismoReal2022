﻿#pragma checksum "..\..\..\Vistas\Mantenimiento.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E0C6B6979A92062601296CCEB6F8B0F4E905401C5DA76B4DF3131A284BD2F29"
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
    /// Mantenimiento
    /// </summary>
    public partial class Mantenimiento : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 238 "..\..\..\Vistas\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMantenimiento;
        
        #line default
        #line hidden
        
        
        #line 304 "..\..\..\Vistas\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SecVehiculo;
        
        #line default
        #line hidden
        
        
        #line 336 "..\..\..\Vistas\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SecCargo;
        
        #line default
        #line hidden
        
        
        #line 368 "..\..\..\Vistas\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SecEstado;
        
        #line default
        #line hidden
        
        
        #line 405 "..\..\..\Vistas\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CrearMantenimiento;
        
        #line default
        #line hidden
        
        
        #line 447 "..\..\..\Vistas\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDatos;
        
        #line default
        #line hidden
        
        
        #line 512 "..\..\..\Vistas\Mantenimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameMantenimiento;
        
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
            System.Uri resourceLocater = new System.Uri("/TurismoReal2022;component/vistas/mantenimiento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\Mantenimiento.xaml"
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
            this.GridMantenimiento = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SecVehiculo = ((System.Windows.Controls.Button)(target));
            
            #line 315 "..\..\..\Vistas\Mantenimiento.xaml"
            this.SecVehiculo.Click += new System.Windows.RoutedEventHandler(this.VehiculoClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SecCargo = ((System.Windows.Controls.Button)(target));
            
            #line 347 "..\..\..\Vistas\Mantenimiento.xaml"
            this.SecCargo.Click += new System.Windows.RoutedEventHandler(this.CargoClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SecEstado = ((System.Windows.Controls.Button)(target));
            
            #line 379 "..\..\..\Vistas\Mantenimiento.xaml"
            this.SecEstado.Click += new System.Windows.RoutedEventHandler(this.EstadoClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CrearMantenimiento = ((System.Windows.Controls.Button)(target));
            
            #line 416 "..\..\..\Vistas\Mantenimiento.xaml"
            this.CrearMantenimiento.Click += new System.Windows.RoutedEventHandler(this.Agregar);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GridDatos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.FrameMantenimiento = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 474 "..\..\..\Vistas\Mantenimiento.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConsultarMant);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 483 "..\..\..\Vistas\Mantenimiento.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Actualizar);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

