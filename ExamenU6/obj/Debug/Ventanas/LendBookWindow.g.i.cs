﻿#pragma checksum "..\..\..\Ventanas\LendBookWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99FD635F1F674011DD8650CF5181E099076356AA11EB4C628386169DBA943739"
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
    /// LendBookWindow
    /// </summary>
    public partial class LendBookWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Ventanas\LendBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RFIDBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Ventanas\LendBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button scanCard;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Ventanas\LendBookWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/ExamenU6;component/ventanas/lendbookwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventanas\LendBookWindow.xaml"
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
            this.RFIDBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.scanCard = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Ventanas\LendBookWindow.xaml"
            this.scanCard.Click += new System.Windows.RoutedEventHandler(this.scanCard_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cancel = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Ventanas\LendBookWindow.xaml"
            this.cancel.Click += new System.Windows.RoutedEventHandler(this.cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

