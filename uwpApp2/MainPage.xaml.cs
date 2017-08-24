using System;
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

namespace uwpApp2
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            TextBlock tbk = new TextBlock();
            tbk.Text = "Welcome to xaml";
            tbk.Width = 200;
            tbk.Height = 20;
            tbk.Margin = new Thickness(10);
            this.stackPanel.Children.Add(tbk);

            Button btn = new Button();
            btn.Content = "OK";
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.Width = 100;
            btn.Height = 35;
            btn.Margin = new Thickness(5);
            btn.Click += btn_Click;
            this.stackPanel.Children.Add(btn);
        }

        private async void btn_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "当前还在运行，确定退出";
            dialog.PrimaryButtonText = "确定";
            dialog.SecondaryButtonText = "取消";
            await dialog.ShowAsync();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "hi all";
        }

        private void OnClick1(object sender, RoutedEventArgs e)
        {
            txb.Text = "hello all";
        }

        private void binding_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BindingPage));
        }

        private void layouts_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LayoutsPage));
        }

        private void binding2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Binding2Page));
        }

        private void markup_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MarkupPage));
        }
    }
}
