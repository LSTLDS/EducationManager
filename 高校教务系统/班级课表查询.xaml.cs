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
    /// 班级课表查询.xaml 的交互逻辑
    /// </summary>
    public partial class 班级课表查询 : Window
    {
        sqlconnect con = new sqlconnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {

            try
            {

                sql = "select Lst_ClaID as 班级编号, Lst_ClaName as 班级名 , Lst_Dept as 专业 , Lst_CID as 课程编号 , Lst_CName as 课程名, Lst_Hours as 学时,Lst_Credit as 学分 from Liust_班级开课 ";
                View.ItemsSource = con.BindDataGrid(sql).AsDataView();

            }
            catch { MessageBox.Show("不能执行该操作！", "警告", MessageBoxButton.OK, MessageBoxImage.Information); }


        }
        public 班级课表查询()
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
