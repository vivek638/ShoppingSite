﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
    DS_AITEM.ITEM_SELECTDataTable IDT = new DS_AITEM.ITEM_SELECTDataTable();
    DS_AITEMTableAdapters.ITEM_SELECTTableAdapter IAdapter = new DS_AITEMTableAdapters.ITEM_SELECTTableAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"].ToString() == "cate")
        {
            string cname = Request.QueryString["name"].ToString();
            IDT = IAdapter.Select_BY_CNAME(cname);
            DataList1.DataSource = IDT;
            DataList1.DataBind();
            lblsearch.Text = "(" + DataList1.Items.Count.ToString() + ")";
        }
        else if (Session["name"].ToString() == "search")
        {
            string cname = Request.QueryString["name"].ToString();
            IDT = IAdapter.searchhhh(cname + "%");
            DataList1.DataSource = IDT;
            DataList1.DataBind();
            lblsearch.Text = "(" + DataList1.Items.Count.ToString() + ")";
        }
        else
        {
            IDT = IAdapter.SeleectTOP7();
            DataList1.DataSource = IDT;
            DataList1.DataBind();
            lblsearch.Text = "(" + DataList1.Items.Count.ToString() + ")";
        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        Response.Redirect("View.aspx?idd=" + e.CommandArgument.ToString());
    }
}