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
using rouge;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace UWPTeamWork
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Page3 : Page
    {
        public Page3()
        {
            this.InitializeComponent();
            knightname.Text = Knight.player.Name;
            knighthp.Text = Knight.player.Hp.ToString();
            knightatk.Text = Knight.player.Atk.ToString();
            Monster.monster.set();
            monsterhp.Text = Monster.monster.Hp.ToString();
            monsteratk.Text = Monster.monster.Atk.ToString();
        }
        
        private void fight_Click(object sender, RoutedEventArgs e)
        {
            while(Knight.player.Hp > 0 && Monster.monster.Hp > 0)
            {
                Knight.player.Hp -= Monster.monster.Atk;
                Monster.monster.Hp -= Knight.player.Atk;
            }
            if(Knight.player.Hp <= 0)
            {
                knighthp.Text = Knight.player.Hp.ToString();
                myframe3.Navigate(typeof(Page7));
            }
            else if (Knight.player.t == 0)
                {
                    myframe3.Navigate(typeof(Page5));
                }
                else
                {
                    knighthp.Text = Knight.player.Hp.ToString();
                    Knight.player.t -= 1;
                    myframe3.Navigate(typeof(Page6));
                }
        }

        //private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //App.SomeImportantValue = ValueTextBox.Text;
        //    Frame.Navigate(typeof(Page3), ValueTextBox.Text);
        //    // Frame.Navigate(typeof(Page3), "DEVIL");
        //}
    }
}
