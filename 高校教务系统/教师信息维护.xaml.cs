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
    /// 教师信息维护.xaml 的交互逻辑
    /// </summary>
    public partial class 教师信息维护 : Window
    {
        sqlconnect con = new sqlconnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind() {

        try
        {   
             
                sql = "select Lst_TchID as 教师编号, Lst_TName as 姓名 , Lst_Sex as 性别, Lst_age as 年龄 , Lst_Title as 职称 , Lst_Phone as 电话 from Liust_Teacher";
                View.ItemsSource = con.BindDataGrid(sql).AsDataView();

         }
         catch { MessageBox.Show("不能执行该操作！", "警告", MessageBoxButton.OK, MessageBoxImage.Information); }
        
        
        }

        public 教师信息维护()
        {
            InitializeComponent();

            SetBind();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new 管理员().Show();
            this.Close();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("确定删除？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK) {
                try {
                    DataRowView a = (DataRowView)View.SelectedItem;
                    sql = "delete from Liust_Teacher where Lst_TchID ='" + a.Row[0].ToString() + "'";
                    con.OperateData(sql);
                    SetBind();
}catch{
     MessageBox.Show("不能该操作","提示",MessageBoxButton.OK,MessageBoxImage.Information );
}
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new 教师信息添加().Show();
            this.Close();
        }
    }
}
