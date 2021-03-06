using System;
using System.Web.UI.WebControls;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Diagnostics;

public partial class admin_item : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();
        b();
    }

    private void Delete_click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString();
        Response.Write(((Button)sender).ID);
    }

    protected void b()
    {
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            //打开数据库连接
            mycon.Open();
            String sql = "select * from item";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();

            TableItemStyle tableStyle = new TableItemStyle();
            tableStyle.HorizontalAlign = HorizontalAlign.Center;
            tableStyle.VerticalAlign = VerticalAlign.Middle;
            tableStyle.Width = Unit.Pixel(100);

            while (reader.Read())
            {
                String id = reader.GetString(reader.GetOrdinal("itemid"));
                String name = reader.GetString(reader.GetOrdinal("name"));
                String type = reader.GetString(reader.GetOrdinal("type"));
                String memo = reader.GetString(reader.GetOrdinal("memo"));
                String skill = reader.GetString(reader.GetOrdinal("skill"));
                String userid = reader.GetString(reader.GetOrdinal("userid"));
                String edate = reader.GetString(reader.GetOrdinal("edate"));
                String sdate = reader.GetString(reader.GetOrdinal("sdate"));
                String status = reader.GetString(reader.GetOrdinal("status"));
                if (status == "1")
                {
                    status = "进行中";
                }
                else
                {
                    status = "已结束";
                }
                String is_deal = reader.GetString(reader.GetOrdinal("is_deal"));
                if (is_deal == "0")
                {
                    is_deal = "未交付";
                }
                else
                {
                    is_deal = "已交付";
                }

                TableRow Row1 = new TableRow();
                TableCell Cell1 = new TableCell();
                Cell1.Text = String.Format(id);
                Row1.Cells.Add(Cell1);
                TableCell Cell2 = new TableCell();
                Cell2.Text = String.Format(name);
                Row1.Cells.Add(Cell2);
                TableCell Cell3 = new TableCell();
                Cell3.Text = String.Format(type);
                Row1.Cells.Add(Cell3);
                TableCell Cell4 = new TableCell();
                Cell4.Text = String.Format(memo);
                Row1.Cells.Add(Cell4);
                TableCell Cell5 = new TableCell();
                Cell5.Text = String.Format(skill);
                Row1.Cells.Add(Cell5);
                TableCell Cell6 = new TableCell();
                Cell6.Text = String.Format(userid);
                Row1.Cells.Add(Cell6);
                TableCell Cell7 = new TableCell();
                Cell7.Text = String.Format(edate);
                Row1.Cells.Add(Cell7);
                TableCell Cell8 = new TableCell();
                Cell8.Text = String.Format(sdate);
                Row1.Cells.Add(Cell8);
                TableCell Cell9 = new TableCell();
                Cell9.Text = String.Format(status);
                Row1.Cells.Add(Cell9);
                TableCell Cell10 = new TableCell();
                Cell10.Text = String.Format(is_deal);
                Row1.Cells.Add(Cell10);
                table2.Rows.Add(Row1);

                TableCell Cell11 = new TableCell(); 
                Button button = new Button();
                button.Text = "删除";
                Cell11.Controls.Add(button);
                button.Click += new EventHandler(delete_Click);
                button.CommandName = "delete_click";
                button.CommandArgument = String.Format(id);
                Row1.Cells.Add(Cell11);
                table2.Rows.Add(Row1);

                TableCell Cell12 = new TableCell();
                Button button2 = new Button();
                button2.Text = "编辑";
                Cell12.Controls.Add(button2);
                button2.Click += new EventHandler(edit_Click);
                button2.CommandName = "edit_click";
                button2.CommandArgument = String.Format(id);
                Row1.Cells.Add(Cell12);
                table2.Rows.Add(Row1);
            }
            foreach (TableRow rw in table2.Rows)
                foreach (TableCell cel in rw.Cells)
                    cel.ApplyStyle(tableStyle);
            TableHeaderCell header = new TableHeaderCell();
            header.RowSpan = 1;
            header.ColumnSpan = 3;
            header.Font.Bold = true;
            header.BackColor = Color.Gray;
            header.HorizontalAlign = HorizontalAlign.Center;
            header.VerticalAlign = VerticalAlign.Middle;

            TableRow headerRow = new TableRow();
            headerRow.Cells.Add(header);

            table2.Rows.AddAt(0, headerRow);

        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
            Debug.Write(ex);
        }
        //关
        mycon.Close();
    }

    protected void delete_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString();
        //String item_id = delete_id.Text;
        String item_id = String.Format(Convert.ToString(((Button)sender).CommandArgument));
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            String sql = "delete from item where itemid= '" + item_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Response.Write("<script>alert('删除项目'" + item_id + "'成功！')</script>");
                Response.Redirect("~/admin/item.aspx");
            }
            else
            {
                Response.Write("删除项目失败！");
            }
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
            Debug.Write(ex);
            Response.Write("数据库连接失败！");
        }
        //关
        mycon.Close();
    }

    protected void edit_Click(object sender, EventArgs e)
    {
        String item_id = String.Format(Convert.ToString(((Button)sender).CommandArgument));
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();
        string s_url;
        s_url = "~/admin/item_edit.aspx?id=" + item_id;
        Response.Redirect(s_url);
        //Response.Redirect("item_edit.aspx");
    }

    protected void Search_Click(object sender, EventArgs e)
    {
        String item_id = search_id.Text;
       // String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";

        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            string sql_count = "select count(*) from item";
            MySqlCommand cmd_count = new MySqlCommand(sql_count, mycon);
            Object result = cmd_count.ExecuteScalar();
            if (result != null)
            {
                int count = int.Parse(result.ToString());
                for (int i = 0; i < count; i++)
                {
                    table2.Rows.RemoveAt(table2.Rows.Count - 1);
                }
            }

            TableItemStyle tableStyle = new TableItemStyle();
            tableStyle.HorizontalAlign = HorizontalAlign.Center;
            tableStyle.VerticalAlign = VerticalAlign.Middle;
            tableStyle.Width = Unit.Pixel(100);

            String sql = "select * from item where name = '" + item_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String id = reader.GetString(reader.GetOrdinal("itemid"));
                String name = reader.GetString(reader.GetOrdinal("name"));
                String type = reader.GetString(reader.GetOrdinal("type"));
                String memo = reader.GetString(reader.GetOrdinal("memo"));
                String skill = reader.GetString(reader.GetOrdinal("skill"));
                String userid = reader.GetString(reader.GetOrdinal("userid"));
                String edate = reader.GetString(reader.GetOrdinal("edate"));
                String sdate = reader.GetString(reader.GetOrdinal("sdate"));
                String status = reader.GetString(reader.GetOrdinal("status"));
                if (status == "1")
                {
                    status = "进行中";
                }
                else
                {
                    status = "已结束";
                }
                String is_deal = reader.GetString(reader.GetOrdinal("is_deal"));
                if (is_deal == "0")
                {
                    is_deal = "未交付";
                }
                else
                {
                    is_deal = "已交付";
                }

                TableRow Row1 = new TableRow();
                TableCell Cell1 = new TableCell();
                Cell1.Text = String.Format(id);
                Row1.Cells.Add(Cell1);
                TableCell Cell2 = new TableCell();
                Cell2.Text = String.Format(name);
                Row1.Cells.Add(Cell2);
                TableCell Cell3 = new TableCell();
                Cell3.Text = String.Format(type);
                Row1.Cells.Add(Cell3);
                TableCell Cell4 = new TableCell();
                Cell4.Text = String.Format(memo);
                Row1.Cells.Add(Cell4);
                TableCell Cell5 = new TableCell();
                Cell5.Text = String.Format(skill);
                Row1.Cells.Add(Cell5);
                TableCell Cell6 = new TableCell();
                Cell6.Text = String.Format(userid);
                Row1.Cells.Add(Cell6);
                TableCell Cell7 = new TableCell();
                Cell7.Text = String.Format(edate);
                Row1.Cells.Add(Cell7);
                TableCell Cell8 = new TableCell();
                Cell8.Text = String.Format(sdate);
                Row1.Cells.Add(Cell8);
                TableCell Cell9 = new TableCell();
                Cell9.Text = String.Format(status);
                Row1.Cells.Add(Cell9);
                TableCell Cell10 = new TableCell();
                Cell10.Text = String.Format(is_deal);
                Row1.Cells.Add(Cell10);
                table2.Rows.Add(Row1);
            }
            foreach (TableRow rw in table2.Rows)
                foreach (TableCell cel in rw.Cells)
                    cel.ApplyStyle(tableStyle);
            TableHeaderCell header = new TableHeaderCell();
            header.RowSpan = 1;
            header.ColumnSpan = 3;
            header.Font.Bold = true;
            header.BackColor = Color.Gray;
            header.HorizontalAlign = HorizontalAlign.Center;
            header.VerticalAlign = VerticalAlign.Middle;

            TableRow headerRow = new TableRow();
            headerRow.Cells.Add(header);
            table2.Rows.AddAt(0, headerRow);
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
            Debug.Write(ex);
        }
        //关
        mycon.Close();
    }

    protected void Edit_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();
        string s_url;
        s_url = "~/admin/item_edit.aspx?id=" + edit_id.Text;
        Response.Redirect(s_url);
        //Response.Redirect("item_edit.aspx");
    }

    protected void Delete_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString();
        String item_id = delete_id.Text;
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            String sql = "delete from item where itemid= '" + item_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Response.Write("<script>alert('删除项目'" + item_id + "'成功！')</script>");
                Response.Redirect("~/admin/item.aspx");
            }
            else {
                Response.Write("删除项目失败！");
            }
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
            Debug.Write(ex);
            Response.Write("数据库连接失败！");
        }
        //关
        mycon.Close();
    }

    protected void Refresh_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            mycon.Open();
            string sql_count = "select count(*) from item";
            MySqlCommand cmd_count = new MySqlCommand(sql_count, mycon);
            Object result = cmd_count.ExecuteScalar();
            if (result != null)
            {
                int count = int.Parse(result.ToString());
                for (int i = 0; i < count; i++)
                {
                    table2.Rows.RemoveAt(table2.Rows.Count - 1);
                }
            }
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
            Debug.Write(ex);
        }
        //关
        mycon.Close();
        b();
    }
}
