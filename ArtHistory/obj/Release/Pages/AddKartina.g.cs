﻿#pragma checksum "..\..\..\Pages\AddKartina.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A23984C86BB6F1959A98F6A0A7B65096DCA91FBFB8ECBF18CDC5627030769F15"
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
    /// AddKartina
    /// </summary>
    public partial class AddKartina : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\AddKartina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image selectedImage;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\AddKartina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label selectedImagePath;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\AddKartina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectImage;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\AddKartina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\AddKartina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAvtor;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\AddKartina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDates;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\AddKartina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox tbOpisanie;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\AddKartina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOtmena;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\AddKartina.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ArtHistory;component/pages/addkartina.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddKartina.xaml"
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
            this.selectedImagePath = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnSelectImage = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\AddKartina.xaml"
            this.btnSelectImage.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbAvtor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbDates = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbOpisanie = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 8:
            this.btnOtmena = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Pages\AddKartina.xaml"
            this.btnOtmena.Click += new System.Windows.RoutedEventHandler(this.Button_ClickOtmena);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Pages\AddKartina.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.Button_ClickSave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

