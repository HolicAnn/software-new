using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public partial class admin_count : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> x1 = new List<string>() { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        List<int> y1 = new List<int>() { 3, 5, 4, 6, 4, 3, 4 };

        Chart1.Series[0].Points.DataBindXY(x1, y1);
    
        Chart1.Titles.Add("上周任务完成量");

        List<string> x2 = new List<string>() { "蒋新", "蒋仁雨", "余佳婧", "李文阳", "李知恒" };
        //a();
        List<int> y2 = new List<int>() { 13, 11, 4, 5, 8 };
        Chart2.Series[0].Points.DataBindXY(x2, y2);
        Chart2.Titles.Add("上周人员任务量");

        List<string> x3 = new List<string>() { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" };
        List<int> y3 = new List<int>() { 2, 1, 2, 1, 1, 3, 2, 1, 3, 4, 1, 2 };
        Chart3.Series[0].Points.DataBindXY(x3, y3);
        Chart3.Titles.Add("本年项目交付数");

        List<string> x4 = new List<string>() { "app", "web网站", "小程序", "系统构建" };
        List<int> y4 = new List<int>() { 1, 1, 1, 1 };
        Chart4.Series[0].Points.DataBindXY(x4, y4);
        Chart4.Titles.Add("项目类型");

        List<string> x5 = new List<string>() { "蒋新", "蒋仁雨", "余佳婧", "李文阳", "李知恒" };
        List<int> y5 = new List<int>() { 4, 3, 1, 2, 3 };
        Chart5.Series[0].Points.DataBindXY(x5, y5);
        Chart5.Titles.Add("开发人员贡献度");

        List<string> x6 = new List<string>() { "一月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" };
        List<int> y6 = new List<int>() { 2, 1, 2, 1, 1, 3, 2, 1, 3, 4, 1, 2 };
        Chart6.Series[0].Points.DataBindXY(x6, y6);
        Chart6.Titles.Add("本年项目交付量");
    }

    protected int a(){
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        int count = 0;
        try
        {
            mycon.Open();
            String sql = "select count(*) as count from work where userid=蒋新";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            Response.Write(cmd);
        }
        catch (Exception ex)
        {
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();
        return count;
    }
}