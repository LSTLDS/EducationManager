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
    /// 个人任课查询.xaml 的交互逻辑
    /// </summary>
    public partial class 个人任课查询 : Window
    {
        sqlconnect con = new sqlconnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {

            try
            {

                 sql = "select Lst_TchID as 教师编号, Lst_TName as 教师姓名 , Lst_CName as 课程名, Lst_Term as 学期 , Lst_Test as 考核方式  from Liust_教师任课  where Lst_TchID='" + SID.Text + "'";
                View.ItemsSource = con.BindDataGrid(sql).AsDataView();

            }
            catch { MessageBox.Show("不能执行该操作！", "警告", MessageBoxButton.OK, MessageBoxImage.Information); }


        }
        public 个人任课查询()
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
    }
}
