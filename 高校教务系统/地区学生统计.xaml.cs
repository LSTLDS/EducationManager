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
    /// 地区学生统计.xaml 的交互逻辑
    /// </summary>
    public partial class 地区学生统计 : Window
    {
        sqlconnect con = new sqlconnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {

            try
            {

                sql = "select Lst_Location as 地区, 地区学生数 as 人数   from 地区学生统计";
                View.ItemsSource = con.BindDataGrid(sql).AsDataView();

            }
            catch { MessageBox.Show("不能执行该操作！", "警告", MessageBoxButton.OK, MessageBoxImage.Information); }


        }
        public 地区学生统计()
        {
            InitializeComponent();
            SetBind();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new 公共查询().Show();
            this.Close();
        }
    }
}
