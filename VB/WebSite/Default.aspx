'INSTANT VB NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level:

<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView"
	TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors"
	TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<script type="text/javascript">
		function Grid_Init(s, e) {
			ShowColumnsProp(s.cpColumnsProp);
		}
		function Grid_EndCallback(s, e) {
			ShowColumnsProp(s.cpColumnsProp);
		}
		function ShowColumnsProp(prop) {
			var result = "";
			for(var name in prop) {
				result += name + " groupIndex = " + prop[name].groupIndex +
					"; sortIndex = " + prop[name].sortIndex + "; sortOrder = " + prop[name].sortOrder + "\n";
			}
			WriteText(result);
		}
		function WriteText(text) {
			document.getElementById("outPut").innerText = text;
		}

	</script>
</head>
<body>
	<form id="form1" runat="server">
	<dx:ASPxGridView ID="Grid" runat="server" AutoGenerateColumns="false" KeyFieldName="ID"
		OnCustomJSProperties="Grid_CustomJSProperties">
		<Columns>
			<dx:GridViewDataColumn FieldName="Col1" />
			<dx:GridViewDataColumn FieldName="Col2" SortOrder="Ascending" SortIndex="1" />
			<dx:GridViewDataColumn FieldName="Col3" SortOrder="Descending" SortIndex="2" />
			<dx:GridViewDataColumn FieldName="Col4" GroupIndex="0" />
			<dx:GridViewDataColumn FieldName="Col5" />
		</Columns>
		<ClientSideEvents Init="Grid_Init" EndCallback="Grid_EndCallback" />
		<Settings ShowGroupPanel="true" />
	</dx:ASPxGridView>
	<br />
	<div id="outPut">
	</div>
	</form>
</body>
</html>