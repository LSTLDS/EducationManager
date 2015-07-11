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
    /// 公共查询.xaml 的交互逻辑
    /// </summary>
    public partial class 公共查询 : Window
    {
        public 公共查询()
        {
            InitializeComponent();
        }

        private void DButton_Click(object sender, RoutedEventArgs e)
        {
         
            new 地区学生统计().Show();
            this.Close();
        }

        private void TButton_Click(object sender, RoutedEventArgs e)
        {
           
            new 教师开课查询().Show();
            this.Close();
        }

        private void BButton_Click(object sender, RoutedEventArgs e)
        {
            
            new 班级课表查询 ().Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

         
            new Login().Show();
            this.Close();
        }
    }
}
