﻿#pragma checksum "..\..\..\Contorl\UserExtendContent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24255FCCD5B012029B44D427A37285A754656FA8D077F8B0AA163A135710825B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using UI.Contorl;


namespace UI.Contorl {
    
    
    /// <summary>
    /// UserExtendContent
    /// </summary>
    public partial class UserExtendContent : System.Windows.Controls.Grid, System.Windows.Markup.IComponentConnector {
        
        
        #line 76 "..\..\..\Contorl\UserExtendContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock navigateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Contorl\UserExtendContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink hyperlink0;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Contorl\UserExtendContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnColor;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/contorl/userextendcontent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Contorl\UserExtendContent.xaml"
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
            this.navigateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.hyperlink0 = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 77 "..\..\..\Contorl\UserExtendContent.xaml"
            this.hyperlink0.Click += new System.Windows.RoutedEventHandler(this.hyperlink0_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnColor = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Contorl\UserExtendContent.xaml"
            this.BtnColor.Click += new System.Windows.RoutedEventHandler(this.Btn_SetColorClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

