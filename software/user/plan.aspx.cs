using System;
using System.Web.UI.WebControls;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Diagnostics;

public partial class admin_plan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();
        a();
    }

    protected void a()
    {
        //string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";
        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            //打开数据库连接
            mycon.Open();
            string sql = "select * from work where userid='" + Session["name"].ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();

            TableItemStyle tableStyle = new TableItemStyle();
            tableStyle.HorizontalAlign = HorizontalAlign.Center;
            tableStyle.VerticalAlign = VerticalAlign.Middle;
            tableStyle.Width = Unit.Pixel(100);

            while (reader.Read())
            {
                String workid = reader.GetString(reader.GetOrdinal("workid"));
                string itemid = reader.GetString(reader.GetOrdinal("itemid"));
                string memo = reader.GetString(reader.GetOrdinal("memo"));
                string priority = reader.GetString(reader.GetOrdinal("priority"));
                if (priority == "3")
                {
                    priority = "严重";
                }
                else if (priority == "2")
                {
                    priority = "重要";
                }
                else
                {
                    priority = "一般";
                }

                string userid = reader.GetString(reader.GetOrdinal("userid"));
                string sdate = reader.GetString(reader.GetOrdinal("sdate"));
                string edate = reader.GetString(reader.GetOrdinal("edate"));
                string status = reader.GetString(reader.GetOrdinal("status"));
                if (status == "1")
                {
                    status = "进行中";
                }
                else
                {
                    status = "已结束";
                }

                TableRow Row1 = new TableRow();
                TableCell Cell1 = new TableCell();
                Cell1.Text = String.Format(workid);
                Row1.Cells.Add(Cell1);
                TableCell Cell2 = new TableCell();
                Cell2.Text = String.Format(itemid);
                Row1.Cells.Add(Cell2);
                TableCell Cell3 = new TableCell();
                Cell3.Text = String.Format(memo);
                Row1.Cells.Add(Cell3);
                TableCell Cell4 = new TableCell();
                Cell4.Text = String.Format(priority);
                Row1.Cells.Add(Cell4);
                TableCell Cell5 = new TableCell();
                Cell5.Text = String.Format(userid);
                Row1.Cells.Add(Cell5);
                TableCell Cell6 = new TableCell();
                Cell6.Text = String.Format(sdate);
                Row1.Cells.Add(Cell6);
                TableCell Cell7 = new TableCell();
                Cell7.Text = String.Format(edate);
                Row1.Cells.Add(Cell7);
                TableCell Cell8 = new TableCell();
                Cell8.Text = String.Format(status);
                Row1.Cells.Add(Cell8);
                table1.Rows.Add(Row1);
            }
            foreach (TableRow rw in table1.Rows)
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

            table1.Rows.AddAt(0, headerRow);

        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
            Debug.Write(ex);
        }
        //关
        mycon.Close();
    }

    protected void Search_Click(object sender, EventArgs e)
    {
        label_name.Text = Session["name"].ToString() + "," + Session["id"].ToString();

        String planid = search_id.Text;
        //string M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp";
        String M_str_sqlcon = "server=localhost;user id=root;password=root;database=asp;Persist Security Info=True;Charset=utf8";

        MySqlConnection mycon = new MySqlConnection(M_str_sqlcon);
        try
        {
            //打开数据库连接
            mycon.Open();
            //LOVE Theme from TIGA
            string sql_count = "select count(*) from work where userid='" + Session["name"].ToString() + "'";
            MySqlCommand cmd_count = new MySqlCommand(sql_count, mycon);
            Object result = cmd_count.ExecuteScalar();
            if (result != null)
            {
                int count = int.Parse(result.ToString());
                for (int i = 0; i < count; i++)
                {
                    table1.Rows.RemoveAt(table1.Rows.Count - 1);
                }
            }

            TableItemStyle tableStyle = new TableItemStyle();
            tableStyle.HorizontalAlign = HorizontalAlign.Center;
            tableStyle.VerticalAlign = VerticalAlign.Middle;
            tableStyle.Width = Unit.Pixel(100);

            String sql = "select * from work where workid = '" + planid + "' and userid='" + Session["name"].ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String workid = reader.GetString(reader.GetOrdinal("workid"));
                string itemid = reader.GetString(reader.GetOrdinal("itemid"));
                string memo = reader.GetString(reader.GetOrdinal("memo"));
                string priority = reader.GetString(reader.GetOrdinal("priority"));
                if (priority == "3")
                {
                    priority = "严重";
                }
                else if (priority == "2")
                {
                    priority = "重要";
                }
                else
                {
                    priority = "一般";
                }

                string userid = reader.GetString(reader.GetOrdinal("userid"));
                string sdate = reader.GetString(reader.GetOrdinal("sdate"));
                string edate = reader.GetString(reader.GetOrdinal("edate"));
                string status = reader.GetString(reader.GetOrdinal("status"));
                if (status == "1")
                {
                    status = "进行中";
                }
                else
                {
                    status = "已结束";
                }

                TableRow Row1 = new TableRow();
                TableCell Cell1 = new TableCell();
                Cell1.Text = String.Format(workid);
                Row1.Cells.Add(Cell1);
                TableCell Cell2 = new TableCell();
                Cell2.Text = String.Format(itemid);
                Row1.Cells.Add(Cell2);
                TableCell Cell3 = new TableCell();
                Cell3.Text = String.Format(memo);
                Row1.Cells.Add(Cell3);
                TableCell Cell4 = new TableCell();
                Cell4.Text = String.Format(priority);
                Row1.Cells.Add(Cell4);
                TableCell Cell5 = new TableCell();
                Cell5.Text = String.Format(userid);
                Row1.Cells.Add(Cell5);
                TableCell Cell6 = new TableCell();
                Cell6.Text = String.Format(sdate);
                Row1.Cells.Add(Cell6);
                TableCell Cell7 = new TableCell();
                Cell7.Text = String.Format(edate);
                Row1.Cells.Add(Cell7);
                TableCell Cell8 = new TableCell();
                Cell8.Text = String.Format(status);
                Row1.Cells.Add(Cell8);
                table1.Rows.Add(Row1);
            }
            foreach (TableRow rw in table1.Rows)
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

            table1.Rows.AddAt(0, headerRow);

        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
            Debug.Write(ex);
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
            string sql_count = "select count(*) from work where userid='" + Session["name"].ToString() + "'";
            MySqlCommand cmd_count = new MySqlCommand(sql_count, mycon);
            Object result = cmd_count.ExecuteScalar();
            if (result != null)
            {
                int count = int.Parse(result.ToString());
                for (int i = 0; i < count; i++)
                {
                    table1.Rows.RemoveAt(table1.Rows.Count - 1);
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
        a();
    }
}