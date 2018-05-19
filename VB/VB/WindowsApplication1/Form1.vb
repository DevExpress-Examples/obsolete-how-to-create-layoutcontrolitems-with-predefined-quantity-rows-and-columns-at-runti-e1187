Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim rows As Integer = 10
			Dim cols As Integer = 5
			layoutControl1.BeginInit()
			Dim layout As New List(Of BaseLayoutItem)()
			For i As Integer = 0 To rows - 1
				For j As Integer = 0 To cols - 1
					Dim labelItems As New LayoutControlItem()
					labelItems.Name = Guid.NewGuid().ToString()
					labelItems.Text = "(" & i & "," & j & ")"
					Dim edit As New TextEdit()
					edit.Name = Guid.NewGuid().ToString()
					labelItems.Control = edit
					layout.Add(labelItems)
					labelItems.Location = New Point(j * 200, i * 200)
					labelItems.Size = New Size(200, 200)
				Next j
			Next i
			layoutControlGroup1.Items.AddRange(layout.ToArray())
			layoutControl1.EndInit()
		End Sub
	End Class
End Namespace