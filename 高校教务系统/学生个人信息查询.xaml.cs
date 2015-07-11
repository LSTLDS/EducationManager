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
    /// 学生个人信息查询.xaml 的交互逻辑
    /// </summary>
    public partial class 学生个人信息查询 : Window
    {
        sqlconnect con = new sqlconnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {

            try
            {

                sql = "select Lst_StuID as 学号,Lst_ClaID as 班级号, Lst_SName as 姓名 , Lst_Sex as 性别, Lst_age as 年龄 , Lst_Location as 所在地 , Lst_Credit as 学分 from Liust_Student where Lst_StuID='" + SID.Text + "'";
                View.ItemsSource = con.BindDataGrid(sql).AsDataView();

            }
            catch { MessageBox.Show("不能执行该操作！", "警告", MessageBoxButton.OK, MessageBoxImage.Information); }


        }
        public 学生个人信息查询()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new 学生窗口().Show();
            this.Close();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            SetBind();

        }
    }
}
