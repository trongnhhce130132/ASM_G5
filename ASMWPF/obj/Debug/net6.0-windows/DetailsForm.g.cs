﻿#pragma checksum "..\..\..\DetailsForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9C7EF0DDED91BD40C69743771BAB8DEA6D84BCEC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ASMWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ASMWPF {
    
    
    /// <summary>
    /// DetailsForm
    /// </summary>
    public partial class DetailsForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgdetail;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnback;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbMT;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbPrice;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnup;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btndown;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSL;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\DetailsForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnadd;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ASMWPF;component/detailsform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DetailsForm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgdetail = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btnback = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\DetailsForm.xaml"
            this.btnback.Click += new System.Windows.RoutedEventHandler(this.btnback_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbMT = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnup = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\DetailsForm.xaml"
            this.btnup.Click += new System.Windows.RoutedEventHandler(this.btnup_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btndown = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\DetailsForm.xaml"
            this.btndown.Click += new System.Windows.RoutedEventHandler(this.btndown_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtSL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnadd = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\DetailsForm.xaml"
            this.btnadd.Click += new System.Windows.RoutedEventHandler(this.btnadd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
