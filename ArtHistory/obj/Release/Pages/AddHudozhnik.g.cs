﻿#pragma checksum "..\..\..\Pages\AddHudozhnik.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "645A61EDF57DFBFE68FFBB5A383E9362713BB37E7AD94EFC6462BA4BE58D9314"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ArtHistory.Pages;
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


namespace ArtHistory.Pages {
    
    
    /// <summary>
    /// AddHudozhnik
    /// </summary>
    public partial class AddHudozhnik : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\AddHudozhnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image selectedImage;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\AddHudozhnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFIO;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\AddHudozhnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDate;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\AddHudozhnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEpoha;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\AddHudozhnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox tbBiografia;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\AddHudozhnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOtmena;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Pages\AddHudozhnik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/ArtHistory;component/pages/addhudozhnik.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddHudozhnik.xaml"
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
            this.selectedImage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.tbFIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbEpoha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbBiografia = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 6:
            this.btnOtmena = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Pages\AddHudozhnik.xaml"
            this.btnOtmena.Click += new System.Windows.RoutedEventHandler(this.Button_ClickOtmena);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Pages\AddHudozhnik.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.Button_ClickSave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
