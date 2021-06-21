using System;
using MySql.Data.MySqlClient;

public partial class admin_item_edit : System.Web.UI.Page
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
            string sql = "select * from item where itemid='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String itemid = reader.GetString(reader.GetOrdinal("itemid"));
                item_itemid.Text = itemid;
                item_itemid.ReadOnly = true;
                String name = reader.GetString(reader.GetOrdinal("name"));
                item_name.Text = name;
                String memo = reader.GetString(reader.GetOrdinal("memo"));
                item_memo.Text = memo;
                String status = reader.GetString(reader.GetOrdinal("status"));
                item_status.Text = status;
                String is_deal = reader.GetString(reader.GetOrdinal("is_deal"));
                item_is_deal.Text = is_deal;
                String type = reader.GetString(reader.GetOrdinal("type"));
                item_type.SelectedValue = type;
                String sdate = reader.GetString(reader.GetOrdinal("sdate"));
                item_sdate.Text = sdate;
                String edate = reader.GetString(reader.GetOrdinal("edate"));
                item_edate.Text = edate;
                String skill = reader.GetString(reader.GetOrdinal("skill"));
                item_skill.SelectedValue = skill;
                if (status == "1")
                {
                    status = "进行中";
                    item_status.Text = status;
                }
                else
                {
                    status = "已结束";
                    item_status.Text = status;
                }
                if (is_deal == "0")
                {
                    is_deal = "未交付";
                    item_is_deal.Text = is_deal;
                }
                else
                {
                    is_deal = "已交付";
                    item_is_deal.Text = is_deal;
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();


    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();

        String a = Request.QueryString["id"];
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);

        String name = item_name.Text;
        String type = item_type.Text;
        String skill = item_skill.Text;
        String memo = item_memo.Text;
        String sdate = item_sdate.Text;
        String userid = item_user.Text;
        String edate = item_edate.Text;
        String status = item_status.Text;
        int statu = 0;
        if (status == "进行中")
        {
            statu = 1;
        }
        String is_deal = item_is_deal.Text;
        int deal = 0;
        if (is_deal == "已交付")
        {
            deal = 1;
        }
        try
        {
            mycon.Open();
            string sql = "update item set name='" + name + "',type='" + type + "',skill='" + skill + "',memo='" + memo+ "',userid='" + userid + "',sdate='" + sdate + "',edate='" + edate + "',status='" + statu + "',is_deal='" + deal + "' where itemid='" + a + "'";
            //Response.Write(sql + "\n");
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                flag = 1;
                Response.Redirect("~/admin/item.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();
    }
}