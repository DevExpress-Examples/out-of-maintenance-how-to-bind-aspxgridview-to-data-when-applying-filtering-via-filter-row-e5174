Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		If ViewState("needBind") IsNot Nothing AndAlso CBool(ViewState("needBind")) Then
			ASPxGridView1.DataSource = Product.GetData()
		Else
			ASPxGridView1.DataSource = Nothing
		End If
	End Sub

	Protected Sub ASPxGridView1_ProcessColumnAutoFilter(ByVal sender As Object, ByVal e As ASPxGridViewAutoFilterEventArgs)
		If String.IsNullOrEmpty(e.Value) Then
			ViewState("needBind") = False
		Else
			If ASPxGridView1.DataSource Is Nothing Then
				ViewState("needBind") = True
			End If
		End If
	End Sub
End Class