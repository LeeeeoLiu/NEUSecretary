﻿#pragma checksum "D:\code\NEUSecretary\NEUSecretary\NEUSecretary\LoginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5E7C5908DDED90ADD4B76E439ACD3E6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEUSecretary
{
    partial class LoginPage : 
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
                    this.HeadPottraitButton = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.LoggedStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.LoggingButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 56 "..\..\..\LoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoggingButton).Click += this.LoggingButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.PassLoginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 62 "..\..\..\LoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PassLoginButton).Click += this.PassLoginButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.GetIdButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\LoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GetIdButton).Click += this.GetIdButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.IdentityCodePic = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.IdentityCodeTextBlock = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.PasswordTextBlock = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 9:
                {
                    this.AccountTextBlock = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

