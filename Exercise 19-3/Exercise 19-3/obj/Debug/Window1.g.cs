﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E505E452A4372BB2E1B8806DBA4B4442"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Exercise_19_3 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\Window1.xaml"
        internal System.Windows.Media.Animation.BeginStoryboard rotateClockwise;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Window1.xaml"
        internal System.Windows.Media.Animation.BeginStoryboard rotateCounterclockwise;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Window1.xaml"
        internal System.Windows.Shapes.Rectangle myRectangle;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Window1.xaml"
        internal System.Windows.Media.RotateTransform rectRotate;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btnClockwise;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btnCounterclockwise;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btnStop;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Exercise 19-3;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.rotateClockwise = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 2:
            this.rotateCounterclockwise = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 3:
            this.myRectangle = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.rectRotate = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 5:
            this.btnClockwise = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btnCounterclockwise = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}