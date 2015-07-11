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
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
  
        }
        private  void loginButton_Click(object sender, RoutedEventArgs e)
        {
            bool success =  App.sqlconnect.Login(uidTextBox.Text, pwsTextBox.Password);

            if (success)
            {
                if (Users.Text == "管理员")
                new 管理员().Show();
            if (Users.Text == "学生")
                new 学生窗口().Show();
             if (Users.Text == "教师")
                new 教师窗口().Show();
                this.Close();
            }
            else
                MessageBox.Show("用户名或密码错误！");
        }


        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

    }
}
