﻿#pragma checksum "..\..\..\Views\POS.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63032985B7F05D02BDF81B2A43F0EBEA9B2E5C0A6699454EB6BBFFA519F4DBD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PosManager.Views;
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


namespace PosManager.Views {
    
    
    /// <summary>
    /// POS
    /// </summary>
    public partial class POS : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Views\POS.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AddProduct;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\POS.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Addsales;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\POS.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AddshowSalesDetails;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\POS.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AddshowCustomers;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\POS.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AddsowCategories;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\POS.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PosLanding;
        
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
            System.Uri resourceLocater = new System.Uri("/PosManager;component/views/pos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\POS.xaml"
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
            this.AddProduct = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\Views\POS.xaml"
            this.AddProduct.Click += new System.Windows.RoutedEventHandler(this.AddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Addsales = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\..\Views\POS.xaml"
            this.Addsales.Click += new System.Windows.RoutedEventHandler(this.AddSale_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddshowSalesDetails = ((System.Windows.Controls.MenuItem)(target));
            
            #line 38 "..\..\..\Views\POS.xaml"
            this.AddshowSalesDetails.Click += new System.Windows.RoutedEventHandler(this.AddSalesDetails_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddshowCustomers = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\..\Views\POS.xaml"
            this.AddshowCustomers.Click += new System.Windows.RoutedEventHandler(this.AddCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddsowCategories = ((System.Windows.Controls.MenuItem)(target));
            
            #line 40 "..\..\..\Views\POS.xaml"
            this.AddsowCategories.Click += new System.Windows.RoutedEventHandler(this.AddCategorie_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PosLanding = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

