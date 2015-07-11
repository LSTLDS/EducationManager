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
    /// 学生窗口.xaml 的交互逻辑
    /// </summary>
    public partial class 学生窗口 : Window
    {
        public 学生窗口()
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
            new 学生个人信息查询().Show();
            this.Close();
        }

        private void GButton_Click(object sender, RoutedEventArgs e)
        {
            new 学生个人成绩查询().Show();
            this.Close();
        }

        private void KButton_Click(object sender, RoutedEventArgs e)
        {
            new 学生个人课表查询().Show();
            this.Close();
        }
        
        
    }
}
