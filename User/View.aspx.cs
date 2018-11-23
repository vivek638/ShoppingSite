﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View : System.Web.UI.Page
{
    DS_ORDER.ORDER_SELECTDataTable ODT = new DS_ORDER.ORDER_SELECTDataTable();
    DS_ORDERTableAdapters.ORDER_SELECTTableAdapter OAdapter = new DS_ORDERTableAdapters.ORDER_SELECTTableAdapter();
  
    DS_AITEM.ITEM_SELECTDataTable IDT = new DS_AITEM.ITEM_SELECTDataTable();
    DS_AITEMTableAdapters.ITEM_SELECTTableAdapter IAdapter = new DS_AITEMTableAdapters.ITEM_SELECTTableAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string idd = Request.QueryString["idd"].ToString();
            IDT = IAdapter.ITEM_SELECT_BUYIID(Convert.ToInt32(idd));

            lblname.Text = IDT.Rows[0]["iname"].ToString();
            lbldetil.Text = IDT.Rows[0]["detail"].ToString();
            lblprice.Text = IDT.Rows[0]["price"].ToString();
            lblqnt.Text = IDT.Rows[0]["qnt"].ToString();
            Image3.ImageUrl = IDT.Rows[0]["image"].ToString();
            Image4.ImageUrl = IDT.Rows[0]["image"].ToString();
            Image5.ImageUrl = IDT.Rows[0]["image1"].ToString();
            Image6.ImageUrl = IDT.Rows[0]["image2"].ToString();

            lblqnt0.Text = IDT.Rows[0]["size"].ToString();

            IDT = IAdapter.SeleectTOP7();
            DataList1.DataSource = IDT;
            DataList1.DataBind();
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ODT = OAdapter.Sleect_BY_UNAME_INAME(Session["uname"].ToString(), lblname.Text);
        if (ODT.Rows.Count == 1)
        {
           //int qntt = Convert.ToInt32(ODT.Rows[0]["Qnt"].ToString()) + 1;
           //int pricee = Convert.ToInt32(ODT.Rows[0]["tprice"].ToString()) + Convert.ToInt32(lblprice.Text);
           //Adapter.Update(Convert.ToInt32(ODT.Rows[0]["oid"].ToString()), lblname.Text, qntt, Convert.ToDouble(ODT.Rows[0]["price"].ToString()), pricee, 0, System.DateTime.Now);
            OAdapter.ORDER_UPDATE_CART(Convert.ToInt32(ODT.Rows[0]["oid"].ToString()), 1, Convert.ToDouble(lblprice.Text));
          //OAdapter.Insert(Session["uname"].ToString(), lblname.Text, qntt.ToString(), lblprice.Text, pricee.ToString(), "0", Image3.ImageUrl.ToString());
            Response.Redirect("MyCart.aspx");
        }
        else
        {
            OAdapter.Insert(Session["uname"].ToString(), lblname.Text, "1", lblprice.Text, lblprice.Text, "0", Image3.ImageUrl.ToString());
            Response.Redirect("MyCart.aspx");
        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        Response.Redirect("View.aspx?idd=" + e.CommandArgument.ToString());
    }
}