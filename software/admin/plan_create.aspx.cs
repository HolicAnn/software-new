using System;
using MySql.Data.MySqlClient;

public partial class admin_plan_create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();

        Random rd = new Random();
        String workid = rd.Next(100000, 999999).ToString();
        String itemid = work_itemid.Text;
        String sdate = work_sdate.Text;
        String edate = work_edate.Text;
        String userid = work_userid.Text;
        String memo = work_memo.Text;
        String priority = work_priority.Text;
        String status = "1";

        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            String sql = "insert into work values('" + workid + "','" + itemid + "','" + sdate + "','" + edate + "','" + userid + "','" + memo + "','" + priority + "','" + status + "');";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            Response.Write("<script>alert('新建任务成功！')</script>");
            Response.Redirect("~/admin/plan.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();
    }
}