using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing.Imaging;
//下面程序中使用的ImageFormat类所在的命名空间
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections.Generic;
//下面程序中使用到关于数据库方面的类所在的命名空间

public partial class admin_Chart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> xData = new List<string>() { "A", "B", "C", "D" };
        List<int> yData = new List<int>() { 10, 20, 30, 40 };
        Chart1.Series[0]["PieLabelStyle"] = "Outside";
        Chart1.Series[0]["PieLabelColor"] = "Black";
        Chart1.Series[0].Points.DataBindXY(xData, yData);
    }
}