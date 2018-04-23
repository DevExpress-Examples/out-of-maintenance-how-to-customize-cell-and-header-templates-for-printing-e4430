Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Printing

Namespace DXSample
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			Dim list As New List(Of TestData)()
			For i As Integer = 0 To 19
				list.Add(New TestData() With {.Number = i, .Text = "Row " & i})
			Next i
			grid.ItemsSource = list
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim preview As New DocumentPreviewWindow()
			Dim link As New PrintableControlLink(view)
			Dim model As New LinkPreviewModel(link)
			preview.Model = model
			link.CreateDocument(True)
			preview.ShowDialog()
		End Sub
	End Class
	Public Class TestData
		Private privateNumber As Integer
		Public Property Number() As Integer
			Get
				Return privateNumber
			End Get
			Set(ByVal value As Integer)
				privateNumber = value
			End Set
		End Property
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
	End Class
End Namespace
