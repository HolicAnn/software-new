using System;
using MySql.Data.MySqlClient;

public partial class admin_plan_edit : System.Web.UI.Page
{
    static int flag = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();

        if (flag == 1)
        {
            a();
            flag = 0;
        }
    }
    protected void a()
    {
        String id = Request.QueryString["id"];
        string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            string sql = "select * from work where workid='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String itemid = reader.GetString(reader.GetOrdinal("itemid"));
                work_itemid.Text = itemid;
                work_itemid.ReadOnly = true;
                String workid = reader.GetString(reader.GetOrdinal("workid"));
                work_workid.Text = workid;
                work_workid.ReadOnly = true;
                String userid = reader.GetString(reader.GetOrdinal("userid"));
                work_userid.Text = userid;
                String memo = reader.GetString(reader.GetOrdinal("memo"));
                work_memo.Text = memo;
                String sdate = reader.GetString(reader.GetOrdinal("sdate"));
                work_sdate.Text = sdate;
                String edate = reader.GetString(reader.GetOrdinal("edate"));
                work_edate.Text = edate;
                String status = reader.GetString(reader.GetOrdinal("stutas"));
                if (status == "1")
                {
                    status = "进行中";
                    work_status.Text = status;
                }
                else
                {
                    status = "已结束";
                    work_status.Text = status;
                }
                String priority = reader.GetString(reader.GetOrdinal("priority"));
                work_priority.Text = priority;
            }
        }
        catch (Exception ex)
        {
            //Response.Write("数据库连接失败\n");
        }
        mycon.Close();
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();

        String a = Request.QueryString["id"];
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);

        String memo = work_memo.Text;
        String sdate = work_sdate.Text;
        String edate = work_edate.Text;
        String status = work_status.Text;
        String priority = work_priority.Text;
        String user = work_userid.Text;
        int statu = 0;
        if (status == "进行中")
        {
            statu = 1;
        }
        try
        {
            mycon.Open();
            string sql = "update work set memo='" + memo + "',userid='" + user + "',sdate='" + sdate + "',edate='" + edate + "',status='" + statu + "',priority='" + priority + "' where workid='" + a + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                flag = 1;
                Response.Redirect("~/admin/plan.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();
    }
}