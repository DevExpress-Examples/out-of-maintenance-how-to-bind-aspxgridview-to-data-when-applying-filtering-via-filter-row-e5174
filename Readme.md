<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128537872/13.1.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5174)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/WebSite/App_Code/Data.cs) (VB: [Data.vb](./VB/WebSite/App_Code/Data.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to bind ASPxGridView to data when applying filtering via Filter Row
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5174/)**
<!-- run online end -->


<p>This example illustrates how to bind ASPxGridView to data when applying filtering via <a href="http://documentation.devexpress.com/#AspNet/CustomDocument3684"><u>Filter Row</u></a>. We catch the moment when filtering is applied by handling the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_ProcessColumnAutoFiltertopic"><u>ASPxGridView.ProcessColumnAutoFilter Event</u></a>. Here we set a flag in the ViewState and use it in the ASPxGridView.DataBinding event handler to populate ASPxGridView with data.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/K18183">Why might paging (sorting, grouping, filtering) not work in the ASPxGridView?</a></p>

<br/>


