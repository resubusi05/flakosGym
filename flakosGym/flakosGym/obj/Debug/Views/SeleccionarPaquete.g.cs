﻿#pragma checksum "..\..\..\Views\SeleccionarPaquete.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9DC84C9B43987A21DEBE95E6996C90C954A68BF38CEC7669763FB2636459A37A"
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
using flakosGym.Views;


namespace flakosGym.Views {
    
    
    /// <summary>
    /// SeleccionarPaquete
    /// </summary>
    public partial class SeleccionarPaquete : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\Views\SeleccionarPaquete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMinimize;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Views\SeleccionarPaquete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClose;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Views\SeleccionarPaquete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox anualidad;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\Views\SeleccionarPaquete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox mensalualidad;
        
        #line default
        #line hidden
        
        
        #line 309 "..\..\..\Views\SeleccionarPaquete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Semana;
        
        #line default
        #line hidden
        
        
        #line 361 "..\..\..\Views\SeleccionarPaquete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox dosSemanas;
        
        #line default
        #line hidden
        
        
        #line 413 "..\..\..\Views\SeleccionarPaquete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox visita;
        
        #line default
        #line hidden
        
        
        #line 447 "..\..\..\Views\SeleccionarPaquete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardarDatos;
        
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
            System.Uri resourceLocater = new System.Uri("/flakosGym;component/views/seleccionarpaquete.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SeleccionarPaquete.xaml"
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
            this.BtnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Views\SeleccionarPaquete.xaml"
            this.BtnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnClose = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Views\SeleccionarPaquete.xaml"
            this.BtnClose.Click += new System.Windows.RoutedEventHandler(this.BtnClose_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.anualidad = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.mensalualidad = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.Semana = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.dosSemanas = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.visita = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.btnGuardarDatos = ((System.Windows.Controls.Button)(target));
            
            #line 458 "..\..\..\Views\SeleccionarPaquete.xaml"
            this.btnGuardarDatos.Click += new System.Windows.RoutedEventHandler(this.btnPagarAhora);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

