﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace NEUSecretary
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var appTitleBar = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TitleBar;
            var coreTitleBar = Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            appTitleBar.ButtonBackgroundColor = Windows.UI.Colors.Transparent;
            MyFrame.Navigate(typeof(Homepage));
            TitleTextBlock.Text = "NEUSecretary";
            Homepage.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                Homepage.IsSelected = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Homepage.IsSelected)
            {
              
                MyFrame.Navigate(typeof(Homepage));
                TitleTextBlock.Text = "主页";
            }
            else if (Library.IsSelected)
            {
         
                MyFrame.Navigate(typeof(Library));
                TitleTextBlock.Text = "图书馆";
            }
            else if (Class.IsSelected)
            {
        
                MyFrame.Navigate(typeof(Class));
                TitleTextBlock.Text = "课程表";
            }
            else if(Selfstudy.IsSelected)
            {
                
                MyFrame.Navigate(typeof(Selfstudy));
                TitleTextBlock.Text = "上自习";
            }
            else if(Score.IsSelected)
            {
                
                MyFrame.Navigate(typeof(Score));
                TitleTextBlock.Text = "查成绩";
            }
            else if(Selfinfo.IsSelected)
            {
                
                MyFrame.Navigate(typeof(Selfinfo));
                TitleTextBlock.Text = "个人信息";
            }
            else if (Secretary.IsSelected)
            {

                MyFrame.Navigate(typeof(Turing));
                TitleTextBlock.Text = "小秘书";
            }
            else if (ChatRoom.IsSelected)
            {

                MyFrame.Navigate(typeof(Chatroom));
                TitleTextBlock.Text = "聊天室";
            }
        }

        private void LoggedButton_Click(object sender, RoutedEventArgs e)
        {
            
            MyFrame.Navigate(typeof(LoginPage));
            TitleTextBlock.Text = "登录";
        }
    }
}
