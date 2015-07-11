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
    /// 管理员.xaml 的交互逻辑
    /// </summary>
    public partial class 管理员 : Window
    {
        public 管理员()
        {
            InitializeComponent();
        }



        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TeacherButton_Click(object sender, RoutedEventArgs e)
        {
            new 教师信息维护().Show();
            this.Close();
        }

        private void StudentButton_Click(object sender, RoutedEventArgs e)
        {
            new 学生信息维护().Show();
            this.Close();

        }

        private void CourseButton_Click(object sender, RoutedEventArgs e)
        {
            new 课程信息维护().Show();
            this.Close();
        }

        private void GongButton_Click(object sender, RoutedEventArgs e)
        {
            new 公共查询().Show();
            this.Close();
        }
    }
}
