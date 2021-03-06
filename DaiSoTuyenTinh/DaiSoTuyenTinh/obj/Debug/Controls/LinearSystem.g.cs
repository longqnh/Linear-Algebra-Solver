﻿#pragma checksum "..\..\..\Controls\LinearSystem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "190FFAEF3FDC2FF0BE5D898920F42B2D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
using System.Windows.Forms.Integration;
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
    /// LinearSystem
    /// </summary>
    public partial class LinearSystem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Controls\LinearSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbError;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Controls\LinearSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listEqs;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\LinearSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Controls\LinearSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNumEquations;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Controls\LinearSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tbRandom;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Controls\LinearSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbQuestion;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Controls\LinearSystem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowSol;
        
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
            System.Uri resourceLocater = new System.Uri("/DaiSoTuyenTinh;component/controls/linearsystem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\LinearSystem.xaml"
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
            this.lbError = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.listEqs = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Controls\LinearSystem.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbNumEquations = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\..\Controls\LinearSystem.xaml"
            this.tbNumEquations.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbNumEquations_TextChanged);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Controls\LinearSystem.xaml"
            this.tbNumEquations.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tb_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Controls\LinearSystem.xaml"
            this.tbNumEquations.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.tb_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbRandom = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Controls\LinearSystem.xaml"
            this.tbRandom.Click += new System.Windows.RoutedEventHandler(this.tbRandom_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbQuestion = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.ShowSol = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Controls\LinearSystem.xaml"
            this.ShowSol.Click += new System.Windows.RoutedEventHandler(this.ShowSol_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

