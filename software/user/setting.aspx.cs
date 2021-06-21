using System;
using MySql.Data.MySqlClient;

public partial class admin_setting : System.Web.UI.Page
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
        String userid_ = Session["id"].ToString();
        string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            string sql = "select * from user where userid='" + userid_ + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String userid = reader.GetString(reader.GetOrdinal("userid"));
                user_userid.Text = userid;
                user_userid.ReadOnly = true;
                String name = reader.GetString(reader.GetOrdinal("name"));
                user_name.Text = name;
                String password = reader.GetString(reader.GetOrdinal("password"));
                user_password.Text = password;
                String email = reader.GetString(reader.GetOrdinal("email"));
                user_email.Text = email;
                String phone = reader.GetString(reader.GetOrdinal("phone"));
                user_phone.Text = phone;
                String sex = reader.GetString(reader.GetOrdinal("sex"));
                user_sex.SelectedValue = sex;
                String birthday = reader.GetString(reader.GetOrdinal("birthday"));
                user_birthday.Text = birthday;
                String skill = reader.GetString(reader.GetOrdinal("skill"));
                user_skill.SelectedValue = skill;
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
        string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            string sql = "update user set name='" + user_name.Text + "',password='" + user_password.Text + "',email='" + user_email.Text + "',phone='" + user_phone.Text + "',sex='" + user_sex.Text + "',birthday='" + user_birthday.Text + "',skill='" + user_skill.SelectedValue.ToString() + "' where userid='" + user_userid.Text.ToString() + "'";
            //Response.Write(sql + "\n");
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                flag = 1;
            }
        }
        catch (Exception ex)
        {
            Response.Write("数据库连接失败\n");
        }
        mycon.Close();
    }

    protected void Refresh_Click(object sender, EventArgs e)
    {
        a();
    }
}
