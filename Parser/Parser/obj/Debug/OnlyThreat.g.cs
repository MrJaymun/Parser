#pragma checksum "..\..\OnlyThreat.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74A71348A6ADD5821EE220C0A3E382D4D4D59BF12195E7A5BEB4F296AE462BF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Parser;
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


namespace Parser {
    
    
    /// <summary>
    /// OnlyThreat
    /// </summary>
    public partial class OnlyThreat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChooseId;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChooseIdButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox source;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox objective;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock conf;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock integ;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock avail;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock error;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\OnlyThreat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/Parser;component/onlythreat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OnlyThreat.xaml"
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
            this.ChooseId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ChooseIdButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\OnlyThreat.xaml"
            this.ChooseIdButton.Click += new System.Windows.RoutedEventHandler(this.FindInfo);
            
            #line default
            #line hidden
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.source = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.objective = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.conf = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.integ = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.avail = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.error = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\OnlyThreat.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.ReturnHome);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

