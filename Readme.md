<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128534297/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3545)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to get the GroupIndex and SortOrder properties on the client side


<p>Sometimes it is necessary to get the ASPxGridViewColumn's GroupIndex or SortOrder values on the client side. ASPxGridView does not provide this capability, because these are the server-side properties. As a solution, perform a callback to the server to retrieve GroupIndex and SortOrder. To pass these values to the client side, handle the  <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_CustomJSPropertiestopic"><u>ASPxGridView.CustomJSProperties</u></a> event. This example illustrates how to utilize this solution.</p>

<br/>


