﻿#pragma checksum "..\..\..\Utils\demoMod.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9BEAEE2A0BAEA7ED2746093FD002887A05FD39D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FestivaliAS.Utils;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace FestivaliAS.Utils {
    
    
    /// <summary>
    /// demoMod
    /// </summary>
    public partial class demoMod : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Utils\demoMod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox Osnovno;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Utils\demoMod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Utils\demoMod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker ColorPicker;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Utils\demoMod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OpisPolje;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Utils\demoMod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajDugme;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Utils\demoMod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Odustani;
        
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
            System.Uri resourceLocater = new System.Uri("/FestivaliAS;component/utils/demomod.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Utils\demoMod.xaml"
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
            
            #line 10 "..\..\..\Utils\demoMod.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Osnovno = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.IdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 22 "..\..\..\Utils\demoMod.xaml"
            this.ColorPicker.TouchEnter += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Boja_Click);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\Utils\demoMod.xaml"
            this.ColorPicker.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Boja_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OpisPolje = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DodajDugme = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Utils\demoMod.xaml"
            this.DodajDugme.Click += new System.Windows.RoutedEventHandler(this.DodajDugme_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Odustani = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
