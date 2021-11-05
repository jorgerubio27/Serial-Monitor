﻿#pragma checksum "..\..\..\Views\SerialDataView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C46F4848FB1FBFFE16B45EC040B83170DB3DBDF918CCEFB77E2043122E049FC7"
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


namespace Whitestone.OpenSerialPortMonitor.Main.Views {
    
    
    /// <summary>
    /// SerialDataView
    /// </summary>
    public partial class SerialDataView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\Views\SerialDataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ParsedDataScroller;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\SerialDataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DataViewParsed;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\SerialDataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer RawDataScroller;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\SerialDataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DataViewHex;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\SerialDataView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DataViewRaw;
        
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
            System.Uri resourceLocater = new System.Uri("/OpenSerialPortMonitor;component/views/serialdataview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SerialDataView.xaml"
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
            this.ParsedDataScroller = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.DataViewParsed = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Views\SerialDataView.xaml"
            this.DataViewParsed.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.DataViewParsed_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RawDataScroller = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 4:
            this.DataViewHex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DataViewRaw = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 61 "..\..\..\Views\SerialDataView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Limpiar);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 70 "..\..\..\Views\SerialDataView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Copy_Brix);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 79 "..\..\..\Views\SerialDataView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Copy_ACC);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 88 "..\..\..\Views\SerialDataView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Copy_ASC);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 97 "..\..\..\Views\SerialDataView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Copy_CO2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

