Imports System.Windows

Namespace DXSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            Dim preview = New MyDocumentPreviewControl() With {.DocumentSource = report}
            Dim window = New Window() With {.Content = preview}
            report.CreateDocument(True)
            window.ShowDialog()
        End Sub
    End Class
End Namespace
