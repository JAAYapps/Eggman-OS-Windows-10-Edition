﻿#pragma checksum "C:\Users\Joshua\Desktop\Eggman OS Windows 10 Edition\Eggman OS Windows 10 Edition\Installer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED5830F4EB2A6496F21DEFA6EFB86EB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eggman_OS_Windows_10_Edition
{
    partial class Installer : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 8 "..\..\..\Installer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.Agreetxt = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.agreepnl = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    this.Agree = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\Installer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Agree).Click += this.Agree_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.Disagree = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\Installer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Disagree).Click += this.Disagree_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.notchoose = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\Installer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.notchoose).Click += this.notchoose_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.LoadSave = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\Installer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoadSave).Click += this.LoadSave_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
