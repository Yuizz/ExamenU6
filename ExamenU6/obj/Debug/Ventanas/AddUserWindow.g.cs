﻿#pragma checksum "..\..\..\Ventanas\AddUserWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3268B357A7C4AA1E97997F8FF21AD65813AEAC0E9DD0D883FB5BD2687C9E8A00"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ExamenU6;
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


namespace ExamenU6 {
    
    
    /// <summary>
    /// AddUserWindow
    /// </summary>
    public partial class AddUserWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TarjetaRFID;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Dato4;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombre;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox direccion;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RFID;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnStudent;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnTeacher;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxDato4;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Guardar;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Ventanas\AddUserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/ExamenU6;component/ventanas/adduserwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventanas\AddUserWindow.xaml"
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
            
            #line 8 "..\..\..\Ventanas\AddUserWindow.xaml"
            ((ExamenU6.AddUserWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TarjetaRFID = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Ventanas\AddUserWindow.xaml"
            this.TarjetaRFID.Click += new System.Windows.RoutedEventHandler(this.TarjetaRFID_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Dato4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.nombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\Ventanas\AddUserWindow.xaml"
            this.nombre.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.nombre_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.direccion = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\Ventanas\AddUserWindow.xaml"
            this.direccion.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.direccion_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RFID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnStudent = ((System.Windows.Controls.RadioButton)(target));
            
            #line 34 "..\..\..\Ventanas\AddUserWindow.xaml"
            this.btnStudent.Click += new System.Windows.RoutedEventHandler(this.btnStudent_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnTeacher = ((System.Windows.Controls.RadioButton)(target));
            
            #line 35 "..\..\..\Ventanas\AddUserWindow.xaml"
            this.btnTeacher.Click += new System.Windows.RoutedEventHandler(this.btnTeacher_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.boxDato4 = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Ventanas\AddUserWindow.xaml"
            this.boxDato4.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.boxDato4_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Guardar = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Ventanas\AddUserWindow.xaml"
            this.Guardar.Click += new System.Windows.RoutedEventHandler(this.Guardar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Ventanas\AddUserWindow.xaml"
            this.Cancelar.Click += new System.Windows.RoutedEventHandler(this.Cancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

