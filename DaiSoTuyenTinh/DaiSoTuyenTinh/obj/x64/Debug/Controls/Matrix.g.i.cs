﻿#pragma checksum "..\..\..\..\Controls\Matrix.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A2294F88A996299934C4C875842149D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DaiSoTuyenTinh.Controls;
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


namespace DaiSoTuyenTinh.Controls {
    
    
    /// <summary>
    /// Matrix
    /// </summary>
    public partial class Matrix : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Controls\Matrix.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbRows;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Controls\Matrix.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCols;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Controls\Matrix.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbMatrix;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Controls\Matrix.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Controls\Matrix.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tbRandom;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Controls\Matrix.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbQuestion;
        
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
            System.Uri resourceLocater = new System.Uri("/DaiSoTuyenTinh;component/controls/matrix.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\Matrix.xaml"
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
            this.tbRows = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbCols = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lbMatrix = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Controls\Matrix.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbRandom = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Controls\Matrix.xaml"
            this.tbRandom.Click += new System.Windows.RoutedEventHandler(this.tbRandom_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbQuestion = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

