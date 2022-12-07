Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports System.Collections

Partial Public Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Grid.DataSource = CreateGridData()
        Grid.DataBind()
    End Sub

    Private Function CreateGridData() As Object
        Dim result = New ArrayList()
        For i As Integer = 0 To 49
            result.Add(New With {Key .ID = i, Key .Col1 = "Col1_" & i, Key .Col2 = "Col2_" & i, Key .Col3 = "Col3_" & i, Key .Col4 = "Col4_" & i Mod 5, Key .Col5 = "Col5_" & i})
        Next i
        Return result
    End Function

    Protected Sub Grid_CustomJSProperties(ByVal sender As Object, ByVal e As ASPxGridViewClientJSPropertiesEventArgs)
        Dim result = New Hashtable()
        For Each col In Grid.AllColumns
            Dim dataCol = TryCast(col, GridViewDataColumn)
            If dataCol IsNot Nothing Then
                result(dataCol.FieldName) = New Dictionary(Of String, Object)
                result(dataCol.FieldName).Add("groupIndex", dataCol.GroupIndex)
                result(dataCol.FieldName).Add("sortIndex", dataCol.SortIndex)
                result(dataCol.FieldName).Add("sortOrder", dataCol.SortOrder)
            End If
        Next col

        e.Properties("cpColumnsProp") = result
    End Sub
End Class