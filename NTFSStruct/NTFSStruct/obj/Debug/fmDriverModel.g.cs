﻿#pragma checksum "..\..\fmDriverModel.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "859C122D93052A117FF0715DC51BCEC0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18408
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace NTFSStruct {
    
    
    /// <summary>
    /// fmDriverModel
    /// </summary>
    public partial class fmDriverModel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\fmDriverModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbText;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\fmDriverModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imDriverModel;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\fmDriverModel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imClick;
        
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
            System.Uri resourceLocater = new System.Uri("/NTFSStruct;component/fmdrivermodel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\fmDriverModel.xaml"
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
            
            #line 4 "..\..\fmDriverModel.xaml"
            ((NTFSStruct.fmDriverModel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 4 "..\..\fmDriverModel.xaml"
            ((NTFSStruct.fmDriverModel)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.imDriverModel = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.imClick = ((System.Windows.Controls.Image)(target));
            
            #line 9 "..\..\fmDriverModel.xaml"
            this.imClick.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.imDriverModel_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 9 "..\..\fmDriverModel.xaml"
            this.imClick.MouseEnter += new System.Windows.Input.MouseEventHandler(this.imDriverModel_MouseEnter);
            
            #line default
            #line hidden
            
            #line 9 "..\..\fmDriverModel.xaml"
            this.imClick.MouseLeave += new System.Windows.Input.MouseEventHandler(this.imDriverModel_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

