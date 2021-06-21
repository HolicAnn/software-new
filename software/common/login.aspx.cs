using System;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

public partial class user_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void SetStyle(Button btn)
    {

    }

    protected void login_Click(object sender, EventArgs e)
    {
        String id = userid.Text;
        String pwd = password.Text;

        string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        Random rd = new Random();
        try
        {
            mycon.Open();
            string sql = "select * from user where userid='" + id + "' and password='" + pwd + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String userid = reader.GetString(reader.GetOrdinal("userid"));
                string password = reader.GetString(reader.GetOrdinal("password"));
                if (userid == id && pwd == password)
                {
                    Session["id"] = userid;
                    Session["name"] = reader.GetString(reader.GetOrdinal("name"));
                    Session.Timeout = 3600;
                    string role = reader.GetString(reader.GetOrdinal("role"));
                    if (role.Equals("1")) 
                    {
                        Response.Write("<script>alert('登陆成功, 管理员，欢迎您!');location.href = '../admin/item.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('登陆成功，欢迎您!');location.href = '../user/item.aspx';</script>");
                    }
                    break;
                }
            }
            Response.Write("<script>alert('用户名或密码错误!')</script>");
        }
        catch (Exception ex)
        {
            Debug.Write(ex);
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();
    }

    protected void a(string id, string pwd)
    {
        //string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        Random rd = new Random();
        try
        {
            mycon.Open();
            string sql = "select * from user where userid='" + id + "' and password='" + pwd + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String userid = reader.GetString(reader.GetOrdinal("userid"));
                string password = reader.GetString(reader.GetOrdinal("password"));
                if (userid == id && pwd == password)
                {
                    Response.Write("登录成功！");
                    Response.Redirect("../admin/item.aspx");
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Debug.Write(ex);
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();
    }
}