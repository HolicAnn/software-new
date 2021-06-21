using System;
using System.Net.Mail;
using MySql.Data.MySqlClient;

public partial class user_sign : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void send_Click(object sender, EventArgs e)
    {
        MailAddress from = new MailAddress("1249556871@qq.com");
        MailMessage message = new MailMessage();
        Random rd = new Random();
        message.Body = "欢迎您注册简明科技软件外包平台会员,验证码为:" + rd.Next(100000, 999999).ToString() + ",验证码有效期五分钟";//邮件内容
        message.IsBodyHtml = true;
        message.BodyEncoding = System.Text.Encoding.UTF8;
        //收件人地址
        //message.To.Add("349906100@qq.com");
        message.To.Add(user_email.Text);
        message.Subject = "注册验证码";//邮件标题
        message.SubjectEncoding = System.Text.Encoding.UTF8;
        message.From = from;
        SmtpClient client = new SmtpClient();
        client.EnableSsl = true;
        client.Host = "smtp.qq.com";
        client.Port = 587;
        //邮箱账户和密码
        client.Credentials = new System.Net.NetworkCredential("1249556871@qq.com", "tnkpqqwrdqvjfhbf");
        try
        {
            client.Send(message);
            //Response.Write("验证码已发送,验证码有效期5分钟，请在有效时间内进行注册！");
            Response.Write("<script>alert('验证码已发送,验证码有效期5分钟，请在有效时间内进行注册！');</script>");
        }
        catch (Exception ex)
        {
            string mssage = ex.ToString();
        }
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        //string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        String name = user_name.Text;
        String password = user_password.Text;
        String email = user_email.Text;
        String phone = user_phone.Text;
        String sex = user_sex.Text;
        String birthday = user_birthday.Text;
        String skill = user_skill.Text;
        String code = user_code.Text;
        Random rd = new Random();
        try
        {
            mycon.Open();
            string id = rd.Next(100000, 999999).ToString();
            string sql = "insert into user values('" + id + "','" + name + "','" + email + "','" + password + "','" + phone + "','" + sex + "','" + birthday + "','" + skill + "',1,0,'" + code + "');";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();
            Email(id);
            Response.Write("<script>alert('注册成功！您的工号已经发往您的邮箱，请查收！');location.href = '../common/login.aspx';</script>");
            mycon.Close();
        }
        catch (Exception ex)
        {
            mycon.Close();
            Response.Write("数据库连接失败\n");
        }
    }

    protected void Email(String id)
    {
        MailAddress from = new MailAddress("1249556871@qq.com");
        MailMessage message = new MailMessage();
        Random rd = new Random();
        message.Body = "您已成为简明科技软件外包平台会员,工号为:" + id.ToString();//邮件内容
        message.IsBodyHtml = true;
        message.BodyEncoding = System.Text.Encoding.UTF8;
        //收件人地址
        //message.To.Add("349906100@qq.com");
        message.To.Add(user_email.Text);
        message.Subject = "人员工号";//邮件标题
        message.SubjectEncoding = System.Text.Encoding.UTF8;
        message.From = from;
        SmtpClient client = new SmtpClient();
        client.EnableSsl = true;
        client.Host = "smtp.qq.com";
        client.Port = 587;
        //邮箱账户和密码
        client.Credentials = new System.Net.NetworkCredential("1249556871@qq.com", "tnkpqqwrdqvjfhbf");
        try
        {
            client.Send(message);
        }
        catch (Exception ex)
        {
            string mssage = ex.ToString();
        }
    }
}