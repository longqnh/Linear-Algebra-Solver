﻿#pragma checksum "..\..\..\..\Controls\Variable.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9E2496008DE10EA1197967B1A479FBB"
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
    /// Variable
    /// </summary>
    public partial class Variable : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\Controls\Variable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbValue;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\Controls\Variable.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbVarName;
        
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
            System.Uri resourceLocater = new System.Uri("/DaiSoTuyenTinh;component/controls/variable.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\Variable.xaml"
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
            this.tbValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 9 "..\..\..\..\Controls\Variable.xaml"
            this.tbValue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbValue_TextChanged);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\..\Controls\Variable.xaml"
            this.tbValue.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.tbValue_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\..\Controls\Variable.xaml"
            this.tbValue.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.tbValue_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbVarName = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
