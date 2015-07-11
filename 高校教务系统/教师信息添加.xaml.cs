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
    /// 教师信息添加.xaml 的交互逻辑
    /// </summary>
    public partial class 教师信息添加 : Window
    {
        sqlconnect con = new sqlconnect();
        private string sql;
        public 教师信息添加()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            new 教师信息维护().Show();
            this.Close();
 
        }

        private void ADDButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sql = "insert into Liust_Teacher values('" + Lst_TchID.Text + "','" + Lst_TName.Text + "','" + Lst_Sex.Text + "','" + Lst_age.Text + "','" + Lst_Title.Text + "','" + Lst_Phone.Text + "')";
                con.OperateData(sql);
                new 教师信息维护().Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "警告", MessageBoxButton.OK, MessageBoxImage.Information);
            }


            {
                
   
          
                MessageBox.Show("操作成功！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
