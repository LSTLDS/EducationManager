using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 高校教务系统
{
    /// <summary>
    /// 教师窗口.xaml 的交互逻辑
    /// </summary>
    public partial class 教师窗口 : Window
    {
        public 教师窗口()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




        private void GongButton_Click(object sender, RoutedEventArgs e)
        {
            new 公共查询().Show();
            this.Close();
        }

        private void XButton_Click(object sender, RoutedEventArgs e)
        {
            new 教师个人信息查询().Show();
            this.Close();
        }

        private void GButton_Click(object sender, RoutedEventArgs e)
        {
            new 学生成绩维护().Show();
            this.Close();
        }

        private void KButton_Click(object sender, RoutedEventArgs e)
        {
            new 个人任课查询().Show();
            this.Close();
        }
    }
}
