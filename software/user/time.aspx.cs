using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_time : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        updatetime.Text = DateTime.Now.ToLongTimeString();
    }

    protected void TmrStock_Tick(object sender, EventArgs e)
    {
        time.Text = DateTime.Now.ToLongDateString();
    }

    protected void rdoltFrequency_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rdoltFrequency.SelectedIndex == 0)
        {
            tmrStock.Enabled = false;
        }
        else
        {
            tmrStock.Enabled = true;
            tmrStock.Interval = rdoltFrequency.SelectedIndex; //int.Parse(rdoltFrequency.SelectedIndex);
        }
    }
}