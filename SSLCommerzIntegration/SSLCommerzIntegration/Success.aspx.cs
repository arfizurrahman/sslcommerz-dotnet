using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SSLCommerzIntegration.Models;

public partial class Success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(Request.Form["status"]) && Request.Form["status"] == "VALID")
        {
            string TrxID = Request.Form["tran_id"];
            // AMOUNT and Currency FROM DB FOR THIS TRANSACTION
            string amount = "1150";
            string currency = "BDT";

            SSLCommerz sslcz = new SSLCommerz("nerdc5e82f0d18a1fc", "nerdc5e82f0d18a1fc@ssl", true);
            Response.Write(sslcz.OrderValidate(TrxID, amount, currency, Request));
        }
        else {
            Response.Write("not found");
        }
    }
}