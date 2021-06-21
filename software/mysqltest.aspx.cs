using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MySql.Data.MySqlClient;
using System.Diagnostics;

public partial class mysqltest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MailAddress from = new MailAddress("1249556871@qq.com");
        MailMessage message = new MailMessage();
        message.Body = "欢迎您注册简明科技软件外包平台会员，验证码为'123123'，验证码有效期五分钟";//邮件内容
        message.IsBodyHtml = true;
        message.BodyEncoding = System.Text.Encoding.UTF8;
        //收件人地址
        message.To.Add("349906100@qq.com");
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
        }
        catch (Exception ex)
        {
            string mssage = ex.ToString();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //构建数据库连接字符串
        string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            //打开数据库连接
            mycon.Open();
            Response.Write("数据库已经连接了！");
            string sql = "select * from user";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);    //将查询语句放进该数据库容器中
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //reader.GetOrdinal("id")是得到ID所在列的index,
                //reader.GetInt32(int n)这是将第n列的数据以Int32的格式返回
                //reader.GetString(int n)这是将第n列的数据以string 格式返回
                String id = reader.GetString(reader.GetOrdinal("userid"));
                string name = reader.GetString(reader.GetOrdinal("name"));
                string email = reader.GetString(reader.GetOrdinal("email"));
                string pwd = reader.GetString(reader.GetOrdinal("password"));
                Response.Write("ID:" + id + "Name:" + name + "email:" + email + "pwd:" + pwd);
                //格式输出数据
                Console.Write("ID:{0},Name:{1},email{2},PWD:{3}\n", id, name, email, pwd);
            }
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
            Debug.Write(ex);
        }
        //关闭数据库连接
        mycon.Close();
    }
}