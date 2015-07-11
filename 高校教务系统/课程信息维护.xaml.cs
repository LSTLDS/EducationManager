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
    /// 课程信息维护.xaml 的交互逻辑
    /// </summary>
    public partial class 课程信息维护 : Window
    {
        public 课程信息维护()
        {
            InitializeComponent();
            SetBind();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        sqlconnect con = new sqlconnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {

            try
            {

                sql = "select Lst_CID as 课程号, Lst_CName as 课程名 , Lst_TchID as 教师编号, Lst_Term as 学期 , Lst_Credit as 学分 , Lst_Hours as 学时,Lst_Test as 考试形式 from Liust_Course";
                View.ItemsSource = con.BindDataGrid(sql).AsDataView();

            }
            catch { MessageBox.Show("不能执行该操作！", "警告", MessageBoxButton.OK, MessageBoxImage.Information); }


        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new 管理员().Show();
            this.Close();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确定删除？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                try
                {
                    DataRowView a = (DataRowView)View.SelectedItem;
                    sql = "delete from Liust_Course where Lst_CID ='" + a.Row[0].ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
                }
                catch
                {
                    MessageBox.Show("不能该操作", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new 课程信息添加().Show();
            this.Close();
        }
    }
}
