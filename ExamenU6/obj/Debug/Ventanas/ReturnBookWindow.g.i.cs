﻿#pragma checksum "..\..\..\Ventanas\ReturnBookWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "48025F671B648533A7F2D4422FCD5624C6C2EB1F8002BB81C11531589C218EFA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ExamenU6.Ventanas;
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


namespace ExamenU6.Ventanas {
    
    
    /// <summary>
    /// ReturnBookWindow
    /// </summary>
    public partial class ReturnBookWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Ventanas\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RFID;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Ventanas\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button scanCard;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Ventanas\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock usuario;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Ventanas\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listLibros;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Ventanas\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button devolverLibro;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Ventanas\ReturnBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/ExamenU6;component/ventanas/returnbookwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventanas\ReturnBookWindow.xaml"
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
            
            #line 8 "..\..\..\Ventanas\ReturnBookWindow.xaml"
            ((ExamenU6.Ventanas.ReturnBookWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RFID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.scanCard = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Ventanas\ReturnBookWindow.xaml"
            this.scanCard.Click += new System.Windows.RoutedEventHandler(this.TarjetaRFID_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.usuario = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.listLibros = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.devolverLibro = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Ventanas\ReturnBookWindow.xaml"
            this.devolverLibro.Click += new System.Windows.RoutedEventHandler(this.devolverLibro_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Ventanas\ReturnBookWindow.xaml"
            this.cancelar.Click += new System.Windows.RoutedEventHandler(this.cancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

