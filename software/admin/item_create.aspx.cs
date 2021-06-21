using System;
using MySql.Data.MySqlClient;

public partial class admin_item_create : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();
        Random rd = new Random();
        String itemid = rd.Next(100000, 999999).ToString();
        String name = item_name.Text;
        String type = item_type.Text;
        String skill = item_skill.Text;
        String memo = item_memo.Text;
        String userid = item_user.Text;
        String sdate = item_sdate.Text;
        String edate = item_edate.Text;

        string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            string sql = "insert into item values('" + itemid + "','" + type + "','" + memo + "','" + name + "','" + skill + "','" + userid + "','" + sdate + "','" + edate + "',1,0);";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);    //将查询语句放进该数据库容器中
            MySqlDataReader reader = cmd.ExecuteReader();
            Response.Write("<script>alert('新建项目成功！')</script>");
            //Response.Write(" <script>function window.onload() {alert( '新建项目成功！' ); } </script> ");
            Response.Redirect("~/admin/item.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();
    }

    protected void bind_skill() {
        item_skill.Items.Clear();
        item_skill.Items.Add("android");
        item_skill.Items.Add("asp.net");
        item_skill.Items.Add("node.js");
        item_skill.Items.Add("java");
        item_skill.Items.Add("linux");
        item_skill.Items.Add("数据库");
    }

    protected void bind_user() {
        item_user.Items.Clear();
        switch (item_user.SelectedValue) {
            case "android":
                item_user.Items.Add("蒋仁雨");
                break;
            case "node.js":
                item_user.Items.Add("蒋新");
                break;
            case "asp.net":
                item_user.Items.Add("蒋秉峰");
                item_user.Items.Add("戴传志");
                item_user.Items.Add("张三");
                break;
        }
    }

    protected void item_skill_SelectedIndexChanged(object sender, EventArgs e)
    {
        //bind_user();
    }

    protected void item_user_SelectedIndexChanged(object sender, EventArgs e)
    {
       // bind_user();
    }
}