using rouge;
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
using UWPTeamWork.Models;
using test;
using System.Xml;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace UWPTeamWork
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //数据保存     
            //创建一个XML文档
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Knights.xml");
            ////创建根节点 knights
            //XmlNode knights = doc.SelectSingleNode("/Knights");
            //XmlElement knight = doc.CreateElement(name0.Text);
            //knights.AppendChild(knight);

            ////根节点下创建子节点 knightname knighthp...
            //XmlElement knightname1 = doc.CreateElement("Knightname");
            //knightname1.InnerText = name1.Text + name0.Text;
            //knight.AppendChild(knightname1);

            //XmlElement knighthp1 = doc.CreateElement("KnightHp");
            //knighthp1.InnerText = hp0.Text;
            //knight.AppendChild(knighthp1);

            //XmlElement knightatk1 = doc.CreateElement("KnightAtk");
            //knightatk1.InnerText = atk0.Text;
            //knight.AppendChild(knightatk1);

            //XmlElement knightspeed1 = doc.CreateElement("Knightspeed");
            //knightspeed1.InnerText = speed0.Text;
            //knight.AppendChild(knightspeed1);
            //doc.Save("Knights.xml");

            //XmlElement knightskill1 = doc.CreateElement("Knightskill");
            //knightskill1.InnerText = skill0.Text;
            //knight.AppendChild(knightskill1);
            //节点创建完毕
            //doc.Save("Knights.xml");
            BookManager.i += 1;
            Knight.player.Name = name1.Text + name0.Text;
            Knight.player.Hp = int.Parse(hp0.Text);
            Knight.player.hp = Knight.player.Hp;
            Knight.player.Atk = int.Parse(atk0.Text);
            Knight.player.atk = Knight.player.Atk;
            Knight.player.t = 10;
            BookManager.books.Add(new Book { BookId = BookManager.i, Title = Knight.player.Name, Author = Knight.player.Hp.ToString(), ATK = Knight.player.Atk.ToString(), CoverImage = "Assets/1.png" });
        }
    }
}
