﻿#pragma checksum "..\..\..\..\Pages\RequestListPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78AFC326C5388ADB612520BBD5557650D49CD1B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ItPlus.Pages;
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


namespace ItPlus.Pages {
    
    
    /// <summary>
    /// RequestListPage
    /// </summary>
    public partial class RequestListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Pages\RequestListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox poisk;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Pages\RequestListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeaveRequest;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\RequestListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView requetlist;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ItPlus;V1.0.0.0;component/pages/requestlistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\RequestListPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\Pages\RequestListPage.xaml"
            ((ItPlus.Pages.RequestListPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.PageLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.poisk = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\Pages\RequestListPage.xaml"
            this.poisk.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.poisk_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LeaveRequest = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Pages\RequestListPage.xaml"
            this.LeaveRequest.Click += new System.Windows.RoutedEventHandler(this.LeaveRequestButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.requetlist = ((System.Windows.Controls.ListView)(target));
            
            #line 23 "..\..\..\..\Pages\RequestListPage.xaml"
            this.requetlist.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChangeReq);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
