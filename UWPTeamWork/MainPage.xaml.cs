using rouge;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace UWPTeamWork
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
      
        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (start.IsSelected) { MyFrame.Navigate(typeof(Page1)); }
            else if (newperson.IsSelected) { MyFrame.Navigate(typeof(Page2)); }
            else if (exitgame.IsSelected) { MyFrame.Navigate(typeof(Page3)); }
            else if (resss.IsSelected) { MyFrame.Navigate(typeof(Page4)); }
        }

        private void Work_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ////创建一个XML文档
            //XmlDocument doc = new XmlDocument();

            //XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);//写第一行数据
            //doc.AppendChild(dec);
            ////创建根节点 knights
            //XmlElement knights = doc.CreateElement("Knights");
            //doc.AppendChild(knights);
            //doc.Save("Knights.xml");
        }
    }
}
