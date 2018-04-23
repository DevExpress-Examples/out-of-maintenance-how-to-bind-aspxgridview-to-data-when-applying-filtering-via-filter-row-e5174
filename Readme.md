# How to bind ASPxGridView to data when applying filtering via Filter Row


<p>This example illustrates how to bind ASPxGridView to data when applying filtering via <a href="http://documentation.devexpress.com/#AspNet/CustomDocument3684"><u>Filter Row</u></a>. We catch the moment when filtering is applied by handling the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_ProcessColumnAutoFiltertopic"><u>ASPxGridView.ProcessColumnAutoFilter Event</u></a>. Here we set a flag in the ViewState and use it in the ASPxGridView.DataBinding event handler to populate ASPxGridView with data.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/K18183">Why might paging (sorting, grouping, filtering) not work in the ASPxGridView?</a></p>

<br/>


