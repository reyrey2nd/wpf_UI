// Updated by XamlIntelliSenseFileGenerator 7/9/2022 6:46:04 PM
#pragma checksum "..\..\..\HomeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F395F0517593FE8965947772938A9BD314F928E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ModernUI;
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


namespace ModernUI
{


    /// <summary>
    /// HomeWindow
    /// </summary>
    public partial class HomeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 62 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock titleText;

#line default
#line hidden


#line 73 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_CreateTicket;

#line default
#line hidden


#line 83 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ViewTickets;

#line default
#line hidden


#line 93 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_SignOut;

#line default
#line hidden


#line 103 "..\..\..\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Exit;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ModernUI;component/homewindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\HomeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 46 "..\..\..\HomeWindow.xaml"
                    ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);

#line default
#line hidden

#line 46 "..\..\..\HomeWindow.xaml"
                    ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.titleText = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 3:
                    this.button_click = ((System.Windows.Controls.Button)(target));
                    return;
                case 4:
                    this.button_CreateTicket = ((System.Windows.Controls.Button)(target));
                    return;
                case 5:
                    this.button_ViewTickets = ((System.Windows.Controls.Button)(target));
                    return;
                case 6:
                    this.button_SignOut = ((System.Windows.Controls.Button)(target));
                    return;
                case 7:
                    this.button_Exit = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

