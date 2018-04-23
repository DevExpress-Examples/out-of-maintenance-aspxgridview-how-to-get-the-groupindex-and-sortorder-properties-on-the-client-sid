using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;
using System.Collections;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        Grid.DataSource = CreateGridData();
        Grid.DataBind();
    }

    object CreateGridData() {
        var result = new ArrayList();
        for(int i = 0; i < 50; i++)
            result.Add(new {
                ID = i,
                Col1 = "Col1_" + i,
                Col2 = "Col2_" + i,
                Col3 = "Col3_" + i,
                Col4 = "Col4_" + i % 5,
                Col5 = "Col5_" + i,
            });
        return result;
    }

    protected void Grid_CustomJSProperties(object sender, ASPxGridViewClientJSPropertiesEventArgs e) {
        var result = new Hashtable();
        foreach(var col in Grid.AllColumns) {
            var dataCol = col as GridViewDataColumn;
            if(dataCol != null) {
                result[dataCol.FieldName] = new Dictionary<string, object>() {
                    { "groupIndex", dataCol.GroupIndex },
                    { "sortIndex", dataCol.SortIndex },
                    { "sortOrder", dataCol.SortOrder }
                };
            }
        }

        e.Properties["cpColumnsProp"] = result;
    }
}