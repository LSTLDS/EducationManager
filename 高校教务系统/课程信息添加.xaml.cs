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
    /// 课程信息添加.xaml 的交互逻辑
    /// </summary>
    public partial class 课程信息添加 : Window
    {
        sqlconnect con = new sqlconnect();
        private string sql;
        public 课程信息添加()
        {
            InitializeComponent();
        }

        private void ADDButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sql = "insert into Liust_Course values('" + Lst_CID.Text + "','" + Lst_CName.Text + "','" + Lst_TchID.Text + "','" + Lst_Term.Text + "','" + Lst_Credit.Text + "','" + Lst_Hours.Text + "','" + Lst_Test.Text + "')";
                con.OperateData(sql);
                new 课程信息维护().Show();
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
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

            new 课程信息维护().Show();
            this.Close();
        }
    }
}
