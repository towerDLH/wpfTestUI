﻿#pragma checksum "..\..\Window9.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1CC7A99BF000A9E929BD0E76A8CAADFA310EDFB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Ay.MvcFramework.AyMarkupExtension;
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Properties.Langs;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using Microsoft.Windows.Shell;
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
using UI;
using Visifire.Charts;
using WpfApp3;


namespace WpfApp3 {
    
    
    /// <summary>
    /// Window9
    /// </summary>
    public partial class Window9 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\Window9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mcom;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Window9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ad;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Window9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton YearRa;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Window9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton YueRa;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Window9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform cloud;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Window9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path ExpandPath;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\Window9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.Rate RateText;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\Window9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Visifire.Charts.Chart topchar;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/window9.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window9.xaml"
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
            this.mcom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.ad = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.YearRa = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.YueRa = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            
            #line 72 "..\..\Window9.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cloud = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 7:
            this.ExpandPath = ((System.Windows.Shapes.Path)(target));
            return;
            case 8:
            this.RateText = ((HandyControl.Controls.Rate)(target));
            return;
            case 9:
            this.topchar = ((Visifire.Charts.Chart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

