using System;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        if (ViewState["needBind"] != null && (bool)ViewState["needBind"])
            ASPxGridView1.DataSource = Product.GetData();
        else
            ASPxGridView1.DataSource = null;
    }

    protected void ASPxGridView1_ProcessColumnAutoFilter(object sender, ASPxGridViewAutoFilterEventArgs e) {
        if (string.IsNullOrEmpty(e.Value)) {
            ViewState["needBind"] = false;
        }
        else {
            if (ASPxGridView1.DataSource == null)
                ViewState["needBind"] = true;
        }
    }
}