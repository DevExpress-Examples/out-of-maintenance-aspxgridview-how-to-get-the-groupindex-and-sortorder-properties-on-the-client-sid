# ASPxGridView - How to get the GroupIndex and SortOrder properties on the client side


<p>Sometimes it is necessary to get the ASPxGridViewColumn's GroupIndex or SortOrder values on the client side. ASPxGridView does not provide this capability, because these are the server-side properties. As a solution, perform a callback to the server to retrieve GroupIndex and SortOrder. To pass these values to the client side, handle the  <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CustomJSPropertiestopic"><u>ASPxGridView.CustomJSProperties</u></a> event. This example illustrates how to utilize this solution.</p>

<br/>


