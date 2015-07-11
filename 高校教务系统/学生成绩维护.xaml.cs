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
using System.Data.SqlClient;
using System.Data;

namespace 高校教务系统
{
    /// <summary>
    /// 学生成绩维护.xaml 的交互逻辑
    /// </summary>
    public partial class 学生成绩维护 : Window
    {
        sqlconnect con = new sqlconnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {

            try
            {

                sql = "select Lst_StuID as 学号, Lst_SName as 姓名 , Lst_CName as 课程名, Lst_Term as 学期 , Lst_Grade as 成绩  from Liust_成绩 where Lst_TchID='" + SID.Text + "'";
                View.ItemsSource = con.BindDataGrid(sql).AsDataView();

            }
            catch { MessageBox.Show("不能执行该操作！", "警告", MessageBoxButton.OK, MessageBoxImage.Information); }


        }
        public 学生成绩维护()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new 教师窗口().Show();
            this.Close();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            SetBind();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new 学生成绩添加().Show();
            this.Close();
        }
        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确定删除？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                try
                {
                    DataRowView a = (DataRowView)View.SelectedItem;
                    sql = "delete from Liust_Grade where Lst_StuID ='" + a.Row[0].ToString() + "' and Lst_TchID='"+SID.Text+"'";
                    con.OperateData(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("不能该操作", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
